using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063AF RID: 25519
	public static class ICommonTarget_UnionVerify
	{
		// Token: 0x0602B54F RID: 177487 RVA: 0x005E7DEC File Offset: 0x005E5FEC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayerTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAssistCharacterTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
