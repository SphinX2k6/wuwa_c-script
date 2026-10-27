using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065B7 RID: 26039
	public static class IDetectBattleStateType_UnionVerify
	{
		// Token: 0x0602D2A2 RID: 184994 RVA: 0x00631540 File Offset: 0x0062F740
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
