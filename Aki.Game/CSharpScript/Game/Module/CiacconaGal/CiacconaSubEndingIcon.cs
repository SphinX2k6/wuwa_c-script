using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BC5 RID: 19397
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaSubEndingIcon : GridProxyAbstract<CiacconaGalSubEndingData>
	{
		// Token: 0x060306C7 RID: 198343 RVA: 0x00D7EB00 File Offset: 0x00D7CD00
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

		// Token: 0x060306C8 RID: 198344 RVA: 0x00D7EB48 File Offset: 0x00D7CD48
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

		// Token: 0x0200A7D2 RID: 42962
		private class EEndingIconComponentDefine
		{
			// Token: 0x04033D69 RID: 212329
			public const int SpriteIcon = 0;
		}
	}
}
