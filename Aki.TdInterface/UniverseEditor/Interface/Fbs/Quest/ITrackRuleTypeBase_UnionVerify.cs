using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004219 RID: 16921
	public static class ITrackRuleTypeBase_UnionVerify
	{
		// Token: 0x06019018 RID: 102424 RVA: 0x00399210 File Offset: 0x00397410
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
