using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005997 RID: 22935
	public class SolarSchoolFavorPanel : UiPanelBase
	{
		// Token: 0x060388E7 RID: 231655 RVA: 0x00FD2CEC File Offset: 0x00FD0EEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnHelpClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060388E8 RID: 231656 RVA: 0x00FD2E7A File Offset: 0x00FD107A
		[NullableContext(1)]
		public void SetHelpCallback(Action<int> callback)
		{
			this.HelpCallback = callback;
		}

		// Token: 0x060388E9 RID: 231657 RVA: 0x00FD2E84 File Offset: 0x00FD1084
		public void SetRole(int roleId, bool showAffinityRedPoint)
		{
			this.RoleId = roleId;
			base.SetUiActive(roleId != 0);
			if (roleId == 0)
			{
				return;
			}
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(showAffinityRedPoint);
			}
			SolarSchoolFriendData friendData = SolarSchoolGamePlayModel.Instance.FriendData;
			bool flag = friendData.IsRoleUnlocked(roleId);
			bool flag2 = flag && friendData.IsFavorFrozen(roleId);
			bool flag3 = !flag || flag2;
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(flag3);
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(!flag3);
			}
			UUIItem item4 = base.GetItem(2);
			if (item4 != null)
			{
				item4.SetUIActive(!friendData.IsFavorLevelMaxed(roleId));
			}
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(friendData.GetFavorLevelText(roleId), true);
			}
			int favor = friendData.GetFavor(roleId);
			int currentLevelFavorCap = friendData.GetCurrentLevelFavorCap(roleId);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(4), "SolarSchool_HaoganNum", new <>z__ReadOnlyArray<object>(new object[]
			{
				favor,
				currentLevelFavorCap
			}));
			UUISliderComponent slider = base.GetSlider(3);
			if (slider != null)
			{
				slider.SetValue((currentLevelFavorCap <= 0) ? 0f : ((float)favor / (float)currentLevelFavorCap), false);
			}
			this.SetFavorStateIcon(roleId);
			this.SetFavorLevelIcon(roleId);
		}

		// Token: 0x060388EA RID: 231658 RVA: 0x00FD2FB8 File Offset: 0x00FD11B8
		private void SetFavorStateIcon(int roleId)
		{
			int favorLevel = SolarSchoolGamePlayModel.Instance.FriendData.GetFavorLevel(roleId);
			string text = (favorLevel > 0) ? SolarSchoolPopupData.GetFavorLevelIcon(favorLevel, ESolarSchoolFavorIconSize.Small) : string.Empty;
			if (!string.IsNullOrEmpty(text))
			{
				base.SetTextureByPath(text, base.GetTexture(8), null, null);
			}
		}

		// Token: 0x060388EB RID: 231659 RVA: 0x00FD300C File Offset: 0x00FD120C
		private void SetFavorLevelIcon(int roleId)
		{
			int favorLevel = SolarSchoolGamePlayModel.Instance.FriendData.GetFavorLevel(roleId);
			SolarSchoolRoleFavorLevel? roleFavorLevel = SolarSchoolConfig.Instance.GetRoleFavorLevel(roleId, favorLevel);
			string text = (roleFavorLevel != null) ? roleFavorLevel.GetValueOrDefault().IconPath : null;
			bool flag = !string.IsNullOrEmpty(text);
			UUITexture texture = base.GetTexture(8);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			if (flag)
			{
				base.SetTextureByPath(text, base.GetTexture(8), null, null);
			}
		}

		// Token: 0x060388EC RID: 231660 RVA: 0x00FD308D File Offset: 0x00FD128D
		private void OnHelpClick()
		{
			if (this.RoleId != 0)
			{
				Action<int> helpCallback = this.HelpCallback;
				if (helpCallback == null)
				{
					return;
				}
				helpCallback(this.RoleId);
			}
		}

		// Token: 0x0401DC99 RID: 122009
		[Nullable(2)]
		private Action<int> HelpCallback;

		// Token: 0x0401DC9A RID: 122010
		private int RoleId;

		// Token: 0x0200B540 RID: 46400
		private class EComponents
		{
			// Token: 0x040380A6 RID: 229542
			public const int BtnHelp = 0;

			// Token: 0x040380A7 RID: 229543
			public const int TxtName = 1;

			// Token: 0x040380A8 RID: 229544
			public const int PnlBar = 2;

			// Token: 0x040380A9 RID: 229545
			public const int SldFavor = 3;

			// Token: 0x040380AA RID: 229546
			public const int TxtValue = 4;

			// Token: 0x040380AB RID: 229547
			public const int PnlLock = 5;

			// Token: 0x040380AC RID: 229548
			public const int PnlAffinityRedPoint = 6;

			// Token: 0x040380AD RID: 229549
			public const int PnlUnlock = 7;

			// Token: 0x040380AE RID: 229550
			public const int TextureFavorLevelIcon = 8;
		}
	}
}
