using System;

namespace System.Runtime.Intrinsics
{
	// Token: 0x02000542 RID: 1346
	internal static class SimdVectorExtensions
	{
		// Token: 0x060049F7 RID: 18935 RVA: 0x000F7EDD File Offset: 0x000F60DD
		public unsafe static void Store<TVector, T>(this TVector source, T* destination) where TVector : ISimdVector<TVector, T>
		{
			ISimdVector<TVector, T>.Store(source, destination);
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x000F7EEC File Offset: 0x000F60EC
		public static TVector WithElement<TVector, T>(this TVector vector, int index, T value) where TVector : ISimdVector<TVector, T>
		{
			return ISimdVector<TVector, T>.WithElement(vector, index, value);
		}
	}
}
