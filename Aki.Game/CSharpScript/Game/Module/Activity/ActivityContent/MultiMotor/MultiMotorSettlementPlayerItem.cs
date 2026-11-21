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
	// Token: 0x0200531D RID: 21277
	public class MultiMotorSettlementPlayerItem : UiPanelBase
	{
		// Token: 0x06034F05 RID: 216837 RVA: 0x00ECE2F0 File Offset: 0x00ECC4F0
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

		// Token: 0x06034F06 RID: 216838 RVA: 0x00ECE4C4 File Offset: 0x00ECC6C4
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

		// Token: 0x06034F07 RID: 216839 RVA: 0x00ECE532 File Offset: 0x00ECC732
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

		// Token: 0x06034F08 RID: 216840 RVA: 0x00ECE55B File Offset: 0x00ECC75B
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

		// Token: 0x06034F09 RID: 216841 RVA: 0x00ECE584 File Offset: 0x00ECC784
		[NullableContext(1)]
		protected virtual void RefreshChampionInfo(OnlineMotorSettleInfo data)
		{
		}

		// Token: 0x06034F0A RID: 216842 RVA: 0x00ECE588 File Offset: 0x00ECC788
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

		// Token: 0x06034F0B RID: 216843 RVA: 0x00ECE6C0 File Offset: 0x00ECC8C0
		protected virtual void RefreshRoleTexture(int skinId)
		{
			RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(skinId);
			if (roleSkinConfig == null)
			{
				return;
			}
			base.SetTextureByPath(roleSkinConfig.Value.FormationRoleCard, base.GetTexture(0), null, null);
		}

		// Token: 0x06034F0C RID: 216844 RVA: 0x00ECE70C File Offset: 0x00ECC90C
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

		// Token: 0x06034F0D RID: 216845 RVA: 0x00ECE784 File Offset: 0x00ECC984
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

		// Token: 0x06034F0E RID: 216846 RVA: 0x00ECE854 File Offset: 0x00ECCA54
		protected void RefreshIsFriend(bool isSelf, bool isFriend, bool hasApplied)
		{
			bool flag = isSelf || isFriend;
			base.GetItem(7).SetUIActive(!flag && hasApplied);
			base.GetButton(6).RootUIComp.Get().SetUIActive(!flag && !hasApplied);
		}

		// Token: 0x06034F0F RID: 216847 RVA: 0x00ECE89A File Offset: 0x00ECCA9A
		protected virtual void OnClickAddFriendBtn()
		{
			FriendController.Instance.RequestFriendApplyAddSend(this.PlayerId, FriendApplyWay.RecentlyTeam);
			this.RefreshIsFriend(false, false, true);
		}

		// Token: 0x0401BFE7 RID: 114663
		public int PlayerId;

		// Token: 0x0200AFA3 RID: 44963
		protected class EPlayerComponents
		{
			// Token: 0x04036491 RID: 222353
			public const int RoleTexture = 0;

			// Token: 0x04036492 RID: 222354
			public const int TagText = 1;

			// Token: 0x04036493 RID: 222355
			public const int Tag2Text = 2;

			// Token: 0x04036494 RID: 222356
			public const int TimeText = 3;

			// Token: 0x04036495 RID: 222357
			public const int OnlineNumberSprite = 4;

			// Token: 0x04036496 RID: 222358
			public const int PlayerNameText = 5;

			// Token: 0x04036497 RID: 222359
			public const int AddFriendBtn = 6;

			// Token: 0x04036498 RID: 222360
			public const int HaveApplyItem = 7;

			// Token: 0x04036499 RID: 222361
			public const int FailItem = 8;

			// Token: 0x0403649A RID: 222362
			public const int HavePlayerItem = 9;

			// Token: 0x0403649B RID: 222363
			public const int NoPlayerItem = 10;
		}
	}
}
