using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006311 RID: 25361
	public static class TWuWaGoEntityDataVerify
	{
		// Token: 0x0602B13A RID: 176442 RVA: 0x005DF0A0 File Offset: 0x005DD2A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IWuWaGoBowTrapVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IWuWaGoEndGridVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWuWaGoGearVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IWuWaGoLevelCenterVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IWuWaGoMovableFloorVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IWuWaGoPressureTriggerVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IWuWaGoPullRodVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IWuWaGoSaveGridVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IWuWaGoSpikeTrapVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IWuWaGoStartGridVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
