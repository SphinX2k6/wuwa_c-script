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
	// Token: 0x02004023 RID: 16419
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotHintView : UiViewBase
	{
		// Token: 0x060298D5 RID: 170197 RVA: 0x00BBB649 File Offset: 0x00BB9849
		public PlotHintView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060298D6 RID: 170198 RVA: 0x00BBB668 File Offset: 0x00BB9868
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

		// Token: 0x060298D7 RID: 170199 RVA: 0x00BBB6D4 File Offset: 0x00BB98D4
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

		// Token: 0x060298D8 RID: 170200 RVA: 0x00BBB7C4 File Offset: 0x00BB99C4
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

		// Token: 0x060298D9 RID: 170201 RVA: 0x00BBB7FC File Offset: 0x00BB99FC
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

		// Token: 0x060298DA RID: 170202 RVA: 0x00BBB870 File Offset: 0x00BB9A70
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

		// Token: 0x060298DB RID: 170203 RVA: 0x00BBB913 File Offset: 0x00BB9B13
		private Action CreateAnimCompleteCallback(int index)
		{
			return delegate()
			{
				this.OnAnimComplete(index);
			};
		}

		// Token: 0x060298DC RID: 170204 RVA: 0x00BBB933 File Offset: 0x00BB9B33
		private void OnAnimComplete(int index)
		{
			this.CompletedAnimCount++;
			if (this.CompletedAnimCount >= this.TotalAnimCount)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x060298DD RID: 170205 RVA: 0x00BBB958 File Offset: 0x00BB9B58
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

		// Token: 0x04016AD7 RID: 92887
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap;

		// Token: 0x04016AD8 RID: 92888
		private readonly List<FLGUIDelegateHandleWrapper> AnimCompleteHandles = new List<FLGUIDelegateHandleWrapper>();

		// Token: 0x04016AD9 RID: 92889
		private readonly List<Action> AnimCompleteCallbacks = new List<Action>();

		// Token: 0x04016ADA RID: 92890
		private int TotalAnimCount;

		// Token: 0x04016ADB RID: 92891
		private int CompletedAnimCount;

		// Token: 0x02009BE6 RID: 39910
		[NullableContext(0)]
		private enum EChildComp
		{
			// Token: 0x0403087F RID: 198783
			ContentText,
			// Token: 0x04030880 RID: 198784
			AniStart
		}
	}
}
