using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062BD RID: 25277
	public static class TPortalViewDistanceConfigVerify
	{
		// Token: 0x0602AF9C RID: 176028 RVA: 0x005DCAD8 File Offset: 0x005DACD8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICustomViewDistanceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHighViewDistanceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILowViewDistanceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMidViewDistanceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
