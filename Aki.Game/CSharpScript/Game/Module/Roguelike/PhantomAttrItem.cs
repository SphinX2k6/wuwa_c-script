using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DE8 RID: 19944
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomAttrItem : GridProxyAbstract<IPhantomAttrItemData>
	{
		// Token: 0x06033780 RID: 210816 RVA: 0x00C065C9 File Offset: 0x00C047C9
		public void Update(IPhantomAttrItemData data)
		{
			this.AffixEntry = data.AffixEntry;
			this.RoguelikeInfo = data.RoguelikeInfo;
			this.RefreshPanel();
		}

		// Token: 0x06033781 RID: 210817 RVA: 0x00C065EC File Offset: 0x00C047EC
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

		// Token: 0x06033782 RID: 210818 RVA: 0x00C0673D File Offset: 0x00C0493D
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06033783 RID: 210819 RVA: 0x00C06750 File Offset: 0x00C04950
		private ElementItem CreateElementItem()
		{
			return new ElementItem();
		}

		// Token: 0x06033784 RID: 210820 RVA: 0x00C06757 File Offset: 0x00C04957
		public override void Refresh(IPhantomAttrItemData data, bool isSelected, int gridIndex)
		{
			this.Update(data);
		}

		// Token: 0x06033785 RID: 210821 RVA: 0x00C06760 File Offset: 0x00C04960
		private void RefreshPanel()
		{
			this.RefreshUnlock();
			this.RefreshAttrText();
			this.RefreshLayout();
			this.RefreshElement();
		}

		// Token: 0x06033786 RID: 210822 RVA: 0x00C0677C File Offset: 0x00C0497C
		private void RefreshUnlock()
		{
			bool isUnlock = this.RoguelikeInfo.GetIsUnlock(this.AffixEntry);
			base.GetSprite(3).SetUIActive(isUnlock);
			base.GetSprite(4).SetUIActive(!isUnlock);
		}

		// Token: 0x06033787 RID: 210823 RVA: 0x00C067B8 File Offset: 0x00C049B8
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

		// Token: 0x06033788 RID: 210824 RVA: 0x00C068F0 File Offset: 0x00C04AF0
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

		// Token: 0x06033789 RID: 210825 RVA: 0x00C069E8 File Offset: 0x00C04BE8
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

		// Token: 0x0603378A RID: 210826 RVA: 0x00C06A2C File Offset: 0x00C04C2C
		public void PlayComplete()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Complete", false, null, false);
		}

		// Token: 0x0401B51C RID: 111900
		public AffixEntry AffixEntry;

		// Token: 0x0401B51D RID: 111901
		private RoguelikeInfo RoguelikeInfo;

		// Token: 0x0401B51E RID: 111902
		private GenericLayout<ElementItem, ElementInfo> ElementLayout;

		// Token: 0x0401B51F RID: 111903
		private GenericLayout<ElementItem, ElementInfo> AdaptationElementLayout;

		// Token: 0x0401B520 RID: 111904
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AF6D RID: 44909
		[NullableContext(0)]
		private class EPhantomAttrItemCom
		{
			// Token: 0x04035441 RID: 218177
			public const int AttrText = 0;

			// Token: 0x04035442 RID: 218178
			public const int ElementsLayout = 1;

			// Token: 0x04035443 RID: 218179
			public const int ElementItem = 2;

			// Token: 0x04035444 RID: 218180
			public const int FinishSprite = 3;

			// Token: 0x04035445 RID: 218181
			public const int NoSprite = 4;

			// Token: 0x04035446 RID: 218182
			public const int BlackGroundItem = 5;

			// Token: 0x04035447 RID: 218183
			public const int AdaptationParentItem = 6;

			// Token: 0x04035448 RID: 218184
			public const int AdaptationAttrText = 7;

			// Token: 0x04035449 RID: 218185
			public const int AdaptationElementsLayout = 8;
		}
	}
}
