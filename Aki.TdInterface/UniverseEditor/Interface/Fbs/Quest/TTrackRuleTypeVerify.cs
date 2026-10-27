using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004328 RID: 17192
	public static class TTrackRuleTypeVerify
	{
		// Token: 0x060197EA RID: 104426 RVA: 0x003A6F2C File Offset: 0x003A512C
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
