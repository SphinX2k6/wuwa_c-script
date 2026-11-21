using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000839 RID: 2105
internal class MowingBuffEntry : UiPanelBase
{
	// Token: 0x06005FA1 RID: 24481 RVA: 0x001E8C64 File Offset: 0x001E6E64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickEntryButton))
		};
	}

	// Token: 0x06005FA2 RID: 24482 RVA: 0x001E8D65 File Offset: 0x001E6F65
	private void OnClickEntryButton()
	{
		UiManager.Instance.OpenView(EUiViewName.MowingTowerBuffView, null, null);
	}

	// Token: 0x06005FA3 RID: 24483 RVA: 0x001E8D78 File Offset: 0x001E6F78
	[NullableContext(1)]
	public void Refresh(MowingTowerBuffInfo buff)
	{
		this.CurrentSelectBuff = buff;
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.SetSelectionState(EUISelectableSelectionState.Normal);
		}
		UUIButtonComponent button2 = base.GetButton(0);
		if (button2 != null)
		{
			button2.SetSelfInteractive(true);
		}
		this.RefreshNoneShow();
		this.RefreshBuffInfo();
		this.RefreshLockItemState();
		this.RefreshSwitchButton();
		this.RefreshBuffTips();
	}

	// Token: 0x06005FA4 RID: 24484 RVA: 0x001E8DD0 File Offset: 0x001E6FD0
	private void RefreshBuffTips()
	{
		string textStringId = "BossRushBuffSelectTips";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
	}

	// Token: 0x06005FA5 RID: 24485 RVA: 0x001E8DFA File Offset: 0x001E6FFA
	private void RefreshLockItemState()
	{
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x06005FA6 RID: 24486 RVA: 0x001E8E09 File Offset: 0x001E7009
	private void RefreshSwitchButton()
	{
		base.GetItem(7).SetUIActive(this.CurrentSelectBuff.BuffId != 0);
	}

	// Token: 0x06005FA7 RID: 24487 RVA: 0x001E8E25 File Offset: 0x001E7025
	private void RefreshNoneShow()
	{
		base.GetItem(1).SetUIActive(this.CurrentSelectBuff.BuffId == 0);
		base.GetItem(2).SetUIActive(this.CurrentSelectBuff.BuffId != 0);
	}

	// Token: 0x06005FA8 RID: 24488 RVA: 0x001E8E5B File Offset: 0x001E705B
	private void RefreshBuffInfo()
	{
		if (this.CurrentSelectBuff.BuffId == 0)
		{
			return;
		}
		this.RefreshBuffName();
		this.RefreshBuffDesc();
		this.RefreshBuffTexture();
	}

	// Token: 0x06005FA9 RID: 24489 RVA: 0x001E8E80 File Offset: 0x001E7080
	private void RefreshBuffTexture()
	{
		string texture = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentSelectBuff.BuffId).Value.Texture;
		base.SetTextureByPath(texture, base.GetTexture(4), null, null);
	}

	// Token: 0x06005FAA RID: 24490 RVA: 0x001E8ECC File Offset: 0x001E70CC
	private void RefreshBuffDesc()
	{
		MowTowerBuffRe? mowingTowerBuffById = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentSelectBuff.BuffId);
		List<string> list = new List<string>();
		int descriptionParamLength = mowingTowerBuffById.Value.DescriptionParamLength;
		for (int i = 0; i < descriptionParamLength; i++)
		{
			string text = mowingTowerBuffById.Value.DescriptionParam(i);
			Match match = new Regex("\\[(.*?)\\]").Match(text ?? "");
			if (match.Success && match.Groups.Count > 1)
			{
				string[] array = match.Groups[1].Value.Split(',', StringSplitOptions.None);
				for (int j = 0; j < array.Length; j++)
				{
					list.Add(array[j]);
				}
			}
		}
		object[] array2 = new object[list.Count];
		for (int k = 0; k < list.Count; k++)
		{
			array2[k] = list[k];
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), mowingTowerBuffById.Value.Description, array2);
	}

	// Token: 0x06005FAB RID: 24491 RVA: 0x001E8FF0 File Offset: 0x001E71F0
	private void RefreshBuffName()
	{
		MowTowerBuffRe? mowingTowerBuffById = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentSelectBuff.BuffId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), mowingTowerBuffById.Value.Name, Array.Empty<object>());
	}

	// Token: 0x04003EAE RID: 16046
	public int SlotIndex;

	// Token: 0x04003EAF RID: 16047
	[Nullable(2)]
	private MowingTowerBuffInfo CurrentSelectBuff;

	// Token: 0x02006B83 RID: 27523
	private class EBuffEntryComponent
	{
		// Token: 0x04023587 RID: 144775
		public const int EntryButton = 0;

		// Token: 0x04023588 RID: 144776
		public const int NoneItem = 1;

		// Token: 0x04023589 RID: 144777
		public const int NotNoneItem = 2;

		// Token: 0x0402358A RID: 144778
		public const int SelectBuffTipsText = 3;

		// Token: 0x0402358B RID: 144779
		public const int BuffTexture = 4;

		// Token: 0x0402358C RID: 144780
		public const int BuffName = 5;

		// Token: 0x0402358D RID: 144781
		public const int BuffDesc = 6;

		// Token: 0x0402358E RID: 144782
		public const int SwitchButton = 7;

		// Token: 0x0402358F RID: 144783
		public const int LockItem = 8;
	}
}
