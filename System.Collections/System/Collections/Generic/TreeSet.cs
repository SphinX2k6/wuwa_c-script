using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x0200002E RID: 46
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public sealed class TreeSet<T> : SortedSet<T>
	{
		// Token: 0x0600020A RID: 522 RVA: 0x000083A2 File Offset: 0x000065A2
		public TreeSet()
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000083AA File Offset: 0x000065AA
		public TreeSet([Nullable(new byte[]
		{
			2,
			1
		})] IComparer<T> comparer) : base(comparer)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000083B3 File Offset: 0x000065B3
		internal TreeSet(TreeSet<T> set, IComparer<T> comparer) : base(set, comparer)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000083BD File Offset: 0x000065BD
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private TreeSet(SerializationInfo siInfo, StreamingContext context) : base(siInfo, context)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000083C7 File Offset: 0x000065C7
		internal override bool AddIfNotPresent(T item)
		{
			bool flag = base.AddIfNotPresent(item);
			if (!flag)
			{
				throw new ArgumentException(SR.Format(SR.Argument_AddingDuplicate, item));
			}
			return flag;
		}
	}
}
