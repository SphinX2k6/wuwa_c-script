using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020010E3 RID: 4323
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class MemoryFragmentTabItem : GridProxyAbstract<TabItemData>
{
	// Token: 0x0600AC9E RID: 44190 RVA: 0x0032DBB0 File Offset: 0x0032BDB0
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

	// Token: 0x0600AC9F RID: 44191 RVA: 0x0032DD1C File Offset: 0x0032BF1C
	private void OnTabToggleClick(EToggleState toggleState)
	{
		if (this.Data == null)
		{
			return;
		}
		this.Data.TabCallBack(base.GridIndex);
	}

	// Token: 0x0600ACA0 RID: 44192 RVA: 0x0032DD3D File Offset: 0x0032BF3D
	private LevelSequencePlayer GetLevelSequencePlayer()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}
		return this.LevelSequencePlayer;
	}

	// Token: 0x0600ACA1 RID: 44193 RVA: 0x0032DD60 File Offset: 0x0032BF60
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

	// Token: 0x0600ACA2 RID: 44194 RVA: 0x0032DE40 File Offset: 0x0032C040
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

	// Token: 0x0600ACA3 RID: 44195 RVA: 0x0032DEE8 File Offset: 0x0032C0E8
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

	// Token: 0x0600ACA4 RID: 44196 RVA: 0x0032DF60 File Offset: 0x0032C160
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

	// Token: 0x0600ACA5 RID: 44197 RVA: 0x0032DFA8 File Offset: 0x0032C1A8
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

	// Token: 0x0600ACA6 RID: 44198 RVA: 0x0032DFF0 File Offset: 0x0032C1F0
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

	// Token: 0x04006382 RID: 25474
	[Nullable(2)]
	private TabItemData Data;

	// Token: 0x04006383 RID: 25475
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006384 RID: 25476
	private bool SelectState;

	// Token: 0x02007368 RID: 29544
	[NullableContext(0)]
	private class ETabItem
	{
		// Token: 0x0402595B RID: 153947
		public const int TabToggle = 0;

		// Token: 0x0402595C RID: 153948
		public const int NumText = 1;

		// Token: 0x0402595D RID: 153949
		public const int NameText = 2;

		// Token: 0x0402595E RID: 153950
		public const int DoneSprite = 3;

		// Token: 0x0402595F RID: 153951
		public const int RedDot = 4;

		// Token: 0x04025960 RID: 153952
		public const int HaveItem = 5;

		// Token: 0x04025961 RID: 153953
		public const int NoneItem = 6;

		// Token: 0x04025962 RID: 153954
		public const int TextNumNone = 7;
	}
}
