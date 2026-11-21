using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E8E RID: 24206
	public static class IRoleMotionInteractType_UnionVerify
	{
		// Token: 0x06028831 RID: 165937 RVA: 0x0058A04C File Offset: 0x0058824C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPetalGrabRoleMotionInteractVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRoleMotionInteractTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
