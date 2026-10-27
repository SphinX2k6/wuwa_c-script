using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006289 RID: 25225
	public static class ICameraLockTargetBase_UnionVerify
	{
		// Token: 0x0602B8EC RID: 178412 RVA: 0x005FF27C File Offset: 0x005FD47C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICameraLockTargetPositionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICameraLockTargetBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
