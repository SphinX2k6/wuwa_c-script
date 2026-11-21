using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000758 RID: 1880
	[NullableContext(1)]
	[Nullable(0)]
	public class MethodBody
	{
		// Token: 0x06007940 RID: 31040 RVA: 0x00005ACC File Offset: 0x00003CCC
		protected MethodBody()
		{
		}

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06007941 RID: 31041 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual int LocalSignatureMetadataToken
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06007942 RID: 31042 RVA: 0x0011FF78 File Offset: 0x0011E178
		public virtual IList<LocalVariableInfo> LocalVariables
		{
			get
			{
				throw new ArgumentNullException("array");
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06007943 RID: 31043 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual int MaxStackSize
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06007944 RID: 31044 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool InitLocals
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06007945 RID: 31045 RVA: 0x0001A4BA File Offset: 0x000186BA
		[NullableContext(2)]
		public virtual byte[] GetILAsByteArray()
		{
			return null;
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06007946 RID: 31046 RVA: 0x0011FF78 File Offset: 0x0011E178
		public virtual IList<ExceptionHandlingClause> ExceptionHandlingClauses
		{
			get
			{
				throw new ArgumentNullException("array");
			}
		}
	}
}
