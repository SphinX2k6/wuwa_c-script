using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FA RID: 26874
	public static class ICameraLockTargetBase_UnionVerify
	{
		// Token: 0x0602E04D RID: 188493 RVA: 0x0064A084 File Offset: 0x00648284
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
