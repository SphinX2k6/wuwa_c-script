using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200624B RID: 25163
	public static class TFrequencyPaintLineOptionVerify
	{
		// Token: 0x0602AD54 RID: 175444 RVA: 0x005D9410 File Offset: 0x005D7610
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFrequencyPaintConnectLineVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFrequencyPaintEncloseLineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFrequencyPaintStraightLineVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFrequencyPaintStrokeLineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
