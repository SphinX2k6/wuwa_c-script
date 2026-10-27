using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063FC RID: 25596
	public static class IClientTeleportConfig_UnionVerify
	{
		// Token: 0x0602C474 RID: 181364 RVA: 0x00613A60 File Offset: 0x00611C60
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IClientTeleportConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IClientTpRelativeEntityPosVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IClientTpToStreamingTargetPointVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
