using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FC3 RID: 32707
	public static class TSetTeleControlConfigVerify
	{
		// Token: 0x0603AE70 RID: 241264 RVA: 0x007E9CA4 File Offset: 0x007E7EA4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetResetPositionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IOpenGravityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
