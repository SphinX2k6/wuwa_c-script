using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001479 RID: 5241
	[NullableContext(1)]
	[Nullable(0)]
	public class CustomActionParams : ActionParams
	{
		// Token: 0x17002819 RID: 10265
		// (get) Token: 0x06007738 RID: 30520 RVA: 0x0011CCCA File Offset: 0x0011AECA
		// (set) Token: 0x06007739 RID: 30521 RVA: 0x0011CCD2 File Offset: 0x0011AED2
		public string Name { get; set; }

		// Token: 0x1700281A RID: 10266
		// (get) Token: 0x0600773A RID: 30522 RVA: 0x0011CCDB File Offset: 0x0011AEDB
		// (set) Token: 0x0600773B RID: 30523 RVA: 0x0011CCE3 File Offset: 0x0011AEE3
		public JsonObject Param { get; set; }

		// Token: 0x0600773C RID: 30524 RVA: 0x0011CCEC File Offset: 0x0011AEEC
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
