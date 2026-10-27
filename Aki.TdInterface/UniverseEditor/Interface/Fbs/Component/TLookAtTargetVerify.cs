using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C59 RID: 23641
	public static class TLookAtTargetVerify
	{
		// Token: 0x0602885C RID: 165980 RVA: 0x00592CC4 File Offset: 0x00590EC4
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
