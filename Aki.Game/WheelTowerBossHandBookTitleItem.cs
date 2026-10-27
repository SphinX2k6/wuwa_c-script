using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200158F RID: 5519
public class WheelTowerBossHandBookTitleItem : GridProxyAbstract<int>
{
	// Token: 0x17000D78 RID: 3448
	// (get) Token: 0x06009D6A RID: 40298 RVA: 0x0022202C File Offset: 0x0022022C
	// (set) Token: 0x06009D6B RID: 40299 RVA: 0x00222034 File Offset: 0x00220234
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

	// Token: 0x06009D6C RID: 40300 RVA: 0x00222040 File Offset: 0x00220240
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

	// Token: 0x06009D6D RID: 40301 RVA: 0x00222108 File Offset: 0x00220308
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

	// Token: 0x06009D6E RID: 40302 RVA: 0x00222188 File Offset: 0x00220388
	public override void OnSelected(bool fireEvent)
	{
		this.OnToggleClick(EToggleState.ETT_Checked);
	}

	// Token: 0x06009D6F RID: 40303 RVA: 0x00222194 File Offset: 0x00220394
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

	// Token: 0x04004539 RID: 17721
	private NewTowerWave? WaveConfig;
}
