using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200767A RID: 30330
	public static class IRogueSelectRoomType_UnionVerify
	{
		// Token: 0x0603535C RID: 217948 RVA: 0x00724358 File Offset: 0x00722558
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRogueRoleSelectRoomVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRogueSelectRoomTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
