using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x020052F3 RID: 21235
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballBattlePauseView : UiViewBase
	{
		// Token: 0x06034D6B RID: 216427 RVA: 0x00EC5362 File Offset: 0x00EC3562
		[NullableContext(1)]
		public PinballBattlePauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x170066AF RID: 26287
		// (get) Token: 0x06034D6C RID: 216428 RVA: 0x00EC536B File Offset: 0x00EC356B
		public new IPinballBattlePauseViewParam OpenParam
		{
			get
			{
				return this.OpenParam as IPinballBattlePauseViewParam;
			}
		}

		// Token: 0x06034D6D RID: 216429 RVA: 0x00EC5378 File Offset: 0x00EC3578
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickToggleRoleInfo));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickToggleLevelInfo));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034D6E RID: 216430 RVA: 0x00EC554C File Offset: 0x00EC374C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballBattlePauseView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattlePauseView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034D6F RID: 216431 RVA: 0x00EC5590 File Offset: 0x00EC3790
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, true, false, false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(2);
			if (extendToggle2 != null)
			{
				extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIExtendToggle extendToggle3 = base.GetExtendToggle(6);
			if (extendToggle3 != null)
			{
				extendToggle3.SetToggleState(EToggleState.ETT_UnChecked, true, false, false);
			}
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.OpenParam.LevelId);
			bool flag = pinballLevelConfigById != null && pinballLevelConfigById.Value.TrailRoleLength > 0;
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(!flag);
		}

		// Token: 0x06034D70 RID: 216432 RVA: 0x00EC5630 File Offset: 0x00EC3830
		private void OnClickToggleRoleInfo(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			PinballBattleLevelInfoView levelInfoView = this.LevelInfoView;
			if (levelInfoView != null)
			{
				levelInfoView.Hide(null);
			}
			PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
			List<int> list = new List<int>();
			if (((pinballBattleSubModel != null) ? pinballBattleSubModel.FormationData : null) != null)
			{
				foreach (PinballFormationRolePb pinballFormationRolePb in pinballBattleSubModel.FormationData)
				{
					list.Add(pinballFormationRolePb.RoleId);
				}
			}
			this.RoleInfoView.OpenParam = new PinballBattleRoleInfoViewParam
			{
				RoleList = list
			};
			PinballBattleRoleInfoView roleInfoView = this.RoleInfoView;
			if (roleInfoView != null)
			{
				roleInfoView.Show(null);
			}
			base.PlayOrReplaySequence("Switch", false, null);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetTitleLocalText("Pinaball_inside_CharacterInformation");
		}

		// Token: 0x06034D71 RID: 216433 RVA: 0x00EC572C File Offset: 0x00EC392C
		private void OnClickToggleLevelInfo(EToggleState state)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(1);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			PinballBattleRoleInfoView roleInfoView = this.RoleInfoView;
			if (roleInfoView != null)
			{
				roleInfoView.Hide(null);
			}
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.OpenParam.LevelId);
			if (pinballLevelConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Pinball;
				ELogAuthor author = ELogAuthor.CB;
				string message = "找不到关卡配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("LevelId", this.OpenParam.LevelId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
			this.LevelInfoView.OpenParam = new PinballBattleLevelInfoViewParam
			{
				LevelId = this.OpenParam.LevelId,
				LevelType = (EPinballLevelShowType)pinballLevelConfigById.Value.Type,
				Score = (int)pinballBattleSubModel.Score,
				StarInfo = pinballBattleSubModel.StarInfo
			};
			PinballBattleLevelInfoView levelInfoView = this.LevelInfoView;
			if (levelInfoView != null)
			{
				levelInfoView.Show(null);
			}
			base.PlayOrReplaySequence("Switch", false, null);
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetTitleLocalText("Pinaball_inside_LevelInformation");
		}

		// Token: 0x06034D72 RID: 216434 RVA: 0x00EC5858 File Offset: 0x00EC3A58
		private void OnClickExitButton()
		{
			PinballLevelConfig? pinballLevelConfig;
			EConfirmBoxConfigId configId;
			if (((PinballConfig.Instance.GetPinballLevelConfigById(this.OpenParam.LevelId) != null) ? new int?(pinballLevelConfig.GetValueOrDefault().Type) : null).GetValueOrDefault() == 2)
			{
				configId = EConfirmBoxConfigId.PinballBattleRestartCowConfirm;
			}
			else
			{
				configId = EConfirmBoxConfigId.PinballBattleRestartConfirm;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(configId);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.LeaveBattle);
			PinballController.Instance.OpenPinballSmallConfirmBoxView(confirmBoxDataNew);
		}

		// Token: 0x06034D73 RID: 216435 RVA: 0x00EC58E8 File Offset: 0x00EC3AE8
		private void LeaveBattle()
		{
			(KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController).RequestQuit();
			base.CloseMe(null);
		}

		// Token: 0x06034D74 RID: 216436 RVA: 0x00EC5905 File Offset: 0x00EC3B05
		private void OnClickContinueButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x06034D75 RID: 216437 RVA: 0x00EC5910 File Offset: 0x00EC3B10
		private void OnClickRestartButton()
		{
			PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
			UUIExtendToggle extendToggle = base.GetExtendToggle(6);
			if (extendToggle != null && extendToggle.GetToggleState() == EToggleState.ETT_Checked)
			{
				PinballFormationViewData param = new PinballFormationViewData
				{
					LevelId = this.OpenParam.LevelId,
					IsRestart = new bool?(true),
					IfReturnToPinballMainView = new bool?(true)
				};
				UiManager.Instance.OpenView(EUiViewName.PinballFormationView, param, null);
				pinballBattleSubController.ClearGame(true);
			}
			else
			{
				pinballBattleSubController.Restart(null).Forget();
			}
			base.CloseMe(null);
		}

		// Token: 0x0401BF2F RID: 114479
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BF30 RID: 114480
		private PinballBattleRoleInfoView RoleInfoView;

		// Token: 0x0401BF31 RID: 114481
		private PinballBattleLevelInfoView LevelInfoView;

		// Token: 0x0401BF32 RID: 114482
		private ButtonItem ExitButton;

		// Token: 0x0401BF33 RID: 114483
		private ButtonItem ContinueButton;

		// Token: 0x0401BF34 RID: 114484
		private ButtonItem RestartButton;

		// Token: 0x0200AF75 RID: 44917
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036382 RID: 222082
			Caption,
			// Token: 0x04036383 RID: 222083
			ToggleRoleInfo,
			// Token: 0x04036384 RID: 222084
			ToggleLevelInfo,
			// Token: 0x04036385 RID: 222085
			BtnExit,
			// Token: 0x04036386 RID: 222086
			BtnContinue,
			// Token: 0x04036387 RID: 222087
			BtnRestart,
			// Token: 0x04036388 RID: 222088
			ToggleFormation,
			// Token: 0x04036389 RID: 222089
			PnlRoleInfo,
			// Token: 0x0403638A RID: 222090
			PnlLevelInfo,
			// Token: 0x0403638B RID: 222091
			FormationItem
		}
	}
}
