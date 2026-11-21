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
	// Token: 0x020040CC RID: 16588
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeItem : UiPanelBase
	{
		// Token: 0x06029EF1 RID: 171761 RVA: 0x00BDAB67 File Offset: 0x00BD8D67
		public AttributeItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x06029EF2 RID: 171762 RVA: 0x00BDAB7C File Offset: 0x00BD8D7C
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

		// Token: 0x06029EF3 RID: 171763 RVA: 0x00BDAC8A File Offset: 0x00BD8E8A
		protected override void OnStart()
		{
			this.Layout = new GenericLayoutNew<AttributePhantomItem>(base.GetLayoutBase(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AttributePhantomItem>(this.InitItem), null);
		}

		// Token: 0x06029EF4 RID: 171764 RVA: 0x00BDACAC File Offset: 0x00BD8EAC
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

		// Token: 0x06029EF5 RID: 171765 RVA: 0x00BDACEF File Offset: 0x00BD8EEF
		protected override void OnBeforeDestroy()
		{
			this.Layout.ClearChildren();
		}

		// Token: 0x06029EF6 RID: 171766 RVA: 0x00BDACFC File Offset: 0x00BD8EFC
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

		// Token: 0x04016DB7 RID: 93623
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayoutNew<AttributePhantomItem> Layout;

		// Token: 0x04016DB8 RID: 93624
		private PhantomFetter? CurrentFetter;

		// Token: 0x02009C8F RID: 40079
		[NullableContext(0)]
		private enum EAttributeItemComponent
		{
			// Token: 0x04030B5D RID: 199517
			Title,
			// Token: 0x04030B5E RID: 199518
			ItemLayout,
			// Token: 0x04030B5F RID: 199519
			Desc,
			// Token: 0x04030B60 RID: 199520
			StateItem1,
			// Token: 0x04030B61 RID: 199521
			StateItem2,
			// Token: 0x04030B62 RID: 199522
			StateItem3,
			// Token: 0x04030B63 RID: 199523
			StateItem4
		}
	}
}
