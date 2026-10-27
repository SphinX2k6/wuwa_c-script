using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B2 RID: 30642
	public static class TSubScreenModeVerify
	{
		// Token: 0x060379A7 RID: 227751 RVA: 0x00785788 File Offset: 0x00783988
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISubScreenModeAdjustVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISubScreenModeExitVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISubScreenModeInitVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
