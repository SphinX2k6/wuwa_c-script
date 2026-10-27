using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043D7 RID: 17367
	public static class TRefSourceDataVerify
	{
		// Token: 0x06019E73 RID: 106099 RVA: 0x003B4C70 File Offset: 0x003B2E70
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
