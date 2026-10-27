using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007396 RID: 29590
	public static class ITeleportToLatestResetPointType_UnionVerify
	{
		// Token: 0x06035B4E RID: 219982 RVA: 0x0074FB90 File Offset: 0x0074DD90
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
