using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200666E RID: 26222
	[NullableContext(2)]
	[Nullable(0)]
	public class EncirclePlayMapItemView : UiPanelBase
	{
		// Token: 0x06041B7A RID: 269178 RVA: 0x00FEFFA8 File Offset: 0x00FEE1A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedMapButton))
			};
		}

		// Token: 0x06041B7B RID: 269179 RVA: 0x00FF0067 File Offset: 0x00FEE267
		protected override void OnStart()
		{
			this.Type = null;
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06041B7C RID: 269180 RVA: 0x00FF0086 File Offset: 0x00FEE286
		protected override void OnBeforeShow()
		{
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06041B7D RID: 269181 RVA: 0x00FF009A File Offset: 0x00FEE29A
		public void SetPos(int x, int y)
		{
			this.PosX = new int?(x);
			this.PosY = new int?(y);
		}

		// Token: 0x06041B7E RID: 269182 RVA: 0x00FF00B4 File Offset: 0x00FEE2B4
		public EncircleHexType? GetType2()
		{
			return this.Type;
		}

		// Token: 0x06041B7F RID: 269183 RVA: 0x00FF00BC File Offset: 0x00FEE2BC
		private void SetTexture(string path)
		{
			UUISprite sprite = base.GetSprite(1);
			this.SetSpriteByPath(path, sprite, false, null, null);
		}

		// Token: 0x06041B80 RID: 269184 RVA: 0x00FF00E4 File Offset: 0x00FEE2E4
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

		// Token: 0x06041B81 RID: 269185 RVA: 0x00FF01EC File Offset: 0x00FEE3EC
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

		// Token: 0x06041B82 RID: 269186 RVA: 0x00FF0260 File Offset: 0x00FEE460
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

		// Token: 0x06041B83 RID: 269187 RVA: 0x00FF029F File Offset: 0x00FEE49F
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

		// Token: 0x06041B84 RID: 269188 RVA: 0x00FF02B7 File Offset: 0x00FEE4B7
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

		// Token: 0x06041B85 RID: 269189 RVA: 0x00FF02F4 File Offset: 0x00FEE4F4
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

		// Token: 0x06041B86 RID: 269190 RVA: 0x00FF0370 File Offset: 0x00FEE570
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

		// Token: 0x06041B87 RID: 269191 RVA: 0x00FF03B7 File Offset: 0x00FEE5B7
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

		// Token: 0x06041B88 RID: 269192 RVA: 0x00FF03CE File Offset: 0x00FEE5CE
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
		}

		// Token: 0x06041B89 RID: 269193 RVA: 0x00FF03E8 File Offset: 0x00FEE5E8
		private void OnClickedMapButton(EToggleState state)
		{
			if (!EncirclePlayLevelController.Instance.ClickMapItem(this.PosX, this.PosY))
			{
				this.SetTabToggle(EToggleState.ETT_UnChecked);
			}
		}

		// Token: 0x06041B8A RID: 269194 RVA: 0x00FF040C File Offset: 0x00FEE60C
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

		// Token: 0x06041B8B RID: 269195 RVA: 0x00FF0455 File Offset: 0x00FEE655
		public void SetTabToggle(EToggleState state)
		{
			base.GetExtendToggle(0).SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0402230D RID: 140045
		private int? PosX;

		// Token: 0x0402230E RID: 140046
		private int? PosY;

		// Token: 0x0402230F RID: 140047
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x04022310 RID: 140048
		private EncircleHexType? Type;
	}
}
