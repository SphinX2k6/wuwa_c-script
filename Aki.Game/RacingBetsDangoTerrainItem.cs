using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002715 RID: 10005
public class RacingBetsDangoTerrainItem : GridProxyAbstract<int>
{
	// Token: 0x0601481E RID: 83998 RVA: 0x0052DD80 File Offset: 0x0052BF80
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0601481F RID: 83999 RVA: 0x0052DDDC File Offset: 0x0052BFDC
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		RacingBetsOrgan? organConfig = RacingBetsConfig.Instance.GetOrganConfig(data);
		if (organConfig == null)
		{
			return;
		}
		base.GetText(1).ShowTextNew(organConfig.Value.Name);
		base.GetText(2).ShowTextNew(organConfig.Value.Description);
		base.SetTextureShowUntilLoaded(organConfig.Value.IconPath, base.GetTexture(0), null);
	}

	// Token: 0x02008D6A RID: 36202
	private class EComponent
	{
		// Token: 0x0402DE2E RID: 187950
		public const int TerrainIcon = 0;

		// Token: 0x0402DE2F RID: 187951
		public const int TerrainName = 1;

		// Token: 0x0402DE30 RID: 187952
		public const int TerrainDesc = 2;
	}
}
