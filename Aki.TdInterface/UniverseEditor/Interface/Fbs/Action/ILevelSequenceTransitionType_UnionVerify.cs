using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F5 RID: 27125
	public static class ILevelSequenceTransitionType_UnionVerify
	{
		// Token: 0x0602F74A RID: 194378 RVA: 0x006768E8 File Offset: 0x00674AE8
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
