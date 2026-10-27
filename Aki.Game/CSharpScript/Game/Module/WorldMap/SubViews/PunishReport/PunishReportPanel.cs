using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.PunishReport
{
	// Token: 0x020047F5 RID: 18421
	[NullableContext(1)]
	[Nullable(0)]
	public class PunishReportPanel : WorldMapSecondaryUiLayoutA
	{
		// Token: 0x06030402 RID: 197634 RVA: 0x00B30B21 File Offset: 0x00B2ED21
		public override string GetResourceId()
		{
			return "UiItem_GeneralPanel_Prefab";
		}

		// Token: 0x06030403 RID: 197635 RVA: 0x00B30B28 File Offset: 0x00B2ED28
		protected override void OnStart()
		{
			this.TargetListPanel = new PunishReportTargetListPanel();
			this.TargetListPanel.Initialize(base.GetVerticalLayout(16));
			base.OnStart();
		}

		// Token: 0x06030404 RID: 197636 RVA: 0x00B30B50 File Offset: 0x00B2ED50
		protected override UniTask OnBeforeShowWorldMapSecondaryUiAsync(params object[] param)
		{
			PunishReportPanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__5 <OnBeforeShowWorldMapSecondaryUiAsync>d__;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>4__this = this;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.param = param;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>1__state = -1;
			<OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Start<PunishReportPanel.<OnBeforeShowWorldMapSecondaryUiAsync>d__5>(ref <OnBeforeShowWorldMapSecondaryUiAsync>d__);
			return <OnBeforeShowWorldMapSecondaryUiAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030405 RID: 197637 RVA: 0x00B30B9C File Offset: 0x00B2ED9C
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
			if (verticalLayout2 == null)
			{
				return;
			}
			verticalLayout2.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06030406 RID: 197638 RVA: 0x00B30C04 File Offset: 0x00B2EE04
		protected override void OnShowWorldMapSecondaryUi(params object[] parameters)
		{
			if (parameters.Length != 0)
			{
				int num = 0;
				int num2 = 0;
				bool flag = false;
				LevelPlayReportMarkItem levelPlayReportMarkItem = parameters[0] as LevelPlayReportMarkItem;
				if (levelPlayReportMarkItem != null)
				{
					this.SelectedMarkItem = new OneOf<LevelPlayReportMarkItem, PunishReportMarkItem>?(levelPlayReportMarkItem);
					this.LayoutContext.MarkItem = levelPlayReportMarkItem;
					num = levelPlayReportMarkItem.MarkConfigId;
					num2 = ((levelPlayReportMarkItem.IsPunishReportFinish() > false) ? 1 : 0);
					flag = levelPlayReportMarkItem.CanGetReward();
				}
				PunishReportMarkItem punishReportMarkItem = parameters[0] as PunishReportMarkItem;
				if (punishReportMarkItem != null)
				{
					this.SelectedMarkItem = new OneOf<LevelPlayReportMarkItem, PunishReportMarkItem>?(punishReportMarkItem);
					this.LayoutContext.MarkItem = punishReportMarkItem;
					num = punishReportMarkItem.MarkConfigId;
					num2 = ((punishReportMarkItem.IsPunishReportFinish() > false) ? 1 : 0);
					flag = punishReportMarkItem.CanGetReward();
				}
				WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonEnableClickByTeleportState(this.LayoutContext);
				WorldMapSecondaryUiLayoutHelper.UpdateConfirmButtonTextWithFastMoveStyle(this.LayoutContext);
				WorldMapSecondaryUiLayoutHelper.UpdateTrackButtonTextWithTrackStyle(this.LayoutContext);
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
				string markDesc = config.Value.MarkDesc;
				string[] array = ((markDesc != null) ? markDesc.Split('|', StringSplitOptions.None) : null) ?? Array.Empty<string>();
				string textStringId = (num2 < array.Length) ? array[num2] : "";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), textStringId, Array.Empty<object>());
				WorldMapSecondaryUiLayoutHelper.UpdateIconAndTitle(this.LayoutContext);
				WorldMapSecondaryUiLayoutHelper.UpdateAreaTxtByConfigMarkItem(this.LayoutContext);
				base.UpdateMultiMap();
				base.UpdateTopRightIconActive();
				base.UpdateHidePlayMapTipPanel();
				bool flag2 = base.UpdateQuickGoto();
				WorldMapSecondaryUiContext layoutContext = this.LayoutContext;
				if (layoutContext != null)
				{
					layoutContext.SetConfirmBtnActive(!flag2);
				}
				UUIVerticalLayout verticalLayout = base.GetVerticalLayout(16);
				if (verticalLayout != null)
				{
					verticalLayout.RootUIComp.Get().SetUIActive(true);
				}
				base.GetItem(25).SetUIActive(flag);
				if (flag)
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(30), "DarkShoreBossRewardNotGet", Array.Empty<object>());
				}
				this.RefreshLayout();
			}
		}

		// Token: 0x06030407 RID: 197639 RVA: 0x00B30DFF File Offset: 0x00B2EFFF
		protected override void OnConfirmBtnClick(int index)
		{
			this.HandleTeleport();
		}

		// Token: 0x06030408 RID: 197640 RVA: 0x00B30E08 File Offset: 0x00B2F008
		private void RefreshLayout()
		{
			if (this.SelectedMarkItem == null || this.TargetListPanel == null)
			{
				return;
			}
			PunishReportTarget punishReportTarget = null;
			if (this.SelectedMarkItem.Value.IsT1)
			{
				punishReportTarget = this.SelectedMarkItem.Value.AsT1.GetPunishReportTarget();
			}
			if (this.SelectedMarkItem.Value.IsT2)
			{
				punishReportTarget = this.SelectedMarkItem.Value.AsT2.GetPunishReportTarget();
			}
			if (((punishReportTarget != null) ? punishReportTarget.States : null) == null)
			{
				return;
			}
			for (int i = 0; i < punishReportTarget.States.Count; i++)
			{
				EPunishReportTargetState epunishReportTargetState = punishReportTarget.States[i];
				string descLocalNewTxt = (i < punishReportTarget.ConditionTxtIds.Count) ? punishReportTarget.ConditionTxtIds[i] : "";
				PunishReportTargetListPanel targetListPanel = this.TargetListPanel;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Target_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				PunishReportTargetListItemPanel punishReportTargetListItemPanel = targetListPanel.AddItemByKey(defaultInterpolatedStringHandler.ToStringAndClear());
				punishReportTargetListItemPanel.SetDescLocalNewTxt(descLocalNewTxt);
				punishReportTargetListItemPanel.SetNumTxt("x1");
				EPunishReportTargetListItemPanelState state = (epunishReportTargetState == EPunishReportTargetState.Achieve) ? EPunishReportTargetListItemPanelState.Selected : EPunishReportTargetListItemPanelState.Lock;
				punishReportTargetListItemPanel.SetState(state);
			}
		}

		// Token: 0x06030409 RID: 197641 RVA: 0x00B30F37 File Offset: 0x00B2F137
		protected override void OnBeforeDestroy()
		{
			this.TargetListPanel.Clear();
			base.OnBeforeDestroy();
		}

		// Token: 0x04019F92 RID: 106386
		[Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private OneOf<LevelPlayReportMarkItem, PunishReportMarkItem>? SelectedMarkItem;

		// Token: 0x04019F93 RID: 106387
		[Nullable(2)]
		private PunishReportTargetListPanel TargetListPanel;

		// Token: 0x0200AABE RID: 43710
		[NullableContext(0)]
		public static class EComponents
		{
			// Token: 0x04033EF5 RID: 212725
			public const int PunishReportPanel = 0;
		}
	}
}
