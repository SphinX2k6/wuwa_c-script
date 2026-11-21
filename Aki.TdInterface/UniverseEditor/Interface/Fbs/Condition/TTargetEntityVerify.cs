using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005258 RID: 21080
	public static class TTargetEntityVerify
	{
		// Token: 0x06021306 RID: 135942 RVA: 0x004949CC File Offset: 0x00492BCC
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
