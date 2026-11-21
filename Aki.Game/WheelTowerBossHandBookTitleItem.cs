using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000A47 RID: 2631
public class WheelTowerBossHandBookTitleItem : GridProxyAbstract<int>
{
	// Token: 0x17000D99 RID: 3481
	// (get) Token: 0x06007148 RID: 29000 RVA: 0x0022BDDC File Offset: 0x00229FDC
	// (set) Token: 0x06007149 RID: 29001 RVA: 0x0022BDE4 File Offset: 0x00229FE4
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<NewTowerWave?, UUIExtendToggle> OnClickToggleBack { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x0600714A RID: 29002 RVA: 0x0022BDF0 File Offset: 0x00229FF0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600714B RID: 29003 RVA: 0x0022BEB8 File Offset: 0x0022A0B8
	public override void Refresh(int waveId, bool isSelected, int gridIndex)
	{
		NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(waveId);
		if (waveConfigById == null)
		{
			return;
		}
		this.WaveConfig = new NewTowerWave?(waveConfigById.Value);
		base.SetTextureByPath(waveConfigById.Value.SmallIconHandBook, base.GetTexture(1), null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), waveConfigById.Value.Name, Array.Empty<object>());
	}

	// Token: 0x0600714C RID: 29004 RVA: 0x0022BF38 File Offset: 0x0022A138
	public override void OnSelected(bool fireEvent)
	{
		this.OnToggleClick(EToggleState.ETT_Checked);
	}

	// Token: 0x0600714D RID: 29005 RVA: 0x0022BF44 File Offset: 0x0022A144
	private void OnToggleClick(EToggleState state)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			Action<NewTowerWave?, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(this.WaveConfig, extendToggle);
		}
	}

	// Token: 0x040045DF RID: 17887
	private NewTowerWave? WaveConfig;
}
