using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D6 RID: 29398
	public static class IMpcEffectParamBase_UnionVerify
	{
		// Token: 0x06033416 RID: 209942 RVA: 0x006EA1F4 File Offset: 0x006E83F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPostProcessVolumeCenterPositionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMpcEffectParamBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
