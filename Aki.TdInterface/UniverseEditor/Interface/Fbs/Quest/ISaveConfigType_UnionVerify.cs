using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040FF RID: 16639
	public static class ISaveConfigType_UnionVerify
	{
		// Token: 0x06018420 RID: 99360 RVA: 0x0037DE1C File Offset: 0x0037C01C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISaveConfigTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISaveNewVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISavePointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
