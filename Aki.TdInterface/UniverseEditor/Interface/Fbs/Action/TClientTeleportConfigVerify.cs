using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E93 RID: 32403
	public static class TClientTeleportConfigVerify
	{
		// Token: 0x0603A7F2 RID: 239602 RVA: 0x007DF8F8 File Offset: 0x007DDAF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IClientTpToStreamingTargetPointVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IClientTpRelativeEntityPosVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
