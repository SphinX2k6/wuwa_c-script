using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DD1 RID: 19921
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CommonSelectItem : GridProxyAbstract<RogueGainEntry>
	{
		// Token: 0x060336A6 RID: 210598 RVA: 0x00C015A8 File Offset: 0x00BFF7A8
		public void SetClickCallBack(Action<CommonSelectItem> callback)
		{
			this.ClickCallBack = callback;
		}

		// Token: 0x060336A7 RID: 210599 RVA: 0x00C015B1 File Offset: 0x00BFF7B1
		protected override void OnStart()
		{
			this.GenericLayout = new GenericLayout<CommonElementItem, int>(base.GetHorizontalLayout(3), new Func<CommonElementItem>(this.CreateElement), null, false, true);
		}

		// Token: 0x060336A8 RID: 210600 RVA: 0x00C015D4 File Offset: 0x00BFF7D4
		private CommonElementItem CreateElement()
		{
			return new CommonElementItem();
		}

		// Token: 0x060336A9 RID: 210601 RVA: 0x00C015DB File Offset: 0x00BFF7DB
		public override void Refresh(RogueGainEntry data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x060336AA RID: 210602 RVA: 0x00C015E4 File Offset: 0x00BFF7E4
		public void Update(RogueGainEntry rogueGainEntry)
		{
			if (rogueGainEntry.RoguelikeGainDataType.GetValueOrDefault() != RoguelikeGainDataType.CommonBuff)
			{
				return;
			}
			this.RogueGainEntry = rogueGainEntry;
			this.InitData();
		}

		// Token: 0x060336AB RID: 210603 RVA: 0x00C01604 File Offset: 0x00BFF804
		private void InitData()
		{
			List<ElementInfo> sortElementInfoArrayByCount = this.RogueGainEntry.GetSortElementInfoArrayByCount(false);
			if (sortElementInfoArrayByCount.Count <= 0)
			{
				return;
			}
			this.ElementInfo = sortElementInfoArrayByCount[0];
			int[] data = Enumerable.Repeat<int>(this.ElementInfo.ElementId, this.ElementInfo.Count).ToArray<int>();
			this.GenericLayout.RefreshByDataAsync(data, false, null).ContinueWith(new Action(this.RefreshPanel));
		}

		// Token: 0x060336AC RID: 210604 RVA: 0x00C0167E File Offset: 0x00BFF87E
		public void SetToggleUnDetermined()
		{
			base.GetExtendToggle(5).SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
		}

		// Token: 0x060336AD RID: 210605 RVA: 0x00C01694 File Offset: 0x00BFF894
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

		// Token: 0x060336AE RID: 210606 RVA: 0x00C01844 File Offset: 0x00BFFA44
		private void SelfToggle(EToggleState state)
		{
			Action<CommonSelectItem> clickCallBack = this.ClickCallBack;
			if (clickCallBack == null)
			{
				return;
			}
			clickCallBack((state == EToggleState.ETT_Checked) ? this : null);
		}

		// Token: 0x060336AF RID: 210607 RVA: 0x00C0185E File Offset: 0x00BFFA5E
		public bool IsSelect()
		{
			return base.GetExtendToggle(5).GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x060336B0 RID: 210608 RVA: 0x00C0186F File Offset: 0x00BFFA6F
		public void RefreshPanel()
		{
			if (this.RogueGainEntry == null)
			{
				return;
			}
			this.RefreshCommon();
			this.RefreshCommonElementItem();
		}

		// Token: 0x060336B1 RID: 210609 RVA: 0x00C01888 File Offset: 0x00BFFA88
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

		// Token: 0x060336B2 RID: 210610 RVA: 0x00C01A10 File Offset: 0x00BFFC10
		private void RefreshCommonElementItem()
		{
			int[] data = Enumerable.Repeat<int>(this.ElementInfo.ElementId, this.ElementInfo.Count).ToArray<int>();
			GenericLayout<CommonElementItem, int> genericLayout = this.GenericLayout;
			if (genericLayout == null)
			{
				return;
			}
			genericLayout.RefreshByDataAsync(data, false, null);
		}

		// Token: 0x0401B4C4 RID: 111812
		public RogueGainEntry RogueGainEntry;

		// Token: 0x0401B4C5 RID: 111813
		private ElementInfo ElementInfo;

		// Token: 0x0401B4C6 RID: 111814
		private GenericLayout<CommonElementItem, int> GenericLayout;

		// Token: 0x0401B4C7 RID: 111815
		public Action<CommonSelectItem> ClickCallBack;

		// Token: 0x0200AF49 RID: 44873
		[NullableContext(0)]
		private class ECommonSelectItemCom
		{
			// Token: 0x0403538F RID: 217999
			public const int QualityBgTexture = 0;

			// Token: 0x04035390 RID: 218000
			public const int IconTexture = 1;

			// Token: 0x04035391 RID: 218001
			public const int NameText = 2;

			// Token: 0x04035392 RID: 218002
			public const int ElementLayout = 3;

			// Token: 0x04035393 RID: 218003
			public const int DescText = 4;

			// Token: 0x04035394 RID: 218004
			public const int SelfToggle = 5;

			// Token: 0x04035395 RID: 218005
			public const int NewItem = 6;

			// Token: 0x04035396 RID: 218006
			public const int QualityLineSprite = 7;

			// Token: 0x04035397 RID: 218007
			public const int GoldItem = 8;

			// Token: 0x04035398 RID: 218008
			public const int YellowItem = 9;
		}
	}
}
