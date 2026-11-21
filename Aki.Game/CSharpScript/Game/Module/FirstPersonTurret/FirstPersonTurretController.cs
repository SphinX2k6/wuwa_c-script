using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.FirstPersonTurret.View;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.FirstPersonTurret
{
	// Token: 0x02004A58 RID: 19032
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class FirstPersonTurretController : ControllerBase
	{
		// Token: 0x0602FA22 RID: 195106 RVA: 0x00D49D71 File Offset: 0x00D47F71
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0602FA23 RID: 195107 RVA: 0x00D49D74 File Offset: 0x00D47F74
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0602FA24 RID: 195108 RVA: 0x00D49D78 File Offset: 0x00D47F78
		public void Start(GeneralLogicTreeContext context)
		{
			this.IsInGameplay = true;
			GeneralLogicTreeContext context2 = this.Context;
			if (context2 != null)
			{
				context2.Release();
			}
			this.Context = GeneralLogicTreeContext.Create(context.BtType, context.TreeIncId, context.TreeConfigId, context.NodeId, null);
			this.BindInputActions();
			this.OpenUi();
		}

		// Token: 0x0602FA25 RID: 195109 RVA: 0x00D49DD5 File Offset: 0x00D47FD5
		public void End()
		{
			this.IsInGameplay = false;
			this.UnBindInputActions();
			GeneralLogicTreeContext context = this.Context;
			if (context != null)
			{
				context.Release();
			}
			this.Context = null;
			this.CloseUi();
		}

		// Token: 0x0602FA26 RID: 195110 RVA: 0x00D49E02 File Offset: 0x00D48002
		protected override bool OnClear()
		{
			this.End();
			return true;
		}

		// Token: 0x0602FA27 RID: 195111 RVA: 0x00D49E0C File Offset: 0x00D4800C
		private void OpenUi()
		{
			BattleUiModel instance = BattleUiModel.Instance;
			if (instance != null)
			{
				BattleUiChildViewData childViewData = instance.ChildViewData;
				if (childViewData != null)
				{
					childViewData.HideBattleView(EBattleUiVisibleReason.Custom, new <>z__ReadOnlyArray<EBattleUiChild>(new EBattleUiChild[]
					{
						EBattleUiChild.Mission,
						EBattleUiChild.Formation,
						EBattleUiChild.GamepadFormation,
						EBattleUiChild.BattleHud,
						EBattleUiChild.ScreenEffect,
						EBattleUiChild.DamageView
					}), 0);
				}
			}
			if (!UiManager.Instance.IsViewOpen(EUiViewName.FirstPersonTurretView))
			{
				UiManager.Instance.OpenView(EUiViewName.FirstPersonTurretView, null, new TOpenViewCallBack(this.OnOpenFightUiFinished));
				return;
			}
			this.RefreshUi();
		}

		// Token: 0x0602FA28 RID: 195112 RVA: 0x00D49E80 File Offset: 0x00D48080
		private void OnOpenFightUiFinished(bool success, int viewId)
		{
			if (!success || !this.IsInGameplay)
			{
				this.CloseUi();
				return;
			}
			this.RefreshUi();
		}

		// Token: 0x0602FA29 RID: 195113 RVA: 0x00D49E9A File Offset: 0x00D4809A
		private void CloseUi()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.FirstPersonTurretView))
			{
				UiManager.Instance.CloseView(EUiViewName.FirstPersonTurretView, null);
			}
			BattleUiModel instance = BattleUiModel.Instance;
			if (instance == null)
			{
				return;
			}
			BattleUiChildViewData childViewData = instance.ChildViewData;
			if (childViewData == null)
			{
				return;
			}
			childViewData.ShowBattleView(EBattleUiVisibleReason.Custom, 0);
		}

		// Token: 0x0602FA2A RID: 195114 RVA: 0x00D49ED8 File Offset: 0x00D480D8
		private void RefreshUi()
		{
			FirstPersonTurretView view = this.GetView();
			if (view == null)
			{
				return;
			}
			view.OnExitClicked = new Action(this.OnExitClicked);
		}

		// Token: 0x0602FA2B RID: 195115 RVA: 0x00D49F02 File Offset: 0x00D48102
		[NullableContext(2)]
		private FirstPersonTurretView GetView()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.FirstPersonTurretView) as FirstPersonTurretView;
		}

		// Token: 0x0602FA2C RID: 195116 RVA: 0x00D49F18 File Offset: 0x00D48118
		private void BindInputActions()
		{
			InputDistributeController.Instance.BindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0602FA2D RID: 195117 RVA: 0x00D49F35 File Offset: 0x00D48135
		private void UnBindInputActions()
		{
			InputDistributeController.Instance.UnBindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0602FA2E RID: 195118 RVA: 0x00D49F52 File Offset: 0x00D48152
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (this.IsInGameplay && actionType == InputDistributeDefine.EActionType.Press && actionName == "玩法放弃")
			{
				this.OnExitClicked();
			}
		}

		// Token: 0x0602FA2F RID: 195119 RVA: 0x00D49F72 File Offset: 0x00D48172
		private void OnExitClicked()
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
		}

		// Token: 0x17005FCB RID: 24523
		// (get) Token: 0x0602FA30 RID: 195120 RVA: 0x00D49F81 File Offset: 0x00D48181
		public static FirstPersonTurretController Instance
		{
			get
			{
				return FirstPersonTurretController._Instance;
			}
		}

		// Token: 0x0602FA31 RID: 195121 RVA: 0x00D49F88 File Offset: 0x00D48188
		public static FirstPersonTurretController GetOrCreateInstance()
		{
			if (FirstPersonTurretController._Instance == null)
			{
				FirstPersonTurretController.CreateInstance();
			}
			return FirstPersonTurretController._Instance;
		}

		// Token: 0x0602FA32 RID: 195122 RVA: 0x00D49F9C File Offset: 0x00D4819C
		public static bool CreateInstance()
		{
			if (FirstPersonTurretController._Instance != null)
			{
				return true;
			}
			FirstPersonTurretController._Instance = new FirstPersonTurretController();
			return true;
		}

		// Token: 0x0602FA33 RID: 195123 RVA: 0x00D49FB2 File Offset: 0x00D481B2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FA34 RID: 195124 RVA: 0x00D49FB4 File Offset: 0x00D481B4
		public static void ResetStaticDefaultValue()
		{
			FirstPersonTurretController._Instance = null;
		}

		// Token: 0x0602FA35 RID: 195125 RVA: 0x00D49FBC File Offset: 0x00D481BC
		static FirstPersonTurretController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FirstPersonTurretController.CreateStaticDefaultValue), new Action(FirstPersonTurretController.ResetStaticDefaultValue));
		}

		// Token: 0x04019499 RID: 103577
		private bool IsInGameplay;

		// Token: 0x0401949A RID: 103578
		[Nullable(2)]
		private GeneralLogicTreeContext Context;

		// Token: 0x0401949B RID: 103579
		[Nullable(2)]
		private static FirstPersonTurretController _Instance;
	}
}
