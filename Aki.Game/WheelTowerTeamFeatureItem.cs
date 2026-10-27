using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020015C8 RID: 5576
public class WheelTowerTeamFeatureItem : GridProxyAbstract<int>
{
	// Token: 0x06009E05 RID: 40453 RVA: 0x00226220 File Offset: 0x00224420
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E06 RID: 40454 RVA: 0x0022628C File Offset: 0x0022448C
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		NewTowerTeamFeature? teamFeatureConfig = WheelTowerConfig.Instance.GetTeamFeatureConfig(data);
		if (teamFeatureConfig == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), teamFeatureConfig.Value.Name, Array.Empty<object>());
		base.SetTextureByPath(teamFeatureConfig.Value.Icon, base.GetTexture(0), null, null);
	}
}
