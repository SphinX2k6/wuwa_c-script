using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F84 RID: 20356
	public static class ICharacterConnectorLogicType_UnionVerify
	{
		// Token: 0x0602050A RID: 132362 RVA: 0x0047EDB8 File Offset: 0x0047CFB8
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
