using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005855 RID: 22613
	public static class IFrequencyPaintLineBase_UnionVerify
	{
		// Token: 0x06024A34 RID: 150068 RVA: 0x00508924 File Offset: 0x00506B24
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFrequencyPaintLineBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFrequencyPaintStraightLineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFrequencyPaintConnectLineVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFrequencyPaintEncloseLineVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
