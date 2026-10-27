using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.CiacconaGal;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020011E1 RID: 4577
[Nullable(new byte[]
{
	0,
	1
})]
public class CiacconaEndingIcon : GridProxyAbstract<CiacconaGalEndingData>
{
	// Token: 0x06007A0C RID: 31244 RVA: 0x0019B2FC File Offset: 0x001994FC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 1;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06007A0D RID: 31245 RVA: 0x0019B344 File Offset: 0x00199544
	[NullableContext(1)]
	public override void Refresh(CiacconaGalEndingData data, bool isSelected, int gridIndex)
	{
		string resourceId = "SP_PlotReasoningLock";
		if (data.IsFinished)
		{
			resourceId = ((data.Type == ECiacconaGalEndingType.Main) ? "SP_PlotReasoningFinishMain" : "SP_PlotReasoningFinishBranch");
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
	}

	// Token: 0x020077CD RID: 30669
	private class EEndingIconComponentDefine
	{
		// Token: 0x040277FB RID: 161787
		public const int SpriteIcon = 0;
	}
}
