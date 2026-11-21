using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001BFC RID: 7164
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsDangoOrderItem : GridProxyAbstract<DangoIdToDiceNum>
{
	// Token: 0x06011CE6 RID: 72934 RVA: 0x0053C375 File Offset: 0x0053A575
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06011CE7 RID: 72935 RVA: 0x0053C3B0 File Offset: 0x0053A5B0
	[NullableContext(1)]
	public override void Refresh(DangoIdToDiceNum diceInfo, bool isSelected, int gridIndex)
	{
		DangoData dangoData = DangoManager.Instance.GetDangoData(diceInfo.DangoId);
		base.SetTextureShowUntilLoaded(dangoData.Icon, base.GetTexture(0), null);
		DangoConfig instance = DangoConfig.Instance;
		Dice? dice = (instance != null) ? instance.GetDiceById(diceInfo.DiceId) : null;
		if (dice != null)
		{
			base.SetTextureShowUntilLoaded(dice.Value.RollDiceBackgroundIcon, base.GetTexture(1), null);
		}
	}

	// Token: 0x02007EE8 RID: 32488
	private enum EComponent
	{
		// Token: 0x04029116 RID: 168214
		DangoIcon,
		// Token: 0x04029117 RID: 168215
		DiceIcon
	}
}
