using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059AE RID: 22958
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolTogItem : GridProxyAbstract<SolarSchoolTogItemData>
	{
		// Token: 0x17006C31 RID: 27697
		// (get) Token: 0x06038992 RID: 231826 RVA: 0x00FD5F99 File Offset: 0x00FD4199
		// (set) Token: 0x06038993 RID: 231827 RVA: 0x00FD5FA1 File Offset: 0x00FD41A1
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SolarSchoolTogItemData> ClickCallback { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x06038994 RID: 231828 RVA: 0x00FD5FAC File Offset: 0x00FD41AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038995 RID: 231829 RVA: 0x00FD613C File Offset: 0x00FD433C
		protected override void OnStart()
		{
			AActor rootActor = base.GetRootActor();
			this.Canvas = (((rootActor != null) ? rootActor.GetComponentByClass(ULGUICanvas.StaticClass()) : null) as ULGUICanvas);
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(() => !this.IsAboveMask);
		}

		// Token: 0x06038996 RID: 231830 RVA: 0x00FD6194 File Offset: 0x00FD4394
		[NullableContext(1)]
		public override void Refresh(SolarSchoolTogItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.SetAboveMask(false);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(data.Text, true);
			}
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.SetText(data.LockHint, true);
			}
			UUIText text3 = base.GetText(4);
			if (text3 != null)
			{
				text3.SetUIActive(!string.IsNullOrEmpty(data.LockHint));
			}
			base.TrySetSpriteByPath(data.IconPath, base.GetSprite(1), false, null, null);
			bool flag = data.Level > 0;
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				UUIText text4 = base.GetText(3);
				if (text4 != null)
				{
					text4.SetText(data.Level.ToString(), true);
				}
			}
			string occupyTagText = SolarSchoolUtils.GetOccupyTagText(data.OccupySlot);
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(!string.IsNullOrEmpty(occupyTagText));
			}
			UUIText text5 = base.GetText(6);
			if (text5 != null)
			{
				text5.SetText(occupyTagText, true);
			}
			UUIItem item3 = base.GetItem(11);
			if (item3 != null)
			{
				SolarSchoolBehavior? solarSchoolBehavior;
				item3.SetUIActive(data.BehaviorId != 0 && SolarSchoolGamePlayModel.Instance.PlayerData.GetCurrentLevelRow(data.BehaviorId) != null && solarSchoolBehavior.GetValueOrDefault().IsRecommend);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetSelfInteractive(data.CanClick);
			}
			this.SetSelectedState(isSelected);
		}

		// Token: 0x06038997 RID: 231831 RVA: 0x00FD6307 File Offset: 0x00FD4507
		public override void Clear()
		{
			this.Data = null;
			this.SetAboveMask(false);
		}

		// Token: 0x06038998 RID: 231832 RVA: 0x00FD6317 File Offset: 0x00FD4517
		public UUIItem GetGuideTogItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return null;
			}
			return extendToggle.GetRootComponent();
		}

		// Token: 0x06038999 RID: 231833 RVA: 0x00FD632B File Offset: 0x00FD452B
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x0603899A RID: 231834 RVA: 0x00FD6334 File Offset: 0x00FD4534
		public override void OnDeselected(bool fireEvent)
		{
			this.SetAboveMask(false);
			this.SetSelectedState(false);
		}

		// Token: 0x0603899B RID: 231835 RVA: 0x00FD6344 File Offset: 0x00FD4544
		public void SetAboveMask(bool above)
		{
			this.IsAboveMask = above;
			ULGUICanvas canvas = this.Canvas;
			if (canvas == null)
			{
				return;
			}
			canvas.SetSortOrder((above > false) ? 1 : 0, true);
		}

		// Token: 0x0603899C RID: 231836 RVA: 0x00FD6364 File Offset: 0x00FD4564
		private void OnClickToggle(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked || this.Data == null || !this.Data.CanClick)
			{
				return;
			}
			IScrollViewDelegate<IGridProxy<SolarSchoolTogItemData>, SolarSchoolTogItemData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<SolarSchoolTogItemData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data);
		}

		// Token: 0x0603899D RID: 231837 RVA: 0x00FD63BF File Offset: 0x00FD45BF
		private void SetSelectedState(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0401DCF4 RID: 122100
		private const int SortOrderNormal = 0;

		// Token: 0x0401DCF5 RID: 122101
		private const int SortOrderAboveMask = 1;

		// Token: 0x0401DCF6 RID: 122102
		private SolarSchoolTogItemData Data;

		// Token: 0x0401DCF7 RID: 122103
		private ULGUICanvas Canvas;

		// Token: 0x0401DCF8 RID: 122104
		private bool IsAboveMask;

		// Token: 0x0200B559 RID: 46425
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403811E RID: 229662
			public const int Toggle = 0;

			// Token: 0x0403811F RID: 229663
			public const int SprIcon = 1;

			// Token: 0x04038120 RID: 229664
			public const int TxtL = 2;

			// Token: 0x04038121 RID: 229665
			public const int TxtLevel = 3;

			// Token: 0x04038122 RID: 229666
			public const int TxtTips = 4;

			// Token: 0x04038123 RID: 229667
			public const int ItemTag = 5;

			// Token: 0x04038124 RID: 229668
			public const int TxtTag = 6;

			// Token: 0x04038125 RID: 229669
			public const int PnlLevel = 7;

			// Token: 0x04038126 RID: 229670
			public const int RecommendItem = 11;
		}
	}
}
