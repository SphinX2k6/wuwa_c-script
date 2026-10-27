using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071A1 RID: 29089
	public static class ISportConfig_UnionVerify
	{
		// Token: 0x0603392D RID: 211245 RVA: 0x006F20AC File Offset: 0x006F02AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISportConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISkiConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISlideConfigVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPetalGrabConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
