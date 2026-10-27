using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004368 RID: 17256
	public static class IPerformerAiDecoratorBase_UnionVerify
	{
		// Token: 0x06019981 RID: 104833 RVA: 0x003A9B04 File Offset: 0x003A7D04
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPerformerAiDecoratorBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPerformerAiConditionDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPerformerAiAlwaysFalseDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPerformerAiAlwaysTrueDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPerformerAiDoOnceDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IPerformerAiCoolDownDecoratorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
