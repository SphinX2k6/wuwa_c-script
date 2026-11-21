using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.GreatSword
{
	// Token: 0x0200374B RID: 14155
	[NullableContext(1)]
	[Nullable(0)]
	public class GreatSwordMarkPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06024D14 RID: 150804 RVA: 0x00A67B3E File Offset: 0x00A65D3E
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06024D15 RID: 150805 RVA: 0x00A67B45 File Offset: 0x00A65D45
		protected override void OnStart()
		{
			this.TargetListPanel = new GreatSwordMarkTargetListPanel();
			this.TargetListPanel.Initialize(base.GetVerticalLayout(16));
			base.OnStart();
		}

		// Token: 0x06024D16 RID: 150806 RVA: 0x00A67B6C File Offset: 0x00A65D6C
		protected override UniTask OnBeforeShowWorldMapSecondaryUiAsync(params object[] param)
		{
			GreatSwordMarkPanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__5 <OnBeforeShowWorldMapSecondaryUiAsync>d__;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>4__this = this;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.param = param;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>1__state = -1;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Start<GreatSwordMarkPanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__5>(ref <OnBeforeShowWorldMapSecondaryUiAsync>d__);
			return <OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024D17 RID: 150807 RVA: 0x00A67BB8 File Offset: 0x00A65DB8
		protected override void SetupWorldMapSecondaryUiLayout()
		{
			base.SetupWorldMapSecondaryUiLayout();
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(7);
			if (verticalLayout != null)
			{
				verticalLayout.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(5);
			if (verticalLayout2 != null)
			{
				verticalLayout2.RootUIComp.Get().SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(32);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
			if (layoutContext == null)
			{
				return;
			}
			layoutContext.SetConfirmBtnActive(true);
		}

		// Token: 0x06024D18 RID: 150808 RVA: 0x00A67C44 File Offset: 0x00A65E44
		protected override void OnShowWorldMapSecondaryUi(params object[] param)
		{
			if (param.Length != 0 && param[0] is GreatSwordChallengeMarkItem)
			{
				GreatSwordChallengeMarkItem selectedMarkItem = this.SelectedMarkItem;
				int num = (selectedMarkItem != null) ? selectedMarkItem.MarkConfigId : 0;
				MapMark? config = ConfigMapMarkByMarkId.GetConfig(num, true);
				if (config == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Map;
					ELogAuthor author = ELogAuthor.LYX;
					string message = "缺少标记配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("MarkId", num);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonEnableClickByTeleportState(this.LayoutContext);
				WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
				WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
				WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), config.Value.MarkDesc, Array.Empty<object>());
				base.UpdateMultiMap();
				base.UpdateTopRightIconActive();
				base.UpdateHidePlayMapTipPanel();
				UUIVerticalLayout verticalLayout = base.GetVerticalLayout(16);
				if (verticalLayout != null)
				{
					verticalLayout.RootUIComp.Get().SetUIActive(true);
				}
				this.RefreshLayout();
			}
		}

		// Token: 0x06024D19 RID: 150809 RVA: 0x00A67D41 File Offset: 0x00A65F41
		protected override void OnConfirmBtnClick(int index)
		{
			this.HandleTeleport();
		}

		// Token: 0x06024D1A RID: 150810 RVA: 0x00A67D4C File Offset: 0x00A65F4C
		private void RefreshLayout()
		{
			ITrialChallenge challenge = GreatSwordChallengeModel.Instance.GetChallenge();
			if (challenge == null)
			{
				return;
			}
			for (int i = 0; i < challenge.SubChallenges.Count; i++)
			{
				ITrialSubChallenge trialSubChallenge = challenge.SubChallenges[i];
				GreatSwordMarkTargetListPanel targetListPanel = this.TargetListPanel;
				GreatSwordMarkTargetListItemPanel greatSwordMarkTargetListItemPanel;
				if (targetListPanel == null)
				{
					greatSwordMarkTargetListItemPanel = null;
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
					defaultInterpolatedStringHandler.AppendLiteral("Target_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i);
					greatSwordMarkTargetListItemPanel = targetListPanel.AddItemByKey(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				GreatSwordMarkTargetListItemPanel greatSwordMarkTargetListItemPanel2 = greatSwordMarkTargetListItemPanel;
				if (greatSwordMarkTargetListItemPanel2 != null)
				{
					greatSwordMarkTargetListItemPanel2.SetDescTxt(trialSubChallenge.Config.MapGoalText);
					greatSwordMarkTargetListItemPanel2.SetState(trialSubChallenge.Completed);
				}
			}
		}

		// Token: 0x06024D1B RID: 150811 RVA: 0x00A67DE6 File Offset: 0x00A65FE6
		protected override void OnBeforeDestroy()
		{
			GreatSwordMarkTargetListPanel targetListPanel = this.TargetListPanel;
			if (targetListPanel != null)
			{
				targetListPanel.Clear();
			}
			base.OnBeforeDestroy();
		}

		// Token: 0x040146BA RID: 83642
		[Nullable(2)]
		private GreatSwordChallengeMarkItem SelectedMarkItem;

		// Token: 0x040146BB RID: 83643
		[Nullable(2)]
		private GreatSwordMarkTargetListPanel TargetListPanel;

		// Token: 0x020094A0 RID: 38048
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x0402E703 RID: 190211
			public const int GreatSwordChallengePanel = 0;
		}
	}
}
