using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DF RID: 17119
	public static class IInformationBoardType_UnionVerify
	{
		// Token: 0x0601807E RID: 98430 RVA: 0x0036DFD8 File Offset: 0x0036C1D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDangoAbyssInformationBoardVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInformationBoardTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
