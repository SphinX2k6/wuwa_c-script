using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061CD RID: 25037
	public static class IWuWaGoHintStepBase_UnionVerify
	{
		// Token: 0x0602A91A RID: 174362 RVA: 0x005CE0A0 File Offset: 0x005CC2A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IWuWaGoHintStepBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IWuWaGoHintStepMoveVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWuWaGoHintStepInteractVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
