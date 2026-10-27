using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005053 RID: 20563
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotHintView : UiViewBase
	{
		// Token: 0x060349E2 RID: 215522 RVA: 0x00C6E3A8 File Offset: 0x00C6C5A8
		public PlotHintView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060349E3 RID: 215523 RVA: 0x00C6E3C8 File Offset: 0x00C6C5C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060349E4 RID: 215524 RVA: 0x00C6E434 File Offset: 0x00C6C634
		protected override void OnStart()
		{
			TransitionPopupViewParams transitionPopupViewParams = this.OpenParam as TransitionPopupViewParams;
			UUIText text = base.GetText(0);
			if (((transitionPopupViewParams != null) ? transitionPopupViewParams.Style : null) != null)
			{
				string styleTitle = this.GetStyleTitle(transitionPopupViewParams.Style);
				if (!string.IsNullOrEmpty(styleTitle))
				{
					if (text != null)
					{
						text.ShowTextNew(styleTitle);
					}
				}
				else if (text != null)
				{
					text.SetUIActive(false);
				}
				this.InitTweenAnim(1);
				return;
			}
			TransitionPopup? transitionPopup = (transitionPopupViewParams != null && transitionPopupViewParams.BoardId != null) ? ConfigTransitionPopupById.GetConfig(transitionPopupViewParams.BoardId.Value, true) : null;
			if (transitionPopup == null)
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
				return;
			}
			if (!string.IsNullOrEmpty(transitionPopup.Value.Title))
			{
				if (text != null)
				{
					text.ShowTextNew(transitionPopup.Value.Title);
				}
			}
			else if (text != null)
			{
				text.SetUIActive(false);
			}
			this.InitTweenAnim(1);
		}

		// Token: 0x060349E5 RID: 215525 RVA: 0x00C6E524 File Offset: 0x00C6C724
		[return: Nullable(2)]
		private string GetStyleTitle(ITransitionPopupStyle style)
		{
			ITransitionPopupLeftTopTip transitionPopupLeftTopTip = style as ITransitionPopupLeftTopTip;
			string result;
			if (transitionPopupLeftTopTip == null)
			{
				ITransitionPopupLeftBottomTransition transitionPopupLeftBottomTransition = style as ITransitionPopupLeftBottomTransition;
				if (transitionPopupLeftBottomTransition == null)
				{
					result = null;
				}
				else
				{
					result = transitionPopupLeftBottomTransition.TitleText;
				}
			}
			else
			{
				result = transitionPopupLeftTopTip.TitleText;
			}
			return result;
		}

		// Token: 0x060349E6 RID: 215526 RVA: 0x00C6E55C File Offset: 0x00C6C75C
		private void InitTweenAnim(int componentType)
		{
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>();
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				list.Add(tarray.Get(i) as ULGUIPlayTweenComponent);
			}
			if (this.TweenAnimMap == null)
			{
				this.TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();
			}
			this.TweenAnimMap.Add(componentType, list);
		}

		// Token: 0x060349E7 RID: 215527 RVA: 0x00C6E5D0 File Offset: 0x00C6C7D0
		protected override void OnAfterShow()
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap != null && this.TweenAnimMap.TryGetValue(1, out list) && list.Count > 0)
			{
				this.TotalAnimCount = list.Count;
				this.CompletedAnimCount = 0;
				for (int i = 0; i < list.Count; i++)
				{
					ULGUIPlayTweenComponent ulguiplayTweenComponent = list[i];
					ULGUIPlayTween playTween = ulguiplayTweenComponent.GetPlayTween();
					if (playTween != null)
					{
						Action action = this.CreateAnimCompleteCallback(i);
						this.AnimCompleteCallbacks.Add(action);
						ULGUIPlayTween ulguiplayTween = playTween;
						FLGUIPlayTweenCompleteDynamicDelegate flguiplayTweenCompleteDynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(action);
						FLGUIDelegateHandleWrapper item = ulguiplayTween.RegisterOnComplete(flguiplayTweenCompleteDynamicDelegate);
						this.AnimCompleteHandles.Add(item);
						ulguiplayTweenComponent.Play();
					}
				}
			}
		}

		// Token: 0x060349E8 RID: 215528 RVA: 0x00C6E673 File Offset: 0x00C6C873
		private Action CreateAnimCompleteCallback(int index)
		{
			return delegate()
			{
				this.OnAnimComplete(index);
			};
		}

		// Token: 0x060349E9 RID: 215529 RVA: 0x00C6E693 File Offset: 0x00C6C893
		private void OnAnimComplete(int index)
		{
			this.CompletedAnimCount++;
			if (this.CompletedAnimCount >= this.TotalAnimCount)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x060349EA RID: 215530 RVA: 0x00C6E6B8 File Offset: 0x00C6C8B8
		protected override void OnBeforeDestroy()
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap != null && this.TweenAnimMap.TryGetValue(1, out list) && list.Count > 0)
			{
				for (int i = 0; i < this.AnimCompleteHandles.Count; i++)
				{
					FLGUIDelegateHandleWrapper flguidelegateHandleWrapper = this.AnimCompleteHandles[i];
					if (flguidelegateHandleWrapper.IsValid() && i < list.Count)
					{
						ULGUIPlayTween playTween = list[i].GetPlayTween();
						if (playTween != null)
						{
							playTween.UnregisterOnComplete(flguidelegateHandleWrapper);
						}
					}
				}
			}
			this.AnimCompleteHandles.Clear();
			foreach (Action callBack in this.AnimCompleteCallbacks)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(callBack);
			}
			this.AnimCompleteCallbacks.Clear();
		}

		// Token: 0x0401C0AC RID: 114860
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

		// Token: 0x0401C0AD RID: 114861
		private readonly List<FLGUIDelegateHandleWrapper> AnimCompleteHandles = new List<FLGUIDelegateHandleWrapper>();

		// Token: 0x0401C0AE RID: 114862
		private readonly List<Action> AnimCompleteCallbacks = new List<Action>();

		// Token: 0x0401C0AF RID: 114863
		private int TotalAnimCount;

		// Token: 0x0401C0B0 RID: 114864
		private int CompletedAnimCount;

		// Token: 0x0200B1AC RID: 45484
		[NullableContext(0)]
		private enum EChildComp
		{
			// Token: 0x04035E2A RID: 220714
			ContentText,
			// Token: 0x04035E2B RID: 220715
			AniStart
		}
	}
}
