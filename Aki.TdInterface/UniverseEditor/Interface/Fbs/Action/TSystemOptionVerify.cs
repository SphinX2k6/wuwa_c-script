using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077BE RID: 30654
	public static class TSystemOptionVerify
	{
		// Token: 0x060379DB RID: 227803 RVA: 0x00785C14 File Offset: 0x00783E14
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGravityControlOptionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPermanentRogueRandomEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
