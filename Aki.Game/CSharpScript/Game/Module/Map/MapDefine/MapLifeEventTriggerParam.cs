using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004550 RID: 17744
	[NullableContext(2)]
	[Nullable(0)]
	public class MapLifeEventTriggerParam<T> : IMapLifeEventTriggerParam
	{
		// Token: 0x170059E0 RID: 23008
		// (get) Token: 0x0602CB52 RID: 183122 RVA: 0x00C86D69 File Offset: 0x00C84F69
		// (set) Token: 0x0602CB53 RID: 183123 RVA: 0x00C86D71 File Offset: 0x00C84F71
		public bool State { get; set; }

		// Token: 0x170059E1 RID: 23009
		// (get) Token: 0x0602CB54 RID: 183124 RVA: 0x00C86D7A File Offset: 0x00C84F7A
		object IMapLifeEventTriggerParam.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x04017FAA RID: 98218
		public T Data;
	}
}
