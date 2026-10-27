using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC9 RID: 27337
	public static class IModifyMediaConfig_UnionVerify
	{
		// Token: 0x0602FE7D RID: 196221 RVA: 0x00684188 File Offset: 0x00682388
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IChangeMediaPlayDaVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IModifyMediaConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
