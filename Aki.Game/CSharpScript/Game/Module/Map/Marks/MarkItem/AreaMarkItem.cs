using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044AA RID: 17578
	[NullableContext(1)]
	[Nullable(0)]
	public class AreaMarkItem : ConfigMarkItem
	{
		// Token: 0x0602C5DA RID: 181722 RVA: 0x00C79B09 File Offset: 0x00C77D09
		public AreaMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource? trackSource = null) : base(markId, markConfig, parent, mapType, markScale, trackSource)
		{
		}

		// Token: 0x0602C5DB RID: 181723 RVA: 0x00C79B1A File Offset: 0x00C77D1A
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.AreaMarkItemView;
		}

		// Token: 0x0602C5DC RID: 181724 RVA: 0x00C79B1D File Offset: 0x00C77D1D
		protected override MarkItemView CreateView()
		{
			return new AreaMarkItemView(this);
		}

		// Token: 0x0602C5DD RID: 181725 RVA: 0x00C79B25 File Offset: 0x00C77D25
		public override bool GetInteractiveFlag()
		{
			return false;
		}
	}
}
