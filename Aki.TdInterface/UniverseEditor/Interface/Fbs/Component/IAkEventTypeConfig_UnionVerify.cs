using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E94 RID: 20116
	public static class IAkEventTypeConfig_UnionVerify
	{
		// Token: 0x0601FA7D RID: 129661 RVA: 0x004688FC File Offset: 0x00466AFC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAkEventTypeConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPointAkEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBoxAkEventVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDefaultAkEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
