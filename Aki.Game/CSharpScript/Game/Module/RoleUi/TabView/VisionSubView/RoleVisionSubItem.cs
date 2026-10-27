using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02004CF4 RID: 19700
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleVisionSubItem : RoleVisionCommonItem
	{
		// Token: 0x06032E6E RID: 208494 RVA: 0x00BDD09E File Offset: 0x00BDB29E
		[NullableContext(1)]
		public RoleVisionSubItem(UUIItem uiItem, EPhantomItemIndex index, [Nullable(2)] RoleDataBase roleData, bool needRedDot = false) : base(uiItem, index, roleData, needRedDot, false, ERoleViewSource.Normal)
		{
		}

		// Token: 0x06032E6F RID: 208495 RVA: 0x00BDD0AD File Offset: 0x00BDB2AD
		protected override UUIItem GetPlusItem()
		{
			return base.GetItem(8);
		}

		// Token: 0x06032E70 RID: 208496 RVA: 0x00BDD0B6 File Offset: 0x00BDB2B6
		protected override UUITexture GetVisionTextureComponent()
		{
			return base.GetTexture(3);
		}

		// Token: 0x06032E71 RID: 208497 RVA: 0x00BDD0BF File Offset: 0x00BDB2BF
		protected override UUISprite GetVisionQualitySprite()
		{
			return base.GetSprite(5);
		}

		// Token: 0x06032E72 RID: 208498 RVA: 0x00BDD0C8 File Offset: 0x00BDB2C8
		protected UUIText GetVisionLevelText()
		{
			return base.GetText(4);
		}

		// Token: 0x06032E73 RID: 208499 RVA: 0x00BDD0D1 File Offset: 0x00BDB2D1
		protected override UUIText GetVisionCostText()
		{
			return base.GetText(7);
		}

		// Token: 0x06032E74 RID: 208500 RVA: 0x00BDD0DA File Offset: 0x00BDB2DA
		protected override UUIItem GetVisionCostItem()
		{
			return base.GetItem(6);
		}

		// Token: 0x06032E75 RID: 208501 RVA: 0x00BDD0E3 File Offset: 0x00BDB2E3
		public override UUIDraggableComponent GetDragComponent()
		{
			return base.GetDraggable(2);
		}

		// Token: 0x06032E76 RID: 208502 RVA: 0x00BDD0EC File Offset: 0x00BDB2EC
		protected override UUIExtendToggle GetSelectToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06032E77 RID: 208503 RVA: 0x00BDD0F8 File Offset: 0x00BDB2F8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, base.OnClickVision)
			};
		}

		// Token: 0x06032E78 RID: 208504 RVA: 0x00BDD1F3 File Offset: 0x00BDB3F3
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x06032E79 RID: 208505 RVA: 0x00BDD212 File Offset: 0x00BDB412
		private bool CanExecuteChange()
		{
			return false;
		}

		// Token: 0x0200AE85 RID: 44677
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034FDA RID: 217050
			ToggleItem,
			// Token: 0x04034FDB RID: 217051
			BackSprite,
			// Token: 0x04034FDC RID: 217052
			CircleItem,
			// Token: 0x04034FDD RID: 217053
			CircleItemTexture,
			// Token: 0x04034FDE RID: 217054
			TextNum,
			// Token: 0x04034FDF RID: 217055
			QualitySprite,
			// Token: 0x04034FE0 RID: 217056
			CostItem,
			// Token: 0x04034FE1 RID: 217057
			CostNumText,
			// Token: 0x04034FE2 RID: 217058
			PlusItem
		}
	}
}
