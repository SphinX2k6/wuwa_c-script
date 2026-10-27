using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.View
{
	// Token: 0x02006490 RID: 25744
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeConfirmBoxView : UiViewBase
	{
		// Token: 0x06040A73 RID: 264819 RVA: 0x00FA5B41 File Offset: 0x00FA3D41
		public MatchThreeConfirmBoxView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06040A74 RID: 264820 RVA: 0x00FA5B60 File Offset: 0x00FA3D60
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClose));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnToggleClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040A75 RID: 264821 RVA: 0x00FA5CD0 File Offset: 0x00FA3ED0
		protected override UniTask OnBeforeStartAsync()
		{
			MatchThreeConfirmBoxView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MatchThreeConfirmBoxView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040A76 RID: 264822 RVA: 0x00FA5D14 File Offset: 0x00FA3F14
		protected override void OnBeforeShow()
		{
			bool flag = this.ShouldShowCloseButton();
			UUIButtonComponent button = base.GetButton(1);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(flag);
				}
			}
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.SetBackBtnShowState(flag);
			}
			IUiPopFrameInterface childPopView2 = this.ChildPopView;
			if (childPopView2 != null)
			{
				childPopView2.PopItem.SetMaskResponsibleState(this.Config.Value.NeedMaskClose);
			}
			IUiPopFrameInterface childPopView3 = this.ChildPopView;
			if (childPopView3 == null)
			{
				return;
			}
			childPopView3.PopItem.OverrideBackBtnCallBack(new Action(this.OnClose));
		}

		// Token: 0x06040A77 RID: 264823 RVA: 0x00FA5DAC File Offset: 0x00FA3FAC
		private bool ShouldShowCloseButton()
		{
			return this.Config.Value.NeedClose && this.ConfirmBoxData != null && this.ConfirmBoxData.ConfigId != EConfirmBoxConfigId.MatchThreeRestartConfirm && this.ConfirmBoxData.ConfigId != EConfirmBoxConfigId.MatchThreeLowerDifficultyConfirm;
		}

		// Token: 0x06040A78 RID: 264824 RVA: 0x00FA5E01 File Offset: 0x00FA4001
		protected override void OnAfterShow()
		{
			Action afterShowFunction = this.ConfirmBoxData.GetAfterShowFunction();
			if (afterShowFunction == null)
			{
				return;
			}
			afterShowFunction();
		}

		// Token: 0x06040A79 RID: 264825 RVA: 0x00FA5E18 File Offset: 0x00FA4018
		protected override void OnBeforeHide()
		{
			if (this.LastHide)
			{
				ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
				if (confirmBoxData == null)
				{
					return;
				}
				Action beforePlayCloseFunction = confirmBoxData.BeforePlayCloseFunction;
				if (beforePlayCloseFunction == null)
				{
					return;
				}
				beforePlayCloseFunction();
			}
		}

		// Token: 0x06040A7A RID: 264826 RVA: 0x00FA5E3C File Offset: 0x00FA403C
		protected override void OnBeforeDestroy()
		{
			this.ResetButtonList();
			this.HandleSelectedIndexWhenClose();
			Action action;
			if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action) && action != null)
			{
				action();
			}
			ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
			if (confirmBoxData == null)
			{
				return;
			}
			Action destroyFunction = confirmBoxData.DestroyFunction;
			if (destroyFunction == null)
			{
				return;
			}
			destroyFunction();
		}

		// Token: 0x06040A7B RID: 264827 RVA: 0x00FA5E9A File Offset: 0x00FA409A
		private void OnClose()
		{
			this.SelectedIndex = -1;
			this.ConfirmBoxButtonClick();
		}

		// Token: 0x06040A7C RID: 264828 RVA: 0x00FA5EAC File Offset: 0x00FA40AC
		private void ConfirmBoxButtonClick()
		{
			ConfirmBoxDataNew confirmBoxData = this.ConfirmBoxData;
			Func<int, bool> func = (confirmBoxData != null) ? confirmBoxData.CanExecuteCloseFunc : null;
			if (func != null && !func(this.SelectedIndex))
			{
				Action action;
				if (this.ConfirmBoxData != null && this.ConfirmBoxData.FunctionMap.TryGetValue(this.SelectedIndex, out action) && action != null)
				{
					action();
				}
				return;
			}
			base.CloseMe(delegate(bool _)
			{
				Action closeFunction = this.ConfirmBoxData.GetCloseFunction();
				if (closeFunction == null)
				{
					return;
				}
				closeFunction();
			});
		}

		// Token: 0x06040A7D RID: 264829 RVA: 0x00FA5F1C File Offset: 0x00FA411C
		private void HandleSelectedIndexWhenClose()
		{
			if (this.SelectedIndex != -1)
			{
				return;
			}
			this.SelectedIndex = (((this.Config != null && this.Config.GetValueOrDefault().ButtonTextLength == 1) || this.ConfirmBoxData.IsEscViewTriggerCallBack) ? 1 : 0);
		}

		// Token: 0x06040A7E RID: 264830 RVA: 0x00FA5F70 File Offset: 0x00FA4170
		private UniTask InitButton()
		{
			MatchThreeConfirmBoxView.<InitButton>d__17 <InitButton>d__;
			<InitButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButton>d__.<>4__this = this;
			<InitButton>d__.<>1__state = -1;
			<InitButton>d__.<>t__builder.Start<MatchThreeConfirmBoxView.<InitButton>d__17>(ref <InitButton>d__);
			return <InitButton>d__.<>t__builder.Task;
		}

		// Token: 0x06040A7F RID: 264831 RVA: 0x00FA5FB4 File Offset: 0x00FA41B4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<ConfirmBoxButton> CreateButton(UUIItem uiItem, int index, Action clickFunction)
		{
			MatchThreeConfirmBoxView.<CreateButton>d__18 <CreateButton>d__;
			<CreateButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<ConfirmBoxButton>.Create();
			<CreateButton>d__.<>4__this = this;
			<CreateButton>d__.uiItem = uiItem;
			<CreateButton>d__.index = index;
			<CreateButton>d__.clickFunction = clickFunction;
			<CreateButton>d__.<>1__state = -1;
			<CreateButton>d__.<>t__builder.Start<MatchThreeConfirmBoxView.<CreateButton>d__18>(ref <CreateButton>d__);
			return <CreateButton>d__.<>t__builder.Task;
		}

		// Token: 0x06040A80 RID: 264832 RVA: 0x00FA6010 File Offset: 0x00FA4210
		private void ResetButtonList()
		{
			int i = 0;
			int num = this.ButtonList.Length;
			while (i < num)
			{
				this.ButtonList[i].Destroy(null);
				i++;
			}
			this.ButtonList = Array.Empty<ConfirmBoxButton>();
		}

		// Token: 0x06040A81 RID: 264833 RVA: 0x00FA604B File Offset: 0x00FA424B
		private void OnToggleClick(EToggleState toggleState)
		{
			Action<bool> toggleFunction = this.ToggleFunction;
			if (toggleFunction == null)
			{
				return;
			}
			toggleFunction(toggleState == EToggleState.ETT_Checked);
		}

		// Token: 0x06040A82 RID: 264834 RVA: 0x00FA6064 File Offset: 0x00FA4264
		private void InitToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			this.ToggleFunction = null;
			ConfirmBoxDataNew data = this.ConfirmBoxData;
			if (data == null)
			{
				if (extendToggle != null)
				{
					UUIItem uuiitem = extendToggle.RootUIComp.Get();
					if (uuiitem == null)
					{
						return;
					}
					uuiitem.SetUIActive(false);
				}
				return;
			}
			if (!data.HasToggle && (this.Config != null && this.Config.GetValueOrDefault().ToggleType == 1))
			{
				data.HasToggle = true;
				data.ToggleTextKey = "Text_Confirmation_Box_Prompt";
				data.SetToggleFunction(delegate(bool isSelectOn)
				{
					ConfirmBoxModel instance = ConfirmBoxModel.Instance;
					if (isSelectOn)
					{
						instance.NotShowAgainSet.Add(data.ConfigId);
						return;
					}
					instance.NotShowAgainSet.Remove(data.ConfigId);
				});
			}
			bool flag = data.HasToggle && (!StringUtils.IsBlank(data.ToggleText) || !StringUtils.IsBlank(data.ToggleTextKey));
			if (extendToggle != null)
			{
				UUIItem uuiitem2 = extendToggle.RootUIComp.Get();
				if (uuiitem2 != null)
				{
					uuiitem2.SetUIActive(flag);
				}
			}
			if (!flag)
			{
				return;
			}
			UUIText text = base.GetText(6);
			if (StringUtils.IsBlank(data.ToggleText))
			{
				LguiUtil.Instance.SetLocalTextNew(text, data.ToggleTextKey, Array.Empty<object>());
			}
			else
			{
				text.SetText(data.ToggleText, true);
			}
			this.ToggleFunction = data.GetToggleFunction();
		}

		// Token: 0x04021A1C RID: 137756
		private ConfirmBoxButton[] ButtonList = Array.Empty<ConfirmBoxButton>();

		// Token: 0x04021A1D RID: 137757
		private readonly List<UUIButtonComponent> ButtonComponentList = new List<UUIButtonComponent>();

		// Token: 0x04021A1E RID: 137758
		private ConfirmBox? Config;

		// Token: 0x04021A1F RID: 137759
		[Nullable(2)]
		private ConfirmBoxDataNew ConfirmBoxData;

		// Token: 0x04021A20 RID: 137760
		[Nullable(2)]
		private Action<bool> ToggleFunction;

		// Token: 0x04021A21 RID: 137761
		private int SelectedIndex;
	}
}
