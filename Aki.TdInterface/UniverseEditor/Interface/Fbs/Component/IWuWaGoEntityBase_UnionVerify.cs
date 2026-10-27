using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA9 RID: 23465
	public static class IWuWaGoEntityBase_UnionVerify
	{
		// Token: 0x060282E8 RID: 164584 RVA: 0x00585910 File Offset: 0x00583B10
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IWuWaGoEntityBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IWuWaGoLevelCenterVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWuWaGoMovableFloorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IWuWaGoPullRodVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IWuWaGoPressureTriggerVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IWuWaGoGearVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IWuWaGoSpikeTrapVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IWuWaGoBowTrapVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IWuWaGoSaveGridVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IWuWaGoEndGridVerify.Verify(verifier, tablePos);
				break;
			case 11:
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
