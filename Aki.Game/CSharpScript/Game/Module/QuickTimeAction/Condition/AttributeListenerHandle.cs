using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02004F4C RID: 20300
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeListenerHandle
	{
		// Token: 0x060340EB RID: 213227 RVA: 0x00C35310 File Offset: 0x00C33510
		public AttributeListenerHandle(int id, Action<EAttributeType, float, float> callback)
		{
			this.Id = id;
			this.Callback = callback;
		}

		// Token: 0x0401BA63 RID: 113251
		public int Id;

		// Token: 0x0401BA64 RID: 113252
		public Action<EAttributeType, float, float> Callback;
	}
}
