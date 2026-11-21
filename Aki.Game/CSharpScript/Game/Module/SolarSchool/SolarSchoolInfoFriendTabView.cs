using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059BC RID: 22972
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolInfoFriendTabView : UiTabViewBase
	{
		// Token: 0x060389DE RID: 231902 RVA: 0x00FD75B0 File Offset: 0x00FD57B0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060389DF RID: 231903 RVA: 0x00FD778C File Offset: 0x00FD598C
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolInfoFriendTabView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolInfoFriendTabView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060389E0 RID: 231904 RVA: 0x00FD77D0 File Offset: 0x00FD59D0
		protected override void OnShowUiTabViewFromToggle()
		{
			this.RefreshRoleListAsync().Forget();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x060389E1 RID: 231905 RVA: 0x00FD7808 File Offset: 0x00FD5A08
		private void ApplyOpenParam()
		{
			SolarSchoolInfoOverviewViewParam solarSchoolInfoOverviewViewParam = this.ExtraParams as SolarSchoolInfoOverviewViewParam;
			if (solarSchoolInfoOverviewViewParam != null && solarSchoolInfoOverviewViewParam.TargetRoleId > 0)
			{
				this.SelectedRoleId = solarSchoolInfoOverviewViewParam.TargetRoleId;
			}
		}

		// Token: 0x060389E2 RID: 231906 RVA: 0x00FD7839 File Offset: 0x00FD5A39
		private SolarSchoolInfoFriendHeadItem CreateRoleHeadItem()
		{
			return new SolarSchoolInfoFriendHeadItem
			{
				ClickCallback = new Action<SolarSchoolRoleData>(this.OnSelectRole)
			};
		}

		// Token: 0x060389E3 RID: 231907 RVA: 0x00FD7854 File Offset: 0x00FD5A54
		private UniTask RefreshRoleListAsync()
		{
			SolarSchoolInfoFriendTabView.<RefreshRoleListAsync>d__11 <RefreshRoleListAsync>d__;
			<RefreshRoleListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshRoleListAsync>d__.<>4__this = this;
			<RefreshRoleListAsync>d__.<>1__state = -1;
			<RefreshRoleListAsync>d__.<>t__builder.Start<SolarSchoolInfoFriendTabView.<RefreshRoleListAsync>d__11>(ref <RefreshRoleListAsync>d__);
			return <RefreshRoleListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060389E4 RID: 231908 RVA: 0x00FD7898 File Offset: 0x00FD5A98
		private void BuildRoleDataList()
		{
			this.RoleDataList.Clear();
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (!instance.IsInGamePlay)
			{
				return;
			}
			foreach (SolarSchoolRoleData solarSchoolRoleData in instance.FriendData.Roles)
			{
				if (solarSchoolRoleData.IsUnlocked || solarSchoolRoleData.Config.IsSpecial)
				{
					this.RoleDataList.Add(solarSchoolRoleData);
				}
			}
			this.RoleDataList.Sort((SolarSchoolRoleData left, SolarSchoolRoleData right) => left.RoleId.CompareTo(right.RoleId));
		}

		// Token: 0x060389E5 RID: 231909 RVA: 0x00FD794C File Offset: 0x00FD5B4C
		private void OnSelectRole(SolarSchoolRoleData data)
		{
			this.RefreshRoleDetail(data);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x060389E6 RID: 231910 RVA: 0x00FD7980 File Offset: 0x00FD5B80
		private void RefreshRoleDetail(SolarSchoolRoleData data)
		{
			this.SelectedRoleId = data.RoleId;
			UUIText text = base.GetText(7);
			if (text != null)
			{
				text.ShowTextNew(data.Config.Name ?? string.Empty);
			}
			bool flag = (data.IsUnlocked || data.Config.IsSpecial) && !string.IsNullOrEmpty(data.Config.Spine);
			UUITexture texture = base.GetTexture(4);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 != null)
			{
				texture2.SetUIActive(flag);
			}
			if (flag)
			{
				base.SetTextureByPath(data.Config.Spine, base.GetTexture(4), null, null);
				base.SetTextureByPath(data.Config.GrayIcon, base.GetTexture(1), null, null);
			}
			this.RefreshLikeItems(data);
			this.RefreshConditions(data);
		}

		// Token: 0x060389E7 RID: 231911 RVA: 0x00FD7A78 File Offset: 0x00FD5C78
		private void RefreshLikeItems(SolarSchoolRoleData data)
		{
			List<SolarSchoolItem> list = new List<SolarSchoolItem>();
			if (!data.IsUnlocked && !data.Config.IsSpecial)
			{
				GenericScrollViewNew<SolarSchoolInfoFriendLikeItem, SolarSchoolItem> likeItemScroll = this.LikeItemScroll;
				if (likeItemScroll != null)
				{
					likeItemScroll.RefreshByData(list, null, false);
				}
				UUIItem item = base.GetItem(12);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
				return;
			}
			else
			{
				foreach (SolarSchoolItem item2 in SolarSchoolConfig.Instance.GetItemListByActivityId(SolarSchoolGamePlayModel.Instance.ActivityId))
				{
					if (NoLinq.Contains<int>(item2.GetFavorRoleListBytes(), data.RoleId))
					{
						list.Add(item2);
					}
				}
				list.Sort((SolarSchoolItem left, SolarSchoolItem right) => left.SortId.CompareTo(right.SortId));
				GenericScrollViewNew<SolarSchoolInfoFriendLikeItem, SolarSchoolItem> likeItemScroll2 = this.LikeItemScroll;
				if (likeItemScroll2 != null)
				{
					likeItemScroll2.RefreshByData(list, null, false);
				}
				UUIItem item3 = base.GetItem(12);
				if (item3 == null)
				{
					return;
				}
				item3.SetUIActive(list.Count > 0);
				return;
			}
		}

		// Token: 0x060389E8 RID: 231912 RVA: 0x00FD7B84 File Offset: 0x00FD5D84
		private void ClearRoleDetail()
		{
			this.SelectedRoleId = 0;
			UUIText text = base.GetText(7);
			if (text != null)
			{
				text.SetText(string.Empty, true);
			}
			UUITexture texture = base.GetTexture(4);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 != null)
			{
				texture2.SetUIActive(true);
			}
			GenericScrollViewNew<SolarSchoolInfoFriendLikeItem, SolarSchoolItem> likeItemScroll = this.LikeItemScroll;
			if (likeItemScroll != null)
			{
				likeItemScroll.RefreshByData(new List<SolarSchoolItem>(), null, false);
			}
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			foreach (SolarSchoolInfoFriendConditionItem solarSchoolInfoFriendConditionItem in this.ConditionItems)
			{
				solarSchoolInfoFriendConditionItem.Clear();
			}
		}

		// Token: 0x060389E9 RID: 231913 RVA: 0x00FD7C48 File Offset: 0x00FD5E48
		private void RefreshConditions(SolarSchoolRoleData data)
		{
			bool flag = SolarSchoolGamePlayModel.Instance.IsFavorLevelUpPending(data.RoleId);
			for (int i = 0; i < this.ConditionItems.Count; i++)
			{
				int favorLevel = i + 1;
				SolarSchoolRoleFavorLevelData favorLevelData = data.GetFavorLevelData(favorLevel);
				if (favorLevelData == null)
				{
					this.ConditionItems[i].Clear();
				}
				else
				{
					bool showAffinityRedPoint = flag && favorLevelData.IsCurrentLevel();
					this.ConditionItems[i].Refresh(favorLevelData, showAffinityRedPoint);
				}
			}
		}

		// Token: 0x0401DD0E RID: 122126
		private readonly List<SolarSchoolRoleData> RoleDataList = new List<SolarSchoolRoleData>();

		// Token: 0x0401DD0F RID: 122127
		private readonly List<SolarSchoolInfoFriendConditionItem> ConditionItems = new List<SolarSchoolInfoFriendConditionItem>();

		// Token: 0x0401DD10 RID: 122128
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SolarSchoolInfoFriendHeadItem, SolarSchoolRoleData> RoleHeadScroll;

		// Token: 0x0401DD11 RID: 122129
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<SolarSchoolInfoFriendLikeItem, SolarSchoolItem> LikeItemScroll;

		// Token: 0x0401DD12 RID: 122130
		private int SelectedRoleId;

		// Token: 0x0200B562 RID: 46434
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403814F RID: 229711
			public const int Root = 0;

			// Token: 0x04038150 RID: 229712
			public const int RoleBackground = 1;

			// Token: 0x04038151 RID: 229713
			public const int RoleHeadScroll = 2;

			// Token: 0x04038152 RID: 229714
			public const int RoleHeadTemplate = 3;

			// Token: 0x04038153 RID: 229715
			public const int RoleTexture = 4;

			// Token: 0x04038154 RID: 229716
			public const int LikeItemScroll = 5;

			// Token: 0x04038155 RID: 229717
			public const int LikeItemTemplate = 6;

			// Token: 0x04038156 RID: 229718
			public const int RoleName = 7;

			// Token: 0x04038157 RID: 229719
			public const int ConditionAcquaintance = 8;

			// Token: 0x04038158 RID: 229720
			public const int ConditionFamiliar = 9;

			// Token: 0x04038159 RID: 229721
			public const int ConditionClose = 10;

			// Token: 0x0403815A RID: 229722
			public const int ConditionBestFriend = 11;

			// Token: 0x0403815B RID: 229723
			public const int PnlLike = 12;
		}
	}
}
