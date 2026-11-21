using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004081 RID: 16513
	public static class ITriggerTipShape_UnionVerify
	{
		// Token: 0x06016BC2 RID: 93122 RVA: 0x0033F780 File Offset: 0x0033D980
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITriggerTipShapeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBoxTriggerTipShapeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISphereTriggerTipShapeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
