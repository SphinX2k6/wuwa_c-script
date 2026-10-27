using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BB7 RID: 23479
	public static class IWuWaGoHintStepBase_UnionVerify
	{
		// Token: 0x06028356 RID: 164694 RVA: 0x00586610 File Offset: 0x00584810
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
