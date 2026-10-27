using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Friend
{
	// Token: 0x02005A22 RID: 23074
	internal class TeamItem : UiPanelBase
	{
		// Token: 0x0603A88E RID: 239758 RVA: 0x00DEEBB5 File Offset: 0x00DECDB5
		[NullableContext(1)]
		public TeamItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0603A88F RID: 239759 RVA: 0x00DEEBCC File Offset: 0x00DECDCC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A890 RID: 239760 RVA: 0x00DEEC58 File Offset: 0x00DECE58
		[NullableContext(1)]
		public void RefreshView(FriendData data)
		{
			base.GetItem(1).SetUIActive(false);
			base.GetItem(2).SetUIActive(false);
			if (data.TeamMemberCount >= 2)
			{
				base.GetItem(1).SetUIActive(true);
			}
			if (data.TeamMemberCount >= 3)
			{
				base.GetItem(2).SetUIActive(true);
			}
		}

		// Token: 0x0200BC98 RID: 48280
		private class ETeamItemComponents
		{
			// Token: 0x04038E6D RID: 233069
			public const int TeamItem = 0;

			// Token: 0x04038E6E RID: 233070
			public const int TeamSecondItem = 1;

			// Token: 0x04038E6F RID: 233071
			public const int TeamThirdItem = 2;
		}
	}
}
