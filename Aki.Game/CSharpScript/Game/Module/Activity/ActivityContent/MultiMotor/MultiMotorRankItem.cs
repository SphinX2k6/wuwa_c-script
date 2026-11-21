using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x02005315 RID: 21269
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorRankItem : UiPanelBase
	{
		// Token: 0x06034EA6 RID: 216742 RVA: 0x00ECC398 File Offset: 0x00ECA598
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034EA7 RID: 216743 RVA: 0x00ECC5D8 File Offset: 0x00ECA7D8
		protected override void OnStart()
		{
			this.OffsetTween = new LguiIntTween();
			this.OffsetTween.BindUpdateTween(new Action<int>(this.UpdateOffsetY));
			UUISprite sprite = base.GetSprite(8);
			this.AccelerateLeftSpriteStartX = sprite.GetAnchorOffsetX();
			this.FinishSequencePlayer = new LevelSequencePlayer(base.GetItem(9));
			this.LeadSequencePlayer = new LevelSequencePlayer(base.GetItem(6));
			this.AccelerateSequencePlayer = new LevelSequencePlayer(base.GetItem(7));
			base.GetItem(6).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			EventSystem.Instance.Add<int, int>(EEventName.MultiMotorBuffRefresh, new Action<int, int>(this.OnMultiMotorBuffRefresh));
			EventSystem.Instance.Add<int>(EEventName.MultiMotorPassLine, new Action<int>(this.OnMultiMotorPassLine));
			this.LeadSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
			{
				if (sequenceName == "LeadClose")
				{
					base.GetItem(6).SetUIActive(false);
				}
			}, false);
			this.AccelerateSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
			{
				if (sequenceName == "GetClose")
				{
					base.GetItem(7).SetUIActive(false);
				}
			}, false);
		}

		// Token: 0x06034EA8 RID: 216744 RVA: 0x00ECC6D4 File Offset: 0x00ECA8D4
		protected override void OnDestroy()
		{
			this.OffsetTween.Destroy();
			TimerHandle leadTimerHandle = this.LeadTimerHandle;
			if (leadTimerHandle != null)
			{
				leadTimerHandle.Remove();
			}
			this.LeadTimerHandle = null;
			TimerHandle accelerateTimerHandle = this.AccelerateTimerHandle;
			if (accelerateTimerHandle != null)
			{
				accelerateTimerHandle.Remove();
			}
			this.AccelerateTimerHandle = null;
			EventSystem.Instance.Remove(EEventName.MultiMotorBuffRefresh, new Action<int, int>(this.OnMultiMotorBuffRefresh));
			EventSystem.Instance.Remove(EEventName.MultiMotorPassLine, new Action<int>(this.OnMultiMotorPassLine));
		}

		// Token: 0x06034EA9 RID: 216745 RVA: 0x00ECC756 File Offset: 0x00ECA956
		public void RefreshRankNumber(int rankNumber)
		{
			this.RankNumber = rankNumber;
			if (this.RankNumber == 0)
			{
				base.GetSprite(3).SetUIActive(false);
				return;
			}
			this.RefreshRankInfo();
		}

		// Token: 0x06034EAA RID: 216746 RVA: 0x00ECC77B File Offset: 0x00ECA97B
		public void InitPlayerId(int playerId, UCurveFloat lerpCurve, float offsetY)
		{
			this.PlayerId = playerId;
			this.LerpCurve = lerpCurve;
			this.GetOriginalItem().SetAnchorOffsetY(offsetY);
			this.RefreshOnlineModelInfo();
		}

		// Token: 0x06034EAB RID: 216747 RVA: 0x00ECC7A0 File Offset: 0x00ECA9A0
		private void OnMultiMotorBuffRefresh(int playerId, int buffId)
		{
			if (playerId != this.PlayerId)
			{
				return;
			}
			MotorOnlineBuff? motorBuffById = MultiMotorConfig.Instance.GetMotorBuffById(buffId);
			if (motorBuffById == null)
			{
				return;
			}
			EMultiMotorBuffType effectType = (EMultiMotorBuffType)motorBuffById.Value.EffectType;
			if (effectType == EMultiMotorBuffType.Leader)
			{
				this.ShowLeaderState(motorBuffById.Value.EffectTime);
				return;
			}
			if (effectType != EMultiMotorBuffType.Accelerate)
			{
				return;
			}
			this.ShowAccelerateState(motorBuffById.Value.EffectTime);
		}

		// Token: 0x06034EAC RID: 216748 RVA: 0x00ECC811 File Offset: 0x00ECAA11
		private void OnMultiMotorPassLine(int playerId)
		{
			if (playerId == this.PlayerId)
			{
				this.ShowFinishState();
			}
		}

		// Token: 0x06034EAD RID: 216749 RVA: 0x00ECC824 File Offset: 0x00ECAA24
		public void ShowLeaderState(int effectTime)
		{
			TimerHandle leadTimerHandle = this.LeadTimerHandle;
			if (leadTimerHandle != null)
			{
				leadTimerHandle.Remove();
			}
			this.LeadTimerHandle = null;
			base.GetItem(6).SetUIActive(true);
			this.LeadSequencePlayer.PlayLevelSequenceByName("Lead", false, null, false);
			this.LeadTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.LeadTimerHandle = null;
				this.LeadSequencePlayer.PlayLevelSequenceByName("LeadClose", false, null, false);
			}, (float)(effectTime * 1000), null, null, true, 1f);
		}

		// Token: 0x06034EAE RID: 216750 RVA: 0x00ECC8A0 File Offset: 0x00ECAAA0
		public void ShowAccelerateState(int effectTime)
		{
			TimerHandle accelerateTimerHandle = this.AccelerateTimerHandle;
			if (accelerateTimerHandle != null)
			{
				accelerateTimerHandle.Remove();
			}
			this.AccelerateTimerHandle = null;
			base.GetItem(7).SetUIActive(true);
			this.AccelerateSequencePlayer.PlayLevelSequenceByName("Get", false, null, false);
			UUISprite sprite = base.GetSprite(8);
			sprite.SetAnchorOffsetX(this.AccelerateLeftSpriteStartX);
			this.AccelerateLeftSpriteEndX = this.AccelerateLeftSpriteStartX - sprite.Width;
			this.AccelerateCountdownElapsed = 0f;
			this.AccelerateCountdownTotal = (float)(effectTime * 1000);
			this.AccelerateTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.AccelerateTimerHandle = null;
				this.AccelerateSequencePlayer.PlayLevelSequenceByName("GetClose", false, null, false);
			}, (float)(effectTime * 1000), null, null, true, 1f);
		}

		// Token: 0x06034EAF RID: 216751 RVA: 0x00ECC95C File Offset: 0x00ECAB5C
		public void TickAccelerateCountdown(float delta)
		{
			if (this.AccelerateCountdownTotal <= 0f)
			{
				return;
			}
			this.AccelerateCountdownElapsed = Math.Min(this.AccelerateCountdownElapsed + delta, this.AccelerateCountdownTotal);
			float num = this.AccelerateCountdownElapsed / this.AccelerateCountdownTotal;
			float anchorOffsetX = this.AccelerateLeftSpriteStartX + num * (this.AccelerateLeftSpriteEndX - this.AccelerateLeftSpriteStartX);
			UUISprite sprite = base.GetSprite(8);
			if (sprite != null)
			{
				sprite.SetAnchorOffsetX(anchorOffsetX);
			}
			if (this.AccelerateCountdownElapsed >= this.AccelerateCountdownTotal)
			{
				this.AccelerateCountdownTotal = 0f;
			}
		}

		// Token: 0x06034EB0 RID: 216752 RVA: 0x00ECC9E4 File Offset: 0x00ECABE4
		public void ShowFinishState()
		{
			UUIItem item = base.GetItem(9);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(10);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIItem item3 = base.GetItem(11);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			UUIItem item4 = base.GetItem(12);
			if (item4 != null)
			{
				item4.SetUIActive(true);
			}
			UUIItem item5 = base.GetItem(14);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			LevelSequencePlayer finishSequencePlayer = this.FinishSequencePlayer;
			if (finishSequencePlayer != null)
			{
				finishSequencePlayer.PlayLevelSequenceByName("Up", false, null, false);
			}
			UUINiagara uiNiagara = base.GetUiNiagara(15);
			if (uiNiagara != null && this.RankNumber != 0)
			{
				string hexStr;
				MultiMotorDefine.MultiMotorFinishNiagaraColor.TryGetValue(this.RankNumber, out hexStr);
				string hexStr2;
				MultiMotorDefine.MultiMotorFinishNiagaraLineColor.TryGetValue(this.RankNumber, out hexStr2);
				FKuroCurveLinearColor fkuroCurveLinearColor = uiNiagara.ColorParameter.Get("Color");
				FColor fcolor = FColor.FromHex(hexStr);
				fkuroCurveLinearColor.Constant = new FLinearColor(ref fcolor);
				FKuroCurveLinearColor fkuroCurveLinearColor2 = uiNiagara.ColorParameter.Get("Line_Color");
				fcolor = FColor.FromHex(hexStr2);
				fkuroCurveLinearColor2.Constant = new FLinearColor(ref fcolor);
			}
			this.RefreshRankColor();
		}

		// Token: 0x170066C9 RID: 26313
		// (get) Token: 0x06034EB1 RID: 216753 RVA: 0x00ECCB00 File Offset: 0x00ECAD00
		private bool IsSelf
		{
			get
			{
				int? id = PlayerInfoModel.Instance.GetId();
				int playerId = this.PlayerId;
				return id.GetValueOrDefault() == playerId & id != null;
			}
		}

		// Token: 0x06034EB2 RID: 216754 RVA: 0x00ECCB34 File Offset: 0x00ECAD34
		private unsafe void RefreshOnlineModelInfo()
		{
			OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(this.PlayerId);
			if (currentTeamListById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorParkour;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "联机摩托跑酷，属性排行Item初始化失败,有可能是玩家已退出玩法";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PlayerId", this.PlayerId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RankNumber", this.RankNumber);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.NonePlayerState();
				return;
			}
			base.GetText(0).SetText(currentTeamListById.Name, true);
			SceneTeamPlayer teamPlayerData = SceneTeamModel.Instance.GetTeamPlayerData(this.PlayerId);
			int? num;
			if (teamPlayerData == null)
			{
				num = null;
			}
			else
			{
				SceneTeamGroup group = teamPlayerData.GetGroup(ETeamGroupType.Battle);
				if (group == null)
				{
					num = null;
				}
				else
				{
					SceneTeamRole currentRole = group.GetCurrentRole();
					num = ((currentRole != null) ? new int?(currentRole.RoleId) : null);
				}
			}
			int? num2 = num;
			int num3;
			if (num2 == null)
			{
				global::WorldTeamPlayerFightInfo worldTeamPlayerFightInfo = OnlineModel.Instance.GetWorldTeamPlayerFightInfo(this.PlayerId);
				num3 = ((worldTeamPlayerFightInfo != null) ? worldTeamPlayerFightInfo.CurRoleId : 0);
			}
			else
			{
				num3 = num2.GetValueOrDefault();
			}
			int num4 = num3;
			string text = null;
			if (num4 > 0)
			{
				int num5;
				if (this.IsSelf)
				{
					num5 = RoleSkinModel.Instance.GetRoleSkinIdByRoleId(num4);
				}
				else
				{
					global::WorldTeamPlayerFightInfo worldTeamPlayerFightInfo2 = OnlineModel.Instance.GetWorldTeamPlayerFightInfo(this.PlayerId);
					int? num6;
					if (worldTeamPlayerFightInfo2 == null)
					{
						num6 = null;
					}
					else
					{
						global::WorldTeamRoleInfo roleInfoByConfigId = worldTeamPlayerFightInfo2.GetRoleInfoByConfigId(num4);
						num6 = ((roleInfoByConfigId != null) ? new int?(roleInfoByConfigId.RoleSkinId) : null);
					}
					num2 = num6;
					num5 = num2.GetValueOrDefault();
				}
				if (num5 > 0)
				{
					RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(num5);
					if (roleSkinConfig != null)
					{
						text = roleSkinConfig.Value.RoleHeadIconBig;
					}
				}
				if (string.IsNullOrEmpty(text))
				{
					RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(num4);
					if (roleConfig != null)
					{
						text = roleConfig.Value.RoleHeadIconBig;
					}
				}
			}
			if (!string.IsNullOrEmpty(text))
			{
				base.SetTextureByPath(text, base.GetTexture(1), null, null);
			}
			this.RefreshOnlineNumber(currentTeamListById.PlayerNumber);
			this.RefreshSelfItem();
			this.RefreshPing(currentTeamListById.PingState);
		}

		// Token: 0x06034EB3 RID: 216755 RVA: 0x00ECCD64 File Offset: 0x00ECAF64
		private void RefreshOnlineNumber(int onlineNumber)
		{
			string inString;
			if (this.IsSelf)
			{
				inString = "SP_Online{0}PIcon_Self";
			}
			else
			{
				inString = "SP_Online{0}PIcon_Self";
			}
			string resourceId = StringUtils.Format(inString, new string[]
			{
				onlineNumber.ToString()
			});
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(2), false, null, null);
		}

		// Token: 0x06034EB4 RID: 216756 RVA: 0x00ECCDC4 File Offset: 0x00ECAFC4
		private void RefreshSelfItem()
		{
			bool isSelf = this.IsSelf;
			base.GetItem(13).SetUIActive(isSelf);
			base.GetItem(14).SetUIActive(isSelf);
			if (isSelf)
			{
				base.GetText(0).SetColor(FColor.FromHex("#000000FF"));
			}
		}

		// Token: 0x06034EB5 RID: 216757 RVA: 0x00ECCE10 File Offset: 0x00ECB010
		private void RefreshPing(ENetPingState ping)
		{
			string text = null;
			if (ping != ENetPingState.Unknown)
			{
				if (ping == ENetPingState.Poor)
				{
					text = "SP_SignalPoor";
				}
			}
			else
			{
				text = "SP_SignalUnknown";
			}
			UUISprite sprite = base.GetSprite(4);
			if (string.IsNullOrEmpty(text))
			{
				sprite.SetUIActive(false);
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(text);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
			sprite.SetUIActive(true);
		}

		// Token: 0x06034EB6 RID: 216758 RVA: 0x00ECCE74 File Offset: 0x00ECB074
		private void NonePlayerState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_RankRoleHeadEmpty");
			base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "PrefabTextItem_2689870187_Text", Array.Empty<object>());
			base.GetSprite(2).SetUIActive(false);
			base.GetItem(13).SetUIActive(false);
			base.GetItem(14).SetUIActive(false);
			base.GetSprite(4).SetUIActive(false);
		}

		// Token: 0x06034EB7 RID: 216759 RVA: 0x00ECCEFA File Offset: 0x00ECB0FA
		private void RefreshRankInfo()
		{
			this.RefreshRankSprite();
		}

		// Token: 0x06034EB8 RID: 216760 RVA: 0x00ECCF04 File Offset: 0x00ECB104
		private void RefreshRankSprite()
		{
			base.GetSprite(3).SetUIActive(true);
			string resourceId;
			MultiMotorDefine.MultiMotorBattleRankSprite.TryGetValue(this.RankNumber, out resourceId);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(3), false, null, null);
		}

		// Token: 0x06034EB9 RID: 216761 RVA: 0x00ECCF58 File Offset: 0x00ECB158
		private void RefreshRankColor()
		{
			if (this.RankNumber == 0)
			{
				return;
			}
			string hexStr;
			MultiMotorDefine.MultiMotorFinishItem1RankColor.TryGetValue(this.RankNumber, out hexStr);
			string hexStr2;
			MultiMotorDefine.MultiMotorFinishItem2RankColor.TryGetValue(this.RankNumber, out hexStr2);
			string hexStr3;
			MultiMotorDefine.MultiMotorFinishItem3RankColor.TryGetValue(this.RankNumber, out hexStr3);
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetColor(FColor.FromHex(hexStr));
			}
			UUIItem item2 = base.GetItem(11);
			if (item2 != null)
			{
				item2.SetColor(FColor.FromHex(hexStr2));
			}
			UUIItem item3 = base.GetItem(12);
			if (item3 != null)
			{
				item3.SetColor(FColor.FromHex(hexStr3));
			}
			string hexStr4;
			MultiMotorDefine.MultiMotorNameRankColor.TryGetValue(this.RankNumber, out hexStr4);
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetColor(FColor.FromHex(hexStr4));
		}

		// Token: 0x06034EBA RID: 216762 RVA: 0x00ECD01C File Offset: 0x00ECB21C
		public void RefreshOffsetY(float offsetY)
		{
			int start = (int)this.GetOriginalItem().GetAnchorOffsetY();
			this.OffsetTween.PlayTween(start, (int)offsetY, 0.3f, null);
		}

		// Token: 0x06034EBB RID: 216763 RVA: 0x00ECD04A File Offset: 0x00ECB24A
		private void UpdateOffsetY(int value)
		{
			this.GetOriginalItem().SetAnchorOffsetY((float)value);
		}

		// Token: 0x0401BFB8 RID: 114616
		private const float TWEEN_DURATION = 0.3f;

		// Token: 0x0401BFB9 RID: 114617
		public int PlayerId;

		// Token: 0x0401BFBA RID: 114618
		private int RankNumber;

		// Token: 0x0401BFBB RID: 114619
		protected LguiIntTween OffsetTween;

		// Token: 0x0401BFBC RID: 114620
		protected UCurveFloat LerpCurve;

		// Token: 0x0401BFBD RID: 114621
		private LevelSequencePlayer FinishSequencePlayer;

		// Token: 0x0401BFBE RID: 114622
		private LevelSequencePlayer LeadSequencePlayer;

		// Token: 0x0401BFBF RID: 114623
		private LevelSequencePlayer AccelerateSequencePlayer;

		// Token: 0x0401BFC0 RID: 114624
		[Nullable(2)]
		private TimerHandle LeadTimerHandle;

		// Token: 0x0401BFC1 RID: 114625
		[Nullable(2)]
		private TimerHandle AccelerateTimerHandle;

		// Token: 0x0401BFC2 RID: 114626
		private float AccelerateLeftSpriteStartX;

		// Token: 0x0401BFC3 RID: 114627
		private float AccelerateLeftSpriteEndX;

		// Token: 0x0401BFC4 RID: 114628
		private float AccelerateCountdownElapsed;

		// Token: 0x0401BFC5 RID: 114629
		private float AccelerateCountdownTotal;

		// Token: 0x0200AF96 RID: 44950
		[NullableContext(0)]
		private class EItemComponents
		{
			// Token: 0x04036447 RID: 222279
			public const int NameText = 0;

			// Token: 0x04036448 RID: 222280
			public const int RoleHeadTexture = 1;

			// Token: 0x04036449 RID: 222281
			public const int OnlineNumberSprite = 2;

			// Token: 0x0403644A RID: 222282
			public const int RankSprite = 3;

			// Token: 0x0403644B RID: 222283
			public const int PingSprite = 4;

			// Token: 0x0403644C RID: 222284
			public const int PanelDisconnectItem = 5;

			// Token: 0x0403644D RID: 222285
			public const int LeadItem = 6;

			// Token: 0x0403644E RID: 222286
			public const int AccelerateItem = 7;

			// Token: 0x0403644F RID: 222287
			public const int AccelerateLeftSprite = 8;

			// Token: 0x04036450 RID: 222288
			public const int FinishItem = 9;

			// Token: 0x04036451 RID: 222289
			public const int FinishSubItem1 = 10;

			// Token: 0x04036452 RID: 222290
			public const int FinishSubItem2 = 11;

			// Token: 0x04036453 RID: 222291
			public const int FinishSubItem3 = 12;

			// Token: 0x04036454 RID: 222292
			public const int SelfItem = 13;

			// Token: 0x04036455 RID: 222293
			public const int SelfBgItem = 14;

			// Token: 0x04036456 RID: 222294
			public const int FinishNiagara = 15;
		}
	}
}
