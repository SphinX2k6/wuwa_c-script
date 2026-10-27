using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004383 RID: 17283
	public static class TPerformerAiDecoratorVerify
	{
		// Token: 0x06019B60 RID: 105312 RVA: 0x003AEB90 File Offset: 0x003ACD90
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPerformerAiAlwaysFalseDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPerformerAiAlwaysTrueDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPerformerAiConditionDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IPerformerAiCoolDownDecoratorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IPerformerAiDoOnceDecoratorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
