using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D5C RID: 19804
	public static class TTargetEntityVerify
	{
		// Token: 0x0601F6BD RID: 128701 RVA: 0x004609F8 File Offset: 0x0045EBF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPlayerEntityVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISelfEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITargetEntityVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITriggeredEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
