using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace System
{
	// Token: 0x02000088 RID: 136
	[NullableContext(2)]
	[ClassInterface(ClassInterfaceType.AutoDispatch)]
	[ComVisible(true)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Object
	{
		// Token: 0x06000469 RID: 1129 RVA: 0x00009E60 File Offset: 0x00008060
		[NullableContext(1)]
		[Intrinsic]
		public Type GetType()
		{
			return this.GetType();
		}

		// Token: 0x0600046A RID: 1130
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		protected extern object MemberwiseClone();

		// Token: 0x0600046B RID: 1131 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NonVersionable]
		public Object()
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NonVersionable]
		protected virtual void Finalize()
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000FF1D File Offset: 0x0000E11D
		public virtual string ToString()
		{
			return this.GetType().ToString();
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000FF2A File Offset: 0x0000E12A
		public virtual bool Equals(object obj)
		{
			return this == obj;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000FF30 File Offset: 0x0000E130
		public static bool Equals(object objA, object objB)
		{
			return objA == objB || (objA != null && objB != null && objA.Equals(objB));
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000FF2A File Offset: 0x0000E12A
		[NonVersionable]
		public static bool ReferenceEquals(object objA, object objB)
		{
			return objA == objB;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000FF47 File Offset: 0x0000E147
		public virtual int GetHashCode()
		{
			return RuntimeHelpers.GetHashCode(this);
		}
	}
}
