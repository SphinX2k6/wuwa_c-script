using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049FD RID: 18941
	public static class IRollBlockItemBase_UnionVerify
	{
		// Token: 0x0601C65F RID: 116319 RVA: 0x00402F44 File Offset: 0x00401144
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
