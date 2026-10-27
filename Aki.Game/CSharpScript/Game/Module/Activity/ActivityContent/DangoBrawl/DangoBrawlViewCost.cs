using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067F8 RID: 26616
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlViewCost : UiPanelBase
	{
		// Token: 0x17009723 RID: 38691
		// (get) Token: 0x060425FC RID: 271868 RVA: 0x0101E3D3 File Offset: 0x0101C5D3
		private UUIText TextWeight
		{
			get
			{
				return base.GetText(1);
			}
		}

		// Token: 0x17009724 RID: 38692
		// (get) Token: 0x060425FD RID: 271869 RVA: 0x0101E3DC File Offset: 0x0101C5DC
		private UUISprite SprWeight
		{
			get
			{
				return base.GetSprite(0);
			}
		}

		// Token: 0x17009725 RID: 38693
		// (get) Token: 0x060425FE RID: 271870 RVA: 0x0101E3E5 File Offset: 0x0101C5E5
		private UUISprite SprWeightRed
		{
			get
			{
				return base.GetSprite(2);
			}
		}

		// Token: 0x060425FF RID: 271871 RVA: 0x0101E3F0 File Offset: 0x0101C5F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06042600 RID: 271872 RVA: 0x0101E47A File Offset: 0x0101C67A
		public void BindData(int configId)
		{
			this.ConfigId = configId;
			this.ItemType = DangoBrawlConfig.Instance.GetItemConfigTypeById(this.ConfigId);
			this.RefreshView();
		}

		// Token: 0x06042601 RID: 271873 RVA: 0x0101E49F File Offset: 0x0101C69F
		public void RefreshView()
		{
			if (this.ConfigId <= 0 || this.ItemType != EDangoBrawlItemType.Weapon)
			{
				base.SetUiActive(false);
				return;
			}
			this.RefreshWeightText();
			base.SetUiActive(true);
		}

		// Token: 0x06042602 RID: 271874 RVA: 0x0101E4C8 File Offset: 0x0101C6C8
		public void RefreshOverLimitView(bool isOverLimit)
		{
			UUIText textWeight = this.TextWeight;
			if (textWeight != null)
			{
				textWeight.SetFontOutlineColor(FColor.FromHex(isOverLimit ? "#822631" : "#155F8E"));
			}
			UUISprite sprWeight = this.SprWeight;
			if (sprWeight != null)
			{
				sprWeight.SetUIActive(!isOverLimit);
			}
			UUISprite sprWeightRed = this.SprWeightRed;
			if (sprWeightRed == null)
			{
				return;
			}
			sprWeightRed.SetUIActive(isOverLimit);
		}

		// Token: 0x06042603 RID: 271875 RVA: 0x0101E520 File Offset: 0x0101C720
		private void RefreshWeightText()
		{
			DangoBrawlItem? dangoBrawlItemById = DangoBrawlConfig.Instance.GetDangoBrawlItemById(this.ConfigId);
			if (dangoBrawlItemById == null)
			{
				return;
			}
			UUIText textWeight = this.TextWeight;
			if (textWeight == null)
			{
				return;
			}
			textWeight.SetText(dangoBrawlItemById.Value.Cost.ToString(), true);
		}

		// Token: 0x040229AE RID: 141742
		private int ConfigId = -1;

		// Token: 0x040229AF RID: 141743
		private EDangoBrawlItemType ItemType = EDangoBrawlItemType.Bag;

		// Token: 0x0200C961 RID: 51553
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CCF0 RID: 249072
			SprWeight,
			// Token: 0x0403CCF1 RID: 249073
			TextWeight,
			// Token: 0x0403CCF2 RID: 249074
			SprRedWeight
		}
	}
}
