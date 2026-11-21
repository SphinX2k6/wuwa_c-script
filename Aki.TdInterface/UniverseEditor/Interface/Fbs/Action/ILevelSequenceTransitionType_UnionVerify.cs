using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A5 RID: 28837
	public static class ILevelSequenceTransitionType_UnionVerify
	{
		// Token: 0x0603210A RID: 205066 RVA: 0x006C6C40 File Offset: 0x006C4E40
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILevelSequenceTransitionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICameraTransitionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMaskTransitionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
