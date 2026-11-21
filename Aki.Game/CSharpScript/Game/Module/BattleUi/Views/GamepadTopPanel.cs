using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.PhoneMessage.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CA0 RID: 19616
	[NullableContext(2)]
	[Nullable(0)]
	public class GamepadTopPanel : BattleVisibleChildView
	{
		// Token: 0x06030FD9 RID: 200665 RVA: 0x00DABC9C File Offset: 0x00DA9E9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedHomeButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030FDA RID: 200666 RVA: 0x00DABE70 File Offset: 0x00DAA070
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.HomeButton);
			this.AddEvents();
			this.BindRedDot();
			if (RoleTowerModel.Instance.IsInRoleTowerDungeon())
			{
				base.SetVisible(8, false);
			}
			this.UiLevelSequence = new LevelSequencePlayer(this.RootItem);
			this.HomeBtnLevelSequence = new LevelSequencePlayer(base.GetButton(0).RootUIComp);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06030FDB RID: 200667 RVA: 0x00DABEEC File Offset: 0x00DAA0EC
		protected override UniTask InitializeAsync(object param = null)
		{
			GamepadTopPanel.<InitializeAsync>d__8 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<GamepadTopPanel.<InitializeAsync>d__8>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030FDC RID: 200668 RVA: 0x00DABF30 File Offset: 0x00DAA130
		public override void Reset()
		{
			base.Reset();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
			GamepadPhoneMessageButton phoneMsgButton = this.PhoneMsgButton;
			if (phoneMsgButton != null)
			{
				phoneMsgButton.Destroy(null);
			}
			this.PhoneMsgButton = null;
			this.RemoveEvents();
			this.RemoveRedDot();
		}

		// Token: 0x06030FDD RID: 200669 RVA: 0x00DABF80 File Offset: 0x00DAA180
		private void BindRedDot()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				base.GetItem(1).SetUIActive(false);
				return;
			}
			RedDotController.Instance.BindRedDot(ERedDotName.BattleViewMenu, base.GetItem(2), new Action<bool, int>(this.OnLeftRedDotItemRefresh), 0);
			RedDotController.Instance.BindRedDot(ERedDotName.ActivityEntrance, base.GetItem(3), new Action<bool, int>(this.OnLeftRedDotItemRefresh), 0);
			if (FunctionModel.Instance.IsOpen(10023))
			{
				RedDotController.Instance.BindRedDot(ERedDotName.AdventureBattleButton, base.GetItem(4), new Action<bool, int>(this.OnLeftRedDotItemRefresh), 0);
			}
			RedDotController.Instance.BindRedDot(ERedDotName.BattleViewGachaButton, base.GetItem(5), new Action<bool, int>(this.OnLeftRedDotItemRefresh), 0);
			RedDotController.Instance.BindRedDot(ERedDotName.BattlePass, base.GetItem(6), new Action<bool, int>(this.OnLeftRedDotItemRefresh), 0);
			RedDotController.Instance.BindRedDot(ERedDotName.ActivityDirectTrainProEntry, base.GetItem(8), new Action<bool, int>(this.OnLeftRedDotItemRefresh), 0);
			if (FunctionModel.Instance.IsOpen(10130))
			{
				RedDotController.Instance.BindRedDot(ERedDotName.FunctionPhoneMsg, base.GetItem(9), new Action<bool, int>(this.OnLeftRedDotItemRefresh), 0);
			}
		}

		// Token: 0x06030FDE RID: 200670 RVA: 0x00DAC0AC File Offset: 0x00DAA2AC
		private void RemoveRedDot()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				return;
			}
			RedDotController.Instance.UnBindRedDot(ERedDotName.BattleViewMenu);
			RedDotController.Instance.UnBindRedDot(ERedDotName.ActivityEntrance);
			if (FunctionModel.Instance.IsOpen(10023))
			{
				RedDotController.Instance.UnBindRedDot(ERedDotName.AdventureBattleButton);
			}
			RedDotController.Instance.UnBindRedDot(ERedDotName.BattleViewGachaButton);
			RedDotController.Instance.UnBindRedDot(ERedDotName.BattlePass);
			RedDotController.Instance.UnBindRedDot(ERedDotName.ActivityDirectTrainProEntry);
		}

		// Token: 0x06030FDF RID: 200671 RVA: 0x00DAC120 File Offset: 0x00DAA320
		private void AddEvents()
		{
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Add(EEventName.OnPhoneTipsClose, new Action(this.OnPhoneTipsClose));
		}

		// Token: 0x06030FE0 RID: 200672 RVA: 0x00DAC184 File Offset: 0x00DAA384
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Remove(EEventName.OnPhoneTipsClose, new Action(this.OnPhoneTipsClose));
		}

		// Token: 0x06030FE1 RID: 200673 RVA: 0x00DAC1E8 File Offset: 0x00DAA3E8
		protected override void OnShowBattleChildView()
		{
			this.RefreshTipsBg();
			this.RefreshTipsHomeButtonSprite();
			this.OnShowButtons();
			LevelSequencePlayer uiLevelSequence = this.UiLevelSequence;
			if (uiLevelSequence == null)
			{
				return;
			}
			uiLevelSequence.PlayLevelSequenceByName("BtnShow", false, null, false);
		}

		// Token: 0x06030FE2 RID: 200674 RVA: 0x00DAC228 File Offset: 0x00DAA428
		protected override void OnHideBattleChildView()
		{
			this.OnHideButtons();
			LevelSequencePlayer uiLevelSequence = this.UiLevelSequence;
			if (uiLevelSequence == null)
			{
				return;
			}
			uiLevelSequence.PlayLevelSequenceByName("BtnHide", false, null, false);
		}

		// Token: 0x06030FE3 RID: 200675 RVA: 0x00DAC25C File Offset: 0x00DAA45C
		private void OnLeftRedDotItemRefresh(bool toState, int _)
		{
			if (!toState)
			{
				return;
			}
			LevelSequencePlayer homeBtnLevelSequence = this.HomeBtnLevelSequence;
			if (homeBtnLevelSequence != null)
			{
				homeBtnLevelSequence.PlayLevelSequenceByName("BtnShow", false, null, false);
			}
			base.GetItem(1).SetUIActive(true);
		}

		// Token: 0x06030FE4 RID: 200676 RVA: 0x00DAC29C File Offset: 0x00DAA49C
		private void RefreshTipsBg()
		{
			bool uiactive = base.GetItem(3).bIsUIActive || base.GetItem(4).bIsUIActive || base.GetItem(5).bIsUIActive || base.GetItem(6).bIsUIActive || base.GetItem(8).bIsUIActive || base.GetItem(9).bIsUIActive;
			base.GetItem(1).SetUIActive(uiactive);
		}

		// Token: 0x06030FE5 RID: 200677 RVA: 0x00DAC310 File Offset: 0x00DAA510
		private void RefreshTipsHomeButtonSprite()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(GamepadTopPanel.IconTypeSprite[Info.Instance.InputControllerType]);
			base.SetTextureByPath(resourcePath, base.GetTexture(7), null, null);
		}

		// Token: 0x06030FE6 RID: 200678 RVA: 0x00DAC354 File Offset: 0x00DAA554
		private void OnShowButtons()
		{
			bool flag = !PhoneMsgModel.Instance.IsAllPhoneMsgRead();
			bool flag2 = PhoneMsgModel.Instance.IsHasUnReceivedMsg() || flag;
			bool flag3 = GameModeController.Instance.IsInInstance();
			if (!FunctionModel.Instance.IsOpen(10130) || !flag2 || flag3)
			{
				base.GetItem(9).SetUIActive(false);
				return;
			}
			GamepadPhoneMessageButton phoneMsgButton = this.PhoneMsgButton;
			if (phoneMsgButton == null)
			{
				return;
			}
			phoneMsgButton.OnShowGamepadTopPanel();
		}

		// Token: 0x06030FE7 RID: 200679 RVA: 0x00DAC3BC File Offset: 0x00DAA5BC
		private void OnHideButtons()
		{
			if (FunctionModel.Instance.IsOpen(10130))
			{
				GamepadPhoneMessageButton phoneMsgButton = this.PhoneMsgButton;
				if (phoneMsgButton == null)
				{
					return;
				}
				phoneMsgButton.OnHideGamepadTopPanel();
			}
		}

		// Token: 0x06030FE8 RID: 200680 RVA: 0x00DAC3DF File Offset: 0x00DAA5DF
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (Info.Instance.IsInGamepad())
			{
				base.SetVisible(5, true);
				this.RefreshTipsHomeButtonSprite();
				return;
			}
			base.SetVisible(5, false);
		}

		// Token: 0x06030FE9 RID: 200681 RVA: 0x00DAC404 File Offset: 0x00DAA604
		public void RefreshRoleTowerVisible()
		{
			base.SetVisible(8, !RoleTowerModel.Instance.IsInRoleTowerDungeon());
		}

		// Token: 0x06030FEA RID: 200682 RVA: 0x00DAC41C File Offset: 0x00DAA61C
		private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
		{
			if (functionType == EFunctionType.AdventureGuide && isOpen)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.AdventureBattleButton, base.GetItem(4), null, 0);
			}
			if (functionType == EFunctionType.PhoneMsg && isOpen)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.FunctionPhoneMsg, base.GetItem(9), null, 0);
			}
		}

		// Token: 0x06030FEB RID: 200683 RVA: 0x00DAC46C File Offset: 0x00DAA66C
		private void OnClickedHomeButton()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.FunctionView, null, null);
		}

		// Token: 0x06030FEC RID: 200684 RVA: 0x00DAC49C File Offset: 0x00DAA69C
		private void OnPhoneTipsClose()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopSequenceByKey("Phone", false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlayLevelSequenceByName("Phone", false, null, false);
		}

		// Token: 0x06030FED RID: 200685 RVA: 0x00DAC4E1 File Offset: 0x00DAA6E1
		[NullableContext(1)]
		[return: Nullable(2)]
		public UUIItem GetPanelItem(string item)
		{
			if (item == "PhoneMsgButton")
			{
				return base.GetItem(9);
			}
			if (!(item == "EntitySequenceButtonRoot"))
			{
				return null;
			}
			return base.GetItem(10);
		}

		// Token: 0x06030FEE RID: 200686 RVA: 0x00DAC512 File Offset: 0x00DAA712
		public IPhoneMessageButtonImplement GetPhoneMsgButton()
		{
			return this.PhoneMsgButton;
		}

		// Token: 0x04019FC1 RID: 106433
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Dictionary<EInputControllerType, string> IconTypeSprite = new Dictionary<EInputControllerType, string>
		{
			{
				EInputControllerType.None,
				"T_IconPcBtn_Xbox17_UI"
			},
			{
				EInputControllerType.Keyboard,
				"T_IconPcBtn_Xbox17_UI"
			},
			{
				EInputControllerType.PS4,
				"T_IconPcBtn_PsCai_UI"
			},
			{
				EInputControllerType.PS5,
				"T_IconPcBtn_PsCai_UI"
			},
			{
				EInputControllerType.XboxOne,
				"T_IconPcBtn_Xbox17_UI"
			},
			{
				EInputControllerType.Touch,
				"T_IconPcBtn_Xbox17_UI"
			},
			{
				EInputControllerType.BackBone,
				"T_IconPcBtn_Xbox17_UI"
			},
			{
				EInputControllerType.NsPro,
				"T_IconPcBtn_Xbox17_UI"
			},
			{
				EInputControllerType.XSX,
				"T_IconPcBtn_Xbox17_UI"
			}
		};

		// Token: 0x04019FC2 RID: 106434
		private LevelSequencePlayer UiLevelSequence;

		// Token: 0x04019FC3 RID: 106435
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019FC4 RID: 106436
		private LevelSequencePlayer HomeBtnLevelSequence;

		// Token: 0x04019FC5 RID: 106437
		private GamepadPhoneMessageButton PhoneMsgButton;

		// Token: 0x0200A8C2 RID: 43202
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403421E RID: 213534
			HomeButton,
			// Token: 0x0403421F RID: 213535
			TipsBgItem,
			// Token: 0x04034220 RID: 213536
			HomeButtonRedDotItem,
			// Token: 0x04034221 RID: 213537
			ActivityRedDotItem,
			// Token: 0x04034222 RID: 213538
			AdventureRedDotItem,
			// Token: 0x04034223 RID: 213539
			GachaRedDotItem,
			// Token: 0x04034224 RID: 213540
			BattlePassRedDotItem,
			// Token: 0x04034225 RID: 213541
			HomeButtonTexture,
			// Token: 0x04034226 RID: 213542
			DirectTrainProItem,
			// Token: 0x04034227 RID: 213543
			PhoneMsgButtonItem,
			// Token: 0x04034228 RID: 213544
			EntitySequenceButtonRoot
		}
	}
}
