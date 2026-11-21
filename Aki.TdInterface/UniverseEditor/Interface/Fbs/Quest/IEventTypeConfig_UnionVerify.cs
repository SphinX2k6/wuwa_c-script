using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004252 RID: 16978
	public static class IEventTypeConfig_UnionVerify
	{
		// Token: 0x06017A1E RID: 96798 RVA: 0x0035EB9C File Offset: 0x0035CD9C
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
