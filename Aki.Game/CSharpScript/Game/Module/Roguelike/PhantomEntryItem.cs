using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DB3 RID: 15795
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomEntryItem : GridProxyAbstract<AffixEntry>
	{
		// Token: 0x060285FE RID: 165374 RVA: 0x00B50234 File Offset: 0x00B4E434
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060285FF RID: 165375 RVA: 0x00B50300 File Offset: 0x00B4E500
		protected override void OnStart()
		{
			this.PhantomElementItemLayout = new GenericLayout<PhantomElementItem, ElementInfo>(base.GetVerticalLayout(0), new Func<PhantomElementItem>(this.CreateElementItem), null, false, true);
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06028600 RID: 165376 RVA: 0x00B50334 File Offset: 0x00B4E534
		private PhantomElementItem CreateElementItem()
		{
			return new PhantomElementItem();
		}

		// Token: 0x06028601 RID: 165377 RVA: 0x00B5033C File Offset: 0x00B4E53C
		public override void Refresh(AffixEntry data, bool isSelected, int gridIndex)
		{
			this.AffixEntry = data;
			List<ElementInfo> sortElementInfoArrayByCount = this.AffixEntry.GetSortElementInfoArrayByCount(false);
			foreach (ElementInfo elementInfo in sortElementInfoArrayByCount)
			{
				if (elementInfo.ElementId == 9)
				{
					elementInfo.Name = "RoguelikeView_16_Text";
				}
				else
				{
					ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(elementInfo.ElementId);
					if (elementConfig != null)
					{
						elementInfo.Name = elementConfig.Value.Name;
					}
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Rogue_Phantom_Info_Index", new <>z__ReadOnlySingleElementList<object>(gridIndex + 1));
			this.PhantomElementItemLayout.RefreshByData(sortElementInfoArrayByCount, null, false);
		}

		// Token: 0x06028602 RID: 165378 RVA: 0x00B50410 File Offset: 0x00B4E610
		[NullableContext(2)]
		public void RefreshPreview(Dictionary<int, int> elementDict = null)
		{
			bool flag = true;
			using (List<PhantomElementItem>.Enumerator enumerator = this.PhantomElementItemLayout.GetLayoutItemList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.RefreshPanel(elementDict))
					{
						flag = false;
					}
				}
			}
			bool flag2 = !this.AffixEntry.IsUnlock.GetValueOrDefault() && flag;
			if (flag2)
			{
				this.PlayComplete();
				this.IsUnlockState = true;
				EventSystem.Instance.Emit(EEventName.RogueTermUnlock);
			}
			else if (this.IsUnlockState)
			{
				this.LevelSequencePlayer.PlayLevelSequenceByName("Disappear", false, null, false);
				this.IsUnlockState = false;
			}
			base.GetItem(2).SetUIActive(flag2);
			UUIText text = base.GetText(3);
			RoguelikeModel instance = RoguelikeModel.Instance;
			if (instance != null && instance.GetDescModel() == EDescModel.SIMPLE)
			{
				LguiUtil.Instance.SetLocalTextNew(text, this.AffixEntry.GetAffixDesc(), Array.Empty<object>());
			}
			else
			{
				RoguelikeConfig instance2 = RoguelikeConfig.Instance;
				RogueAffix? rogueAffix = (instance2 != null) ? instance2.GetRogueAffixConfig(this.AffixEntry.Id.Value) : null;
				if (rogueAffix != null)
				{
					LguiUtil.Instance.SetLocalTextNew(text, this.AffixEntry.GetAffixDesc(), rogueAffix.Value.AffixDescParam());
				}
			}
			UUIItem uuiitem = text;
			bool bUseChangeColor = flag2;
			FColor? fcolor;
			FColor? fcolor2;
			if (text == null)
			{
				fcolor = null;
				fcolor2 = fcolor;
			}
			else
			{
				fcolor2 = new FColor?(text.changeColor);
			}
			fcolor = fcolor2;
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}

		// Token: 0x06028603 RID: 165379 RVA: 0x00B50598 File Offset: 0x00B4E798
		private void PlayComplete()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Complete", false, null, false);
		}

		// Token: 0x04015EF6 RID: 89846
		private AffixEntry AffixEntry;

		// Token: 0x04015EF7 RID: 89847
		private GenericLayout<PhantomElementItem, ElementInfo> PhantomElementItemLayout;

		// Token: 0x04015EF8 RID: 89848
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04015EF9 RID: 89849
		private bool IsUnlockState;

		// Token: 0x020099A5 RID: 39333
		[NullableContext(0)]
		private class EPhantomEntryItemCom
		{
			// Token: 0x0402FE84 RID: 196228
			public const int PhantomElementItemLayout = 0;

			// Token: 0x0402FE85 RID: 196229
			public const int PhantomElementItem = 1;

			// Token: 0x0402FE86 RID: 196230
			public const int DescPanel = 2;

			// Token: 0x0402FE87 RID: 196231
			public const int DescText = 3;

			// Token: 0x0402FE88 RID: 196232
			public const int IndexText = 4;
		}
	}
}
