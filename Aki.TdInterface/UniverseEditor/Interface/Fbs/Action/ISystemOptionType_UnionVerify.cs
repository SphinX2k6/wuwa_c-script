using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200728B RID: 29323
	public static class ISystemOptionType_UnionVerify
	{
		// Token: 0x06034078 RID: 213112 RVA: 0x006FEE84 File Offset: 0x006FD084
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISystemOptionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRogueRandomEventOptionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPermanentRogueRandomEventVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IGravityControlOptionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
