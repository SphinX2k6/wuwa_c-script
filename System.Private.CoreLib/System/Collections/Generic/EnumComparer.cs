using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x020009A2 RID: 2466
	[Serializable]
	internal sealed class EnumComparer<T> : Comparer<T>, ISerializable where T : struct, Enum
	{
		// Token: 0x060091DF RID: 37343 RVA: 0x0016A8BD File Offset: 0x00168ABD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int Compare(T x, T y)
		{
			return JitHelpers.EnumCompareTo<T>(x, y);
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x0016A8C6 File Offset: 0x00168AC6
		public EnumComparer()
		{
		}

		// Token: 0x060091E1 RID: 37345 RVA: 0x0016A8C6 File Offset: 0x00168AC6
		private EnumComparer(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060091E2 RID: 37346 RVA: 0x0016A8CE File Offset: 0x00168ACE
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj != null && base.GetType() == obj.GetType();
		}

		// Token: 0x060091E3 RID: 37347 RVA: 0x0016A8E6 File Offset: 0x00168AE6
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}

		// Token: 0x060091E4 RID: 37348 RVA: 0x0016A8F3 File Offset: 0x00168AF3
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(typeof(ObjectComparer<T>));
		}
	}
}
