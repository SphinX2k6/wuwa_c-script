using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007216 RID: 29206
	public static class ISubScreenModeConfig_UnionVerify
	{
		// Token: 0x06033CD9 RID: 212185 RVA: 0x006F8B6C File Offset: 0x006F6D6C
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
