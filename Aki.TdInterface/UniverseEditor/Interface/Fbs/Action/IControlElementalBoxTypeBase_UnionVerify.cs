using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B41 RID: 27457
	public static class IControlElementalBoxTypeBase_UnionVerify
	{
		// Token: 0x0602F3F9 RID: 193529 RVA: 0x006736D4 File Offset: 0x006718D4
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
