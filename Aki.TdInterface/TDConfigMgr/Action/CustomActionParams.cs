using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020015D2 RID: 5586
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomActionParams : ActionParams
	{
		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x06007E05 RID: 32261 RVA: 0x0012B8D5 File Offset: 0x00129AD5
		// (set) Token: 0x06007E06 RID: 32262 RVA: 0x0012B8DD File Offset: 0x00129ADD
		public string Name { get; set; }

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x06007E07 RID: 32263 RVA: 0x0012B8E6 File Offset: 0x00129AE6
		// (set) Token: 0x06007E08 RID: 32264 RVA: 0x0012B8EE File Offset: 0x00129AEE
		public JsonObject Param { get; set; }

		// Token: 0x06007E09 RID: 32265 RVA: 0x0012B8F7 File Offset: 0x00129AF7
		[NullableContext(2)]
		public CustomActionParams(string name, JsonObject jsonObj)
		{
			if (name == null)
			{
				throw new JsonException("CustomActionParams, name为空");
			}
			this.Name = name;
			if (jsonObj == null)
			{
				throw new JsonException("CustomActionParams, jsonObj为空");
			}
			this.Param = jsonObj;
		}
	}
}
