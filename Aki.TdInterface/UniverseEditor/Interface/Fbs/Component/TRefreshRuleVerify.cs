using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062CC RID: 25292
	public static class TRefreshRuleVerify
	{
		// Token: 0x0602AFE0 RID: 176096 RVA: 0x005DD0F0 File Offset: 0x005DB2F0
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
