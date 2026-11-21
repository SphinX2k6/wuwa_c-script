using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005748 RID: 22344
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlViewCost : UiPanelBase
	{
		// Token: 0x17006A64 RID: 27236
		// (get) Token: 0x06037151 RID: 225617 RVA: 0x00F5F917 File Offset: 0x00F5DB17
		private UUIText TextWeight
		{
			get
			{
				return base.GetText(1);
			}
		}

		// Token: 0x17006A65 RID: 27237
		// (get) Token: 0x06037152 RID: 225618 RVA: 0x00F5F920 File Offset: 0x00F5DB20
		private UUISprite SprWeight
		{
			get
			{
				return base.GetSprite(0);
			}
		}

		// Token: 0x17006A66 RID: 27238
		// (get) Token: 0x06037153 RID: 225619 RVA: 0x00F5F929 File Offset: 0x00F5DB29
		private UUISprite SprWeightRed
		{
			get
			{
				return base.GetSprite(2);
			}
		}

		// Token: 0x06037154 RID: 225620 RVA: 0x00F5F934 File Offset: 0x00F5DB34
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

		// Token: 0x06037155 RID: 225621 RVA: 0x00F5F9BE File Offset: 0x00F5DBBE
		public void BindData(int configId)
		{
			this.ConfigId = configId;
			this.ItemType = DangoBrawlConfig.Instance.GetItemConfigTypeById(this.ConfigId);
			this.RefreshView();
		}

		// Token: 0x06037156 RID: 225622 RVA: 0x00F5F9E3 File Offset: 0x00F5DBE3
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

		// Token: 0x06037157 RID: 225623 RVA: 0x00F5FA0C File Offset: 0x00F5DC0C
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

		// Token: 0x06037158 RID: 225624 RVA: 0x00F5FA64 File Offset: 0x00F5DC64
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

		// Token: 0x0401D20B RID: 119307
		private int ConfigId = -1;

		// Token: 0x0401D20C RID: 119308
		private EDangoBrawlItemType ItemType = EDangoBrawlItemType.Bag;

		// Token: 0x0200B32E RID: 45870
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040375DD RID: 226781
			SprWeight,
			// Token: 0x040375DE RID: 226782
			TextWeight,
			// Token: 0x040375DF RID: 226783
			SprRedWeight
		}
	}
}
