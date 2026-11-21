using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E3E RID: 24126
	public static class IRefreshRule_UnionVerify
	{
		// Token: 0x060284D8 RID: 165080 RVA: 0x005828CC File Offset: 0x00580ACC
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
