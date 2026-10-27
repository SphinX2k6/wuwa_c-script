using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CDD RID: 23773
	public static class TWuWaGoEntityDataVerify
	{
		// Token: 0x06028AE6 RID: 166630 RVA: 0x00596830 File Offset: 0x00594A30
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
