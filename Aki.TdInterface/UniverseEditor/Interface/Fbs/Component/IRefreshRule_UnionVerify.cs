using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005837 RID: 22583
	public static class IRefreshRule_UnionVerify
	{
		// Token: 0x06025FB8 RID: 155576 RVA: 0x0053C740 File Offset: 0x0053A940
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRefreshRuleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICdRefreshRuleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFixedDateTimeRefreshRuleVerify.Verify(verifier, tablePos);
				break;
			case 4:
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
