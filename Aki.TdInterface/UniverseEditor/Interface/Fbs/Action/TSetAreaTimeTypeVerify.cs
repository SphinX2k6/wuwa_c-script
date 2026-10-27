using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200777F RID: 30591
	public static class TSetAreaTimeTypeVerify
	{
		// Token: 0x060378BD RID: 227517 RVA: 0x00784294 File Offset: 0x00782494
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
