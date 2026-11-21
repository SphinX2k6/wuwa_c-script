using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DB1 RID: 15793
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomAttrItem : GridProxyAbstract<IPhantomAttrItemData>
	{
		// Token: 0x060285EB RID: 165355 RVA: 0x00B4FAD9 File Offset: 0x00B4DCD9
		public void Update(IPhantomAttrItemData data)
		{
			this.AffixEntry = data.AffixEntry;
			this.RoguelikeInfo = data.RoguelikeInfo;
			this.RefreshPanel();
		}

		// Token: 0x060285EC RID: 165356 RVA: 0x00B4FAFC File Offset: 0x00B4DCFC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060285ED RID: 165357 RVA: 0x00B4FC4D File Offset: 0x00B4DE4D
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060285EE RID: 165358 RVA: 0x00B4FC60 File Offset: 0x00B4DE60
		private ElementItem CreateElementItem()
		{
			return new ElementItem();
		}

		// Token: 0x060285EF RID: 165359 RVA: 0x00B4FC67 File Offset: 0x00B4DE67
		public override void Refresh(IPhantomAttrItemData data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x060285F0 RID: 165360 RVA: 0x00B4FC70 File Offset: 0x00B4DE70
		private void RefreshPanel()
		{
			this.RefreshUnlock();
			this.RefreshAttrText();
			this.RefreshLayout();
			this.RefreshElement();
		}

		// Token: 0x060285F1 RID: 165361 RVA: 0x00B4FC8C File Offset: 0x00B4DE8C
		private void RefreshUnlock()
		{
			bool isUnlock = this.RoguelikeInfo.GetIsUnlock(this.AffixEntry);
			base.GetSprite(3).SetUIActive(isUnlock);
			base.GetSprite(4).SetUIActive(!isUnlock);
		}

		// Token: 0x060285F2 RID: 165362 RVA: 0x00B4FCC8 File Offset: 0x00B4DEC8
		private void RefreshAttrText()
		{
			RogueAffix? rogueAffixConfig = RoguelikeConfig.Instance.GetRogueAffixConfig(this.AffixEntry.Id.Value);
			if (rogueAffixConfig == null)
			{
				return;
			}
			bool descModel = RoguelikeModel.Instance.GetDescModel() != EDescModel.SIMPLE;
			UUIText text = base.GetText(0);
			UUIText text2 = base.GetText(7);
			UUIItem uuiitem = text2;
			AffixEntry affixEntry = this.AffixEntry;
			uuiitem.SetColor((affixEntry != null && affixEntry.IsUnlock.GetValueOrDefault()) ? FColor.FromHex("BEFE58FF") : FColor.FromHex("ECE5D8FF"));
			UUIItem uuiitem2 = text;
			AffixEntry affixEntry2 = this.AffixEntry;
			uuiitem2.SetColor((affixEntry2 != null && affixEntry2.IsUnlock.GetValueOrDefault()) ? FColor.FromHex("BEFE58FF") : FColor.FromHex("ECE5D8FF"));
			if (!descModel)
			{
				text.ShowTextNew(rogueAffixConfig.Value.AffixDescSimple);
				text2.ShowTextNew(rogueAffixConfig.Value.AffixDescSimple);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, rogueAffixConfig.Value.AffixDesc, rogueAffixConfig.Value.AffixDescParam());
			LguiUtil.Instance.SetLocalTextNew(text2, rogueAffixConfig.Value.AffixDesc, rogueAffixConfig.Value.AffixDescParam());
		}

		// Token: 0x060285F3 RID: 165363 RVA: 0x00B4FE00 File Offset: 0x00B4E000
		private void RefreshLayout()
		{
			UUIText text = base.GetText(0);
			bool flag = text.GetTextRenderSize().X < text.Width;
			UUIItem parentAsUIItem = base.GetHorizontalLayout(1).GetRootComponent().GetParentAsUIItem();
			UUIItem item = base.GetItem(6);
			UUISizeControlByOther uuisizeControlByOther = base.GetItem(5).GetOwner().GetComponentByClass(UUISizeControlByOther.StaticClass()) as UUISizeControlByOther;
			AUIBaseActor targetActor = (flag ? parentAsUIItem.GetOwner() : item.GetOwner()) as AUIBaseActor;
			uuisizeControlByOther.SetTargetActor(targetActor);
			parentAsUIItem.SetUIActive(flag);
			item.SetUIActive(!flag);
			if (this.ElementLayout == null)
			{
				this.ElementLayout = new GenericLayout<ElementItem, ElementInfo>(base.GetHorizontalLayout(1), new Func<ElementItem>(this.CreateElementItem), null, false, true);
			}
			if (this.AdaptationElementLayout == null)
			{
				this.AdaptationElementLayout = new GenericLayout<ElementItem, ElementInfo>(base.GetHorizontalLayout(8), new Func<ElementItem>(this.CreateElementItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			}
		}

		// Token: 0x060285F4 RID: 165364 RVA: 0x00B4FEF8 File Offset: 0x00B4E0F8
		private void RefreshElement()
		{
			List<ElementInfo> sortElementInfoArrayByCount = this.AffixEntry.GetSortElementInfoArrayByCount(false);
			GenericLayout<ElementItem, ElementInfo> elementLayout = this.ElementLayout;
			if (elementLayout != null)
			{
				elementLayout.RefreshByData(sortElementInfoArrayByCount, null, false);
			}
			GenericLayout<ElementItem, ElementInfo> adaptationElementLayout = this.AdaptationElementLayout;
			if (adaptationElementLayout == null)
			{
				return;
			}
			adaptationElementLayout.RefreshByData(sortElementInfoArrayByCount, null, false);
		}

		// Token: 0x060285F5 RID: 165365 RVA: 0x00B4FF3C File Offset: 0x00B4E13C
		public void PlayComplete()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Complete", false, null, false);
		}

		// Token: 0x04015EEF RID: 89839
		public AffixEntry AffixEntry;

		// Token: 0x04015EF0 RID: 89840
		private RoguelikeInfo RoguelikeInfo;

		// Token: 0x04015EF1 RID: 89841
		private GenericLayout<ElementItem, ElementInfo> ElementLayout;

		// Token: 0x04015EF2 RID: 89842
		private GenericLayout<ElementItem, ElementInfo> AdaptationElementLayout;

		// Token: 0x04015EF3 RID: 89843
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x020099A2 RID: 39330
		[NullableContext(0)]
		private class EPhantomAttrItemCom
		{
			// Token: 0x0402FE74 RID: 196212
			public const int AttrText = 0;

			// Token: 0x0402FE75 RID: 196213
			public const int ElementsLayout = 1;

			// Token: 0x0402FE76 RID: 196214
			public const int ElementItem = 2;

			// Token: 0x0402FE77 RID: 196215
			public const int FinishSprite = 3;

			// Token: 0x0402FE78 RID: 196216
			public const int NoSprite = 4;

			// Token: 0x0402FE79 RID: 196217
			public const int BlackGroundItem = 5;

			// Token: 0x0402FE7A RID: 196218
			public const int AdaptationParentItem = 6;

			// Token: 0x0402FE7B RID: 196219
			public const int AdaptationAttrText = 7;

			// Token: 0x0402FE7C RID: 196220
			public const int AdaptationElementsLayout = 8;
		}
	}
}
