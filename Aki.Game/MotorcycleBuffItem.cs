using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200119D RID: 4509
public class MotorcycleBuffItem : UiPanelBase
{
	// Token: 0x0600B3ED RID: 46061 RVA: 0x003525AC File Offset: 0x003507AC
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

	// Token: 0x0600B3EE RID: 46062 RVA: 0x0035261C File Offset: 0x0035081C
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

	// Token: 0x0200746B RID: 29803
	private static class EBuffItemComponentDefine
	{
		// Token: 0x04025E52 RID: 155218
		public const int Self = 0;

		// Token: 0x04025E53 RID: 155219
		public const int BgSprite = 1;

		// Token: 0x04025E54 RID: 155220
		public const int IconTexture = 2;

		// Token: 0x04025E55 RID: 155221
		public const int DescText = 3;
	}
}
