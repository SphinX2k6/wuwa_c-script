using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200409C RID: 16540
	public static class TTriggerTipShapeVerify
	{
		// Token: 0x06016C96 RID: 93334 RVA: 0x00340D78 File Offset: 0x0033EF78
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
