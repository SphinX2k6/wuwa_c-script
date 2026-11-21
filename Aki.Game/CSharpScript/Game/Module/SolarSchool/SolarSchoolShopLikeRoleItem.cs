using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A09 RID: 23049
	public sealed class SolarSchoolShopLikeRoleItem : GridProxyAbstract<int>
	{
		// Token: 0x06038C0D RID: 232461 RVA: 0x00FE2908 File Offset: 0x00FE0B08
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038C0E RID: 232462 RVA: 0x00FE29B4 File Offset: 0x00FE0BB4
		public override void Refresh(int roleId, bool isSelected, int gridIndex)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetSelfInteractive(false);
			}
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			int favorLevel = SolarSchoolGamePlayModel.Instance.FriendData.GetFavorLevel(roleId);
			string text = (favorLevel > 0) ? SolarSchoolPopupData.GetFavorLevelIcon(favorLevel, ESolarSchoolFavorIconSize.Small) : string.Empty;
			bool flag = !string.IsNullOrEmpty(text);
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			if (flag)
			{
				base.SetTextureByPath(text, base.GetTexture(2), null, null);
			}
			SolarSchoolRole? role = SolarSchoolConfig.Instance.GetRole(roleId);
			bool flag2 = role != null && !string.IsNullOrEmpty(role.Value.HeadIcon);
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 != null)
			{
				texture2.SetUIActive(flag2);
			}
			if (flag2)
			{
				base.SetTextureByPath(role.Value.HeadIcon, base.GetTexture(1), null, null);
			}
		}

		// Token: 0x06038C0F RID: 232463 RVA: 0x00FE2AC6 File Offset: 0x00FE0CC6
		[NullableContext(1)]
		public override object GetKey(int roleId, int displayIndex)
		{
			return roleId;
		}

		// Token: 0x0200B5B9 RID: 46521
		private static class EComponent
		{
			// Token: 0x04038318 RID: 230168
			public const int Toggle = 0;

			// Token: 0x04038319 RID: 230169
			public const int RoleHead = 1;

			// Token: 0x0403831A RID: 230170
			public const int FavorState = 2;

			// Token: 0x0403831B RID: 230171
			public const int RedDot = 3;
		}
	}
}
