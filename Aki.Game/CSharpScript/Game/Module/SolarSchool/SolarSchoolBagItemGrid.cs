using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005988 RID: 22920
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolBagItemGrid : GridProxyAbstract<SolarSchoolBagItemData>
	{
		// Token: 0x17006C21 RID: 27681
		// (get) Token: 0x06038828 RID: 231464 RVA: 0x00FCF4DF File Offset: 0x00FCD6DF
		// (set) Token: 0x06038829 RID: 231465 RVA: 0x00FCF4E7 File Offset: 0x00FCD6E7
		public Action<SolarSchoolBagItemData> ClickCallback { get; set; }

		// Token: 0x17006C22 RID: 27682
		// (get) Token: 0x0603882A RID: 231466 RVA: 0x00FCF4F0 File Offset: 0x00FCD6F0
		// (set) Token: 0x0603882B RID: 231467 RVA: 0x00FCF4F8 File Offset: 0x00FCD6F8
		public int GiftRoleId { get; set; }

		// Token: 0x17006C23 RID: 27683
		// (get) Token: 0x0603882C RID: 231468 RVA: 0x00FCF501 File Offset: 0x00FCD701
		// (set) Token: 0x0603882D RID: 231469 RVA: 0x00FCF509 File Offset: 0x00FCD709
		public bool IsPlayingUsedSequence { get; private set; }

		// Token: 0x0603882E RID: 231470 RVA: 0x00FCF514 File Offset: 0x00FCD714
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603882F RID: 231471 RVA: 0x00FCF5FC File Offset: 0x00FCD7FC
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			this.DefaultWidth = ((rootItem != null) ? rootItem.GetWidth() : 0f);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x06038830 RID: 231472 RVA: 0x00FCF64E File Offset: 0x00FCD84E
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06038831 RID: 231473 RVA: 0x00FCF668 File Offset: 0x00FCD868
		public void PlayUsedSequence()
		{
			this.CollapsedItemId = ((this.Data != null) ? this.Data.GetValueOrDefault().ItemId : 0);
			this.IsPlayingUsedSequence = true;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayOrReplaySequenceByName("Use", false, null);
		}

		// Token: 0x06038832 RID: 231474 RVA: 0x00FCF6C0 File Offset: 0x00FCD8C0
		public override void Refresh(SolarSchoolBagItemData data, bool isSelected, int gridIndex)
		{
			this.RestoreCollapsedWidth(data.ItemId);
			this.Data = new SolarSchoolBagItemData?(data);
			base.SetTextureByPath(data.Config.Icon, base.GetTexture(1), null, null);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetText(data.Count.ToString(), true);
			}
			SolarSchoolItem? solarSchoolItem = (this.GiftRoleId > 0) ? SolarSchoolConfig.Instance.GetItem(data.ItemId) : null;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(solarSchoolItem != null && Array.IndexOf<int>(solarSchoolItem.Value.GetFavorRoleListArray(), this.GiftRoleId) >= 0);
			}
			this.SetSelectedState(isSelected);
		}

		// Token: 0x06038833 RID: 231475 RVA: 0x00FCF795 File Offset: 0x00FCD995
		public override void Clear()
		{
			this.Data = null;
			UUIItem item = base.GetItem(3);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06038834 RID: 231476 RVA: 0x00FCF7B5 File Offset: 0x00FCD9B5
		[NullableContext(1)]
		public override object GetKey(SolarSchoolBagItemData data, int displayIndex)
		{
			return data.ItemId;
		}

		// Token: 0x06038835 RID: 231477 RVA: 0x00FCF7C3 File Offset: 0x00FCD9C3
		public override void OnSelected(bool fireEvent)
		{
			this.SetSelectedState(true);
		}

		// Token: 0x06038836 RID: 231478 RVA: 0x00FCF7CC File Offset: 0x00FCD9CC
		public override void OnDeselected(bool fireEvent)
		{
			this.SetSelectedState(false);
		}

		// Token: 0x06038837 RID: 231479 RVA: 0x00FCF7D8 File Offset: 0x00FCD9D8
		private void OnToggleStateChanged(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked || this.Data == null)
			{
				return;
			}
			IScrollViewDelegate<IGridProxy<SolarSchoolBagItemData>, SolarSchoolBagItemData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<SolarSchoolBagItemData> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data.Value);
		}

		// Token: 0x06038838 RID: 231480 RVA: 0x00FCF830 File Offset: 0x00FCDA30
		private void SetSelectedState(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06038839 RID: 231481 RVA: 0x00FCF84D File Offset: 0x00FCDA4D
		private void RestoreCollapsedWidth(int newItemId)
		{
			if (this.CollapsedItemId == 0 || this.CollapsedItemId == newItemId)
			{
				return;
			}
			this.CollapsedItemId = 0;
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetWidth(this.DefaultWidth);
		}

		// Token: 0x0603883A RID: 231482 RVA: 0x00FCF87E File Offset: 0x00FCDA7E
		[NullableContext(1)]
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName != "Use" || !this.IsPlayingUsedSequence)
			{
				return;
			}
			this.IsPlayingUsedSequence = false;
			EventSystem.Instance.Emit(EEventName.SolarSchoolBagGridSequenceEnd);
		}

		// Token: 0x0401DC56 RID: 121942
		private SolarSchoolBagItemData? Data;

		// Token: 0x0401DC59 RID: 121945
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401DC5A RID: 121946
		private float DefaultWidth;

		// Token: 0x0401DC5B RID: 121947
		private int CollapsedItemId;

		// Token: 0x0200B52A RID: 46378
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038029 RID: 229417
			public const int Toggle = 0;

			// Token: 0x0403802A RID: 229418
			public const int TexIcon = 1;

			// Token: 0x0403802B RID: 229419
			public const int TxtNum = 2;

			// Token: 0x0403802C RID: 229420
			public const int PnlRecommend = 3;
		}
	}
}
