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
	// Token: 0x02004DEA RID: 19946
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomEntryItem : GridProxyAbstract<AffixEntry>
	{
		// Token: 0x06033793 RID: 210835 RVA: 0x00C06D24 File Offset: 0x00C04F24
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

		// Token: 0x06033794 RID: 210836 RVA: 0x00C06DF0 File Offset: 0x00C04FF0
		protected override void OnStart()
		{
			this.PhantomElementItemLayout = new GenericLayout<PhantomElementItem, ElementInfo>(base.GetVerticalLayout(0), new Func<PhantomElementItem>(this.CreateElementItem), null, false, true);
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06033795 RID: 210837 RVA: 0x00C06E24 File Offset: 0x00C05024
		private PhantomElementItem CreateElementItem()
		{
			return new PhantomElementItem();
		}

		// Token: 0x06033796 RID: 210838 RVA: 0x00C06E2C File Offset: 0x00C0502C
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

		// Token: 0x06033797 RID: 210839 RVA: 0x00C06F00 File Offset: 0x00C05100
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

		// Token: 0x06033798 RID: 210840 RVA: 0x00C07088 File Offset: 0x00C05288
		private void PlayComplete()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Complete", false, null, false);
		}

		// Token: 0x0401B523 RID: 111907
		private AffixEntry AffixEntry;

		// Token: 0x0401B524 RID: 111908
		private GenericLayout<PhantomElementItem, ElementInfo> PhantomElementItemLayout;

		// Token: 0x0401B525 RID: 111909
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B526 RID: 111910
		private bool IsUnlockState;

		// Token: 0x0200AF70 RID: 44912
		[NullableContext(0)]
		private class EPhantomEntryItemCom
		{
			// Token: 0x04035451 RID: 218193
			public const int PhantomElementItemLayout = 0;

			// Token: 0x04035452 RID: 218194
			public const int PhantomElementItem = 1;

			// Token: 0x04035453 RID: 218195
			public const int DescPanel = 2;

			// Token: 0x04035454 RID: 218196
			public const int DescText = 3;

			// Token: 0x04035455 RID: 218197
			public const int IndexText = 4;
		}
	}
}
