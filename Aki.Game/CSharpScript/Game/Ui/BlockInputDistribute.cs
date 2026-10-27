using System;
using CSharpScript.Game.Camera;
using CSharpScript.Game.LevelGamePlay.ResetPlayer;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Module.SeamlessTravel;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.World.Model;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004680 RID: 18048
	public class BlockInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E97A RID: 190842 RVA: 0x00AC94E4 File Offset: 0x00AC76E4
		public override bool OnRefresh()
		{
			if (this.IsInSeamlessTravel())
			{
				SeamlessTravelModel instance = SeamlessTravelModel.Instance;
				if (instance != null && instance.IsSeamlessTravel)
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.YJX, "[InputDistribute]无缝加载过渡场景中，使用无缝加载设置的输入分发tag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTags(SeamlessTravelModel.Instance.SeamlessTravelInputDistributeTags);
					return true;
				}
				Log.Instance.Info(ELogModule.Input, ELogAuthor.YJX, "[InputDistribute]无缝加载过渡场景中，只允许角色轴向输入", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetInputDistributeTag("FightInputRoot.FightInput.AxisInput");
				return true;
			}
			else
			{
				if (this.IsLoading())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]加载中设置输入分发tag为 MouseInputTag NavigationTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTags(new string[]
					{
						"UiInputRoot.MouseInputTag",
						"UiInputRoot.Navigation"
					});
					return true;
				}
				if (this.IsKick())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]断线中，则设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				if (this.IsSdkGetFocus())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]Sdk打开界面，则设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				if (this.IsInBattleSettlement())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.CFT, "[InputDistribute]战斗结算中设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				if (DeadReviveModel.Instance.BlockAllInput)
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.LYY, "[InputDistribute]死亡界面打开中设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				if (ResetPlayerModel.Instance.IsReseting)
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.LYY, "[InputDistribute]重置玩家位置中设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				if (SceneTeamModel.Instance.IsSeamlessUpdateTeamBlockInput)
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.LYY, "[InputDistribute]切换编队无缝表现中, 只允许角色轴向输入", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("FightInputRoot.FightInput.AxisInput");
					return true;
				}
				if (this.IsInVideoView())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.JYS, "[InputDistribute]CG中，则设置输入分发tag为 UiInputRootTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("UiInputRoot");
					return true;
				}
				if (this.IsInBlackScreen())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.JYS, "[InputDistribute]黑幕中，则设置输入分发tag为 MouseInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("UiInputRoot.MouseInputTag");
					return true;
				}
				if (this.IsTransitionPopupBlock())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.JYS, "[InputDistribute] 转场弹窗中，禁用输入", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				if (CameraController.Instance.IsSequenceCameraInCinematic("MainCamera"))
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]玩家角色在播放处决中，大招中等镜头时，只允许角色技能输入，设置输入分发tag为 CharacterSkillInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("FightInputRoot.FightInput.ActionInput.CharacterSkillInput");
					return true;
				}
				MapModel instance2 = MapModel.Instance;
				if (instance2 != null && instance2.IsInUnopenedAreaPullback())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]角色进入未开放区域启动拉回，设置输入分发tag为 MouseInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("UiInputRoot.MouseInputTag");
					return true;
				}
				if (this.IsInWaterfallMove())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.YJX, "[InputDistribute]角色处于载具攀瀑状态，禁止所有输入", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
				BaseTagComponent baseTagComponent;
				if (getCurrentEntity == null)
				{
					baseTagComponent = null;
				}
				else
				{
					WorldEntity entity = getCurrentEntity.Entity;
					baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
				}
				BaseTagComponent baseTagComponent2 = baseTagComponent;
				if (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]))
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]角色落水中，则设置输入分发tag为 MouseInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("UiInputRoot.MouseInputTag");
					return true;
				}
				if (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.驾驶载具.退出中"]))
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.YJX, "[InputDistribute]角色退出载具中，禁止交互和战斗输入", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTags(new string[]
					{
						"FightInputRoot.FightInput.AxisInput",
						"UiInputRoot.Navigation"
					});
					return true;
				}
				MenuModel instance3 = MenuModel.Instance;
				if (instance3 != null && instance3.IsWaitForKeyInput)
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]玩家设置按键中，则设置输入分发tag为 NavigationTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTags(new string[]
					{
						"UiInputRoot.Navigation",
						"UiInputRoot.MouseInputTag"
					});
					return true;
				}
				if (GeneralLogicTreeModel.Instance.DisableInput)
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]行为配置禁用输入 设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				if (this.IsInLinkExplosion())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.WWJ, "[InputDistribute]播放Link分屏中 设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				SubLevelModel instance4 = SubLevelModel.Instance;
				if (instance4 != null && instance4.IsInSubLevelSwitchingAndBlockingInput())
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]切换子关卡且禁止输入 设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					base.SetInputDistributeTag("BlockAllInputTag");
					return true;
				}
				if (DeadEyeModeModel.Instance.IsInDeadEyeMode)
				{
					Log.Instance.Info(ELogModule.Input, ELogAuthor.WWJ, "[InputDistribute]死眼跳台玩法中 设置输入分发tag为 BlockAllInputTag", default(ReadOnlySpan<ValueTuple<string, object>>));
					string[] inputDistributeTags = new string[]
					{
						"FightInputRoot.FightInput.AxisInput.CameraInput.CameraRotation",
						"UiInputRoot"
					};
					base.SetInputDistributeTags(inputDistributeTags);
					return true;
				}
				return false;
			}
		}

		// Token: 0x0602E97B RID: 190843 RVA: 0x00AC9A03 File Offset: 0x00AC7C03
		private bool IsInSeamlessTravel()
		{
			if (!SeamlessTravelModel.Instance.IsSeamlessTravel)
			{
				TeleportContext teleportContext = TeleportModel.Instance.TeleportContext;
				return teleportContext != null && teleportContext.IsInSeamlessTeleport;
			}
			return true;
		}

		// Token: 0x0602E97C RID: 190844 RVA: 0x00AC9A28 File Offset: 0x00AC7C28
		private bool IsLoading()
		{
			return LoadingModel.Instance.IsLoading;
		}

		// Token: 0x0602E97D RID: 190845 RVA: 0x00AC9A34 File Offset: 0x00AC7C34
		private bool IsKick()
		{
			return ReConnectModel.Instance.GetReConnectStatus() == EReConnectStatus.ReConnectDoing;
		}

		// Token: 0x0602E97E RID: 190846 RVA: 0x00AC9A43 File Offset: 0x00AC7C43
		private bool IsSdkGetFocus()
		{
			return KuroSdkModel.Instance.GetSdkFocusState();
		}

		// Token: 0x0602E97F RID: 190847 RVA: 0x00AC9A4F File Offset: 0x00AC7C4F
		private bool IsInVideoView()
		{
			return UiManager.Instance.IsViewOpen(EUiViewName.VideoView);
		}

		// Token: 0x0602E980 RID: 190848 RVA: 0x00AC9A60 File Offset: 0x00AC7C60
		private bool IsInBlackScreen()
		{
			return BlackScreenFadeController.Instance.NeedInputDis;
		}

		// Token: 0x0602E981 RID: 190849 RVA: 0x00AC9A6C File Offset: 0x00AC7C6C
		private bool IsInBattleSettlement()
		{
			return BattleUiModel.Instance.IsInBattleSettlement;
		}

		// Token: 0x0602E982 RID: 190850 RVA: 0x00AC9A78 File Offset: 0x00AC7C78
		private bool IsInWaterfallMove()
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
			CharacterDriveVehicleComponent characterDriveVehicleComponent = (characterActorComponent != null) ? characterActorComponent.Entity.GetComponent<CharacterDriveVehicleComponent>() : null;
			object obj;
			if (characterDriveVehicleComponent == null)
			{
				obj = null;
			}
			else
			{
				Entity vehicleEntity = characterDriveVehicleComponent.VehicleEntity;
				obj = ((vehicleEntity != null) ? vehicleEntity.GetComponent<GongduolaPerformComponent>() : null);
			}
			object obj2 = obj;
			return obj2 != null && obj2.IsWaterfallMove;
		}

		// Token: 0x0602E983 RID: 190851 RVA: 0x00AC9ACA File Offset: 0x00AC7CCA
		private bool IsInLinkExplosion()
		{
			BattleLinkController instance = BattleLinkController.Instance;
			return instance != null && instance.GetIsInLinkExplosion();
		}

		// Token: 0x0602E984 RID: 190852 RVA: 0x00AC9ADC File Offset: 0x00AC7CDC
		private bool IsTransitionPopupBlock()
		{
			TransitionPopupView transitionPopupView = UiManager.Instance.GetViewByName(EUiViewName.TransitionPopupView) as TransitionPopupView;
			return transitionPopupView != null && transitionPopupView.IsLimitOperation;
		}
	}
}
