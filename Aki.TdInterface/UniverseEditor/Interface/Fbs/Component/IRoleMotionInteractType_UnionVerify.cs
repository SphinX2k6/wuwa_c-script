using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005881 RID: 22657
	public static class IRoleMotionInteractType_UnionVerify
	{
		// Token: 0x060262CF RID: 156367 RVA: 0x00543500 File Offset: 0x00541700
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
