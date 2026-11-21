using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CD9 RID: 19673
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiTweenAnimPlayer
	{
		// Token: 0x06031396 RID: 201622 RVA: 0x00DBDB00 File Offset: 0x00DBBD00
		public void Clear(bool stopAll = false)
		{
			if (stopAll)
			{
				this.StopAll();
			}
			this.TweenAnimMap.Clear();
			foreach (KeyValuePair<ULGUIPlayTween, FLGUIDelegateHandleWrapper> keyValuePair in this.TweenDelegateWrapperMap)
			{
				ULGUIPlayTween ulguiplayTween;
				FLGUIDelegateHandleWrapper flguidelegateHandleWrapper;
				keyValuePair.Deconstruct(out ulguiplayTween, out flguidelegateHandleWrapper);
				ULGUIPlayTween ulguiplayTween2 = ulguiplayTween;
				FLGUIDelegateHandleWrapper flguidelegateHandleWrapper2 = flguidelegateHandleWrapper;
				ulguiplayTween2.UnregisterOnComplete(flguidelegateHandleWrapper2);
			}
			this.TweenCallbackMap.Clear();
			foreach (Action callBack in this.TweenCallbackMap.Values)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(callBack);
			}
			this.TweenCallbackMap.Clear();
		}

		// Token: 0x06031397 RID: 201623 RVA: 0x00DBDBD4 File Offset: 0x00DBBDD4
		public void InitTweenAnim(int componentType, UUIItem item, bool stopOnInited = false)
		{
			if (item == null)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "BattleUiTweenAnimPlayer.InitTweenAnim : 参数item不能为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>();
			TArray<UActorComponent> tarray = item.GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				list.Add(tarray.Get(i) as ULGUIPlayTweenComponent);
			}
			this.TweenAnimMap[componentType] = list;
			if (stopOnInited)
			{
				this.StopTweenAnim(componentType);
			}
		}

		// Token: 0x06031398 RID: 201624 RVA: 0x00DBDC60 File Offset: 0x00DBBE60
		public void PlayTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x06031399 RID: 201625 RVA: 0x00DBDCBC File Offset: 0x00DBBEBC
		public UniTask PlayTweenAnimAsync(int componentType)
		{
			BattleUiTweenAnimPlayer.<PlayTweenAnimAsync>d__7 <PlayTweenAnimAsync>d__;
			<PlayTweenAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTweenAnimAsync>d__.<>4__this = this;
			<PlayTweenAnimAsync>d__.componentType = componentType;
			<PlayTweenAnimAsync>d__.<>1__state = -1;
			<PlayTweenAnimAsync>d__.<>t__builder.Start<BattleUiTweenAnimPlayer.<PlayTweenAnimAsync>d__7>(ref <PlayTweenAnimAsync>d__);
			return <PlayTweenAnimAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603139A RID: 201626 RVA: 0x00DBDD08 File Offset: 0x00DBBF08
		public void StopTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x0603139B RID: 201627 RVA: 0x00DBDD64 File Offset: 0x00DBBF64
		public void StopAll()
		{
			foreach (List<ULGUIPlayTweenComponent> list in this.TweenAnimMap.Values)
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x0603139C RID: 201628 RVA: 0x00DBDDF0 File Offset: 0x00DBBFF0
		public void StopAllBut(List<int> exception)
		{
			foreach (KeyValuePair<int, List<ULGUIPlayTweenComponent>> keyValuePair in this.TweenAnimMap)
			{
				if (exception == null || !exception.Contains(keyValuePair.Key))
				{
					foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in keyValuePair.Value)
					{
						ulguiplayTweenComponent.Stop();
					}
				}
			}
		}

		// Token: 0x0603139D RID: 201629 RVA: 0x00DBDE90 File Offset: 0x00DBC090
		public void Active(int componentType, bool bPlay)
		{
			if (bPlay)
			{
				this.PlayTweenAnim(componentType);
				return;
			}
			this.StopTweenAnim(componentType);
		}

		// Token: 0x0603139E RID: 201630 RVA: 0x00DBDEA4 File Offset: 0x00DBC0A4
		public bool CheckIsPlaying(int componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					UObject world = GlobalData.World;
					ULGUIPlayTween playTween = ulguiplayTweenComponent.GetPlayTween();
					if (ULTweenBPLibrary.IsTweening(world, (playTween != null) ? playTween.GetTweener() : null))
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0603139F RID: 201631 RVA: 0x00DBDF20 File Offset: 0x00DBC120
		public float GetDuration(int componentType)
		{
			float num = 0f;
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ULGUIPlayTween playTween = ulguiplayTweenComponent.playTween;
					num = Math.Max((playTween != null) ? playTween.duration : 0f, num);
				}
			}
			return num;
		}

		// Token: 0x060313A0 RID: 201632 RVA: 0x00DBDF9C File Offset: 0x00DBC19C
		public void SetTweenTimeScale(int componentType, float timeScale)
		{
			List<ULGUIPlayTweenComponent> list;
			if (!this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				return;
			}
			foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
			{
				ULGUIPlayTween playTween = ulguiplayTweenComponent.GetPlayTween();
				ULTweener ultweener = (playTween != null) ? playTween.GetTweener() : null;
				if (ultweener != null)
				{
					ultweener.SetSpeed(timeScale);
				}
			}
		}

		// Token: 0x060313A1 RID: 201633 RVA: 0x00DBE014 File Offset: 0x00DBC214
		public void RegisterOnComplete(int componentType, Action callback)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue(componentType, out list))
			{
				ULGUIPlayTween playTween = list[0].GetPlayTween();
				if (playTween != null)
				{
					FLGUIPlayTweenCompleteDynamicDelegate flguiplayTweenCompleteDynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(callback);
					FLGUIDelegateHandleWrapper value = playTween.RegisterOnComplete(flguiplayTweenCompleteDynamicDelegate);
					this.TweenCallbackMap.Add(componentType, callback);
					this.TweenDelegateWrapperMap.Add(playTween, value);
				}
			}
		}

		// Token: 0x0401A131 RID: 106801
		protected Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0401A132 RID: 106802
		protected Dictionary<int, Action> TweenCallbackMap = new Dictionary<int, Action>();

		// Token: 0x0401A133 RID: 106803
		protected Dictionary<ULGUIPlayTween, FLGUIDelegateHandleWrapper> TweenDelegateWrapperMap = new Dictionary<ULGUIPlayTween, FLGUIDelegateHandleWrapper>();

		// Token: 0x0401A134 RID: 106804
		private const bool TsDebugLog = false;
	}
}
