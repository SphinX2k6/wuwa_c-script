using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B3 RID: 21683
	public static class ICharacterConnectorLogicType_UnionVerify
	{
		// Token: 0x0602225C RID: 139868 RVA: 0x004B4DA8 File Offset: 0x004B2FA8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICharacterConnectorRangeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICharacterConnectorLogicTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
