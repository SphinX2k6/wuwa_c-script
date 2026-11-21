using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C66 RID: 19558
	public static class TEntityOwnerVerify
	{
		// Token: 0x0601E015 RID: 122901 RVA: 0x00434C20 File Offset: 0x00432E20
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
