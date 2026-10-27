using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C3B RID: 23611
	public static class THookLockScreenDetectTypeVerify
	{
		// Token: 0x060287D4 RID: 165844 RVA: 0x005920B8 File Offset: 0x005902B8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IHookLockScreenDetectTypeFullScreenVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IHookLockScreenDetectTypeCentralEllipseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
