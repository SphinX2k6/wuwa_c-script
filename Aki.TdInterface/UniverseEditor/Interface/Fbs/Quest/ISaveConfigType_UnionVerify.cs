using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004540 RID: 17728
	public static class ISaveConfigType_UnionVerify
	{
		// Token: 0x06019AC1 RID: 105153 RVA: 0x003A7D6C File Offset: 0x003A5F6C
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
