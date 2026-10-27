using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051D6 RID: 20950
	public static class IExhibitItemTypeVerify
	{
		// Token: 0x06021F95 RID: 139157 RVA: 0x004B67CE File Offset: 0x004B49CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
