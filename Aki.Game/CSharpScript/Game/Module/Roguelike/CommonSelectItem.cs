using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D9A RID: 15770
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CommonSelectItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x06028513 RID: 165139 RVA: 0x00B4AAE8 File Offset: 0x00B48CE8
		public void SetClickCallBack(Action<CommonSelectItem> callback)
		{
			this.ClickCallBack = callback;
		}

		// Token: 0x06028514 RID: 165140 RVA: 0x00B4AAF1 File Offset: 0x00B48CF1
		protected override void OnStart()
		{
			this.GenericLayout = new GenericLayout<CommonElementItem, int>(base.GetHorizontalLayout(3), new Func<CommonElementItem>(this.CreateElement), null, false, true);
		}

		// Token: 0x06028515 RID: 165141 RVA: 0x00B4AB14 File Offset: 0x00B48D14
		private CommonElementItem CreateElement()
		{
			return new CommonElementItem();
		}

		// Token: 0x06028516 RID: 165142 RVA: 0x00B4AB1B File Offset: 0x00B48D1B
		public override void Refresh(RogueGainEntry data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x06028517 RID: 165143 RVA: 0x00B4AB24 File Offset: 0x00B48D24
		public void Update(RogueGainEntry rogueGainEntry)
		{
			if (rogueGainEntry.RoguelikeGainDataType.GetValueOrDefault() != RoguelikeGainDataType.CommonBuff)
			{
				return;
			}
			this.RogueGainEntry = rogueGainEntry;
			this.InitData();
		}

		// Token: 0x06028518 RID: 165144 RVA: 0x00B4AB44 File Offset: 0x00B48D44
		private void InitData()
		{
			List<ElementInfo> sortElementInfoArrayByCount = this.RogueGainEntry.GetSortElementInfoArrayByCount(false);
			if (sortElementInfoArrayByCount.Count <= 0)
			{
				return;
			}
			this.ElementInfo = sortElementInfoArrayByCount[0];
			int[] array = new int[this.ElementInfo.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this.ElementInfo.ElementId;
			}
			this.GenericLayout.RefreshByDataAsync(array, false, null).ContinueWith(new Action(this.RefreshPanel));
		}

		// Token: 0x06028519 RID: 165145 RVA: 0x00B4ABCA File Offset: 0x00B48DCA
		public void SetToggleUnDetermined()
		{
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		}

		// Token: 0x0602851A RID: 165146 RVA: 0x00B4ABE0 File Offset: 0x00B48DE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(this.SelfToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602851B RID: 165147 RVA: 0x00B4AD90 File Offset: 0x00B48F90
		private void SelfToggle(EToggleState state)
		{
			Action<CommonSelectItem> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack((state == EToggleState.ETT_Checked) ? this : null);
		}

		// Token: 0x0602851C RID: 165148 RVA: 0x00B4ADAA File Offset: 0x00B48FAA
		public bool IsSelect()
		{
			return base.GetExtendToggle(5).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x0602851D RID: 165149 RVA: 0x00B4ADBB File Offset: 0x00B48FBB
		public void RefreshPanel()
		{
			if (this.RogueGainEntry == null)
			{
				return;
			}
			this.RefreshCommon();
			this.RefreshCommonElementItem();
		}

		// Token: 0x0602851E RID: 165150 RVA: 0x00B4ADD4 File Offset: 0x00B48FD4
		private void RefreshCommon()
		{
			base.GetItem(6).SetUIActive(this.RogueGainEntry.IsNew);
			RogueBuffPool? rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(this.RogueGainEntry.ConfigId);
			if (rogueBuffConfig == null)
			{
				return;
			}
			base.GetText(2).ShowTextNew(rogueBuffConfig.Value.BuffName);
			if (RoguelikeModel.Instance.GetDescModel() == EDescModel.SIMPLE)
			{
				base.GetText(4).ShowTextNew(rogueBuffConfig.Value.BuffDescSimple);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), rogueBuffConfig.Value.BuffDesc, rogueBuffConfig.Value.BuffDescParam());
			}
			base.SetTextureByPath(rogueBuffConfig.Value.BuffIcon, base.GetTexture(1), null, null);
			RogueQualityConfig? rogueQualityConfigByQualityId = RoguelikeConfig.Instance.GetRogueQualityConfigByQualityId(rogueBuffConfig.Value.Quality);
			if (rogueQualityConfigByQualityId != null)
			{
				base.SetTextureByPath(rogueQualityConfigByQualityId.Value.TokenBg, base.GetTexture(0), null, null);
			}
			base.GetSprite(7).SetColor(FColor.FromHex(rogueQualityConfigByQualityId.Value.TokenColor));
			base.GetItem(9).SetUIActive(rogueBuffConfig.Value.Quality == 5);
			base.GetItem(8).SetUIActive(rogueBuffConfig.Value.Quality == 6);
		}

		// Token: 0x0602851F RID: 165151 RVA: 0x00B4AF5C File Offset: 0x00B4915C
		private void RefreshCommonElementItem()
		{
			int[] array = new int[this.ElementInfo.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this.ElementInfo.ElementId;
			}
			GenericLayout<CommonElementItem, int> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return;
			}
			genericLayout.RefreshByDataAsync(array, false, null);
		}

		// Token: 0x04015E97 RID: 89751
		public RogueGainEntry RogueGainEntry;

		// Token: 0x04015E98 RID: 89752
		private ElementInfo ElementInfo;

		// Token: 0x04015E99 RID: 89753
		private GenericLayout<CommonElementItem, int> GenericLayout;

		// Token: 0x04015E9A RID: 89754
		public Action<CommonSelectItem> ClickCallBack;

		// Token: 0x0200997E RID: 39294
		[NullableContext(0)]
		private class ECommonSelectItemCom
		{
			// Token: 0x0402FDC4 RID: 196036
			public const int QualityBgTexture = 0;

			// Token: 0x0402FDC5 RID: 196037
			public const int IconTexture = 1;

			// Token: 0x0402FDC6 RID: 196038
			public const int NameText = 2;

			// Token: 0x0402FDC7 RID: 196039
			public const int ElementLayout = 3;

			// Token: 0x0402FDC8 RID: 196040
			public const int DescText = 4;

			// Token: 0x0402FDC9 RID: 196041
			public const int SelfToggle = 5;

			// Token: 0x0402FDCA RID: 196042
			public const int NewItem = 6;

			// Token: 0x0402FDCB RID: 196043
			public const int QualityLineSprite = 7;

			// Token: 0x0402FDCC RID: 196044
			public const int GoldItem = 8;

			// Token: 0x0402FDCD RID: 196045
			public const int YellowItem = 9;
		}
	}
}
