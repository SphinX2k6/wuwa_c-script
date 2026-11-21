using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A84 RID: 19076
	public static class TRollBlockItemVerify
	{
		// Token: 0x0601CADB RID: 117467 RVA: 0x0040B780 File Offset: 0x00409980
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRollBlockItemBreakableObstacleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRollBlockItemLaserEmitterVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRollBlockItemQuantumObstacleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
