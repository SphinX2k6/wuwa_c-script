using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Kurotato.View.Components;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x0200572B RID: 22315
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class GridItem : SyncGridProxyAbstract<GridItemCellData>
	{
		// Token: 0x06038BC3 RID: 232387 RVA: 0x00D773A0 File Offset: 0x00D755A0
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

		// Token: 0x06038BC4 RID: 232388 RVA: 0x00D77409 File Offset: 0x00D75609
		protected override void OnStart()
		{
			this.GridItemInner.CreateThenShowByActor(base.GetItem(1).GetOwner());
		}

		// Token: 0x06038BC5 RID: 232389 RVA: 0x00D77424 File Offset: 0x00D75624
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

		// Token: 0x0401DC49 RID: 121929
		public GridItemCellData Data;

		// Token: 0x0401DC4A RID: 121930
		private readonly KurotatoWeaponSmallItemGrid GridItemInner = new KurotatoWeaponSmallItemGrid(false);

		// Token: 0x0401DC4B RID: 121931
		[Nullable(2)]
		private Action OnClick;

		// Token: 0x0200B8F5 RID: 47349
		[NullableContext(0)]
		private class EGridComp
		{
			// Token: 0x04037F18 RID: 229144
			public const int SpriteEmpty = 0;

			// Token: 0x04037F19 RID: 229145
			public const int GridItem = 1;
		}
	}
}
