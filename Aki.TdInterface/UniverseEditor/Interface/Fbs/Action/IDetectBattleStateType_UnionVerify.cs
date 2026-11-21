using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1F RID: 27679
	public static class IDetectBattleStateType_UnionVerify
	{
		// Token: 0x0602FA26 RID: 195110 RVA: 0x0067D704 File Offset: 0x0067B904
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDetectBattleTagVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDetectBattleStateTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
