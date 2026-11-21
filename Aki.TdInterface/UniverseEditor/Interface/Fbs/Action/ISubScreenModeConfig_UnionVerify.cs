using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079EB RID: 31211
	public static class ISubScreenModeConfig_UnionVerify
	{
		// Token: 0x06036FDB RID: 225243 RVA: 0x00759ECC File Offset: 0x007580CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISubScreenModeConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISubScreenModeInitVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISubScreenModeAdjustVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISubScreenModeExitVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
