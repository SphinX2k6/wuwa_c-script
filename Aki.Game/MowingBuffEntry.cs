using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001385 RID: 4997
internal class MowingBuffEntry : UiPanelBase
{
	// Token: 0x06008C06 RID: 35846 RVA: 0x001DFE10 File Offset: 0x001DE010
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

	// Token: 0x06008C07 RID: 35847 RVA: 0x001DFF11 File Offset: 0x001DE111
	private void OnClickEntryButton()
	{
		UiManager.Instance.OpenView(EUiViewName.MowingTowerBuffView, null, null);
	}

	// Token: 0x06008C08 RID: 35848 RVA: 0x001DFF24 File Offset: 0x001DE124
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

	// Token: 0x06008C09 RID: 35849 RVA: 0x001DFF7C File Offset: 0x001DE17C
	private void RefreshBuffTips()
	{
		string textStringId = "BossRushBuffSelectTips";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, Array.Empty<object>());
	}

	// Token: 0x06008C0A RID: 35850 RVA: 0x001DFFA6 File Offset: 0x001DE1A6
	private void RefreshLockItemState()
	{
		base.GetItem(8).SetUIActive(false);
	}

	// Token: 0x06008C0B RID: 35851 RVA: 0x001DFFB5 File Offset: 0x001DE1B5
	private void RefreshSwitchButton()
	{
		base.GetItem(7).SetUIActive(this.CurrentSelectBuff.BuffId != 0);
	}

	// Token: 0x06008C0C RID: 35852 RVA: 0x001DFFD1 File Offset: 0x001DE1D1
	private void RefreshNoneShow()
	{
		base.GetItem(1).SetUIActive(this.CurrentSelectBuff.BuffId == 0);
		base.GetItem(2).SetUIActive(this.CurrentSelectBuff.BuffId != 0);
	}

	// Token: 0x06008C0D RID: 35853 RVA: 0x001E0007 File Offset: 0x001DE207
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

	// Token: 0x06008C0E RID: 35854 RVA: 0x001E002C File Offset: 0x001DE22C
	private void RefreshBuffTexture()
	{
		string texture = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentSelectBuff.BuffId).Value.Texture;
		base.SetTextureByPath(texture, base.GetTexture(4), null, null);
	}

	// Token: 0x06008C0F RID: 35855 RVA: 0x001E0078 File Offset: 0x001DE278
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

	// Token: 0x06008C10 RID: 35856 RVA: 0x001E019C File Offset: 0x001DE39C
	private void RefreshBuffName()
	{
		MowTowerBuffRe? mowingTowerBuffById = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentSelectBuff.BuffId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), mowingTowerBuffById.Value.Name, Array.Empty<object>());
	}

	// Token: 0x04003E16 RID: 15894
	public int SlotIndex;

	// Token: 0x04003E17 RID: 15895
	[Nullable(2)]
	private MowingTowerBuffInfo CurrentSelectBuff;

	// Token: 0x020079F9 RID: 31225
	private class EBuffEntryComponent
	{
		// Token: 0x0402825A RID: 164442
		public const int EntryButton = 0;

		// Token: 0x0402825B RID: 164443
		public const int NoneItem = 1;

		// Token: 0x0402825C RID: 164444
		public const int NotNoneItem = 2;

		// Token: 0x0402825D RID: 164445
		public const int SelectBuffTipsText = 3;

		// Token: 0x0402825E RID: 164446
		public const int BuffTexture = 4;

		// Token: 0x0402825F RID: 164447
		public const int BuffName = 5;

		// Token: 0x04028260 RID: 164448
		public const int BuffDesc = 6;

		// Token: 0x04028261 RID: 164449
		public const int SwitchButton = 7;

		// Token: 0x04028262 RID: 164450
		public const int LockItem = 8;
	}
}
