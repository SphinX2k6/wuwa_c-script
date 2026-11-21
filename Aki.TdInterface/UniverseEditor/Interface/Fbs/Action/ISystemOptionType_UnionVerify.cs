using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A60 RID: 31328
	public static class ISystemOptionType_UnionVerify
	{
		// Token: 0x0603737C RID: 226172 RVA: 0x00760214 File Offset: 0x0075E414
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISystemOptionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRogueRandomEventOptionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPermanentRogueRandomEventVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IGravityControlOptionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILiveInteractScOptionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
