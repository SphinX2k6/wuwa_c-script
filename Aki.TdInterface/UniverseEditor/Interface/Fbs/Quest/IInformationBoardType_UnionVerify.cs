using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EA1 RID: 16033
	public static class IInformationBoardType_UnionVerify
	{
		// Token: 0x06016A31 RID: 92721 RVA: 0x00345050 File Offset: 0x00343250
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
