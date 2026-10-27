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
	// Token: 0x02006397 RID: 25495
	[NullableContext(1)]
	[Nullable(0)]
	public class MultiMotorRankItem : UiPanelBase
	{
		// Token: 0x060401E5 RID: 262629 RVA: 0x00F85424 File Offset: 0x00F83624
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

		// Token: 0x060401E6 RID: 262630 RVA: 0x00F85664 File Offset: 0x00F83864
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

		// Token: 0x060401E7 RID: 262631 RVA: 0x00F85760 File Offset: 0x00F83960
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

		// Token: 0x060401E8 RID: 262632 RVA: 0x00F857E2 File Offset: 0x00F839E2
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

		// Token: 0x060401E9 RID: 262633 RVA: 0x00F85807 File Offset: 0x00F83A07
		public void InitPlayerId(int playerId, UCurveFloat lerpCurve, float offsetY)
		{
			this.PlayerId = playerId;
			this.LerpCurve = lerpCurve;
			this.GetOriginalItem().SetAnchorOffsetY(offsetY);
			this.RefreshOnlineModelInfo();
		}

		// Token: 0x060401EA RID: 262634 RVA: 0x00F8582C File Offset: 0x00F83A2C
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

		// Token: 0x060401EB RID: 262635 RVA: 0x00F8589D File Offset: 0x00F83A9D
		private void OnMultiMotorPassLine(int playerId)
		{
			if (playerId == this.PlayerId)
			{
				this.ShowFinishState();
			}
		}

		// Token: 0x060401EC RID: 262636 RVA: 0x00F858B0 File Offset: 0x00F83AB0
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

		// Token: 0x060401ED RID: 262637 RVA: 0x00F8592C File Offset: 0x00F83B2C
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

		// Token: 0x060401EE RID: 262638 RVA: 0x00F859E8 File Offset: 0x00F83BE8
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

		// Token: 0x060401EF RID: 262639 RVA: 0x00F85A70 File Offset: 0x00F83C70
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

		// Token: 0x17009367 RID: 37735
		// (get) Token: 0x060401F0 RID: 262640 RVA: 0x00F85B8C File Offset: 0x00F83D8C
		private bool IsSelf
		{
			get
			{
				int? id = PlayerInfoModel.Instance.GetId();
				int playerId = this.PlayerId;
				return id.GetValueOrDefault() == playerId & id != null;
			}
		}

		// Token: 0x060401F1 RID: 262641 RVA: 0x00F85BC0 File Offset: 0x00F83DC0
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

		// Token: 0x060401F2 RID: 262642 RVA: 0x00F85DF0 File Offset: 0x00F83FF0
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

		// Token: 0x060401F3 RID: 262643 RVA: 0x00F85E50 File Offset: 0x00F84050
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

		// Token: 0x060401F4 RID: 262644 RVA: 0x00F85E9C File Offset: 0x00F8409C
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

		// Token: 0x060401F5 RID: 262645 RVA: 0x00F85F00 File Offset: 0x00F84100
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

		// Token: 0x060401F6 RID: 262646 RVA: 0x00F85F86 File Offset: 0x00F84186
		private void RefreshRankInfo()
		{
			this.RefreshRankSprite();
		}

		// Token: 0x060401F7 RID: 262647 RVA: 0x00F85F90 File Offset: 0x00F84190
		private void RefreshRankSprite()
		{
			base.GetSprite(3).SetUIActive(true);
			string resourceId;
			MultiMotorDefine.MultiMotorBattleRankSprite.TryGetValue(this.RankNumber, out resourceId);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(3), false, null, null);
		}

		// Token: 0x060401F8 RID: 262648 RVA: 0x00F85FE4 File Offset: 0x00F841E4
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

		// Token: 0x060401F9 RID: 262649 RVA: 0x00F860A8 File Offset: 0x00F842A8
		public void RefreshOffsetY(float offsetY)
		{
			int start = (int)this.GetOriginalItem().GetAnchorOffsetY();
			this.OffsetTween.PlayTween(start, (int)offsetY, 0.3f, null);
		}

		// Token: 0x060401FA RID: 262650 RVA: 0x00F860D6 File Offset: 0x00F842D6
		private void UpdateOffsetY(int value)
		{
			this.GetOriginalItem().SetAnchorOffsetY((float)value);
		}

		// Token: 0x04021689 RID: 136841
		private const float TWEEN_DURATION = 0.3f;

		// Token: 0x0402168A RID: 136842
		public int PlayerId;

		// Token: 0x0402168B RID: 136843
		private int RankNumber;

		// Token: 0x0402168C RID: 136844
		protected LguiIntTween OffsetTween;

		// Token: 0x0402168D RID: 136845
		protected UCurveFloat LerpCurve;

		// Token: 0x0402168E RID: 136846
		private LevelSequencePlayer FinishSequencePlayer;

		// Token: 0x0402168F RID: 136847
		private LevelSequencePlayer LeadSequencePlayer;

		// Token: 0x04021690 RID: 136848
		private LevelSequencePlayer AccelerateSequencePlayer;

		// Token: 0x04021691 RID: 136849
		[Nullable(2)]
		private TimerHandle LeadTimerHandle;

		// Token: 0x04021692 RID: 136850
		[Nullable(2)]
		private TimerHandle AccelerateTimerHandle;

		// Token: 0x04021693 RID: 136851
		private float AccelerateLeftSpriteStartX;

		// Token: 0x04021694 RID: 136852
		private float AccelerateLeftSpriteEndX;

		// Token: 0x04021695 RID: 136853
		private float AccelerateCountdownElapsed;

		// Token: 0x04021696 RID: 136854
		private float AccelerateCountdownTotal;

		// Token: 0x0200C5AF RID: 50607
		[NullableContext(0)]
		private class EItemComponents
		{
			// Token: 0x0403BAE6 RID: 244454
			public const int NameText = 0;

			// Token: 0x0403BAE7 RID: 244455
			public const int RoleHeadTexture = 1;

			// Token: 0x0403BAE8 RID: 244456
			public const int OnlineNumberSprite = 2;

			// Token: 0x0403BAE9 RID: 244457
			public const int RankSprite = 3;

			// Token: 0x0403BAEA RID: 244458
			public const int PingSprite = 4;

			// Token: 0x0403BAEB RID: 244459
			public const int PanelDisconnectItem = 5;

			// Token: 0x0403BAEC RID: 244460
			public const int LeadItem = 6;

			// Token: 0x0403BAED RID: 244461
			public const int AccelerateItem = 7;

			// Token: 0x0403BAEE RID: 244462
			public const int AccelerateLeftSprite = 8;

			// Token: 0x0403BAEF RID: 244463
			public const int FinishItem = 9;

			// Token: 0x0403BAF0 RID: 244464
			public const int FinishSubItem1 = 10;

			// Token: 0x0403BAF1 RID: 244465
			public const int FinishSubItem2 = 11;

			// Token: 0x0403BAF2 RID: 244466
			public const int FinishSubItem3 = 12;

			// Token: 0x0403BAF3 RID: 244467
			public const int SelfItem = 13;

			// Token: 0x0403BAF4 RID: 244468
			public const int SelfBgItem = 14;

			// Token: 0x0403BAF5 RID: 244469
			public const int FinishNiagara = 15;
		}
	}
}
