using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007788 RID: 30600
	public static class TSetPlayerOperationRestrictionVerify
	{
		// Token: 0x060378E9 RID: 227561 RVA: 0x00784694 File Offset: 0x00782894
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDisableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDisableModulePlayerOperationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEnableAllPlayerOperationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
