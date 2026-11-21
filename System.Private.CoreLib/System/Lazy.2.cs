using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System
{
	// Token: 0x0200015F RID: 351
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class Lazy<[Nullable(2), DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] T, [Nullable(2)] TMetadata> : Lazy<T>
	{
		// Token: 0x06001732 RID: 5938 RVA: 0x000464B8 File Offset: 0x000446B8
		public Lazy(Func<T> valueFactory, TMetadata metadata) : base(valueFactory)
		{
			this._metadata = metadata;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x000464C8 File Offset: 0x000446C8
		public Lazy(TMetadata metadata)
		{
			this._metadata = metadata;
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x000464D7 File Offset: 0x000446D7
		public Lazy(TMetadata metadata, bool isThreadSafe) : base(isThreadSafe)
		{
			this._metadata = metadata;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x000464E7 File Offset: 0x000446E7
		public Lazy(Func<T> valueFactory, TMetadata metadata, bool isThreadSafe) : base(valueFactory, isThreadSafe)
		{
			this._metadata = metadata;
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x000464F8 File Offset: 0x000446F8
		public Lazy(TMetadata metadata, LazyThreadSafetyMode mode) : base(mode)
		{
			this._metadata = metadata;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x00046508 File Offset: 0x00044708
		public Lazy(Func<T> valueFactory, TMetadata metadata, LazyThreadSafetyMode mode) : base(valueFactory, mode)
		{
			this._metadata = metadata;
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00046519 File Offset: 0x00044719
		public TMetadata Metadata
		{
			get
			{
				return this._metadata;
			}
		}

		// Token: 0x040004DF RID: 1247
		private readonly TMetadata _metadata;
	}
}
