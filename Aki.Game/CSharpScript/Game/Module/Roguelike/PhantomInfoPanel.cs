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
	// Token: 0x02003DB4 RID: 15796
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomInfoPanel : UiPanelBase
	{
		// Token: 0x06028605 RID: 165381 RVA: 0x00B505C8 File Offset: 0x00B4E7C8
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

		// Token: 0x06028606 RID: 165382 RVA: 0x00B50713 File Offset: 0x00B4E913
		private void DetailBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RoguePhantomSelectResultView, new RogueSelectResult(this.RogueGainEntry, null, null, false), null);
		}

		// Token: 0x06028607 RID: 165383 RVA: 0x00B50733 File Offset: 0x00B4E933
		protected override void OnStart()
		{
			this.PhantomEntryItemLayout = new GenericLayout<PhantomEntryItem, AffixEntry>(base.GetVerticalLayout(3), new Func<PhantomEntryItem>(this.CreatePhantomEntryItem), null, false, true);
		}

		// Token: 0x06028608 RID: 165384 RVA: 0x00B50756 File Offset: 0x00B4E956
		protected PhantomEntryItem CreatePhantomEntryItem()
		{
			return new PhantomEntryItem();
		}

		// Token: 0x06028609 RID: 165385 RVA: 0x00B5075D File Offset: 0x00B4E95D
		public void Update(RogueGainEntry rogueGainEntry)
		{
			this.RogueGainEntry = rogueGainEntry;
		}

		// Token: 0x0602860A RID: 165386 RVA: 0x00B50766 File Offset: 0x00B4E966
		public void Refresh()
		{
			this.RefreshPhantom();
			this.RefreshPhantomEntryItemLayout();
		}

		// Token: 0x0602860B RID: 165387 RVA: 0x00B50774 File Offset: 0x00B4E974
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

		// Token: 0x0602860C RID: 165388 RVA: 0x00B50788 File Offset: 0x00B4E988
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

		// Token: 0x0602860D RID: 165389 RVA: 0x00B50867 File Offset: 0x00B4EA67
		private void RefreshPhantomEntryItemLayout()
		{
			this.PhantomEntryItemLayout.RefreshByData(this.RogueGainEntry.AffixEntryList ?? new List<AffixEntry>(), null, false);
		}

		// Token: 0x0602860E RID: 165390 RVA: 0x00B5088C File Offset: 0x00B4EA8C
		[NullableContext(2)]
		public void RefreshPhantomEntryItemRefreshPreview(Dictionary<int, int> elementDict = null)
		{
			foreach (PhantomEntryItem phantomEntryItem in this.PhantomEntryItemLayout.GetLayoutItemList())
			{
				phantomEntryItem.RefreshPreview(elementDict);
			}
		}

		// Token: 0x04015EFA RID: 89850
		private RogueGainEntry RogueGainEntry;

		// Token: 0x04015EFB RID: 89851
		private GenericLayout<PhantomEntryItem, AffixEntry> PhantomEntryItemLayout;

		// Token: 0x020099A6 RID: 39334
		[NullableContext(0)]
		private class EPhantomInfoPanelCom
		{
			// Token: 0x0402FE89 RID: 196233
			public const int QualityHeadTexture = 0;

			// Token: 0x0402FE8A RID: 196234
			public const int HeadIconTexture = 1;

			// Token: 0x0402FE8B RID: 196235
			public const int PhantomNameText = 2;

			// Token: 0x0402FE8C RID: 196236
			public const int PhantomAttrItemLayout = 3;

			// Token: 0x0402FE8D RID: 196237
			public const int PhantomAttrItem = 4;

			// Token: 0x0402FE8E RID: 196238
			public const int DetailBtn = 5;

			// Token: 0x0402FE8F RID: 196239
			public const int QualityHeadTextureB = 6;
		}
	}
}
