using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CF7 RID: 23799
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiTweenAnimPlayer
	{
		// Token: 0x0603C440 RID: 246848 RVA: 0x00E6D54C File Offset: 0x00E6B74C
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

		// Token: 0x0603C441 RID: 246849 RVA: 0x00E6D620 File Offset: 0x00E6B820
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

		// Token: 0x0603C442 RID: 246850 RVA: 0x00E6D6AC File Offset: 0x00E6B8AC
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

		// Token: 0x0603C443 RID: 246851 RVA: 0x00E6D708 File Offset: 0x00E6B908
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

		// Token: 0x0603C444 RID: 246852 RVA: 0x00E6D754 File Offset: 0x00E6B954
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

		// Token: 0x0603C445 RID: 246853 RVA: 0x00E6D7B0 File Offset: 0x00E6B9B0
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

		// Token: 0x0603C446 RID: 246854 RVA: 0x00E6D83C File Offset: 0x00E6BA3C
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

		// Token: 0x0603C447 RID: 246855 RVA: 0x00E6D8DC File Offset: 0x00E6BADC
		public void Active(int componentType, bool bPlay)
		{
			if (bPlay)
			{
				this.PlayTweenAnim(componentType);
				return;
			}
			this.StopTweenAnim(componentType);
		}

		// Token: 0x0603C448 RID: 246856 RVA: 0x00E6D8F0 File Offset: 0x00E6BAF0
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

		// Token: 0x0603C449 RID: 246857 RVA: 0x00E6D96C File Offset: 0x00E6BB6C
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

		// Token: 0x0603C44A RID: 246858 RVA: 0x00E6D9E8 File Offset: 0x00E6BBE8
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

		// Token: 0x0603C44B RID: 246859 RVA: 0x00E6DA60 File Offset: 0x00E6BC60
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

		// Token: 0x0401F678 RID: 128632
		protected Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0401F679 RID: 128633
		protected Dictionary<int, Action> TweenCallbackMap = new Dictionary<int, Action>();

		// Token: 0x0401F67A RID: 128634
		protected Dictionary<ULGUIPlayTween, FLGUIDelegateHandleWrapper> TweenDelegateWrapperMap = new Dictionary<ULGUIPlayTween, FLGUIDelegateHandleWrapper>();

		// Token: 0x0401F67B RID: 128635
		private const bool TsDebugLog = false;
	}
}
