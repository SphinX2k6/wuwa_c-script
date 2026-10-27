using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Vision.View
{
	// Token: 0x020050FC RID: 20732
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeItem : UiPanelBase
	{
		// Token: 0x06034FF8 RID: 217080 RVA: 0x00C8D88B File Offset: 0x00C8BA8B
		public AttributeItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06034FF9 RID: 217081 RVA: 0x00C8D8A0 File Offset: 0x00C8BAA0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034FFA RID: 217082 RVA: 0x00C8D9AE File Offset: 0x00C8BBAE
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<AttributePhantomItem>(base.GetLayoutBase(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AttributePhantomItem>(this.InitItem), null);
		}

		// Token: 0x06034FFB RID: 217083 RVA: 0x00C8D9D0 File Offset: 0x00C8BBD0
		private ILayoutItem<AttributePhantomItem> InitItem(object data, UUIItem uiItem, int index)
		{
			AttributePhantomItem attributePhantomItem = new AttributePhantomItem(uiItem);
			attributePhantomItem.Update((int)data, this.CurrentFetter.Value);
			return new LayoutItem<AttributePhantomItem>
			{
				Key = index,
				Value = attributePhantomItem
			};
		}

		// Token: 0x06034FFC RID: 217084 RVA: 0x00C8DA13 File Offset: 0x00C8BC13
		protected override void OnBeforeDestroy()
		{
			this.Layout.ClearChildren();
		}

		// Token: 0x06034FFD RID: 217085 RVA: 0x00C8DA20 File Offset: 0x00C8BC20
		public void Update(VisionAttributeVariantTwoData data)
		{
			base.GetItem(3).SetUIActive(false);
			base.GetItem(4).SetUIActive(false);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			PhantomFetter phantomFetterById = PhantomBattleConfig.Instance.GetPhantomFetterById(data.FetterId);
			this.CurrentFetter = new PhantomFetter?(phantomFetterById);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), phantomFetterById.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), phantomFetterById.EffectDescription, phantomFetterById.EffectDescriptionParam());
			string hexStr = "AEAEABFF";
			if (data.State == EFetterCompare.Decrease)
			{
				hexStr = "D05656FF";
				base.GetItem(6).SetUIActive(true);
			}
			else if (data.State == EFetterCompare.Add)
			{
				hexStr = "87C583FF";
				base.GetItem(5).SetUIActive(true);
			}
			else
			{
				int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
				if (PhantomBattleController.Instance.CheckFetterActivate(data.FetterId, curSelectMainRoleId.GetValueOrDefault()))
				{
					hexStr = "87C583FF";
					base.GetItem(4).SetUIActive(true);
				}
				else
				{
					base.GetItem(3).SetUIActive(true);
				}
			}
			FColor color = FColor.FromHex(hexStr);
			base.GetText(0).SetColor(color);
			base.GetText(2).SetColor(color);
		}

		// Token: 0x0401C384 RID: 115588
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayoutNew<AttributePhantomItem> Layout;

		// Token: 0x0401C385 RID: 115589
		private PhantomFetter? CurrentFetter;

		// Token: 0x0200B256 RID: 45654
		[NullableContext(0)]
		private enum EAttributeItemComponent
		{
			// Token: 0x04036108 RID: 221448
			Title,
			// Token: 0x04036109 RID: 221449
			ItemLayout,
			// Token: 0x0403610A RID: 221450
			Desc,
			// Token: 0x0403610B RID: 221451
			StateItem1,
			// Token: 0x0403610C RID: 221452
			StateItem2,
			// Token: 0x0403610D RID: 221453
			StateItem3,
			// Token: 0x0403610E RID: 221454
			StateItem4
		}
	}
}
