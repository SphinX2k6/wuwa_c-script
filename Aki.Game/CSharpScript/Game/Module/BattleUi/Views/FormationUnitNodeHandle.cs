using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Battle;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D2D RID: 23853
	[NullableContext(2)]
	[Nullable(0)]
	public class FormationUnitNodeHandle
	{
		// Token: 0x0603C7D8 RID: 247768 RVA: 0x00E831B0 File Offset: 0x00E813B0
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

		// Token: 0x0603C7D9 RID: 247769 RVA: 0x00E831FB File Offset: 0x00E813FB
		public void Init(FormationPanel formationPanel, FormationPanel gamepadFormationPanel)
		{
			this.RefreshFormationUnitNodeParent(formationPanel, gamepadFormationPanel);
			this.InitializeLinkEnergyButton();
			this.InitializeWeeklyRogueButton();
			this.InitializeBattleTimeDilationButton();
		}

		// Token: 0x0603C7DA RID: 247770 RVA: 0x00E83217 File Offset: 0x00E81417
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

		// Token: 0x0603C7DB RID: 247771 RVA: 0x00E83243 File Offset: 0x00E81443
		public void Tick(float delta)
		{
			FormationExtraButton curFormationExtraButton = this.CurFormationExtraButton;
			if (curFormationExtraButton == null)
			{
				return;
			}
			curFormationExtraButton.Tick(delta);
		}

		// Token: 0x0603C7DC RID: 247772 RVA: 0x00E83256 File Offset: 0x00E81456
		public void OnInputControllerChange(FormationPanel formationPanel, FormationPanel gamepadFormationPanel)
		{
			this.RefreshFormationUnitNodeParent(formationPanel, gamepadFormationPanel);
		}

		// Token: 0x0603C7DD RID: 247773 RVA: 0x00E83260 File Offset: 0x00E81460
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

		// Token: 0x0603C7DE RID: 247774 RVA: 0x00E832AB File Offset: 0x00E814AB
		public UUIItem GetRootItem()
		{
			return this.FormationUnitNode;
		}

		// Token: 0x0603C7DF RID: 247775 RVA: 0x00E832B3 File Offset: 0x00E814B3
		public void SetNodeVisible(bool visible)
		{
			UUIItem formationUnitNode = this.FormationUnitNode;
			if (formationUnitNode == null)
			{
				return;
			}
			formationUnitNode.SetUIActive(visible);
		}

		// Token: 0x0603C7E0 RID: 247776 RVA: 0x00E832C6 File Offset: 0x00E814C6
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

		// Token: 0x0603C7E1 RID: 247777 RVA: 0x00E832FC File Offset: 0x00E814FC
		public BattleLinkEnergyButton GetLinkEnergyButton()
		{
			return this.LinkEnergyButton;
		}

		// Token: 0x0603C7E2 RID: 247778 RVA: 0x00E83304 File Offset: 0x00E81504
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

		// Token: 0x0603C7E3 RID: 247779 RVA: 0x00E83380 File Offset: 0x00E81580
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

		// Token: 0x0603C7E4 RID: 247780 RVA: 0x00E8341A File Offset: 0x00E8161A
		public BattleWeeklyRogueButton GetWeeklyRogueButton()
		{
			return this.WeeklyRogueButton;
		}

		// Token: 0x0603C7E5 RID: 247781 RVA: 0x00E83424 File Offset: 0x00E81624
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

		// Token: 0x0603C7E6 RID: 247782 RVA: 0x00E83492 File Offset: 0x00E81692
		public BattleTimeDilationButton GetBattleTimeDilationButton()
		{
			return this.BattleTimeDilationButton;
		}

		// Token: 0x0603C7E7 RID: 247783 RVA: 0x00E8349C File Offset: 0x00E8169C
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

		// Token: 0x0603C7E8 RID: 247784 RVA: 0x00E8350C File Offset: 0x00E8170C
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

		// Token: 0x0401F855 RID: 129109
		private UUIItem FormationUnitNode;

		// Token: 0x0401F856 RID: 129110
		private FormationExtraButton CurFormationExtraButton;

		// Token: 0x0401F857 RID: 129111
		private BattleLinkEnergyButton LinkEnergyButton;

		// Token: 0x0401F858 RID: 129112
		private BattleWeeklyRogueButton WeeklyRogueButton;

		// Token: 0x0401F859 RID: 129113
		private BattleTimeDilationButton BattleTimeDilationButton;
	}
}
