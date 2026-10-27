using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E2 RID: 30690
	public static class TToggleMapMarkStateVerify
	{
		// Token: 0x06037AA7 RID: 228007 RVA: 0x00786FF4 File Offset: 0x007851F4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDisableMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHideMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IShowMapMarkVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
