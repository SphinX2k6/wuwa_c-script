using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C00 RID: 7168
public class RacingBetsDangoTerrainItem : GridProxyAbstract<int>
{
	// Token: 0x06011D00 RID: 72960 RVA: 0x0053CA9C File Offset: 0x0053AC9C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06011D01 RID: 72961 RVA: 0x0053CAF8 File Offset: 0x0053ACF8
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

	// Token: 0x02007EF3 RID: 32499
	private class EComponent
	{
		// Token: 0x04029145 RID: 168261
		public const int TerrainIcon = 0;

		// Token: 0x04029146 RID: 168262
		public const int TerrainName = 1;

		// Token: 0x04029147 RID: 168263
		public const int TerrainDesc = 2;
	}
}
