using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C9B RID: 23707
	public static class TRefreshRuleVerify
	{
		// Token: 0x0602899A RID: 166298 RVA: 0x005949B8 File Offset: 0x00592BB8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICdRefreshRuleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFixedDateTimeRefreshRuleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRandomNpcRuleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
