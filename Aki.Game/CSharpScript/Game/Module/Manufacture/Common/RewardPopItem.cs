using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x0200569D RID: 22173
	public class RewardPopItem : UiPanelBase
	{
		// Token: 0x060386CB RID: 231115 RVA: 0x00D6582E File Offset: 0x00D63A2E
		[NullableContext(1)]
		public RewardPopItem(UUIItem uiItem)
		{
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
		}

		// Token: 0x060386CC RID: 231116 RVA: 0x00D65844 File Offset: 0x00D63A44
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060386CD RID: 231117 RVA: 0x00D6592E File Offset: 0x00D63B2E
		[NullableContext(1)]
		public void Update(ICommonPopItemData data)
		{
			this.ItemData = data;
			this.SetIcon();
			this.SetQuality();
			this.SetCount();
		}

		// Token: 0x060386CE RID: 231118 RVA: 0x00D6594C File Offset: 0x00D63B4C
		private void SetIcon()
		{
			base.SetItemIcon(base.GetTexture(4), this.ItemData.ItemId, null, null);
		}

		// Token: 0x060386CF RID: 231119 RVA: 0x00D6597C File Offset: 0x00D63B7C
		private void SetQuality()
		{
			base.SetItemQualityIcon(base.GetSprite(5), this.ItemData.ItemId, null, CommonDefine.EQualityIconType.BackgroundSprite, null);
		}

		// Token: 0x060386D0 RID: 231120 RVA: 0x00D659AC File Offset: 0x00D63BAC
		private void SetCount()
		{
			base.GetText(8).SetText(this.ItemData.ItemNum.ToString(), true);
		}

		// Token: 0x060386D1 RID: 231121 RVA: 0x00D659D9 File Offset: 0x00D63BD9
		private void OnClick()
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemData.ItemId, true, null);
		}

		// Token: 0x0401DA2D RID: 121389
		[Nullable(2)]
		private ICommonPopItemData ItemData;

		// Token: 0x0200B861 RID: 47201
		private class ECommonPopItemDefine
		{
			// Token: 0x04037CEC RID: 228588
			public const int IconTexture = 4;

			// Token: 0x04037CED RID: 228589
			public const int QualitySprite = 5;

			// Token: 0x04037CEE RID: 228590
			public const int NumText = 8;

			// Token: 0x04037CEF RID: 228591
			public const int ItemButton = 9;
		}
	}
}
