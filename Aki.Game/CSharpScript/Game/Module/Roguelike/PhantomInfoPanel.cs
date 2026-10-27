using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DEB RID: 19947
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomInfoPanel : UiPanelBase
	{
		// Token: 0x0603379A RID: 210842 RVA: 0x00C070B8 File Offset: 0x00C052B8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.DetailBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603379B RID: 210843 RVA: 0x00C07203 File Offset: 0x00C05403
		private void DetailBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguePhantomSelectResultView, new RogueSelectResult(this.RogueGainEntry, null, null, false), null);
		}

		// Token: 0x0603379C RID: 210844 RVA: 0x00C07223 File Offset: 0x00C05423
		protected override void OnStart()
		{
			this.PhantomEntryItemLayout = new GenericLayout<PhantomEntryItem, AffixEntry>(base.GetVerticalLayout(3), new Func<PhantomEntryItem>(this.CreatePhantomEntryItem), null, false, true);
		}

		// Token: 0x0603379D RID: 210845 RVA: 0x00C07246 File Offset: 0x00C05446
		protected PhantomEntryItem CreatePhantomEntryItem()
		{
			return new PhantomEntryItem();
		}

		// Token: 0x0603379E RID: 210846 RVA: 0x00C0724D File Offset: 0x00C0544D
		public void Update(RogueGainEntry rogueGainEntry)
		{
			this.RogueGainEntry = rogueGainEntry;
		}

		// Token: 0x0603379F RID: 210847 RVA: 0x00C07256 File Offset: 0x00C05456
		public void Refresh()
		{
			this.RefreshPhantom();
			this.RefreshPhantomEntryItemLayout();
		}

		// Token: 0x060337A0 RID: 210848 RVA: 0x00C07264 File Offset: 0x00C05464
		[NullableContext(2)]
		public UUIItem GetAttributeItem(int index)
		{
			GenericLayout<PhantomEntryItem, AffixEntry> phantomEntryItemLayout = this.PhantomEntryItemLayout;
			if (phantomEntryItemLayout == null)
			{
				return null;
			}
			return phantomEntryItemLayout.GetItemByIndex(index);
		}

		// Token: 0x060337A1 RID: 210849 RVA: 0x00C07278 File Offset: 0x00C05478
		private void RefreshPhantom()
		{
			RoguePokemon? roguePhantomConfig = RoguelikeConfig.Instance.GetRoguePhantomConfig(this.RogueGainEntry.ConfigId);
			if (roguePhantomConfig == null)
			{
				return;
			}
			base.GetText(2).ShowTextNew(roguePhantomConfig.Value.PokemonName);
			base.SetTextureByPath(roguePhantomConfig.Value.PokemonIcon, base.GetTexture(1), null, null);
			RogueQualityConfig? rogueQualityConfigByQualityId = RoguelikeConfig.Instance.GetRogueQualityConfigByQualityId(roguePhantomConfig.Value.Quality);
			if (rogueQualityConfigByQualityId != null)
			{
				base.SetTextureByPath(rogueQualityConfigByQualityId.Value.PhantomBgC, base.GetTexture(0), null, null);
				base.SetTextureByPath(rogueQualityConfigByQualityId.Value.PhantomBgB, base.GetTexture(6), null, null);
			}
		}

		// Token: 0x060337A2 RID: 210850 RVA: 0x00C07357 File Offset: 0x00C05557
		private void RefreshPhantomEntryItemLayout()
		{
			this.PhantomEntryItemLayout.RefreshByData(this.RogueGainEntry.AffixEntryList ?? new List<AffixEntry>(), null, false);
		}

		// Token: 0x060337A3 RID: 210851 RVA: 0x00C0737C File Offset: 0x00C0557C
		[NullableContext(2)]
		public void RefreshPhantomEntryItemRefreshPreview(Dictionary<int, int> elementDict = null)
		{
			foreach (PhantomEntryItem phantomEntryItem in this.PhantomEntryItemLayout.GetLayoutItemList())
			{
				phantomEntryItem.RefreshPreview(elementDict);
			}
		}

		// Token: 0x0401B527 RID: 111911
		private RogueGainEntry RogueGainEntry;

		// Token: 0x0401B528 RID: 111912
		private GenericLayout<PhantomEntryItem, AffixEntry> PhantomEntryItemLayout;

		// Token: 0x0200AF71 RID: 44913
		[NullableContext(0)]
		private class EPhantomInfoPanelCom
		{
			// Token: 0x04035456 RID: 218198
			public const int QualityHeadTexture = 0;

			// Token: 0x04035457 RID: 218199
			public const int HeadIconTexture = 1;

			// Token: 0x04035458 RID: 218200
			public const int PhantomNameText = 2;

			// Token: 0x04035459 RID: 218201
			public const int PhantomAttrItemLayout = 3;

			// Token: 0x0403545A RID: 218202
			public const int PhantomAttrItem = 4;

			// Token: 0x0403545B RID: 218203
			public const int DetailBtn = 5;

			// Token: 0x0403545C RID: 218204
			public const int QualityHeadTextureB = 6;
		}
	}
}
