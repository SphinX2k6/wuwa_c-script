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
	// Token: 0x02005CC7 RID: 23751
	public class MoveCursorPanel : BattleVisibleChildView, IExtraShowCursor, IBattleUiCenterPanelOtherMovePanel
	{
		// Token: 0x0603C0DB RID: 245979 RVA: 0x00E5CBAB File Offset: 0x00E5ADAB
		[NullableContext(1)]
		public void CreateDynamic(UUIItem parentItem)
		{
			this.TagIdVisible = BattleUiModel.Instance.GetTagIdMoveCursorVisible();
			base.CreateThenShowByResourceIdAsync("UiItem_SlashTip", parentItem, false).Forget();
		}

		// Token: 0x0603C0DC RID: 245980 RVA: 0x00E5CBD0 File Offset: 0x00E5ADD0
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

		// Token: 0x0603C0DD RID: 245981 RVA: 0x00E5CC0E File Offset: 0x00E5AE0E
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TxtBtn = base.GetTexture(1);
		}

		// Token: 0x0603C0DE RID: 245982 RVA: 0x00E5CC30 File Offset: 0x00E5AE30
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

		// Token: 0x0603C0DF RID: 245983 RVA: 0x00E5CC78 File Offset: 0x00E5AE78
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

		// Token: 0x0603C0E0 RID: 245984 RVA: 0x00E5CE1C File Offset: 0x00E5B01C
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

		// Token: 0x0603C0E1 RID: 245985 RVA: 0x00E5CEE0 File Offset: 0x00E5B0E0
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

		// Token: 0x0603C0E2 RID: 245986 RVA: 0x00E5CFF0 File Offset: 0x00E5B1F0
		private void SetTexBtnIcon()
		{
			if (Info.Instance.IsInKeyBoard())
			{
				base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/UiIconPcBtn/T_IconPcBtn_Mouse2_UI.T_IconPcBtn_Mouse2_UI", this.TxtBtn, null, null);
				return;
			}
			base.SetTextureByPath("/Game/Aki/UI/UIResources/Common/Image/UiIconPcBtn/T_IconPcBtn_XboxL2_UI.T_IconPcBtn_XboxL2_UI", this.TxtBtn, null, null);
		}

		// Token: 0x0603C0E3 RID: 245987 RVA: 0x00E5D040 File Offset: 0x00E5B240
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

		// Token: 0x0603C0E4 RID: 245988 RVA: 0x00E5D162 File Offset: 0x00E5B362
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603C0E5 RID: 245989 RVA: 0x00E5D17C File Offset: 0x00E5B37C
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

		// Token: 0x0603C0E6 RID: 245990 RVA: 0x00E5D1CA File Offset: 0x00E5B3CA
		public bool IsShowCursor()
		{
			return Info.Instance.IsInKeyBoard() && this.NeedCursor;
		}

		// Token: 0x0603C0E7 RID: 245991 RVA: 0x00E5D1E0 File Offset: 0x00E5B3E0
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

		// Token: 0x0401F518 RID: 128280
		private const float SECTOR_ANGLE_SIZE = 0.022222223f;

		// Token: 0x0401F519 RID: 128281
		private const float HALF_SECTOR_ANGLE_SIZE = 22.5f;

		// Token: 0x0401F51A RID: 128282
		private const int SECTOR_NUM = 8;

		// Token: 0x0401F51B RID: 128283
		[Nullable(1)]
		private const string MOUSE_SAFE_AREA_KEY = "GuyingxiongkaiSafeArea";

		// Token: 0x0401F51C RID: 128284
		[Nullable(1)]
		private const string THIS_VIEW_NAME = "MoveCursorPanel";

		// Token: 0x0401F51D RID: 128285
		private float MouseSafeAreaX;

		// Token: 0x0401F51E RID: 128286
		private float MouseSafeAreaY;

		// Token: 0x0401F51F RID: 128287
		private MoveCursorPanel.ESectorScreen LastSector;

		// Token: 0x0401F520 RID: 128288
		private bool NeedCursor = true;

		// Token: 0x0401F521 RID: 128289
		[Nullable(2)]
		private int[] TagIdVisible;

		// Token: 0x0401F522 RID: 128290
		[Nullable(2)]
		private UUITexture TxtBtn;

		// Token: 0x0401F523 RID: 128291
		[Nullable(2)]
		private BaseTagComponent GameplayTagComp;

		// Token: 0x0401F524 RID: 128292
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200BECF RID: 48847
		private enum EChildType
		{
			// Token: 0x040398BE RID: 235710
			TexBtn = 1
		}

		// Token: 0x0200BED0 RID: 48848
		private enum ESectorScreen
		{
			// Token: 0x040398C0 RID: 235712
			Right,
			// Token: 0x040398C1 RID: 235713
			UpRight,
			// Token: 0x040398C2 RID: 235714
			Up,
			// Token: 0x040398C3 RID: 235715
			UpLeft,
			// Token: 0x040398C4 RID: 235716
			Left,
			// Token: 0x040398C5 RID: 235717
			DowLeft,
			// Token: 0x040398C6 RID: 235718
			Down,
			// Token: 0x040398C7 RID: 235719
			DownRight
		}

		// Token: 0x0200BED1 RID: 48849
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040398C8 RID: 235720
			public static TInputHandle<InputDistributeDefine.EActionType> <0>__InputAction;
		}
	}
}
