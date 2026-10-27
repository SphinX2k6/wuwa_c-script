using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FC2 RID: 24514
	[NullableContext(2)]
	[Nullable(0)]
	public class TotalTopUpPickRoleRewardView : UiViewBase
	{
		// Token: 0x0603E21E RID: 254494 RVA: 0x00F0176D File Offset: 0x00EFF96D
		[NullableContext(1)]
		public TotalTopUpPickRoleRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603E21F RID: 254495 RVA: 0x00F01780 File Offset: 0x00EFF980
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickConfirmButton))
			};
		}

		// Token: 0x0603E220 RID: 254496 RVA: 0x00F01858 File Offset: 0x00EFFA58
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPickRoleRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPickRoleRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E221 RID: 254497 RVA: 0x00F0189B File Offset: 0x00EFFA9B
		protected override void OnStart()
		{
			TotalTopUpPickRoleChoicePanel choicePanel = this.ChoicePanel;
			if (choicePanel == null)
			{
				return;
			}
			TotalTopUpPickRoleViewModel viewModel = this.ViewModel;
			choicePanel.SelectItem((viewModel != null) ? viewModel.FirstCanClaimIndex : 0);
		}

		// Token: 0x0603E222 RID: 254498 RVA: 0x00F018BF File Offset: 0x00EFFABF
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603E223 RID: 254499 RVA: 0x00F018C8 File Offset: 0x00EFFAC8
		private void OnClickConfirmButton()
		{
			TotalTopUpPickRoleViewModel viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.Claim(delegate
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x0603E224 RID: 254500 RVA: 0x00F018E8 File Offset: 0x00EFFAE8
		[NullableContext(1)]
		private void OnSelectItemCallback(ITotalTopUpPickRoleRewardItemData data)
		{
			bool flag = this.CurrentSelectedIndex >= 0 && this.CurrentSelectedIndex != data.Index;
			this.CurrentSelectedIndex = data.Index;
			TotalTopUpPickRoleViewModel viewModel = this.ViewModel;
			if (viewModel != null)
			{
				viewModel.SelectItem(data.Index);
			}
			this.Refresh();
			if (flag)
			{
				base.PlayOrReplaySequence("Switch", false, null);
			}
		}

		// Token: 0x0603E225 RID: 254501 RVA: 0x00F01954 File Offset: 0x00EFFB54
		private void Refresh()
		{
			if (this.ViewModel == null)
			{
				return;
			}
			bool canClaim = this.ViewModel.CanClaim;
			base.GetItem(4).SetUIActive(!canClaim);
			base.GetButton(5).RootUIComp.Get().SetUIActive(canClaim);
			base.GetItem(1).SetUIActive(this.ViewModel.IsRole);
			base.GetItem(2).SetUIActive(!this.ViewModel.IsRole);
			string currentRoleBackgroundPath = this.ViewModel.CurrentRoleBackgroundPath;
			base.TrySetTextureByPath((currentRoleBackgroundPath.Length > 0) ? currentRoleBackgroundPath : null, base.GetTexture(6), null, null);
			TotalTopUpPickRoleRolePanel rolePanel = this.RolePanel;
			if (rolePanel != null)
			{
				rolePanel.Refresh(this.ViewModel);
			}
			TotalTopUpPickRoleItemPanel itemPanel = this.ItemPanel;
			if (itemPanel == null)
			{
				return;
			}
			itemPanel.Refresh(this.ViewModel);
		}

		// Token: 0x04020755 RID: 132949
		[Nullable(1)]
		private const string SWITCH_SEQUENCE_NAME = "Switch";

		// Token: 0x04020756 RID: 132950
		private TotalTopUpPickRoleViewModel ViewModel;

		// Token: 0x04020757 RID: 132951
		private PopupCaptionItem CaptionItem;

		// Token: 0x04020758 RID: 132952
		private TotalTopUpPickRoleChoicePanel ChoicePanel;

		// Token: 0x04020759 RID: 132953
		private TotalTopUpPickRoleRolePanel RolePanel;

		// Token: 0x0402075A RID: 132954
		private TotalTopUpPickRoleItemPanel ItemPanel;

		// Token: 0x0402075B RID: 132955
		private int CurrentSelectedIndex = -1;
	}
}
