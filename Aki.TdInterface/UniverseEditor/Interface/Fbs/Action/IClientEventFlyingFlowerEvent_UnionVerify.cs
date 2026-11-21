using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A0D RID: 27149
	public static class IClientEventFlyingFlowerEvent_UnionVerify
	{
		// Token: 0x0602E93E RID: 190782 RVA: 0x0065A35C File Offset: 0x0065855C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClientEventFlyingFlowerUpdateSubtitleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientEventFlyingFlowerEventVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
