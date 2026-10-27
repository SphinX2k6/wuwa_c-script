using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE7 RID: 23527
	public static class TAkEventTypeVerify
	{
		// Token: 0x0602851E RID: 165150 RVA: 0x0058A244 File Offset: 0x00588444
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBoxAkEventVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IDefaultAkEventVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPointAkEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
