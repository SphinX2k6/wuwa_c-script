using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.FirstPersonTurret.View;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.FirstPersonTurret
{
	// Token: 0x02005A7C RID: 23164
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class FirstPersonTurretController : ControllerBase
	{
		// Token: 0x0603AAD9 RID: 240345 RVA: 0x00DF97DD File Offset: 0x00DF79DD
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x0603AADA RID: 240346 RVA: 0x00DF97E0 File Offset: 0x00DF79E0
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0603AADB RID: 240347 RVA: 0x00DF97E4 File Offset: 0x00DF79E4
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

		// Token: 0x0603AADC RID: 240348 RVA: 0x00DF9841 File Offset: 0x00DF7A41
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

		// Token: 0x0603AADD RID: 240349 RVA: 0x00DF986E File Offset: 0x00DF7A6E
		protected override bool OnClear()
		{
			this.End();
			return true;
		}

		// Token: 0x0603AADE RID: 240350 RVA: 0x00DF9878 File Offset: 0x00DF7A78
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

		// Token: 0x0603AADF RID: 240351 RVA: 0x00DF98EC File Offset: 0x00DF7AEC
		private void OnOpenFightUiFinished(bool success, int viewId)
		{
			if (!success || !this.IsInGameplay)
			{
				this.CloseUi();
				return;
			}
			this.RefreshUi();
		}

		// Token: 0x0603AAE0 RID: 240352 RVA: 0x00DF9906 File Offset: 0x00DF7B06
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

		// Token: 0x0603AAE1 RID: 240353 RVA: 0x00DF9944 File Offset: 0x00DF7B44
		private void RefreshUi()
		{
			FirstPersonTurretView view = this.GetView();
			if (view == null)
			{
				return;
			}
			view.OnExitClicked = new Action(this.OnExitClicked);
		}

		// Token: 0x0603AAE2 RID: 240354 RVA: 0x00DF996E File Offset: 0x00DF7B6E
		[NullableContext(2)]
		private FirstPersonTurretView GetView()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.FirstPersonTurretView) as FirstPersonTurretView;
		}

		// Token: 0x0603AAE3 RID: 240355 RVA: 0x00DF9984 File Offset: 0x00DF7B84
		private void BindInputActions()
		{
			InputDistributeController.Instance.BindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603AAE4 RID: 240356 RVA: 0x00DF99A1 File Offset: 0x00DF7BA1
		private void UnBindInputActions()
		{
			InputDistributeController.Instance.UnBindAction("玩法放弃", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
		}

		// Token: 0x0603AAE5 RID: 240357 RVA: 0x00DF99BE File Offset: 0x00DF7BBE
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (this.IsInGameplay && actionType == InputDistributeDefine.EActionType.Press && actionName == "玩法放弃")
			{
				this.OnExitClicked();
			}
		}

		// Token: 0x0603AAE6 RID: 240358 RVA: 0x00DF99DE File Offset: 0x00DF7BDE
		private void OnExitClicked()
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
		}

		// Token: 0x17008BFD RID: 35837
		// (get) Token: 0x0603AAE7 RID: 240359 RVA: 0x00DF99ED File Offset: 0x00DF7BED
		public static FirstPersonTurretController Instance
		{
			get
			{
				return FirstPersonTurretController._Instance;
			}
		}

		// Token: 0x0603AAE8 RID: 240360 RVA: 0x00DF99F4 File Offset: 0x00DF7BF4
		public static FirstPersonTurretController GetOrCreateInstance()
		{
			if (FirstPersonTurretController._Instance == null)
			{
				FirstPersonTurretController.CreateInstance();
			}
			return FirstPersonTurretController._Instance;
		}

		// Token: 0x0603AAE9 RID: 240361 RVA: 0x00DF9A08 File Offset: 0x00DF7C08
		public static bool CreateInstance()
		{
			if (FirstPersonTurretController._Instance != null)
			{
				return true;
			}
			FirstPersonTurretController._Instance = new FirstPersonTurretController();
			return true;
		}

		// Token: 0x0603AAEA RID: 240362 RVA: 0x00DF9A1E File Offset: 0x00DF7C1E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AAEB RID: 240363 RVA: 0x00DF9A20 File Offset: 0x00DF7C20
		public static void ResetStaticDefaultValue()
		{
			FirstPersonTurretController._Instance = null;
		}

		// Token: 0x0603AAEC RID: 240364 RVA: 0x00DF9A28 File Offset: 0x00DF7C28
		static FirstPersonTurretController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FirstPersonTurretController.CreateStaticDefaultValue), new Action(FirstPersonTurretController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E9F2 RID: 125426
		private bool IsInGameplay;

		// Token: 0x0401E9F3 RID: 125427
		[Nullable(2)]
		private GeneralLogicTreeContext Context;

		// Token: 0x0401E9F4 RID: 125428
		[Nullable(2)]
		private static FirstPersonTurretController _Instance;
	}
}
