using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005453 RID: 21587
	public static class IBossStateViewStyle_UnionVerify
	{
		// Token: 0x06021E09 RID: 138761 RVA: 0x004AB730 File Offset: 0x004A9930
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDoubleViewBossStateViewStyleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBossStateViewStyleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
