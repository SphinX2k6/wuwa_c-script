using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FE7 RID: 16359
	[NullableContext(2)]
	[Nullable(0)]
	public class MovieSceneSubQteParamsProxy
	{
		// Token: 0x06029672 RID: 169586 RVA: 0x00BA87B5 File Offset: 0x00BA69B5
		public MovieSceneSubQteParamsProxy(int subQteId, QteSpineInfoProxy spineInfo)
		{
			this.SubQteId = subQteId;
			this.SpineInfo = spineInfo;
		}

		// Token: 0x0401697A RID: 92538
		public readonly int SubQteId;

		// Token: 0x0401697B RID: 92539
		public readonly QteSpineInfoProxy SpineInfo;
	}
}
