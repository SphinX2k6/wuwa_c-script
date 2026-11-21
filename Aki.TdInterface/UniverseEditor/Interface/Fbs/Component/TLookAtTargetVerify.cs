using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200627E RID: 25214
	public static class TLookAtTargetVerify
	{
		// Token: 0x0602AE6A RID: 175722 RVA: 0x005DAEDC File Offset: 0x005D90DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ILookAtTargetPlayerVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ILookAtTargetEntityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
