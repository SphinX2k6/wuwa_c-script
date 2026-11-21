using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006200 RID: 25088
	public static class TAkEventTypeVerify
	{
		// Token: 0x0602AAEE RID: 174830 RVA: 0x005D1DD0 File Offset: 0x005CFFD0
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
