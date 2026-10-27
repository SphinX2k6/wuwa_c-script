using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004595 RID: 17813
	public static class IRollBlockItemBase_UnionVerify
	{
		// Token: 0x0601AE8A RID: 110218 RVA: 0x003D6CA8 File Offset: 0x003D4EA8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRollBlockItemBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRollBlockItemBreakableObstacleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRollBlockItemQuantumObstacleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRollBlockItemLaserEmitterVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
