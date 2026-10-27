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
	// Token: 0x02005CBE RID: 23742
	[NullableContext(2)]
	[Nullable(0)]
	public class GamepadTopPanel : BattleVisibleChildView
	{
		// Token: 0x0603C085 RID: 245893 RVA: 0x00E5B5B4 File Offset: 0x00E597B4
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

		// Token: 0x0603C086 RID: 245894 RVA: 0x00E5B788 File Offset: 0x00E59988
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			base.InitChildType(EBattleUiChild.HomeButton);
			this.AddEvents();
			this.BindRedDot();
			this.UiLevelSequence = new LevelSequencePlayer(this.RootItem);
			this.HomeBtnLevelSequence = new LevelSequencePlayer(base.GetButton(0).RootUIComp);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603C087 RID: 245895 RVA: 0x00E5B7F0 File Offset: 0x00E599F0
		protected override UniTask InitializeAsync(object param = null)
		{
			GamepadTopPanel.<InitializeAsync>d__8 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<GamepadTopPanel.<InitializeAsync>d__8>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C088 RID: 245896 RVA: 0x00E5B834 File Offset: 0x00E59A34
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

		// Token: 0x0603C089 RID: 245897 RVA: 0x00E5B884 File Offset: 0x00E59A84
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

		// Token: 0x0603C08A RID: 245898 RVA: 0x00E5B9B0 File Offset: 0x00E59BB0
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

		// Token: 0x0603C08B RID: 245899 RVA: 0x00E5BA24 File Offset: 0x00E59C24
		private void AddEvents()
		{
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Add(EEventName.OnPhoneTipsClose, new Action(this.OnPhoneTipsClose));
		}

		// Token: 0x0603C08C RID: 245900 RVA: 0x00E5BA88 File Offset: 0x00E59C88
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Remove(EEventName.OnPhoneTipsClose, new Action(this.OnPhoneTipsClose));
		}

		// Token: 0x0603C08D RID: 245901 RVA: 0x00E5BAEC File Offset: 0x00E59CEC
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

		// Token: 0x0603C08E RID: 245902 RVA: 0x00E5BB2C File Offset: 0x00E59D2C
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

		// Token: 0x0603C08F RID: 245903 RVA: 0x00E5BB60 File Offset: 0x00E59D60
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

		// Token: 0x0603C090 RID: 245904 RVA: 0x00E5BBA0 File Offset: 0x00E59DA0
		private void RefreshTipsBg()
		{
			bool uiactive = base.GetItem(3).bIsUIActive || base.GetItem(4).bIsUIActive || base.GetItem(5).bIsUIActive || base.GetItem(6).bIsUIActive || base.GetItem(8).bIsUIActive || base.GetItem(9).bIsUIActive;
			base.GetItem(1).SetUIActive(uiactive);
		}

		// Token: 0x0603C091 RID: 245905 RVA: 0x00E5BC14 File Offset: 0x00E59E14
		private void RefreshTipsHomeButtonSprite()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(GamepadTopPanel.IconTypeSprite[Info.Instance.InputControllerType]);
			base.SetTextureByPath(resourcePath, base.GetTexture(7), null, null);
		}

		// Token: 0x0603C092 RID: 245906 RVA: 0x00E5BC58 File Offset: 0x00E59E58
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

		// Token: 0x0603C093 RID: 245907 RVA: 0x00E5BCC0 File Offset: 0x00E59EC0
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

		// Token: 0x0603C094 RID: 245908 RVA: 0x00E5BCE3 File Offset: 0x00E59EE3
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

		// Token: 0x0603C095 RID: 245909 RVA: 0x00E5BD08 File Offset: 0x00E59F08
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

		// Token: 0x0603C096 RID: 245910 RVA: 0x00E5BD58 File Offset: 0x00E59F58
		private void OnClickedHomeButton()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(null, null, true);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.FunctionView, null, null);
		}

		// Token: 0x0603C097 RID: 245911 RVA: 0x00E5BD88 File Offset: 0x00E59F88
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

		// Token: 0x0603C098 RID: 245912 RVA: 0x00E5BDCD File Offset: 0x00E59FCD
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

		// Token: 0x0603C099 RID: 245913 RVA: 0x00E5BDFE File Offset: 0x00E59FFE
		public IPhoneMessageButtonImplement GetPhoneMsgButton()
		{
			return this.PhoneMsgButton;
		}

		// Token: 0x0401F508 RID: 128264
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

		// Token: 0x0401F509 RID: 128265
		private LevelSequencePlayer UiLevelSequence;

		// Token: 0x0401F50A RID: 128266
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F50B RID: 128267
		private LevelSequencePlayer HomeBtnLevelSequence;

		// Token: 0x0401F50C RID: 128268
		private GamepadPhoneMessageButton PhoneMsgButton;

		// Token: 0x0200BEBC RID: 48828
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403985D RID: 235613
			HomeButton,
			// Token: 0x0403985E RID: 235614
			TipsBgItem,
			// Token: 0x0403985F RID: 235615
			HomeButtonRedDotItem,
			// Token: 0x04039860 RID: 235616
			ActivityRedDotItem,
			// Token: 0x04039861 RID: 235617
			AdventureRedDotItem,
			// Token: 0x04039862 RID: 235618
			GachaRedDotItem,
			// Token: 0x04039863 RID: 235619
			BattlePassRedDotItem,
			// Token: 0x04039864 RID: 235620
			HomeButtonTexture,
			// Token: 0x04039865 RID: 235621
			DirectTrainProItem,
			// Token: 0x04039866 RID: 235622
			PhoneMsgButtonItem,
			// Token: 0x04039867 RID: 235623
			EntitySequenceButtonRoot
		}
	}
}
