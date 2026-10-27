using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002714 RID: 10004
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsDangoSkillItem : GridProxyAbstract<RacingBetsDungeonDangoInfo>
{
	// Token: 0x0601481B RID: 83995 RVA: 0x0052DC98 File Offset: 0x0052BE98
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x0601481C RID: 83996 RVA: 0x0052DCF4 File Offset: 0x0052BEF4
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

	// Token: 0x02008D69 RID: 36201
	private class EComponent
	{
		// Token: 0x0402DE2B RID: 187947
		public const int DangoIcon = 0;

		// Token: 0x0402DE2C RID: 187948
		public const int SkillName = 1;

		// Token: 0x0402DE2D RID: 187949
		public const int SkillDesc = 2;
	}
}
