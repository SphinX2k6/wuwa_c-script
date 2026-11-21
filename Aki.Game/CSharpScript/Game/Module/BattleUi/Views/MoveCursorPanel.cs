using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CA9 RID: 19625
	public class MoveCursorPanel : BattleVisibleChildView, IExtraShowCursor, IBattleUiCenterPanelOtherMovePanel
	{
		// Token: 0x06031030 RID: 200752 RVA: 0x00DAD2BF File Offset: 0x00DAB4BF
		[NullableContext(1)]
		public void CreateDynamic(UUIItem parentItem)
		{
			this.TagIdVisible = BattleUiModel.Instance.GetTagIdMoveCursorVisible();
			base.CreateThenShowByResourceIdAsync("UiItem_SlashTip", parentItem, false).Forget();
		}

		// Token: 0x06031031 RID: 200753 RVA: 0x00DAD2E4 File Offset: 0x00DAB4E4
		[NullableContext(2)]
		public override void Initialize(object param = null)
		{
			IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("GuyingxiongkaiSafeArea");
			if (floatArrayConfig != null && floatArrayConfig.Count >= 2)
			{
				this.MouseSafeAreaX = floatArrayConfig[0];
				this.MouseSafeAreaY = floatArrayConfig[1];
			}
		}

		// Token: 0x06031032 RID: 200754 RVA: 0x00DAD322 File Offset: 0x00DAB522
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TxtBtn = base.GetTexture(1);
		}

		// Token: 0x06031033 RID: 200755 RVA: 0x00DAD344 File Offset: 0x00DAB544
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031034 RID: 200756 RVA: 0x00DAD38C File Offset: 0x00DAB58C
		protected override void OnAfterShow()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely("Loop", false, false, null, null, false);
			}
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData != null)
			{
				if (this.TagIdVisible != null)
				{
					this.GameplayTagComp = curRoleData.GameplayTagComponent;
					if (this.GameplayTagComp != null)
					{
						if (this.GameplayTagComp.HasAnyTag(this.TagIdVisible))
						{
							this.NeedCursor = false;
							base.SetUiActive(false);
							curRoleData.MorphShowSpecialEnergyBar = true;
						}
						else
						{
							this.SetTexBtnIcon();
							curRoleData.MorphShowSpecialEnergyBar = false;
							InputDistributeController instance = InputDistributeController.Instance;
							IReadOnlyList<string> actionNames = new <>z__ReadOnlyArray<string>(new string[]
							{
								"攻击",
								"闪避"
							});
							TInputHandle<InputDistributeDefine.EActionType> actionCallback;
							if ((actionCallback = MoveCursorPanel.<>O.<0>__InputAction) == null)
							{
								actionCallback = (MoveCursorPanel.<>O.<0>__InputAction = new TInputHandle<InputDistributeDefine.EActionType>(MoveCursorPanel.InputAction));
							}
							instance.BindActions(actionNames, actionCallback);
							InputExtraShowCursorCenter.Instance.RegisterExtraRefreshData("MoveCursorPanel", this);
							foreach (int tagId in this.TagIdVisible)
							{
								BaseTagComponent gameplayTagComp = this.GameplayTagComp;
								if (gameplayTagComp != null)
								{
									gameplayTagComp.AddTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnTagAddOrRemove), null);
								}
							}
						}
					}
					else
					{
						Log.Instance.Error(ELogModule.Battle, ELogAuthor.HCW, "OnAfterShow this.GameplayTagComp 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
				}
			}
			else
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.HCW, "OnAfterShow roleData 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
		}

		// Token: 0x06031035 RID: 200757 RVA: 0x00DAD530 File Offset: 0x00DAB730
		private void OnTagAddOrRemove(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
				if (curRoleData != null)
				{
					curRoleData.MorphShowSpecialEnergyBar = true;
				}
				else
				{
					Log.Instance.Error(ELogModule.Battle, ELogAuthor.HCW, "OnTagAddOrRemove roleData 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				EventSystem.Instance.Emit<bool>(EEventName.BattleUiEnergyBarVisible, true);
				this.NeedCursor = false;
				base.SetUiActive(false);
				InputDistributeController instance = InputDistributeController.Instance;
				IReadOnlyList<string> actionNames = new <>z__ReadOnlyArray<string>(new string[]
				{
					"攻击",
					"闪避"
				});
				TInputHandle<InputDistributeDefine.EActionType> actionCallback;
				if ((actionCallback = MoveCursorPanel.<>O.<0>__InputAction) == null)
				{
					actionCallback = (MoveCursorPanel.<>O.<0>__InputAction = new TInputHandle<InputDistributeDefine.EActionType>(MoveCursorPanel.InputAction));
				}
				instance.UnBindActions(actionNames, actionCallback);
				InputExtraShowCursorCenter.Instance.UnRegisterExtraRefreshData("MoveCursorPanel");
				EventSystem.Instance.Emit(EEventName.RefreshCursor);
			}
		}

		// Token: 0x06031036 RID: 200758 RVA: 0x00DAD5F4 File Offset: 0x00DAB7F4
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (this.TagIdVisible != null)
			{
				BaseTagComponent gameplayTagComp = this.GameplayTagComp;
				if (gameplayTagComp != null && gameplayTagComp.HasAnyTag(this.TagIdVisible))
				{
					return;
				}
			}
			this.SetTexBtnIcon();
			if (Info.Instance.IsInKeyBoard())
			{
				this.NeedCursor = true;
				InputDistributeController instance = InputDistributeController.Instance;
				IReadOnlyList<string> actionNames = new <>z__ReadOnlyArray<string>(new string[]
				{
					"攻击",
					"闪避"
				});
				TInputHandle<InputDistributeDefine.EActionType> actionCallback;
				if ((actionCallback = MoveCursorPanel.<>O.<0>__InputAction) == null)
				{
					actionCallback = (MoveCursorPanel.<>O.<0>__InputAction = new TInputHandle<InputDistributeDefine.EActionType>(MoveCursorPanel.InputAction));
				}
				instance.BindActions(actionNames, actionCallback);
				InputExtraShowCursorCenter.Instance.RegisterExtraRefreshData("MoveCursorPanel", this);
				EventSystem.Instance.Emit(EEventName.RefreshCursor);
				return;
			}
			this.NeedCursor = false;
			InputDistributeController instance2 = InputDistributeController.Instance;
			IReadOnlyList<string> actionNames2 = new <>z__ReadOnlyArray<string>(new string[]
			{
				"攻击",
				"闪避"
			});
			TInputHandle<InputDistributeDefine.EActionType> actionCallback2;
			if ((actionCallback2 = MoveCursorPanel.<>O.<0>__InputAction) == null)
			{
				actionCallback2 = (MoveCursorPanel.<>O.<0>__InputAction = new TInputHandle<InputDistributeDefine.EActionType>(MoveCursorPanel.InputAction));
			}
			instance2.UnBindActions(actionNames2, actionCallback2);
			InputExtraShowCursorCenter.Instance.UnRegisterExtraRefreshData("MoveCursorPanel");
			EventSystem.Instance.Emit(EEventName.RefreshCursor);
		}

		// Token: 0x06031037 RID: 200759 RVA: 0x00DAD704 File Offset: 0x00DAB904
		private void SetTexBtnIcon()
		{
			if (Info.Instance.IsInKeyBoard())
			{
				base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/UiIconPcBtn/T_IconPcBtn_Mouse2_UI.T_IconPcBtn_Mouse2_UI", this.TxtBtn, null, null);
				return;
			}
			base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/UiIconPcBtn/T_IconPcBtn_XboxL2_UI.T_IconPcBtn_XboxL2_UI", this.TxtBtn, null, null);
		}

		// Token: 0x06031038 RID: 200760 RVA: 0x00DAD754 File Offset: 0x00DAB954
		protected override void OnHideBattleChildView()
		{
			if (this.NeedCursor)
			{
				InputDistributeController instance = InputDistributeController.Instance;
				IReadOnlyList<string> actionNames = new <>z__ReadOnlyArray<string>(new string[]
				{
					"攻击",
					"闪避"
				});
				TInputHandle<InputDistributeDefine.EActionType> actionCallback;
				if ((actionCallback = MoveCursorPanel.<>O.<0>__InputAction) == null)
				{
					actionCallback = (MoveCursorPanel.<>O.<0>__InputAction = new TInputHandle<InputDistributeDefine.EActionType>(MoveCursorPanel.InputAction));
				}
				instance.UnBindActions(actionNames, actionCallback);
				InputExtraShowCursorCenter.Instance.UnRegisterExtraRefreshData("MoveCursorPanel");
				EventSystem.Instance.Emit(EEventName.RefreshCursor);
			}
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			if (curRoleData != null)
			{
				if (this.TagIdVisible != null && curRoleData.GameplayTagComponent != null)
				{
					foreach (int tagId in this.TagIdVisible)
					{
						curRoleData.GameplayTagComponent.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnTagAddOrRemove));
					}
				}
				curRoleData.MorphShowSpecialEnergyBar = true;
			}
			else
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.HCW, "OnBeforeDestroy roleData 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (EventSystem.Instance.Has(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange)))
			{
				EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			}
		}

		// Token: 0x06031039 RID: 200761 RVA: 0x00DAD876 File Offset: 0x00DABA76
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603103A RID: 200762 RVA: 0x00DAD890 File Offset: 0x00DABA90
		[NullableContext(1)]
		private static void InputAction(string name, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if ("攻击" == name && actionType == InputDistributeDefine.EActionType.Press)
			{
				InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.攻击, EInputState.Press);
				return;
			}
			if ("闪避" == name && actionType == InputDistributeDefine.EActionType.Press)
			{
				InputController.Instance.InputAction(CSharpScript.Game.Input.EInputAction.闪避, EInputState.Press);
			}
		}

		// Token: 0x0603103B RID: 200763 RVA: 0x00DAD8DE File Offset: 0x00DABADE
		public bool IsShowCursor()
		{
			return Info.Instance.IsInKeyBoard() && this.NeedCursor;
		}

		// Token: 0x0603103C RID: 200764 RVA: 0x00DAD8F4 File Offset: 0x00DABAF4
		public void Tick(float delta)
		{
			if (!this.IsShowCursor())
			{
				return;
			}
			Vector2D cursorPosition = Global.CharacterController.GetCursorPosition();
			if (cursorPosition == null)
			{
				return;
			}
			Vector2D viewportSize = BattleUiModel.Instance.ViewportSize;
			double num = viewportSize.X * 0.5;
			double num2 = viewportSize.Y * 0.5;
			double num3 = num * (double)this.MouseSafeAreaX;
			double num4 = num2 * (double)this.MouseSafeAreaY;
			double num5 = cursorPosition.X - num;
			double num6 = num2 - cursorPosition.Y;
			if (Math.Abs(num5) < num3 && Math.Abs(num6) < num4)
			{
				return;
			}
			float num7 = (float)(Math.Atan2(num6, num5) * 57.295780181884766);
			if (num7 < 0f)
			{
				num7 += 360f;
			}
			MoveCursorPanel.ESectorScreen esectorScreen = (MoveCursorPanel.ESectorScreen)Math.Floor((double)((num7 + 22.5f) * 0.022222223f)) % (MoveCursorPanel.ESectorScreen)8;
			if (esectorScreen == this.LastSector)
			{
				return;
			}
			this.LastSector = esectorScreen;
			switch (esectorScreen)
			{
			case MoveCursorPanel.ESectorScreen.Right:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, 1f, true);
				return;
			case MoveCursorPanel.ESectorScreen.UpRight:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, 1f, true);
				InputController.Instance.InputAxis(EInputAxis.MoveForward, 1f, true);
				return;
			case MoveCursorPanel.ESectorScreen.Up:
				InputController.Instance.InputAxis(EInputAxis.MoveForward, 1f, true);
				return;
			case MoveCursorPanel.ESectorScreen.UpLeft:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, -1f, true);
				InputController.Instance.InputAxis(EInputAxis.MoveForward, 1f, true);
				return;
			case MoveCursorPanel.ESectorScreen.Left:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, -1f, true);
				return;
			case MoveCursorPanel.ESectorScreen.DowLeft:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, -1f, true);
				InputController.Instance.InputAxis(EInputAxis.MoveForward, -1f, true);
				return;
			case MoveCursorPanel.ESectorScreen.Down:
				InputController.Instance.InputAxis(EInputAxis.MoveForward, -1f, true);
				return;
			case MoveCursorPanel.ESectorScreen.DownRight:
				InputController.Instance.InputAxis(EInputAxis.MoveRight, 1f, true);
				InputController.Instance.InputAxis(EInputAxis.MoveForward, -1f, true);
				return;
			default:
				return;
			}
		}

		// Token: 0x04019FD1 RID: 106449
		private const float SECTOR_ANGLE_SIZE = 0.022222223f;

		// Token: 0x04019FD2 RID: 106450
		private const float HALF_SECTOR_ANGLE_SIZE = 22.5f;

		// Token: 0x04019FD3 RID: 106451
		private const int SECTOR_NUM = 8;

		// Token: 0x04019FD4 RID: 106452
		[Nullable(1)]
		private const string MOUSE_SAFE_AREA_KEY = "GuyingxiongkaiSafeArea";

		// Token: 0x04019FD5 RID: 106453
		[Nullable(1)]
		private const string THIS_VIEW_NAME = "MoveCursorPanel";

		// Token: 0x04019FD6 RID: 106454
		private float MouseSafeAreaX;

		// Token: 0x04019FD7 RID: 106455
		private float MouseSafeAreaY;

		// Token: 0x04019FD8 RID: 106456
		private MoveCursorPanel.ESectorScreen LastSector;

		// Token: 0x04019FD9 RID: 106457
		private bool NeedCursor = true;

		// Token: 0x04019FDA RID: 106458
		[Nullable(2)]
		private int[] TagIdVisible;

		// Token: 0x04019FDB RID: 106459
		[Nullable(2)]
		private UUITexture TxtBtn;

		// Token: 0x04019FDC RID: 106460
		[Nullable(2)]
		private BaseTagComponent GameplayTagComp;

		// Token: 0x04019FDD RID: 106461
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A8D5 RID: 43221
		private enum EChildType
		{
			// Token: 0x0403427F RID: 213631
			TexBtn = 1
		}

		// Token: 0x0200A8D6 RID: 43222
		private enum ESectorScreen
		{
			// Token: 0x04034281 RID: 213633
			Right,
			// Token: 0x04034282 RID: 213634
			UpRight,
			// Token: 0x04034283 RID: 213635
			Up,
			// Token: 0x04034284 RID: 213636
			UpLeft,
			// Token: 0x04034285 RID: 213637
			Left,
			// Token: 0x04034286 RID: 213638
			DowLeft,
			// Token: 0x04034287 RID: 213639
			Down,
			// Token: 0x04034288 RID: 213640
			DownRight
		}

		// Token: 0x0200A8D7 RID: 43223
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04034289 RID: 213641
			public static TInputHandle<InputDistributeDefine.EActionType> <0>__InputAction;
		}
	}
}
