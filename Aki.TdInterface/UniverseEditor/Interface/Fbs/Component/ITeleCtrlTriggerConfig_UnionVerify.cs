using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A4B RID: 23115
	public static class ITeleCtrlTriggerConfig_UnionVerify
	{
		// Token: 0x060274E3 RID: 160995 RVA: 0x0056881C File Offset: 0x00566A1C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITeleCtrlTriggerConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMechascoutJavelinTriggerConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMechascoutExplosiveBarrelTriggerConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
