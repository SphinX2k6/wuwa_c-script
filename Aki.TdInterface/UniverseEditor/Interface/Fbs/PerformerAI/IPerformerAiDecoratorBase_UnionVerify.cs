using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x020047CA RID: 18378
	public static class IPerformerAiDecoratorBase_UnionVerify
	{
		// Token: 0x0601B10F RID: 110863 RVA: 0x003D552C File Offset: 0x003D372C
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
