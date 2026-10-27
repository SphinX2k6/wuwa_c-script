using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x0200501D RID: 20509
	[NullableContext(2)]
	[Nullable(0)]
	public class MovieSceneSubQteParamsProxy
	{
		// Token: 0x060347CF RID: 214991 RVA: 0x00C5D269 File Offset: 0x00C5B469
		public MovieSceneSubQteParamsProxy(int subQteId, QteSpineInfoProxy spineInfo)
		{
			this.SubQteId = subQteId;
			this.SpineInfo = spineInfo;
		}

		// Token: 0x0401BF8F RID: 114575
		public readonly int SubQteId;

		// Token: 0x0401BF90 RID: 114576
		public readonly QteSpineInfoProxy SpineInfo;
	}
}
