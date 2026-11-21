using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007411 RID: 29713
	public static class IPetalGrabMoveType_UnionVerify
	{
		// Token: 0x06033FD5 RID: 212949 RVA: 0x00702000 File Offset: 0x00700200
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPetalGrabMoveLinearVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IPetalGrabMoveTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
