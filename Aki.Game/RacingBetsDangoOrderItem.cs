using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002711 RID: 10001
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsDangoOrderItem : GridProxyAbstract<DangoIdToDiceNum>
{
	// Token: 0x06014804 RID: 83972 RVA: 0x0052D659 File Offset: 0x0052B859
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06014805 RID: 83973 RVA: 0x0052D694 File Offset: 0x0052B894
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

	// Token: 0x02008D5F RID: 36191
	private enum EComponent
	{
		// Token: 0x0402DDFF RID: 187903
		DangoIcon,
		// Token: 0x0402DE00 RID: 187904
		DiceIcon
	}
}
