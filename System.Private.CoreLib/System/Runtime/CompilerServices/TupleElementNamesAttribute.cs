using System;
using System.Collections.Generic;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020006DA RID: 1754
	[CLSCompliant(false)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	public sealed class TupleElementNamesAttribute : Attribute
	{
		// Token: 0x060074BC RID: 29884 RVA: 0x00115EE0 File Offset: 0x001140E0
		public TupleElementNamesAttribute([Nullable(new byte[]
		{
			1,
			2
		})] string[] transformNames)
		{
			ArgumentNullException.ThrowIfNull(transformNames, "transformNames");
			this._transformNames = transformNames;
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060074BD RID: 29885 RVA: 0x00115EFA File Offset: 0x001140FA
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public IList<string> TransformNames
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				return this._transformNames;
			}
		}

		// Token: 0x040014FD RID: 5373
		private readonly string[] _transformNames;
	}
}
