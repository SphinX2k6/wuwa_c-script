using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200478A RID: 18314
	public static class TTrackRuleTypeVerify
	{
		// Token: 0x0601AF78 RID: 110456 RVA: 0x003D2954 File Offset: 0x003D0B54
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITrackRuleFindLastMatchStateVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITrackRuleFindFirstNotMatchStateVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
