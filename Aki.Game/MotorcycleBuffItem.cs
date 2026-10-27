using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CDB RID: 7387
public class MotorcycleBuffItem : UiPanelBase
{
	// Token: 0x0600DFD0 RID: 57296 RVA: 0x00346B84 File Offset: 0x00344D84
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x0600DFD1 RID: 57297 RVA: 0x00346BF4 File Offset: 0x00344DF4
	[NullableContext(1)]
	public void SetDesc(IBuffGateDesc buffInfo)
	{
		MotorFightBuffGate? buffGateConfigById = MotorcycleArrowConfig.Instance.GetBuffGateConfigById(buffInfo.BuffGateId);
		if (buffGateConfigById == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), buffGateConfigById.Value.DetailDesc, new <>z__ReadOnlySingleElementList<object>(buffInfo.Desc.Item1));
		MotorFightQuality? config = ConfigMotorFightQualityById.GetConfig(buffGateConfigById.Value.Quality, true);
		base.SetTextureByPath(MotorcycleArrowConfig.Instance.GetCollectionTypeConfigById(buffGateConfigById.Value.Type).Value.TextureIcon, base.GetTexture(2), null, null);
		UUISprite sprite = base.GetSprite(1);
		if (sprite == null)
		{
			return;
		}
		sprite.SetColor(FColor.FromHex(config.Value.BgColor));
	}

	// Token: 0x020082E2 RID: 33506
	private static class EBuffItemComponentDefine
	{
		// Token: 0x0402AB2A RID: 174890
		public const int Self = 0;

		// Token: 0x0402AB2B RID: 174891
		public const int BgSprite = 1;

		// Token: 0x0402AB2C RID: 174892
		public const int IconTexture = 2;

		// Token: 0x0402AB2D RID: 174893
		public const int DescText = 3;
	}
}
