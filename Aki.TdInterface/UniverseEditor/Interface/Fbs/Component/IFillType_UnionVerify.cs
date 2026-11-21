using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BC RID: 22460
	public static class IFillType_UnionVerify
	{
		// Token: 0x0602441E RID: 148510 RVA: 0x004FBAAC File Offset: 0x004F9CAC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFillTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFixedFillVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDirectionFillVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
