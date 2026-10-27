using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E17 RID: 15895
	public static class IEventTypeConfig_UnionVerify
	{
		// Token: 0x060163F1 RID: 91121 RVA: 0x00335FA4 File Offset: 0x003341A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEventTypeConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonEventVarValueChangeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICommonEventEntityStateChangeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
