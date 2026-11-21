using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.CiacconaGal;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000695 RID: 1685
[Nullable(new byte[]
{
	0,
	1
})]
public class CiacconaEndingIcon : GridProxyAbstract<CiacconaGalEndingData>
{
	// Token: 0x06004DA3 RID: 19875 RVA: 0x001A3FA8 File Offset: 0x001A21A8
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

	// Token: 0x06004DA4 RID: 19876 RVA: 0x001A3FF0 File Offset: 0x001A21F0
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

	// Token: 0x02006958 RID: 26968
	private class EEndingIconComponentDefine
	{
		// Token: 0x04022B2D RID: 142125
		public const int SpriteIcon = 0;
	}
}
