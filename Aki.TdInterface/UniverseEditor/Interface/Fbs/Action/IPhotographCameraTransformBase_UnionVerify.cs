using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CBF RID: 27839
	public static class IPhotographCameraTransformBase_UnionVerify
	{
		// Token: 0x060310F0 RID: 200944 RVA: 0x006A86F4 File Offset: 0x006A68F4
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
