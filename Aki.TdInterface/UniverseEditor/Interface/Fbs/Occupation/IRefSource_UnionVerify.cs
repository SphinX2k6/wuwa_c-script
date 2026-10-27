using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020043C4 RID: 17348
	public static class IRefSource_UnionVerify
	{
		// Token: 0x06019DDF RID: 105951 RVA: 0x003B3D00 File Offset: 0x003B1F00
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRefSourceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAwakeEntityRefSourceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDestroyEntityRefSourceVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
