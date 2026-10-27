using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CF6 RID: 7414
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PinballBattleBuffItem : GridProxyAbstract<IBuffView>
{
	// Token: 0x0600E09D RID: 57501 RVA: 0x0034AD60 File Offset: 0x00348F60
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600E09E RID: 57502 RVA: 0x0034ADCC File Offset: 0x00348FCC
	public override void Refresh(IBuffView buffView, bool isSelected, int gridIndex)
	{
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.SetUIActive(buffView.BuffType != EPinballBuffType.Special && buffView.BuffCount > 1);
		}
		if (buffView.BuffType == EPinballBuffType.Special)
		{
			base.TrySetSpriteByPath(PinballConfig.Instance.GetPinballBuffConfigById(buffView.BuffId).Value.BuffIcon, base.GetSprite(0), false, null, null);
			return;
		}
		PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
		string path = null;
		PinballWorldConfig? pinballWorldConfig = (pinballBattleSubModel != null) ? pinballBattleSubModel.WorldConfigCache : null;
		if (pinballWorldConfig != null)
		{
			PinballWorldConfig value = pinballWorldConfig.Value;
			for (int i = 0; i < value.CommonBuffIconMapLength; i++)
			{
				DicIntString? dicIntString = value.CommonBuffIconMap(i);
				if (dicIntString != null && dicIntString.Value.Key == (int)buffView.BuffType)
				{
					path = dicIntString.Value.Value;
					break;
				}
			}
		}
		base.TrySetSpriteByPath(path, base.GetSprite(0), false, null, null);
		UUIText text2 = base.GetText(1);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(buffView.BuffCount.ToString(), true);
	}
}
