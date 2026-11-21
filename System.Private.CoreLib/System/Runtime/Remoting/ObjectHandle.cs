using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Remoting
{
	// Token: 0x0200052C RID: 1324
	[NullableContext(2)]
	[Nullable(0)]
	public class ObjectHandle : MarshalByRefObject
	{
		// Token: 0x060048EA RID: 18666 RVA: 0x000F1F94 File Offset: 0x000F0194
		public ObjectHandle(object o)
		{
			this._wrappedObject = o;
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x000F1FA3 File Offset: 0x000F01A3
		public object Unwrap()
		{
			return this._wrappedObject;
		}

		// Token: 0x0400117E RID: 4478
		private readonly object _wrappedObject;
	}
}
