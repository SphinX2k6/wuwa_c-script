using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C24 RID: 7204
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class MemoryFragmentTabItem : GridProxyAbstract<TabItemData>
{
	// Token: 0x0600D888 RID: 55432 RVA: 0x003227D8 File Offset: 0x003209D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTabToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D889 RID: 55433 RVA: 0x00322944 File Offset: 0x00320B44
	private void OnTabToggleClick(EToggleState toggleState)
	{
		if (this.Data == null)
		{
			return;
		}
		this.Data.TabCallBack(base.GridIndex);
	}

	// Token: 0x0600D88A RID: 55434 RVA: 0x00322965 File Offset: 0x00320B65
	private LevelSequencePlayer GetLevelSequencePlayer()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}
		return this.LevelSequencePlayer;
	}

	// Token: 0x0600D88B RID: 55435 RVA: 0x00322988 File Offset: 0x00320B88
	public override void Refresh(TabItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		bool flag = base.GridIndex == data.GetCurrentSelectTabIndex();
		EToggleState etoggleState = flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(etoggleState, false, false, false);
		}
		if (data.FragmentCollectData == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), data.FragmentCollectData.GetTitle(), Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.FragmentCollectData.GetTitle(), Array.Empty<object>());
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(data.FragmentCollectData.GetIfGetReward());
		}
		this.RefreshRedDot();
		this.RefreshHaveItem();
		this.RefreshNoneItem();
		this.RefreshNumText();
		if (this.SelectState != flag)
		{
			this.RefreshToggleAnimation(etoggleState);
		}
		this.SelectState = flag;
	}

	// Token: 0x0600D88C RID: 55436 RVA: 0x00322A68 File Offset: 0x00320C68
	private void RefreshToggleAnimation(EToggleState targetState)
	{
		string text = (targetState == EToggleState.ETT_Checked) ? "Select" : "Unselect";
		TabItemData data = this.Data;
		if (data != null && data.NeedSwitchAnimation)
		{
			LevelSequencePlayer levelSequencePlayer = this.GetLevelSequencePlayer();
			if (levelSequencePlayer.GetCurrentSequence() == text)
			{
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.ReplaySequenceByKey(text);
					return;
				}
			}
			else if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlaySequencePurely(text, false, false, null, null, false);
				return;
			}
		}
		else
		{
			LevelSequencePlayer levelSequencePlayer2 = this.GetLevelSequencePlayer();
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.StopSequenceByKey("Select", false, false);
			}
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlaySequencePurely(text, false, false, null, null, false);
			}
			levelSequencePlayer2.StopSequenceByKey(text, false, true);
		}
	}

	// Token: 0x0600D88D RID: 55437 RVA: 0x00322B10 File Offset: 0x00320D10
	private void RefreshNumText()
	{
		TabItemData data = this.Data;
		if (((data != null) ? data.FragmentCollectData : null) == null)
		{
			return;
		}
		if (this.Data.FragmentCollectData.GetIfUnlock())
		{
			string newText = (base.GridIndex + 1).ToString().PadLeft(2, '0');
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(newText, true);
			return;
		}
		else
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText("", true);
			return;
		}
	}

	// Token: 0x0600D88E RID: 55438 RVA: 0x00322B88 File Offset: 0x00320D88
	private void RefreshHaveItem()
	{
		TabItemData data = this.Data;
		if (((data != null) ? data.FragmentCollectData : null) == null)
		{
			return;
		}
		bool ifUnlock = this.Data.FragmentCollectData.GetIfUnlock();
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(ifUnlock);
	}

	// Token: 0x0600D88F RID: 55439 RVA: 0x00322BD0 File Offset: 0x00320DD0
	private void RefreshNoneItem()
	{
		TabItemData data = this.Data;
		if (((data != null) ? data.FragmentCollectData : null) == null)
		{
			return;
		}
		bool uiactive = !this.Data.FragmentCollectData.GetIfUnlock();
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x0600D890 RID: 55440 RVA: 0x00322C18 File Offset: 0x00320E18
	private void RefreshRedDot()
	{
		TabItemData data = this.Data;
		if (((data != null) ? data.FragmentCollectData : null) == null)
		{
			return;
		}
		RedDotController.Instance.UnBindGivenUi(ERedDotName.FragmentMemoryReward, base.GetItem(4), this.Data.FragmentCollectData.GetId());
		RedDotController.Instance.BindRedDot(ERedDotName.FragmentMemoryReward, base.GetItem(4), null, this.Data.FragmentCollectData.GetId());
	}

	// Token: 0x040062B0 RID: 25264
	[Nullable(2)]
	private TabItemData Data;

	// Token: 0x040062B1 RID: 25265
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040062B2 RID: 25266
	private bool SelectState;

	// Token: 0x020081DF RID: 33247
	[NullableContext(0)]
	private class ETabItem
	{
		// Token: 0x0402A634 RID: 173620
		public const int TabToggle = 0;

		// Token: 0x0402A635 RID: 173621
		public const int NumText = 1;

		// Token: 0x0402A636 RID: 173622
		public const int NameText = 2;

		// Token: 0x0402A637 RID: 173623
		public const int DoneSprite = 3;

		// Token: 0x0402A638 RID: 173624
		public const int RedDot = 4;

		// Token: 0x0402A639 RID: 173625
		public const int HaveItem = 5;

		// Token: 0x0402A63A RID: 173626
		public const int NoneItem = 6;

		// Token: 0x0402A63B RID: 173627
		public const int TextNumNone = 7;
	}
}
