using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C8A RID: 15498
	public static class TTriggerTipShapeVerify
	{
		// Token: 0x0601575E RID: 87902 RVA: 0x00319B00 File Offset: 0x00317D00
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISphereTriggerTipShapeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBoxTriggerTipShapeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
