using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047FE RID: 18430
	public static class TEntityOwnerVerify
	{
		// Token: 0x0601C818 RID: 116760 RVA: 0x004082D0 File Offset: 0x004064D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEntityOwnerEntityVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEntityOwnerLevelPlayVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityOwnerQuestVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
