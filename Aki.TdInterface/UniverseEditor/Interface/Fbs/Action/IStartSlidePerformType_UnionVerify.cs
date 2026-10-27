using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BC RID: 29116
	public static class IStartSlidePerformType_UnionVerify
	{
		// Token: 0x06033A0D RID: 211469 RVA: 0x006F3C2C File Offset: 0x006F1E2C
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
