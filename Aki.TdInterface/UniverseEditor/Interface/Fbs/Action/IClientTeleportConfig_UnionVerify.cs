using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7C RID: 27260
	public static class IClientTeleportConfig_UnionVerify
	{
		// Token: 0x0602EC4A RID: 191562 RVA: 0x0065F8EC File Offset: 0x0065DAEC
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
