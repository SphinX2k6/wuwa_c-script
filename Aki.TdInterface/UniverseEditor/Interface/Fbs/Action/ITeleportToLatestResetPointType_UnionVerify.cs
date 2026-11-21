using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B7D RID: 31613
	public static class ITeleportToLatestResetPointType_UnionVerify
	{
		// Token: 0x06038EE9 RID: 233193 RVA: 0x007B20D0 File Offset: 0x007B02D0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITeleportToLatestResetPointDirectlyVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITeleportToLatestResetPointTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
