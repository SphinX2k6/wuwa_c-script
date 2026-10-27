using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064D6 RID: 25814
	public static class IControlElementalBoxTypeBase_UnionVerify
	{
		// Token: 0x0602CC75 RID: 183413 RVA: 0x006275AC File Offset: 0x006257AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IControlElementalBoxTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IControlElementalBoxCaptureVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IControlElementalBoxReturnVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
