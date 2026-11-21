using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005956 RID: 22870
	public static class IHookLockScreenDetectTypeBase_UnionVerify
	{
		// Token: 0x0602541E RID: 152606 RVA: 0x0051D6D8 File Offset: 0x0051B8D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHookLockScreenDetectTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHookLockScreenDetectTypeCentralEllipseVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHookLockScreenDetectTypeFullScreenVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
