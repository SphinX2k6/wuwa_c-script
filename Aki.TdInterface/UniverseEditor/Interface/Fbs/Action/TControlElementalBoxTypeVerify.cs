using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E9F RID: 32415
	public static class TControlElementalBoxTypeVerify
	{
		// Token: 0x0603A86E RID: 239726 RVA: 0x007E0710 File Offset: 0x007DE910
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
