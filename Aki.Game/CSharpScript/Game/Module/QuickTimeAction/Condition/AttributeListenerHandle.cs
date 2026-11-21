using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuickTimeAction.Condition
{
	// Token: 0x02003F15 RID: 16149
	[NullableContext(1)]
	[Nullable(0)]
	public class AttributeListenerHandle
	{
		// Token: 0x06028F59 RID: 167769 RVA: 0x00B7EAB0 File Offset: 0x00B7CCB0
		public AttributeListenerHandle(int id, Action<EAttributeType, float, float> callback)
		{
			this.Id = id;
			this.Callback = callback;
		}

		// Token: 0x04016438 RID: 91192
		public int Id;

		// Token: 0x04016439 RID: 91193
		public Action<EAttributeType, float, float> Callback;
	}
}
