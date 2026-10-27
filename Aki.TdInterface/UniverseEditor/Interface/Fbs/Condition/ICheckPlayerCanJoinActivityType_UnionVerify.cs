using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AE0 RID: 19168
	public static class ICheckPlayerCanJoinActivityType_UnionVerify
	{
		// Token: 0x0601E1BF RID: 123327 RVA: 0x00439334 File Offset: 0x00437534
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICheckPlayerCanJoinRogueVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICheckPlayerCanJoinActivityTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
