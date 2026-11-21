using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.View.Components;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02004702 RID: 18178
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class GridItem : SyncGridProxyAbstract<GridItemCellData>
	{
		// Token: 0x0602DAD3 RID: 187091 RVA: 0x00CC5A4C File Offset: 0x00CC3C4C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DAD4 RID: 187092 RVA: 0x00CC5AB5 File Offset: 0x00CC3CB5
		protected override void OnStart()
		{
			this.GridItemInner.CreateThenShowByActor(base.GetItem(1).GetOwner());
		}

		// Token: 0x0602DAD5 RID: 187093 RVA: 0x00CC5AD0 File Offset: 0x00CC3CD0
		public override void Refresh(GridItemCellData data)
		{
			this.Data = data;
			this.OnClick = data.OnClick;
			if (data.Item.Type == EKurotatoCardType.None)
			{
				base.GetSprite(0).SetUIActive(true);
				base.GetItem(1).SetUIActive(false);
				return;
			}
			base.GetSprite(0).SetUIActive(false);
			base.GetItem(1).SetUIActive(true);
			this.GridItemInner.Refresh(data.Item);
			this.GridItemInner.BindCallback(delegate(IKurotatoSmallItemGridData d, EToggleState state, int gridIndex)
			{
				this.GridItemInner.SetSelected(false, false);
				Action onClick = this.OnClick;
				if (onClick == null)
				{
					return;
				}
				onClick();
			});
		}

		// Token: 0x040186DF RID: 100063
		public GridItemCellData Data;

		// Token: 0x040186E0 RID: 100064
		private readonly KurotatoWeaponSmallItemGrid GridItemInner = new KurotatoWeaponSmallItemGrid(false);

		// Token: 0x040186E1 RID: 100065
		[Nullable(2)]
		private Action OnClick;

		// Token: 0x0200A316 RID: 41750
		[NullableContext(0)]
		private class EGridComp
		{
			// Token: 0x04032928 RID: 207144
			public const int SpriteEmpty = 0;

			// Token: 0x04032929 RID: 207145
			public const int GridItem = 1;
		}
	}
}
