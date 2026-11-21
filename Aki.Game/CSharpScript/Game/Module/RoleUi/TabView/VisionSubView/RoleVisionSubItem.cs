using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.TabView.VisionSubView
{
	// Token: 0x02003CA6 RID: 15526
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleVisionSubItem : RoleVisionCommonItem
	{
		// Token: 0x06027C49 RID: 162889 RVA: 0x00B229A6 File Offset: 0x00B20BA6
		[NullableContext(1)]
		public RoleVisionSubItem(UUIItem uiItem, EPhantomItemIndex index, [Nullable(2)] RoleDataBase roleData, bool needRedDot = false) : base(uiItem, index, roleData, needRedDot, false, ERoleViewSource.Normal)
		{
		}

		// Token: 0x06027C4A RID: 162890 RVA: 0x00B229B5 File Offset: 0x00B20BB5
		protected override UUIItem GetPlusItem()
		{
			return base.GetItem(8);
		}

		// Token: 0x06027C4B RID: 162891 RVA: 0x00B229BE File Offset: 0x00B20BBE
		protected override UUITexture GetVisionTextureComponent()
		{
			return base.GetTexture(3);
		}

		// Token: 0x06027C4C RID: 162892 RVA: 0x00B229C7 File Offset: 0x00B20BC7
		protected override UUISprite GetVisionQualitySprite()
		{
			return base.GetSprite(5);
		}

		// Token: 0x06027C4D RID: 162893 RVA: 0x00B229D0 File Offset: 0x00B20BD0
		protected UUIText GetVisionLevelText()
		{
			return base.GetText(4);
		}

		// Token: 0x06027C4E RID: 162894 RVA: 0x00B229D9 File Offset: 0x00B20BD9
		protected override UUIText GetVisionCostText()
		{
			return base.GetText(7);
		}

		// Token: 0x06027C4F RID: 162895 RVA: 0x00B229E2 File Offset: 0x00B20BE2
		protected override UUIItem GetVisionCostItem()
		{
			return base.GetItem(6);
		}

		// Token: 0x06027C50 RID: 162896 RVA: 0x00B229EB File Offset: 0x00B20BEB
		public override UUIDraggableComponent GetDragComponent()
		{
			return base.GetDraggable(2);
		}

		// Token: 0x06027C51 RID: 162897 RVA: 0x00B229F4 File Offset: 0x00B20BF4
		protected override UUIExtendToggle GetSelectToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06027C52 RID: 162898 RVA: 0x00B22A00 File Offset: 0x00B20C00
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

		// Token: 0x06027C53 RID: 162899 RVA: 0x00B22AFB File Offset: 0x00B20CFB
		protected override void OnStart()
		{
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
		}

		// Token: 0x06027C54 RID: 162900 RVA: 0x00B22B1A File Offset: 0x00B20D1A
		private bool CanExecuteChange()
		{
			return false;
		}

		// Token: 0x020098A3 RID: 39075
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0402F982 RID: 194946
			ToggleItem,
			// Token: 0x0402F983 RID: 194947
			BackSprite,
			// Token: 0x0402F984 RID: 194948
			CircleItem,
			// Token: 0x0402F985 RID: 194949
			CircleItemTexture,
			// Token: 0x0402F986 RID: 194950
			TextNum,
			// Token: 0x0402F987 RID: 194951
			QualitySprite,
			// Token: 0x0402F988 RID: 194952
			CostItem,
			// Token: 0x0402F989 RID: 194953
			CostNumText,
			// Token: 0x0402F98A RID: 194954
			PlusItem
		}
	}
}
