using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D0 RID: 21456
	public static class IHookLockScreenDetectTypeBase_UnionVerify
	{
		// Token: 0x06023366 RID: 144230 RVA: 0x004E06AC File Offset: 0x004DE8AC
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
