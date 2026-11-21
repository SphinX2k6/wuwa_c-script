using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Friend
{
	// Token: 0x020049FE RID: 18942
	internal class TeamItem : UiPanelBase
	{
		// Token: 0x0602F7D7 RID: 194519 RVA: 0x00D3F139 File Offset: 0x00D3D339
		[NullableContext(1)]
		public TeamItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x0602F7D8 RID: 194520 RVA: 0x00D3F150 File Offset: 0x00D3D350
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

		// Token: 0x0602F7D9 RID: 194521 RVA: 0x00D3F1DC File Offset: 0x00D3D3DC
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

		// Token: 0x0200A6A1 RID: 42657
		private class ETeamItemComponents
		{
			// Token: 0x04033838 RID: 211000
			public const int TeamItem = 0;

			// Token: 0x04033839 RID: 211001
			public const int TeamSecondItem = 1;

			// Token: 0x0403383A RID: 211002
			public const int TeamThirdItem = 2;
		}
	}
}
