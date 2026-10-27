using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007694 RID: 30356
	public static class TControlElementalBoxTypeVerify
	{
		// Token: 0x060373CB RID: 226251 RVA: 0x0077C5BC File Offset: 0x0077A7BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IControlElementalBoxReturnVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IControlElementalBoxCaptureVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
