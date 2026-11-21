using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007991 RID: 31121
	public static class IStartSlidePerformType_UnionVerify
	{
		// Token: 0x06036D0B RID: 224523 RVA: 0x00754EF8 File Offset: 0x007530F8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISlopeSlidePerformStartVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IStartSlidePerformTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
