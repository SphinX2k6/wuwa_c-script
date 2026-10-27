using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007685 RID: 30341
	public static class TClientTeleportConfigVerify
	{
		// Token: 0x0603734B RID: 226123 RVA: 0x0077B7B0 File Offset: 0x007799B0
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
