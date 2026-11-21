using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.SmallItemGrid
{
	// Token: 0x02004B2A RID: 19242
	public class SmallItemGridWeaponResonanceLevelComponent : SmallItemGridComponent
	{
		// Token: 0x06030206 RID: 197126 RVA: 0x00D6C0E0 File Offset: 0x00D6A2E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030207 RID: 197127 RVA: 0x00D6C128 File Offset: 0x00D6A328
		[NullableContext(1)]
		protected override string GetResourceId()
		{
			return "UiItem_ItemRoleDevRank";
		}

		// Token: 0x06030208 RID: 197128 RVA: 0x00D6C12F File Offset: 0x00D6A32F
		public override EItemGridComponentLayoutLevel GetLayoutLevel()
		{
			return EItemGridComponentLayoutLevel.Bottom;
		}

		// Token: 0x06030209 RID: 197129 RVA: 0x00D6C134 File Offset: 0x00D6A334
		[NullableContext(2)]
		protected override void OnRefresh(object level)
		{
			if (!(level is int))
			{
				this.SetActive(false);
				return;
			}
			int num = (int)level;
			this.SetActive(true);
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(num.ToString(), true);
		}

		// Token: 0x0200A781 RID: 42881
		private enum EChildType
		{
			// Token: 0x04033C3A RID: 212026
			LevelText
		}
	}
}
