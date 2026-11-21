using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006058 RID: 24664
	public static class ITeleCtrlTriggerConfig_UnionVerify
	{
		// Token: 0x06029A5B RID: 170587 RVA: 0x005AF828 File Offset: 0x005ADA28
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
