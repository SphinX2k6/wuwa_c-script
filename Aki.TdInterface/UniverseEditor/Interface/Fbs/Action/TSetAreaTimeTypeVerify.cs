using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FB7 RID: 32695
	public static class TSetAreaTimeTypeVerify
	{
		// Token: 0x0603AE36 RID: 241206 RVA: 0x007E9754 File Offset: 0x007E7954
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetAreaTimeUnLockVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetAreaTimeLockVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
