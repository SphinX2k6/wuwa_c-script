using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200483C RID: 18492
	public static class TRefSourceDataVerify
	{
		// Token: 0x0601B622 RID: 112162 RVA: 0x003E0AC0 File Offset: 0x003DECC0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAwakeEntityRefSourceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDestroyEntityRefSourceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IManualOccupationRefSourceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
