using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Battle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D0F RID: 19727
	[NullableContext(2)]
	[Nullable(0)]
	public class FormationUnitNodeHandle
	{
		// Token: 0x06031731 RID: 202545 RVA: 0x00DD3950 File Offset: 0x00DD1B50
		[NullableContext(1)]
		public UniTask InitializeAsync(UUIItem parentItem)
		{
			FormationUnitNodeHandle.<InitializeAsync>d__2 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.parentItem = parentItem;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<FormationUnitNodeHandle.<InitializeAsync>d__2>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031732 RID: 202546 RVA: 0x00DD399B File Offset: 0x00DD1B9B
		public void Init(FormationPanel formationPanel, FormationPanel gamepadFormationPanel)
		{
			this.RefreshFormationUnitNodeParent(formationPanel, gamepadFormationPanel);
			this.InitializeLinkEnergyButton();
			this.InitializeWeeklyRogueButton();
			this.InitializeBattleTimeDilationButton();
		}

		// Token: 0x06031733 RID: 202547 RVA: 0x00DD39B7 File Offset: 0x00DD1BB7
		public void Destroy()
		{
			if (this.CurFormationExtraButton == null)
			{
				return;
			}
			this.CurFormationExtraButton.Destroy(null);
			this.CurFormationExtraButton = null;
			this.LinkEnergyButton = null;
			this.WeeklyRogueButton = null;
		}

		// Token: 0x06031734 RID: 202548 RVA: 0x00DD39E3 File Offset: 0x00DD1BE3
		public void Tick(float delta)
		{
			FormationExtraButton curFormationExtraButton = this.CurFormationExtraButton;
			if (curFormationExtraButton == null)
			{
				return;
			}
			curFormationExtraButton.Tick(delta);
		}

		// Token: 0x06031735 RID: 202549 RVA: 0x00DD39F6 File Offset: 0x00DD1BF6
		public void OnInputControllerChange(FormationPanel formationPanel, FormationPanel gamepadFormationPanel)
		{
			this.RefreshFormationUnitNodeParent(formationPanel, gamepadFormationPanel);
		}

		// Token: 0x06031736 RID: 202550 RVA: 0x00DD3A00 File Offset: 0x00DD1C00
		[NullableContext(1)]
		private UniTask NewFormationUnitNode(UUIItem parentItem)
		{
			FormationUnitNodeHandle.<NewFormationUnitNode>d__7 <NewFormationUnitNode>d__;
			<NewFormationUnitNode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewFormationUnitNode>d__.<>4__this = this;
			<NewFormationUnitNode>d__.parentItem = parentItem;
			<NewFormationUnitNode>d__.<>1__state = -1;
			<NewFormationUnitNode>d__.<>t__builder.Start<FormationUnitNodeHandle.<NewFormationUnitNode>d__7>(ref <NewFormationUnitNode>d__);
			return <NewFormationUnitNode>d__.<>t__builder.Task;
		}

		// Token: 0x06031737 RID: 202551 RVA: 0x00DD3A4B File Offset: 0x00DD1C4B
		public UUIItem GetRootItem()
		{
			return this.FormationUnitNode;
		}

		// Token: 0x06031738 RID: 202552 RVA: 0x00DD3A53 File Offset: 0x00DD1C53
		public void SetNodeVisible(bool visible)
		{
			UUIItem formationUnitNode = this.FormationUnitNode;
			if (formationUnitNode == null)
			{
				return;
			}
			formationUnitNode.SetUIActive(visible);
		}

		// Token: 0x06031739 RID: 202553 RVA: 0x00DD3A66 File Offset: 0x00DD1C66
		private void RefreshFormationUnitNodeParent(FormationPanel formationPanel, FormationPanel gamepadFormationPanel)
		{
			if (this.FormationUnitNode == null)
			{
				return;
			}
			if (Info.Instance.IsInGamepad())
			{
				if (gamepadFormationPanel != null)
				{
					gamepadFormationPanel.AddChildToRoleHeadPanel(this.FormationUnitNode);
					return;
				}
			}
			else if (formationPanel != null)
			{
				formationPanel.AddChildToRoleHeadPanel(this.FormationUnitNode);
			}
		}

		// Token: 0x0603173A RID: 202554 RVA: 0x00DD3A9C File Offset: 0x00DD1C9C
		public BattleLinkEnergyButton GetLinkEnergyButton()
		{
			return this.LinkEnergyButton;
		}

		// Token: 0x0603173B RID: 202555 RVA: 0x00DD3AA4 File Offset: 0x00DD1CA4
		private void InitializeLinkEnergyButton()
		{
			if (this.LinkEnergyButton != null)
			{
				return;
			}
			if (!BattleLinkModel.Instance.CheckInNewBattleLink() && !BattleLinkModel.Instance.CheckInSpecialBattleLink())
			{
				return;
			}
			BattleLinkEnergyButton battleLinkEnergyButton = new BattleLinkEnergyButton();
			string resourceId = battleLinkEnergyButton.GetResourceId();
			if (string.IsNullOrEmpty(resourceId))
			{
				return;
			}
			this.LinkEnergyButton = battleLinkEnergyButton;
			this.LinkEnergyButton.InitHandle(this);
			this.LinkEnergyButton.CreateByResourceIdAsync(resourceId, this.FormationUnitNode, false).Forget();
			this.CurFormationExtraButton = this.LinkEnergyButton;
		}

		// Token: 0x0603173C RID: 202556 RVA: 0x00DD3B20 File Offset: 0x00DD1D20
		public void ShowLinkButton(bool isShow)
		{
			if (isShow)
			{
				if (this.LinkEnergyButton == null)
				{
					BattleLinkEnergyButton battleLinkEnergyButton = new BattleLinkEnergyButton();
					string resourceId = battleLinkEnergyButton.GetResourceId();
					if (string.IsNullOrEmpty(resourceId))
					{
						return;
					}
					this.LinkEnergyButton = battleLinkEnergyButton;
					this.LinkEnergyButton.InitHandle(this);
					this.LinkEnergyButton.CreateByResourceIdAsync(resourceId, this.FormationUnitNode, false).ContinueWith(delegate()
					{
						BattleLinkEnergyButton linkEnergyButton3 = this.LinkEnergyButton;
						if (linkEnergyButton3 == null)
						{
							return;
						}
						linkEnergyButton3.SetVisible(true);
					}).Forget();
					this.CurFormationExtraButton = this.LinkEnergyButton;
					return;
				}
				else
				{
					BattleLinkEnergyButton linkEnergyButton = this.LinkEnergyButton;
					if (linkEnergyButton == null)
					{
						return;
					}
					linkEnergyButton.SetVisible(true);
					return;
				}
			}
			else
			{
				BattleLinkEnergyButton linkEnergyButton2 = this.LinkEnergyButton;
				if (linkEnergyButton2 == null)
				{
					return;
				}
				linkEnergyButton2.SetVisible(false);
				return;
			}
		}

		// Token: 0x0603173D RID: 202557 RVA: 0x00DD3BBA File Offset: 0x00DD1DBA
		public BattleWeeklyRogueButton GetWeeklyRogueButton()
		{
			return this.WeeklyRogueButton;
		}

		// Token: 0x0603173E RID: 202558 RVA: 0x00DD3BC4 File Offset: 0x00DD1DC4
		private void InitializeWeeklyRogueButton()
		{
			if (this.WeeklyRogueButton != null)
			{
				return;
			}
			if (!WeeklyRogueModel.Instance.CheckIsInWeeklyRogue())
			{
				return;
			}
			this.WeeklyRogueButton = new BattleWeeklyRogueButton();
			this.WeeklyRogueButton.InitHandle(this);
			this.WeeklyRogueButton.CreateByResourceIdAsync("UiItem_WeeklyRogueButton", this.FormationUnitNode, false).Forget();
			this.CurFormationExtraButton = this.WeeklyRogueButton;
			this.WeeklyRogueButton.SetVisible(true);
		}

		// Token: 0x0603173F RID: 202559 RVA: 0x00DD3C32 File Offset: 0x00DD1E32
		public BattleTimeDilationButton GetBattleTimeDilationButton()
		{
			return this.BattleTimeDilationButton;
		}

		// Token: 0x06031740 RID: 202560 RVA: 0x00DD3C3C File Offset: 0x00DD1E3C
		private void InitializeBattleTimeDilationButton()
		{
			if (this.BattleTimeDilationButton != null)
			{
				return;
			}
			if (!BattleUiModel.Instance.IsTimeDilationSkillButtonEnable())
			{
				return;
			}
			this.BattleTimeDilationButton = new BattleTimeDilationButton();
			this.BattleTimeDilationButton.InitHandle(this);
			this.BattleTimeDilationButton.CreateByResourceIdAsync("UiItem_BattlePhotoHourglass", this.FormationUnitNode, false).Forget();
			this.CurFormationExtraButton = this.BattleTimeDilationButton;
			this.BattleTimeDilationButton.SetVisible(true);
		}

		// Token: 0x06031741 RID: 202561 RVA: 0x00DD3CAC File Offset: 0x00DD1EAC
		public void UpdateTimeDilationButton()
		{
			if (BattleUiModel.Instance.IsTimeDilationSkillButtonEnable())
			{
				if (this.BattleTimeDilationButton == null)
				{
					this.BattleTimeDilationButton = new BattleTimeDilationButton();
					this.BattleTimeDilationButton.InitHandle(this);
					this.BattleTimeDilationButton.CreateByResourceIdAsync("UiItem_BattlePhotoHourglass", this.FormationUnitNode, false).ContinueWith(delegate()
					{
						BattleTimeDilationButton battleTimeDilationButton3 = this.BattleTimeDilationButton;
						if (battleTimeDilationButton3 == null)
						{
							return;
						}
						battleTimeDilationButton3.SetVisible(BattleUiModel.Instance.IsTimeDilationSkillButtonEnable());
					}).Forget();
					this.CurFormationExtraButton = this.BattleTimeDilationButton;
					return;
				}
				BattleTimeDilationButton battleTimeDilationButton = this.BattleTimeDilationButton;
				if (battleTimeDilationButton == null)
				{
					return;
				}
				battleTimeDilationButton.SetVisible(true);
				return;
			}
			else
			{
				BattleTimeDilationButton battleTimeDilationButton2 = this.BattleTimeDilationButton;
				if (battleTimeDilationButton2 == null)
				{
					return;
				}
				battleTimeDilationButton2.SetVisible(false);
				return;
			}
		}

		// Token: 0x0401A30E RID: 107278
		private UUIItem FormationUnitNode;

		// Token: 0x0401A30F RID: 107279
		private FormationExtraButton CurFormationExtraButton;

		// Token: 0x0401A310 RID: 107280
		private BattleLinkEnergyButton LinkEnergyButton;

		// Token: 0x0401A311 RID: 107281
		private BattleWeeklyRogueButton WeeklyRogueButton;

		// Token: 0x0401A312 RID: 107282
		private BattleTimeDilationButton BattleTimeDilationButton;
	}
}
