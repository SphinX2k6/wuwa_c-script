using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007608 RID: 30216
	public static class IResetEntityConfig_UnionVerify
	{
		// Token: 0x06035048 RID: 217160 RVA: 0x0071F4F0 File Offset: 0x0071D6F0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IResetEntityConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IResetTeleControlEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IJigsawItemEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
