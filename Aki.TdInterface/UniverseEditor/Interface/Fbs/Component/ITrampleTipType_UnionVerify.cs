using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060E1 RID: 24801
	public static class ITrampleTipType_UnionVerify
	{
		// Token: 0x06029FF7 RID: 172023 RVA: 0x005BB868 File Offset: 0x005B9A68
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrampleTipTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICountDownTextTipVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMechaTrackCountDownTipVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
