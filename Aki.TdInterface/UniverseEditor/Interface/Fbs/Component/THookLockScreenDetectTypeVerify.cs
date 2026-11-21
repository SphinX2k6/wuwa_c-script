using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006260 RID: 25184
	public static class THookLockScreenDetectTypeVerify
	{
		// Token: 0x0602ADE2 RID: 175586 RVA: 0x005DA2D0 File Offset: 0x005D84D0
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
