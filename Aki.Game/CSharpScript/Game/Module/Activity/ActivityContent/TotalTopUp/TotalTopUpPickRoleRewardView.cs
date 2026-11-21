using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004FA9 RID: 20393
	[NullableContext(2)]
	[Nullable(0)]
	public class TotalTopUpPickRoleRewardView : UiViewBase
	{
		// Token: 0x060331B8 RID: 209336 RVA: 0x00E53429 File Offset: 0x00E51629
		[NullableContext(1)]
		public TotalTopUpPickRoleRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060331B9 RID: 209337 RVA: 0x00E5343C File Offset: 0x00E5163C
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

		// Token: 0x060331BA RID: 209338 RVA: 0x00E53514 File Offset: 0x00E51714
		protected override UniTask OnBeforeStartAsync()
		{
			TotalTopUpPickRoleRewardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TotalTopUpPickRoleRewardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060331BB RID: 209339 RVA: 0x00E53557 File Offset: 0x00E51757
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

		// Token: 0x060331BC RID: 209340 RVA: 0x00E5357B File Offset: 0x00E5177B
		private void OnClickedCloseButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x060331BD RID: 209341 RVA: 0x00E53584 File Offset: 0x00E51784
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

		// Token: 0x060331BE RID: 209342 RVA: 0x00E535A4 File Offset: 0x00E517A4
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

		// Token: 0x060331BF RID: 209343 RVA: 0x00E53610 File Offset: 0x00E51810
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

		// Token: 0x0401B227 RID: 111143
		[Nullable(1)]
		private const string SWITCH_SEQUENCE_NAME = "Switch";

		// Token: 0x0401B228 RID: 111144
		private TotalTopUpPickRoleViewModel ViewModel;

		// Token: 0x0401B229 RID: 111145
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401B22A RID: 111146
		private TotalTopUpPickRoleChoicePanel ChoicePanel;

		// Token: 0x0401B22B RID: 111147
		private TotalTopUpPickRoleRolePanel RolePanel;

		// Token: 0x0401B22C RID: 111148
		private TotalTopUpPickRoleItemPanel ItemPanel;

		// Token: 0x0401B22D RID: 111149
		private int CurrentSelectedIndex = -1;
	}
}
