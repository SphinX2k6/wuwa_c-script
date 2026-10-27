using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007090 RID: 28816
	public static class ISetTeleControlConfig_UnionVerify
	{
		// Token: 0x06033064 RID: 208996 RVA: 0x006E1E68 File Offset: 0x006E0068
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISetTeleControlConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenGravityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetResetPositionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
