using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007435 RID: 29749
	public static class IPhotographCameraTransformBase_UnionVerify
	{
		// Token: 0x060340C7 RID: 213191 RVA: 0x00703928 File Offset: 0x00701B28
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPhotographCameraTransformAbsoluteVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPhotographCameraTransformBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
