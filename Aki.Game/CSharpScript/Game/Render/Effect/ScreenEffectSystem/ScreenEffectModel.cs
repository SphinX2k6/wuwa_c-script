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
	// Token: 0x020045F0 RID: 17904
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class ScreenEffectModel : ModelBase
	{
		// Token: 0x0602E2D2 RID: 189138 RVA: 0x00AACADD File Offset: 0x00AAACDD
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x0602E2D3 RID: 189139 RVA: 0x00AACAFC File Offset: 0x00AAACFC
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

		// Token: 0x0602E2D4 RID: 189140 RVA: 0x00AACBA4 File Offset: 0x00AAADA4
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

		// Token: 0x0602E2D5 RID: 189141 RVA: 0x00AACC7C File Offset: 0x00AAAE7C
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

		// Token: 0x0602E2D6 RID: 189142 RVA: 0x00AACCE8 File Offset: 0x00AAAEE8
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

		// Token: 0x0602E2D7 RID: 189143 RVA: 0x00AACD34 File Offset: 0x00AAAF34
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

		// Token: 0x0602E2D8 RID: 189144 RVA: 0x00AACDAC File Offset: 0x00AAAFAC
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

		// Token: 0x0602E2D9 RID: 189145 RVA: 0x00AACE50 File Offset: 0x00AAB050
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

		// Token: 0x0602E2DA RID: 189146 RVA: 0x00AACEB4 File Offset: 0x00AAB0B4
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

		// Token: 0x0602E2DB RID: 189147 RVA: 0x00AACF24 File Offset: 0x00AAB124
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

		// Token: 0x0602E2DC RID: 189148 RVA: 0x00AACF9B File Offset: 0x00AAB19B
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			this.HandleIdGenerator = 0;
			this.ClearAllEffect();
			return true;
		}

		// Token: 0x0602E2DD RID: 189149 RVA: 0x00AACFC8 File Offset: 0x00AAB1C8
		private void ClearAllEffect()
		{
			foreach (ScreenEffectModel.ScreenEffectHandle handle in this.PathToHandleMap.Values)
			{
				this.ClearEffect(handle);
			}
			this.PathToHandleMap.Clear();
			this.HandleMap.Clear();
		}

		// Token: 0x0602E2DE RID: 189150 RVA: 0x00AAD038 File Offset: 0x00AAB238
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

		// Token: 0x0602E2DF RID: 189151 RVA: 0x00AAD100 File Offset: 0x00AAB300
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

		// Token: 0x0602E2E0 RID: 189152 RVA: 0x00AAD19C File Offset: 0x00AAB39C
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

		// Token: 0x0602E2E1 RID: 189153 RVA: 0x00AAD238 File Offset: 0x00AAB438
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

		// Token: 0x0602E2E2 RID: 189154 RVA: 0x00AAD2D4 File Offset: 0x00AAB4D4
		public ScreenEffectModel.ScreenEffectHandle GetHandle()
		{
			ScreenEffectModel.ScreenEffectHandle result;
			if (this.HandlePool.TryPop(out result))
			{
				return result;
			}
			return new ScreenEffectModel.ScreenEffectHandle();
		}

		// Token: 0x0602E2E3 RID: 189155 RVA: 0x00AAD2F8 File Offset: 0x00AAB4F8
		public void ReleaseHandle(ScreenEffectModel.ScreenEffectHandle target)
		{
			if (this.HandlePool.Contains(target))
			{
				Log.Instance.Warn(ELogModule.RenderEffect, ELogAuthor.CFT, "镜头特效Handel重复入池", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.HandlePool.Add(target);
		}

		// Token: 0x0602E2E4 RID: 189156 RVA: 0x00AAD33C File Offset: 0x00AAB53C
		private void OnWorldDone()
		{
			this.LoadScreenEffectRoot();
			this.LoadCoverLoadingRoot();
		}

		// Token: 0x0602E2E5 RID: 189157 RVA: 0x00AAD34C File Offset: 0x00AAB54C
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

		// Token: 0x0602E2E6 RID: 189158 RVA: 0x00AAD470 File Offset: 0x00AAB670
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

		// Token: 0x0602E2E7 RID: 189159 RVA: 0x00AAD4B4 File Offset: 0x00AAB6B4
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

		// Token: 0x0602E2E8 RID: 189160 RVA: 0x00AAD514 File Offset: 0x00AAB714
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

		// Token: 0x0602E2E9 RID: 189161 RVA: 0x00AAD63C File Offset: 0x00AAB83C
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

		// Token: 0x170075AF RID: 30127
		// (get) Token: 0x0602E2EA RID: 189162 RVA: 0x00AAD680 File Offset: 0x00AAB880
		public static ScreenEffectModel Instance
		{
			get
			{
				return ScreenEffectModel._Instance;
			}
		}

		// Token: 0x0602E2EB RID: 189163 RVA: 0x00AAD687 File Offset: 0x00AAB887
		public static ScreenEffectModel GetOrCreateInstance()
		{
			if (ScreenEffectModel._Instance == null)
			{
				ScreenEffectModel.CreateInstance();
			}
			return ScreenEffectModel._Instance;
		}

		// Token: 0x0602E2EC RID: 189164 RVA: 0x00AAD69B File Offset: 0x00AAB89B
		public static bool CreateInstance()
		{
			if (ScreenEffectModel._Instance != null)
			{
				return true;
			}
			ScreenEffectModel._Instance = new ScreenEffectModel();
			return true;
		}

		// Token: 0x0602E2ED RID: 189165 RVA: 0x00AAD6B1 File Offset: 0x00AAB8B1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E2EE RID: 189166 RVA: 0x00AAD6B3 File Offset: 0x00AAB8B3
		public static void ResetStaticDefaultValue()
		{
			ScreenEffectModel._Instance = null;
		}

		// Token: 0x0602E2EF RID: 189167 RVA: 0x00AAD6BB File Offset: 0x00AAB8BB
		static ScreenEffectModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ScreenEffectModel.CreateStaticDefaultValue), new Action(ScreenEffectModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018C77 RID: 101495
		public int HandleIdGenerator = 1;

		// Token: 0x04018C78 RID: 101496
		public Dictionary<int, ScreenEffectModel.ScreenEffectHandle> HandleMap = new Dictionary<int, ScreenEffectModel.ScreenEffectHandle>();

		// Token: 0x04018C79 RID: 101497
		public Dictionary<string, ScreenEffectModel.ScreenEffectHandle> PathToHandleMap = new Dictionary<string, ScreenEffectModel.ScreenEffectHandle>();

		// Token: 0x04018C7A RID: 101498
		public List<ScreenEffectModel.ScreenEffectHandle> HandlePool = new List<ScreenEffectModel.ScreenEffectHandle>();

		// Token: 0x04018C7B RID: 101499
		public bool FightRootInited;

		// Token: 0x04018C7C RID: 101500
		public bool GeneralRootInited;

		// Token: 0x04018C7D RID: 101501
		public bool CoverLoadingRootInited;

		// Token: 0x04018C7E RID: 101502
		[Nullable(2)]
		private AUIContainerActor ScreenEffectGeneralRoot;

		// Token: 0x04018C7F RID: 101503
		[Nullable(2)]
		private AUIContainerActor ScreenEffectCoverLoadingRoot;

		// Token: 0x04018C80 RID: 101504
		[Nullable(2)]
		private static ScreenEffectModel _Instance;

		// Token: 0x0200A83E RID: 43070
		[Nullable(0)]
		public class ScreenEffectHandle
		{
			// Token: 0x04033383 RID: 209795
			public HashSet<int> HandleIds = new HashSet<int>();

			// Token: 0x04033384 RID: 209796
			[Nullable(2)]
			public string Path;

			// Token: 0x04033385 RID: 209797
			[Nullable(2)]
			public EffectScreenPlayData_C EffectData;

			// Token: 0x04033386 RID: 209798
			public int LoadResId = -1;

			// Token: 0x04033387 RID: 209799
			public bool WaitingRootInit;

			// Token: 0x04033388 RID: 209800
			public E_SE_RootType RootType;

			// Token: 0x04033389 RID: 209801
			public List<CustomPromise> PlayedPromises = new List<CustomPromise>();
		}
	}
}
