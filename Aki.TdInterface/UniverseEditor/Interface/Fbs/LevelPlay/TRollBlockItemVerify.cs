using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200461C RID: 17948
	public static class TRollBlockItemVerify
	{
		// Token: 0x0601B306 RID: 111366 RVA: 0x003DF4E4 File Offset: 0x003DD6E4
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
