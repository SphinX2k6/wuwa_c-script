using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MultiMotor
{
	// Token: 0x0200639F RID: 25503
	public class MultiMotorSettlementPlayerItem : UiPanelBase
	{
		// Token: 0x06040244 RID: 262724 RVA: 0x00F873B8 File Offset: 0x00F855B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
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
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickAddFriendBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040245 RID: 262725 RVA: 0x00F8758C File Offset: 0x00F8578C
		[NullableContext(2)]
		public void RefreshItemByData(OnlineMotorSettleInfo data)
		{
			if (data == null)
			{
				this.ShowNoPlayerState();
				return;
			}
			if (OnlineModel.Instance.GetCurrentTeamListById(data.PlayerId) == null)
			{
				this.ShowNoPlayerState();
				return;
			}
			this.ShowHavePlayerState();
			this.RefreshTag(data);
			this.RefreshRoleTexture(data.SkinId);
			this.RefreshTime(data.ConsumeTime, data.IsFinished);
			this.RefreshPlayerInfo(data.PlayerId);
			this.RefreshChampionInfo(data);
		}

		// Token: 0x06040246 RID: 262726 RVA: 0x00F875FA File Offset: 0x00F857FA
		protected virtual void ShowNoPlayerState()
		{
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06040247 RID: 262727 RVA: 0x00F87623 File Offset: 0x00F85823
		protected virtual void ShowHavePlayerState()
		{
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(true);
		}

		// Token: 0x06040248 RID: 262728 RVA: 0x00F8764C File Offset: 0x00F8584C
		[NullableContext(1)]
		protected virtual void RefreshChampionInfo(OnlineMotorSettleInfo data)
		{
		}

		// Token: 0x06040249 RID: 262729 RVA: 0x00F87650 File Offset: 0x00F85850
		[NullableContext(1)]
		protected virtual void RefreshTag(OnlineMotorSettleInfo data)
		{
			base.GetText(1).SetUIActive(true);
			base.GetText(2).SetUIActive(true);
			int ranking = data.Ranking;
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("MultiMotor_Rank_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(ranking);
			defaultInterpolatedStringHandler.AppendLiteral("_Tag");
			instance.SetLocalTextNew(text, defaultInterpolatedStringHandler.ToStringAndClear(), Array.Empty<object>());
			if (ranking == 1)
			{
				ChampionExtra championExtra = data.ChampionExtra;
				if (championExtra == null || !championExtra.AbsoluteRule)
				{
					ChampionExtra championExtra2 = data.ChampionExtra;
					if (championExtra2 == null || !championExtra2.Destroyer)
					{
						goto IL_CD;
					}
				}
				ChampionExtra championExtra3 = data.ChampionExtra;
				string textStringId = (championExtra3 != null && championExtra3.AbsoluteRule) ? "MultiMotor_Rank_1_AbsoluteRule_Tag" : "MultiMotor_Rank_1_Destroyer_Tag";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), textStringId, Array.Empty<object>());
				return;
			}
			IL_CD:
			if (data.IsFinished)
			{
				LguiUtil instance2 = LguiUtil.Instance;
				UUIText text2 = base.GetText(2);
				defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
				defaultInterpolatedStringHandler.AppendLiteral("MultiMotor_Rank_");
				defaultInterpolatedStringHandler.AppendFormatted<int>(ranking);
				defaultInterpolatedStringHandler.AppendLiteral("_Finish_Tag");
				instance2.SetLocalTextNew(text2, defaultInterpolatedStringHandler.ToStringAndClear(), Array.Empty<object>());
				return;
			}
			base.GetText(2).SetUIActive(false);
		}

		// Token: 0x0604024A RID: 262730 RVA: 0x00F87788 File Offset: 0x00F85988
		protected virtual void RefreshRoleTexture(int skinId)
		{
			RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(skinId);
			if (roleSkinConfig == null)
			{
				return;
			}
			base.SetTextureByPath(roleSkinConfig.Value.FormationRoleCard, base.GetTexture(0), null, null);
		}

		// Token: 0x0604024B RID: 262731 RVA: 0x00F877D4 File Offset: 0x00F859D4
		protected virtual void RefreshTime(int time, bool isFinish)
		{
			if (time <= 0 || !isFinish)
			{
				base.GetItem(8).SetUIActive(true);
				base.GetText(3).SetUIActive(false);
				return;
			}
			base.GetItem(8).SetActive(false, false);
			base.GetText(3).SetUIActive(true);
			string remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat5((double)time * TimeUtil.Instance.Millisecond);
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.SetText(remainTimeDataFormat, true);
		}

		// Token: 0x0604024C RID: 262732 RVA: 0x00F8784C File Offset: 0x00F85A4C
		protected void RefreshPlayerInfo(int playerId)
		{
			OnlineTeamData currentTeamListById = OnlineModel.Instance.GetCurrentTeamListById(playerId);
			if (currentTeamListById == null)
			{
				return;
			}
			int? id = PlayerInfoModel.Instance.GetId();
			bool flag = id.GetValueOrDefault() == playerId & id != null;
			string inString;
			if (flag)
			{
				inString = "SP_Online{0}PIcon_Self";
			}
			else
			{
				inString = "SP_Online{0}PIcon";
			}
			string resourceId = StringUtils.Format(inString, new string[]
			{
				currentTeamListById.PlayerNumber.ToString()
			});
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
			base.GetText(5).SetText(currentTeamListById.PlayerName, true);
			bool isFriend = FriendModel.Instance.IsMyFriend(playerId);
			bool hasApplied = FriendModel.Instance.CurrentApplyFriendListHasPlayer(playerId);
			this.RefreshIsFriend(flag, isFriend, hasApplied);
		}

		// Token: 0x0604024D RID: 262733 RVA: 0x00F8791C File Offset: 0x00F85B1C
		protected void RefreshIsFriend(bool isSelf, bool isFriend, bool hasApplied)
		{
			bool flag = isSelf || isFriend;
			base.GetItem(7).SetUIActive(!flag && hasApplied);
			base.GetButton(6).RootUIComp.Get().SetUIActive(!flag && !hasApplied);
		}

		// Token: 0x0604024E RID: 262734 RVA: 0x00F87962 File Offset: 0x00F85B62
		protected virtual void OnClickAddFriendBtn()
		{
			FriendController.Instance.RequestFriendApplyAddSend(this.PlayerId, FriendApplyWay.RecentlyTeam);
			this.RefreshIsFriend(false, false, true);
		}

		// Token: 0x040216B8 RID: 136888
		public int PlayerId;

		// Token: 0x0200C5BC RID: 50620
		protected class EPlayerComponents
		{
			// Token: 0x0403BB32 RID: 244530
			public const int RoleTexture = 0;

			// Token: 0x0403BB33 RID: 244531
			public const int TagText = 1;

			// Token: 0x0403BB34 RID: 244532
			public const int Tag2Text = 2;

			// Token: 0x0403BB35 RID: 244533
			public const int TimeText = 3;

			// Token: 0x0403BB36 RID: 244534
			public const int OnlineNumberSprite = 4;

			// Token: 0x0403BB37 RID: 244535
			public const int PlayerNameText = 5;

			// Token: 0x0403BB38 RID: 244536
			public const int AddFriendBtn = 6;

			// Token: 0x0403BB39 RID: 244537
			public const int HaveApplyItem = 7;

			// Token: 0x0403BB3A RID: 244538
			public const int FailItem = 8;

			// Token: 0x0403BB3B RID: 244539
			public const int HavePlayerItem = 9;

			// Token: 0x0403BB3C RID: 244540
			public const int NoPlayerItem = 10;
		}
	}
}
