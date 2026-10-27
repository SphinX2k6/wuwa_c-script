using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063B1 RID: 25521
	public static class IClientEventTarget_UnionVerify
	{
		// Token: 0x0602C25E RID: 180830 RVA: 0x0060FFB0 File Offset: 0x0060E1B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientEventTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISelfClientEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientUiEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
