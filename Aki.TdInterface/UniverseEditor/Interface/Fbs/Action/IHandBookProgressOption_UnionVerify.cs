using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6A RID: 28522
	public static class IHandBookProgressOption_UnionVerify
	{
		// Token: 0x060315DF RID: 202207 RVA: 0x006B2014 File Offset: 0x006B0214
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHandBookProgressOptionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHandBookGrantEmojiOptionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHandBookRollbackEmojiOptionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
