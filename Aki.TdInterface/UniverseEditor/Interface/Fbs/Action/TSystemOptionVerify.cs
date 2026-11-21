using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FF6 RID: 32758
	public static class TSystemOptionVerify
	{
		// Token: 0x0603AF5E RID: 241502 RVA: 0x007EB218 File Offset: 0x007E9418
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGravityControlOptionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILiveInteractScOptionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPermanentRogueRandomEventVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRogueRandomEventOptionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
