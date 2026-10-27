using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C72 RID: 15474
	public static class ITriggerTipShape_UnionVerify
	{
		// Token: 0x060156AE RID: 87726 RVA: 0x003188E0 File Offset: 0x00316AE0
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
