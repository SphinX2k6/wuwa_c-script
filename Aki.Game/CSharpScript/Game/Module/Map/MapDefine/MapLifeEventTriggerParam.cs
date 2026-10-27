using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200557D RID: 21885
	[NullableContext(2)]
	[Nullable(0)]
	public class MapLifeEventTriggerParam<T> : IMapLifeEventTriggerParam
	{
		// Token: 0x17008637 RID: 34359
		// (get) Token: 0x06037C78 RID: 228472 RVA: 0x00D39295 File Offset: 0x00D37495
		// (set) Token: 0x06037C79 RID: 228473 RVA: 0x00D3929D File Offset: 0x00D3749D
		public bool State { get; set; }

		// Token: 0x17008638 RID: 34360
		// (get) Token: 0x06037C7A RID: 228474 RVA: 0x00D392A6 File Offset: 0x00D374A6
		object IMapLifeEventTriggerParam.Data
		{
			get
			{
				return this.Data;
			}
		}

		// Token: 0x0401D521 RID: 120097
		public T Data;
	}
}
