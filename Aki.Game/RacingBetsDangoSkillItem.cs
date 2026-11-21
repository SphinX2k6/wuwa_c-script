using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001BFF RID: 7167
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsDangoSkillItem : GridProxyAbstract<RacingBetsDungeonDangoInfo>
{
	// Token: 0x06011CFD RID: 72957 RVA: 0x0053C9B4 File Offset: 0x0053ABB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06011CFE RID: 72958 RVA: 0x0053CA10 File Offset: 0x0053AC10
	[NullableContext(1)]
	public override void Refresh(RacingBetsDungeonDangoInfo data, bool isSelected, int gridIndex)
	{
		DangoData dangoData = DangoManager.Instance.GetDangoData(data.DangoId);
		base.SetTextureShowUntilLoaded(dangoData.Icon, base.GetTexture(0), null);
		DangoSkill? skillConfig = dangoData.GetSkillConfig();
		if (skillConfig != null)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(skillConfig.Value.Name);
			}
			UUIText text2 = base.GetText(2);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew(skillConfig.Value.Desc);
		}
	}

	// Token: 0x02007EF2 RID: 32498
	private class EComponent
	{
		// Token: 0x04029142 RID: 168258
		public const int DangoIcon = 0;

		// Token: 0x04029143 RID: 168259
		public const int SkillName = 1;

		// Token: 0x04029144 RID: 168260
		public const int SkillDesc = 2;
	}
}
