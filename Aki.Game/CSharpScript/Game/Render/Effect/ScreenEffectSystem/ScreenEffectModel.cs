using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render.Effect.ScreenEffectSystem
{
	// Token: 0x02003519 RID: 13593
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ScreenEffectModel : ModelBase
	{
		// Token: 0x060229C7 RID: 141767 RVA: 0x009D9279 File Offset: 0x009D7479
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x060229C8 RID: 141768 RVA: 0x009D9298 File Offset: 0x009D7498
		[NullableContext(2)]
		public int PlayScreenEffect([Nullable(1)] string path, string memoryTag = null, CustomPromise playedPromise = null)
		{
			ScreenEffectModel.ScreenEffectHandle handle;
			if (!this.PathToHandleMap.TryGetValue(path, out handle))
			{
				handle = this.GetHandle();
				handle.Path = path;
				this.PathToHandleMap.Add(path, handle);
			}
			int handleIdGenerator = this.HandleIdGenerator;
			this.HandleIdGenerator = handleIdGenerator + 1;
			int num = handleIdGenerator;
			handle.HandleIds.Add(num);
			this.HandleMap.Add(num, handle);
			if (playedPromise != null)
			{
				if (handle.EffectData != null && !handle.WaitingRootInit)
				{
					playedPromise.SetResult();
				}
				else
				{
					handle.PlayedPromises.Add(playedPromise);
				}
			}
			if (handle.HandleIds.Count == 1)
			{
				handle.LoadResId = this.LoadAndPlayScreenEffect(path, memoryTag);
			}
			return num;
		}

		// Token: 0x060229C9 RID: 141769 RVA: 0x009D9340 File Offset: 0x009D7540
		public unsafe void PlayScreenEffectForce(string path, [Nullable(2)] string memoryTag = null)
		{
			ScreenEffectModel.ScreenEffectHandle screenEffectHandle;
			if (this.PathToHandleMap.TryGetValue(path, out screenEffectHandle) && screenEffectHandle.EffectData != null)
			{
				BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
				BP_ScreenEffectPlayer_C bp_ScreenEffectPlayer_C = (instance != null) ? instance.Effects.Get(screenEffectHandle.EffectData) : null;
				if (bp_ScreenEffectPlayer_C != null && bp_ScreenEffectPlayer_C.IsValid() && !(bp_ScreenEffectPlayer_C.State == E_SE_PlayState.Over))
				{
					Log instance2 = Log.Instance;
					ELogModule module = ELogModule.RenderEffect;
					ELogAuthor author = ELogAuthor.WRY;
					string message = "屏幕特效强制播放: 上次特效未结束";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("path", path);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("playerState", bp_ScreenEffectPlayer_C.State);
					instance2.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
				this.EndScreenEffectByPath(path);
			}
			this.PlayScreenEffect(path, memoryTag, null);
		}

		// Token: 0x060229CA RID: 141770 RVA: 0x009D9418 File Offset: 0x009D7618
		private void FlushPlayedPromises(ScreenEffectModel.ScreenEffectHandle handle)
		{
			if (handle.PlayedPromises.Count == 0)
			{
				return;
			}
			List<CustomPromise> playedPromises = handle.PlayedPromises;
			handle.PlayedPromises = new List<CustomPromise>();
			foreach (CustomPromise customPromise in playedPromises)
			{
				customPromise.SetResult();
			}
		}

		// Token: 0x060229CB RID: 141771 RVA: 0x009D9484 File Offset: 0x009D7684
		private int LoadAndPlayScreenEffect(string path, [Nullable(2)] string memoryTag = null)
		{
			return ResourceSystem.Instance.LoadAsync<EffectScreenPlayData_C>(path, delegate([Nullable(2)] EffectScreenPlayData_C resObj, string _)
			{
				ScreenEffectModel.ScreenEffectHandle screenEffectHandle;
				if (!this.PathToHandleMap.TryGetValue(path, out screenEffectHandle) || screenEffectHandle.HandleIds.Count == 0 || resObj == null)
				{
					return;
				}
				screenEffectHandle.EffectData = resObj;
				screenEffectHandle.RootType = resObj.RootType;
				if (resObj.bUsedForSequence)
				{
					screenEffectHandle.RootType = E_SE_RootType.Plot;
				}
				else
				{
					switch (resObj.RootType)
					{
					case E_SE_RootType.Fight:
						if (!this.FightRootInited)
						{
							screenEffectHandle.WaitingRootInit = true;
							return;
						}
						break;
					case E_SE_RootType.General:
						if (!this.GeneralRootInited)
						{
							screenEffectHandle.WaitingRootInit = true;
							return;
						}
						break;
					case E_SE_RootType.CoverLoading:
						if (!this.CoverLoadingRootInited)
						{
							screenEffectHandle.WaitingRootInit = true;
							return;
						}
						break;
					}
				}
				ScreenEffectSystem.GetInstance().PlayScreenEffect(resObj);
				this.FlushPlayedPromises(screenEffectHandle);
			}, ResourceSystem.EResourceLoadPriority.Ui, memoryTag ?? "js_undefined");
		}

		// Token: 0x060229CC RID: 141772 RVA: 0x009D94D0 File Offset: 0x009D76D0
		public void EndScreenEffectByPath(string path)
		{
			ScreenEffectModel.ScreenEffectHandle screenEffectHandle;
			if (!this.PathToHandleMap.TryGetValue(path, out screenEffectHandle))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "调用停止镜头特效接口时找不到path对应的Handle，尝试直接获取已加载的PlayData来停止特效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				EffectScreenPlayData_C loadedAsset = ResourceSystem.Instance.GetLoadedAsset<EffectScreenPlayData_C>(path);
				if (loadedAsset != null)
				{
					ScreenEffectSystem.GetInstance().EndScreenEffect(loadedAsset);
				}
				return;
			}
			this.PathToHandleMap.Remove(screenEffectHandle.Path);
			this.ClearEffect(screenEffectHandle);
		}

		// Token: 0x060229CD RID: 141773 RVA: 0x009D9548 File Offset: 0x009D7748
		public int? ChangeScreenEffectState(string path, int state, bool playIfAbsent = false)
		{
			ScreenEffectModel.ScreenEffectHandle screenEffectHandle;
			if (this.PathToHandleMap.TryGetValue(path, out screenEffectHandle) && screenEffectHandle.EffectData != null)
			{
				BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
				if (instance != null)
				{
					instance.SetEffectExtraState(screenEffectHandle.EffectData, state);
				}
				return null;
			}
			if (playIfAbsent)
			{
				CustomPromise playedPromise = new CustomPromise();
				int num = this.PlayScreenEffect(path, null, playedPromise);
				this.ChangeScreenEffectStateAfterPlayed(playedPromise, num, path, state).Forget();
				return new int?(num);
			}
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.RenderEffect;
			ELogAuthor author = ELogAuthor.HYF;
			string message = "ChangeScreenEffectState: 找不到目标特效";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", path);
			instance2.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060229CE RID: 141774 RVA: 0x009D95EC File Offset: 0x009D77EC
		private UniTask ChangeScreenEffectStateAfterPlayed(CustomPromise playedPromise, int handleId, string path, int state)
		{
			ScreenEffectModel.<ChangeScreenEffectStateAfterPlayed>d__15 <ChangeScreenEffectStateAfterPlayed>d__;
			<ChangeScreenEffectStateAfterPlayed>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ChangeScreenEffectStateAfterPlayed>d__.<>4__this = this;
			<ChangeScreenEffectStateAfterPlayed>d__.playedPromise = playedPromise;
			<ChangeScreenEffectStateAfterPlayed>d__.handleId = handleId;
			<ChangeScreenEffectStateAfterPlayed>d__.path = path;
			<ChangeScreenEffectStateAfterPlayed>d__.state = state;
			<ChangeScreenEffectStateAfterPlayed>d__.<>1__state = -1;
			<ChangeScreenEffectStateAfterPlayed>d__.<>t__builder.Start<ScreenEffectModel.<ChangeScreenEffectStateAfterPlayed>d__15>(ref <ChangeScreenEffectStateAfterPlayed>d__);
			return <ChangeScreenEffectStateAfterPlayed>d__.<>t__builder.Task;
		}

		// Token: 0x060229CF RID: 141775 RVA: 0x009D9650 File Offset: 0x009D7850
		public void EndScreenEffect(int handleId)
		{
			ScreenEffectModel.ScreenEffectHandle screenEffectHandle;
			if (!this.HandleMap.TryGetValue(handleId, out screenEffectHandle))
			{
				return;
			}
			if (!screenEffectHandle.HandleIds.Contains(handleId))
			{
				return;
			}
			screenEffectHandle.HandleIds.Remove(handleId);
			this.HandleMap.Remove(handleId);
			if (screenEffectHandle.HandleIds.Count == 0)
			{
				this.PathToHandleMap.Remove(screenEffectHandle.Path);
				this.ClearEffect(screenEffectHandle);
			}
		}

		// Token: 0x060229D0 RID: 141776 RVA: 0x009D96C0 File Offset: 0x009D78C0
		public bool TrySetScreenEffectAlpha(int handleId, float alpha)
		{
			ScreenEffectModel.ScreenEffectHandle screenEffectHandle;
			if (!this.HandleMap.TryGetValue(handleId, out screenEffectHandle))
			{
				return false;
			}
			if (!screenEffectHandle.HandleIds.Contains(handleId))
			{
				return false;
			}
			if (screenEffectHandle.EffectData == null)
			{
				return true;
			}
			BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
			BP_ScreenEffectPlayer_C bp_ScreenEffectPlayer_C = (instance != null) ? instance.Effects.Get(screenEffectHandle.EffectData) : null;
			if (bp_ScreenEffectPlayer_C == null || !bp_ScreenEffectPlayer_C.IsValid())
			{
				return true;
			}
			bp_ScreenEffectPlayer_C.Alpha = alpha;
			bp_ScreenEffectPlayer_C.UpdateComponentsAlpha();
			bp_ScreenEffectPlayer_C.BeforeStart();
			return true;
		}

		// Token: 0x060229D1 RID: 141777 RVA: 0x009D9737 File Offset: 0x009D7937
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			this.HandleIdGenerator = 0;
			this.ClearAllEffect();
			return true;
		}

		// Token: 0x060229D2 RID: 141778 RVA: 0x009D9764 File Offset: 0x009D7964
		private void ClearAllEffect()
		{
			foreach (ScreenEffectModel.ScreenEffectHandle handle in this.PathToHandleMap.Values)
			{
				this.ClearEffect(handle);
			}
			this.PathToHandleMap.Clear();
			this.HandleMap.Clear();
		}

		// Token: 0x060229D3 RID: 141779 RVA: 0x009D97D4 File Offset: 0x009D79D4
		private void ClearEffect(ScreenEffectModel.ScreenEffectHandle handle)
		{
			foreach (int key in handle.HandleIds)
			{
				this.HandleMap.Remove(key);
			}
			handle.HandleIds.Clear();
			this.FlushPlayedPromises(handle);
			if (handle.EffectData != null)
			{
				ScreenEffectSystem.GetInstance().EndScreenEffect(handle.EffectData);
				handle.EffectData = null;
			}
			if (handle.LoadResId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(handle.LoadResId);
				handle.LoadResId = -1;
			}
			handle.Path = null;
			handle.RootType = E_SE_RootType.Fight;
			handle.WaitingRootInit = false;
			this.ReleaseHandle(handle);
		}

		// Token: 0x060229D4 RID: 141780 RVA: 0x009D989C File Offset: 0x009D7A9C
		public void SetFightRootInited(bool isInit)
		{
			if (this.FightRootInited == isInit)
			{
				return;
			}
			this.FightRootInited = isInit;
			if (isInit)
			{
				foreach (ScreenEffectModel.ScreenEffectHandle screenEffectHandle in this.PathToHandleMap.Values)
				{
					if (screenEffectHandle.WaitingRootInit && screenEffectHandle.RootType == E_SE_RootType.Fight)
					{
						screenEffectHandle.WaitingRootInit = false;
						if (screenEffectHandle.EffectData != null)
						{
							ScreenEffectSystem.GetInstance().PlayScreenEffect(screenEffectHandle.EffectData);
							this.FlushPlayedPromises(screenEffectHandle);
						}
					}
				}
			}
		}

		// Token: 0x060229D5 RID: 141781 RVA: 0x009D9938 File Offset: 0x009D7B38
		public void SetGeneralRootInited(bool isInit)
		{
			if (this.GeneralRootInited == isInit)
			{
				return;
			}
			this.GeneralRootInited = isInit;
			if (isInit)
			{
				foreach (ScreenEffectModel.ScreenEffectHandle screenEffectHandle in this.PathToHandleMap.Values)
				{
					if (screenEffectHandle.WaitingRootInit && screenEffectHandle.RootType == E_SE_RootType.General)
					{
						screenEffectHandle.WaitingRootInit = false;
						if (screenEffectHandle.EffectData != null)
						{
							ScreenEffectSystem.GetInstance().PlayScreenEffect(screenEffectHandle.EffectData);
							this.FlushPlayedPromises(screenEffectHandle);
						}
					}
				}
			}
		}

		// Token: 0x060229D6 RID: 141782 RVA: 0x009D99D4 File Offset: 0x009D7BD4
		public void SetCoverLoadingRootInited(bool isInit)
		{
			if (this.CoverLoadingRootInited == isInit)
			{
				return;
			}
			this.CoverLoadingRootInited = isInit;
			if (isInit)
			{
				foreach (ScreenEffectModel.ScreenEffectHandle screenEffectHandle in this.PathToHandleMap.Values)
				{
					if (screenEffectHandle.WaitingRootInit && screenEffectHandle.RootType == E_SE_RootType.CoverLoading)
					{
						screenEffectHandle.WaitingRootInit = false;
						if (screenEffectHandle.EffectData != null)
						{
							ScreenEffectSystem.GetInstance().PlayScreenEffect(screenEffectHandle.EffectData);
							this.FlushPlayedPromises(screenEffectHandle);
						}
					}
				}
			}
		}

		// Token: 0x060229D7 RID: 141783 RVA: 0x009D9A70 File Offset: 0x009D7C70
		public ScreenEffectModel.ScreenEffectHandle GetHandle()
		{
			ScreenEffectModel.ScreenEffectHandle result;
			if (this.HandlePool.TryPop(out result))
			{
				return result;
			}
			return new ScreenEffectModel.ScreenEffectHandle();
		}

		// Token: 0x060229D8 RID: 141784 RVA: 0x009D9A94 File Offset: 0x009D7C94
		public void ReleaseHandle(ScreenEffectModel.ScreenEffectHandle target)
		{
			if (this.HandlePool.Contains(target))
			{
				Log.Instance.Warn(ELogModule.RenderEffect, ELogAuthor.CFT, "镜头特效Handel重复入池", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.HandlePool.Add(target);
		}

		// Token: 0x060229D9 RID: 141785 RVA: 0x009D9AD8 File Offset: 0x009D7CD8
		private void OnWorldDone()
		{
			this.LoadScreenEffectRoot();
			this.LoadCoverLoadingRoot();
		}

		// Token: 0x060229DA RID: 141786 RVA: 0x009D9AE8 File Offset: 0x009D7CE8
		private void LoadScreenEffectRoot()
		{
			AUIContainerActor auicontainerActor = null;
			BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
			UUIItem layerRootUiItem = UiLayer.Instance.GetLayerRootUiItem(ELayerType.ScreenEffect);
			if (instance == null || !instance.IsValid() || layerRootUiItem == null)
			{
				return;
			}
			instance.GetScreenEffectGeneralRoot(ref auicontainerActor);
			if (auicontainerActor == null)
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.ZYL, "ScreenEffectUiRoot获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (auicontainerActor == this.ScreenEffectGeneralRoot)
			{
				return;
			}
			AUIContainerActor screenEffectGeneralRoot = this.ScreenEffectGeneralRoot;
			if (screenEffectGeneralRoot != null && screenEffectGeneralRoot.IsValid())
			{
				Log.Instance.Info(ELogModule.UiCore, ELogAuthor.ZYL, "ScreenEffectUiRoot被替换", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ScreenEffectGeneralRoot.OnPreDestroyed.Remove(new Action<AActor>(this.OnScreenEffectGeneralRootDestroyed));
				AUIContainerActor screenEffectGeneralRoot2 = this.ScreenEffectGeneralRoot;
				if (screenEffectGeneralRoot2 != null)
				{
					screenEffectGeneralRoot2.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
				}
				this.SetGeneralRootInited(false);
			}
			this.ScreenEffectGeneralRoot = auicontainerActor;
			this.ScreenEffectGeneralRoot.OnPreDestroyed.Add(new Action<AActor>(this.OnScreenEffectGeneralRootDestroyed));
			this.ScreenEffectGeneralRoot.K2_AttachRootComponentTo(layerRootUiItem, default(FName), EAttachLocation.KeepRelativeOffset, true);
			UKuroStaticLibrary.SetActorPermanent(instance, true, false);
			UKuroStaticLibrary.SetActorPermanent(auicontainerActor, true, false);
			this.SetGeneralRootInited(true);
		}

		// Token: 0x060229DB RID: 141787 RVA: 0x009D9C0C File Offset: 0x009D7E0C
		[NullableContext(2)]
		private void OnScreenEffectGeneralRootDestroyed(AActor _)
		{
			Log.Instance.Info(ELogModule.UiCore, ELogAuthor.ZYL, "ScreenEffectUiRoot被销毁", default(ReadOnlySpan<ValueTuple<string, object>>));
			AUIContainerActor screenEffectGeneralRoot = this.ScreenEffectGeneralRoot;
			if (screenEffectGeneralRoot != null)
			{
				screenEffectGeneralRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
			}
			this.SetGeneralRootInited(false);
		}

		// Token: 0x060229DC RID: 141788 RVA: 0x009D9C50 File Offset: 0x009D7E50
		public bool GetIsGeneralScreenEffectActive()
		{
			using (Dictionary<string, ScreenEffectModel.ScreenEffectHandle>.ValueCollection.Enumerator enumerator = this.PathToHandleMap.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RootType == E_SE_RootType.General)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060229DD RID: 141789 RVA: 0x009D9CB0 File Offset: 0x009D7EB0
		private void LoadCoverLoadingRoot()
		{
			AUIContainerActor auicontainerActor = null;
			BP_ScreenEffectSystem_C instance = ScreenEffectSystem.GetInstance();
			UUIItem floatUnit = UiLayer.Instance.GetFloatUnit(ELayerType.Loading, 1);
			if (instance == null || !instance.IsValid() || floatUnit == null)
			{
				return;
			}
			instance.GetScreenEffectCoverLoadingRoot(ref auicontainerActor);
			if (auicontainerActor == null)
			{
				Log.Instance.Error(ELogModule.UiCore, ELogAuthor.ZYL, "CoverLoadingUiRoot获取失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (auicontainerActor == this.ScreenEffectCoverLoadingRoot)
			{
				return;
			}
			AUIContainerActor screenEffectCoverLoadingRoot = this.ScreenEffectCoverLoadingRoot;
			if (screenEffectCoverLoadingRoot != null && screenEffectCoverLoadingRoot.IsValid())
			{
				Log.Instance.Info(ELogModule.UiCore, ELogAuthor.ZYL, "ScreenEffectUiRoot被替换", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ScreenEffectCoverLoadingRoot.OnDestroyed.Remove(new Action<AActor>(this.OnScreenEffectCoverLoadingRootDestroyed));
				AUIContainerActor screenEffectCoverLoadingRoot2 = this.ScreenEffectCoverLoadingRoot;
				if (screenEffectCoverLoadingRoot2 != null)
				{
					screenEffectCoverLoadingRoot2.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
				}
				this.SetCoverLoadingRootInited(false);
			}
			this.ScreenEffectCoverLoadingRoot = auicontainerActor;
			this.ScreenEffectCoverLoadingRoot.OnDestroyed.Add(new Action<AActor>(this.OnScreenEffectCoverLoadingRootDestroyed));
			this.ScreenEffectCoverLoadingRoot.K2_AttachRootComponentTo(floatUnit, default(FName), EAttachLocation.KeepRelativeOffset, true);
			UKuroStaticLibrary.SetActorPermanent(instance, true, false);
			UKuroStaticLibrary.SetActorPermanent(auicontainerActor, true, false);
			this.SetCoverLoadingRootInited(true);
		}

		// Token: 0x060229DE RID: 141790 RVA: 0x009D9DD8 File Offset: 0x009D7FD8
		[NullableContext(2)]
		private void OnScreenEffectCoverLoadingRootDestroyed(AActor _)
		{
			Log.Instance.Info(ELogModule.UiCore, ELogAuthor.ZYL, "CoverLoadingUiRoot被销毁", default(ReadOnlySpan<ValueTuple<string, object>>));
			AUIContainerActor screenEffectCoverLoadingRoot = this.ScreenEffectCoverLoadingRoot;
			if (screenEffectCoverLoadingRoot != null)
			{
				screenEffectCoverLoadingRoot.K2_DetachFromActor(EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative, EDetachmentRule.KeepRelative);
			}
			this.SetCoverLoadingRootInited(false);
		}

		// Token: 0x17004867 RID: 18535
		// (get) Token: 0x060229DF RID: 141791 RVA: 0x009D9E1C File Offset: 0x009D801C
		public static ScreenEffectModel Instance
		{
			get
			{
				return ScreenEffectModel._Instance;
			}
		}

		// Token: 0x060229E0 RID: 141792 RVA: 0x009D9E23 File Offset: 0x009D8023
		public static ScreenEffectModel GetOrCreateInstance()
		{
			if (ScreenEffectModel._Instance == null)
			{
				ScreenEffectModel.CreateInstance();
			}
			return ScreenEffectModel._Instance;
		}

		// Token: 0x060229E1 RID: 141793 RVA: 0x009D9E37 File Offset: 0x009D8037
		public static bool CreateInstance()
		{
			if (ScreenEffectModel._Instance != null)
			{
				return true;
			}
			ScreenEffectModel._Instance = new ScreenEffectModel();
			return true;
		}

		// Token: 0x060229E2 RID: 141794 RVA: 0x009D9E4D File Offset: 0x009D804D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060229E3 RID: 141795 RVA: 0x009D9E4F File Offset: 0x009D804F
		public static void ResetStaticDefaultValue()
		{
			ScreenEffectModel._Instance = null;
		}

		// Token: 0x060229E4 RID: 141796 RVA: 0x009D9E57 File Offset: 0x009D8057
		static ScreenEffectModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScreenEffectModel.CreateStaticDefaultValue), new Action(ScreenEffectModel.ResetStaticDefaultValue));
		}

		// Token: 0x040132B6 RID: 78518
		public int HandleIdGenerator = 1;

		// Token: 0x040132B7 RID: 78519
		public Dictionary<int, ScreenEffectModel.ScreenEffectHandle> HandleMap = new Dictionary<int, ScreenEffectModel.ScreenEffectHandle>();

		// Token: 0x040132B8 RID: 78520
		public Dictionary<string, ScreenEffectModel.ScreenEffectHandle> PathToHandleMap = new Dictionary<string, ScreenEffectModel.ScreenEffectHandle>();

		// Token: 0x040132B9 RID: 78521
		public List<ScreenEffectModel.ScreenEffectHandle> HandlePool = new List<ScreenEffectModel.ScreenEffectHandle>();

		// Token: 0x040132BA RID: 78522
		public bool FightRootInited;

		// Token: 0x040132BB RID: 78523
		public bool GeneralRootInited;

		// Token: 0x040132BC RID: 78524
		public bool CoverLoadingRootInited;

		// Token: 0x040132BD RID: 78525
		[Nullable(2)]
		private AUIContainerActor ScreenEffectGeneralRoot;

		// Token: 0x040132BE RID: 78526
		[Nullable(2)]
		private AUIContainerActor ScreenEffectCoverLoadingRoot;

		// Token: 0x040132BF RID: 78527
		[Nullable(2)]
		private static ScreenEffectModel _Instance;

		// Token: 0x020091F6 RID: 37366
		[Nullable(0)]
		public class ScreenEffectHandle
		{
			// Token: 0x0402DB11 RID: 187153
			public HashSet<int> HandleIds = new HashSet<int>();

			// Token: 0x0402DB12 RID: 187154
			[Nullable(2)]
			public string Path;

			// Token: 0x0402DB13 RID: 187155
			[Nullable(2)]
			public EffectScreenPlayData_C EffectData;

			// Token: 0x0402DB14 RID: 187156
			public int LoadResId = -1;

			// Token: 0x0402DB15 RID: 187157
			public bool WaitingRootInit;

			// Token: 0x0402DB16 RID: 187158
			public E_SE_RootType RootType;

			// Token: 0x0402DB17 RID: 187159
			public List<CustomPromise> PlayedPromises = new List<CustomPromise>();
		}
	}
}
