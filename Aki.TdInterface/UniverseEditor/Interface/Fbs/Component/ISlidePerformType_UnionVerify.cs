using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005934 RID: 22836
	public static class ISlidePerformType_UnionVerify
	{
		// Token: 0x06026A21 RID: 158241 RVA: 0x005522C8 File Offset: 0x005504C8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISlopeSlidePerformVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISlidePerformTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
