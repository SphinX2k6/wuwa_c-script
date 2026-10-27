using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BE5 RID: 23525
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaSubEndingIcon : GridProxyAbstract<CiacconaGalSubEndingData>
	{
		// Token: 0x0603B77C RID: 243580 RVA: 0x00E2E7F0 File Offset: 0x00E2C9F0
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

		// Token: 0x0603B77D RID: 243581 RVA: 0x00E2E838 File Offset: 0x00E2CA38
		[NullableContext(1)]
		public override void Refresh(CiacconaGalSubEndingData data, bool isSelected, int gridIndex)
		{
			string resourceId = "SP_PlotReasoningLock";
			if (data.IsFinished)
			{
				resourceId = ((data.Type == ECiacconaGalSubEndingType.Main) ? "SP_PlotReasoningFinishMain" : "SP_PlotReasoningFinishBranch");
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x0200BDCA RID: 48586
		private class EEndingIconComponentDefine
		{
			// Token: 0x040393A6 RID: 234406
			public const int SpriteIcon = 0;
		}
	}
}
