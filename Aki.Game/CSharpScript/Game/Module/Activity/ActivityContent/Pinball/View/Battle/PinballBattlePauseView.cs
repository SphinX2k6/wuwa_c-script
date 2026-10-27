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
	// Token: 0x02006375 RID: 25461
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballBattlePauseView : UiViewBase
	{
		// Token: 0x060400AA RID: 262314 RVA: 0x00F7E402 File Offset: 0x00F7C602
		[NullableContext(1)]
		public PinballBattlePauseView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x1700934D RID: 37709
		// (get) Token: 0x060400AB RID: 262315 RVA: 0x00F7E40B File Offset: 0x00F7C60B
		public new IPinballBattlePauseViewParam OpenParam
		{
			get
			{
				return this.OpenParam as IPinballBattlePauseViewParam;
			}
		}

		// Token: 0x060400AC RID: 262316 RVA: 0x00F7E418 File Offset: 0x00F7C618
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

		// Token: 0x060400AD RID: 262317 RVA: 0x00F7E5EC File Offset: 0x00F7C7EC
		protected override UniTask OnBeforeStartAsync()
		{
			PinballBattlePauseView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballBattlePauseView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060400AE RID: 262318 RVA: 0x00F7E630 File Offset: 0x00F7C830
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

		// Token: 0x060400AF RID: 262319 RVA: 0x00F7E6D0 File Offset: 0x00F7C8D0
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

		// Token: 0x060400B0 RID: 262320 RVA: 0x00F7E7CC File Offset: 0x00F7C9CC
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

		// Token: 0x060400B1 RID: 262321 RVA: 0x00F7E8F8 File Offset: 0x00F7CAF8
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

		// Token: 0x060400B2 RID: 262322 RVA: 0x00F7E988 File Offset: 0x00F7CB88
		private void LeaveBattle()
		{
			(KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController).RequestQuit();
			base.CloseMe(null);
		}

		// Token: 0x060400B3 RID: 262323 RVA: 0x00F7E9A5 File Offset: 0x00F7CBA5
		private void OnClickContinueButton()
		{
			base.CloseMe(null);
		}

		// Token: 0x060400B4 RID: 262324 RVA: 0x00F7E9B0 File Offset: 0x00F7CBB0
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

		// Token: 0x04021600 RID: 136704
		private PopupCaptionItem CaptionItem;

		// Token: 0x04021601 RID: 136705
		private PinballBattleRoleInfoView RoleInfoView;

		// Token: 0x04021602 RID: 136706
		private PinballBattleLevelInfoView LevelInfoView;

		// Token: 0x04021603 RID: 136707
		private ButtonItem ExitButton;

		// Token: 0x04021604 RID: 136708
		private ButtonItem ContinueButton;

		// Token: 0x04021605 RID: 136709
		private ButtonItem RestartButton;

		// Token: 0x0200C58E RID: 50574
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403BA20 RID: 244256
			Caption,
			// Token: 0x0403BA21 RID: 244257
			ToggleRoleInfo,
			// Token: 0x0403BA22 RID: 244258
			ToggleLevelInfo,
			// Token: 0x0403BA23 RID: 244259
			BtnExit,
			// Token: 0x0403BA24 RID: 244260
			BtnContinue,
			// Token: 0x0403BA25 RID: 244261
			BtnRestart,
			// Token: 0x0403BA26 RID: 244262
			ToggleFormation,
			// Token: 0x0403BA27 RID: 244263
			PnlRoleInfo,
			// Token: 0x0403BA28 RID: 244264
			PnlLevelInfo,
			// Token: 0x0403BA29 RID: 244265
			FormationItem
		}
	}
}
