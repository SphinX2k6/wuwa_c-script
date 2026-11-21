using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle.View
{
	// Token: 0x0200301E RID: 12318
	[NullableContext(2)]
	[Nullable(0)]
	public class EncirclePlayMapItemView : UiPanelBase
	{
		// Token: 0x0601D3A2 RID: 119714 RVA: 0x008EBF48 File Offset: 0x008EA148
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedMapButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601D3A3 RID: 119715 RVA: 0x008EC072 File Offset: 0x008EA272
		protected override void OnStart()
		{
			this.Type = null;
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0601D3A4 RID: 119716 RVA: 0x008EC091 File Offset: 0x008EA291
		protected override void OnBeforeShow()
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0601D3A5 RID: 119717 RVA: 0x008EC0A5 File Offset: 0x008EA2A5
		public void SetPos(int x, int y)
		{
			this.PosX = new int?(x);
			this.PosY = new int?(y);
		}

		// Token: 0x0601D3A6 RID: 119718 RVA: 0x008EC0BF File Offset: 0x008EA2BF
		public EncircleHexType? GetType2()
		{
			return this.Type;
		}

		// Token: 0x0601D3A7 RID: 119719 RVA: 0x008EC0C8 File Offset: 0x008EA2C8
		private void SetTexture(string path)
		{
			UUISprite sprite = base.GetSprite(1);
			this.SetSpriteByPath(path, sprite, false, null, null);
		}

		// Token: 0x0601D3A8 RID: 119720 RVA: 0x008EC0F0 File Offset: 0x008EA2F0
		public void ChangeNorMap(int mapId, int? posKey = null)
		{
			string bgPath = ActivityEncircleConfig.Instance.GetMapItemResource(mapId);
			EncircleHexType? oldType = this.Type;
			EncircleHexType? type = ActivityEncircleConfig.Instance.GetMapItemType(mapId);
			this.Type = type;
			EncircleHexType? encircleHexType = type;
			EncircleHexType encircleHexType2 = EncircleHexType.Plain;
			bool flag = encircleHexType.GetValueOrDefault() == encircleHexType2 & encircleHexType != null;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(flag ? EToggleState.ETT_UnChecked : EToggleState.ETT_UnDetermined, false, false, false);
			}
			TTimerAction ttimerAction = delegate(float _)
			{
				this.InitSequenceState();
				EncircleHexType? type;
				bool flag2 = this.HandlePlainState(type.Value, oldType);
				this.HandleWallState(type.Value, oldType);
				this.HandleTrapState(type.Value, oldType);
				this.HandleDifficultyWallState(type.Value, oldType);
				type = type;
				EncircleHexType encircleHexType3 = EncircleHexType.LimitWall;
				if ((type.GetValueOrDefault() == encircleHexType3 & type != null) && posKey != null)
				{
					int currentRound = EncirclePlayLevelController.Instance.GetCurrentRound();
					int limitRound = EncirclePlayLevelController.Instance.GetLimitWallByPosKey(posKey.Value).LimitRound;
					string limitWallPath = this.GetLimitWallPath(limitRound - currentRound);
					this.SetTexture(limitWallPath);
					return;
				}
				if (!flag2)
				{
					this.SetTexture(bgPath);
				}
			};
			encircleHexType = type;
			encircleHexType2 = EncircleHexType.Monster;
			if (encircleHexType.GetValueOrDefault() == encircleHexType2 & encircleHexType != null)
			{
				encircleHexType = oldType;
				encircleHexType2 = EncircleHexType.Trap;
				if (encircleHexType.GetValueOrDefault() == encircleHexType2 & encircleHexType != null)
				{
					TimerSystem.GameplayTimeInstance.Delay(ttimerAction, 500f, null, null, true, 1f);
					return;
				}
			}
			ttimerAction(0f);
		}

		// Token: 0x0601D3A9 RID: 119721 RVA: 0x008EC1F8 File Offset: 0x008EA3F8
		private bool HandlePlainState(EncircleHexType type, EncircleHexType? oldType)
		{
			bool result = false;
			if (type == EncircleHexType.Plain)
			{
				EncircleHexType? encircleHexType = oldType;
				EncircleHexType encircleHexType2 = EncircleHexType.LimitWall;
				if (encircleHexType.GetValueOrDefault() == encircleHexType2 & encircleHexType != null)
				{
					UUISprite sprite = base.GetSprite(3);
					if (sprite != null)
					{
						sprite.SetAlpha(0f);
					}
					UUIItem item = base.GetItem(3);
					if (item != null)
					{
						item.SetUIActive(true);
					}
					this.ViewSequencePlayer.PlayLevelSequenceByName("Ice", false, null, false);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601D3AA RID: 119722 RVA: 0x008EC26C File Offset: 0x008EA46C
		private void HandleWallState(EncircleHexType type, EncircleHexType? oldType)
		{
			if (type == EncircleHexType.Wall)
			{
				UUIItem item = base.GetItem(3);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				this.ViewSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
		}

		// Token: 0x0601D3AB RID: 119723 RVA: 0x008EC2AB File Offset: 0x008EA4AB
		private void HandleTrapState(EncircleHexType type, EncircleHexType? oldType)
		{
			if (type == EncircleHexType.Trap)
			{
				UUIItem item = base.GetItem(3);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(true);
			}
		}

		// Token: 0x0601D3AC RID: 119724 RVA: 0x008EC2C3 File Offset: 0x008EA4C3
		private void HandleDifficultyWallState(EncircleHexType type, EncircleHexType? oldType)
		{
			if (type == EncircleHexType.DifficultyWall)
			{
				UUISprite sprite = base.GetSprite(5);
				if (sprite != null)
				{
					sprite.SetAlpha(1f);
				}
				UUIItem item = base.GetItem(3);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				EncirclePlayLevelController.Instance.IncreaseDifficultyRound();
			}
		}

		// Token: 0x0601D3AD RID: 119725 RVA: 0x008EC300 File Offset: 0x008EA500
		private void InitSequenceState()
		{
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.SetAlpha(0f);
			}
			UUITexture texture = base.GetTexture(4);
			if (texture != null)
			{
				texture.SetAlpha(0f);
			}
			UUISprite sprite2 = base.GetSprite(1);
			if (sprite2 != null)
			{
				sprite2.SetAlpha(1f);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer == null)
			{
				return;
			}
			viewSequencePlayer.StopSequenceByKey("Next", true, true);
		}

		// Token: 0x0601D3AE RID: 119726 RVA: 0x008EC37C File Offset: 0x008EA57C
		public void ShowMonsterMoveEffect(bool value)
		{
			if (value)
			{
				LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
				if (viewSequencePlayer == null)
				{
					return;
				}
				viewSequencePlayer.PlayOrReplaySequenceByName("Next", false, null);
				return;
			}
			else
			{
				LevelSequencePlayer viewSequencePlayer2 = this.ViewSequencePlayer;
				if (viewSequencePlayer2 == null)
				{
					return;
				}
				viewSequencePlayer2.StopSequenceByKey("Next", true, true);
				return;
			}
		}

		// Token: 0x0601D3AF RID: 119727 RVA: 0x008EC3C3 File Offset: 0x008EA5C3
		private string GetLimitWallPath(int round)
		{
			if (round == 1)
			{
				return "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity31/Encircle/Map/SP_EncircleMapBarrierInitialLimited1.SP_EncircleMapBarrierInitialLimited1";
			}
			if (round == 2)
			{
				return "/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity31/Encircle/Map/SP_EncircleMapBarrierInitialLimited2.SP_EncircleMapBarrierInitialLimited2";
			}
			return null;
		}

		// Token: 0x0601D3B0 RID: 119728 RVA: 0x008EC3DA File Offset: 0x008EA5DA
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x0601D3B1 RID: 119729 RVA: 0x008EC3F4 File Offset: 0x008EA5F4
		private void OnClickedMapButton(EToggleState state)
		{
			if (!EncirclePlayLevelController.Instance.ClickMapItem(this.PosX, this.PosY))
			{
				this.SetTabToggle(EToggleState.ETT_UnChecked);
			}
		}

		// Token: 0x0601D3B2 RID: 119730 RVA: 0x008EC418 File Offset: 0x008EA618
		public void ShowSuccess()
		{
			if (this.Type != null)
			{
				EncircleHexType? type = this.Type;
				EncircleHexType encircleHexType = EncircleHexType.Wall;
				if (type.GetValueOrDefault() == encircleHexType & type != null)
				{
					UUIItem item = base.GetItem(2);
					if (item == null)
					{
						return;
					}
					item.SetUIActive(true);
				}
			}
		}

		// Token: 0x0601D3B3 RID: 119731 RVA: 0x008EC461 File Offset: 0x008EA661
		public void SetTabToggle(EToggleState state)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0400F617 RID: 62999
		private int? PosX;

		// Token: 0x0400F618 RID: 63000
		private int? PosY;

		// Token: 0x0400F619 RID: 63001
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x0400F61A RID: 63002
		private EncircleHexType? Type;
	}
}
