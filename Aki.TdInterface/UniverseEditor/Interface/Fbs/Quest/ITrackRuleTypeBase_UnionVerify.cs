using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004675 RID: 18037
	public static class ITrackRuleTypeBase_UnionVerify
	{
		// Token: 0x0601A784 RID: 108420 RVA: 0x003C48E8 File Offset: 0x003C2AE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITrackRuleTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITrackRuleFindLastMatchStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITrackRuleFindFirstNotMatchStateVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
