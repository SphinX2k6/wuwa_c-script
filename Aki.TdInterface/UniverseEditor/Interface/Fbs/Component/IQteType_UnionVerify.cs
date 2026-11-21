using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DCC RID: 24012
	public static class IQteType_UnionVerify
	{
		// Token: 0x06028081 RID: 163969 RVA: 0x00579780 File Offset: 0x00577980
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISingleBtnQteVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IQteTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
