using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF6 RID: 28406
	public static class IRogueSelectRoomType_UnionVerify
	{
		// Token: 0x0603231C RID: 205596 RVA: 0x006C8624 File Offset: 0x006C6824
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
