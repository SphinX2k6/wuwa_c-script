using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BD RID: 21437
	public static class IAkEventTypeConfig_UnionVerify
	{
		// Token: 0x06021772 RID: 137074 RVA: 0x0049DB60 File Offset: 0x0049BD60
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
