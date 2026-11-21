using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200624E RID: 25166
	public static class TFrequencyPaintRangeVerify
	{
		// Token: 0x0602AD60 RID: 175456 RVA: 0x005D9530 File Offset: 0x005D7730
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISphereTriggerShapeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IBoxTriggerShapeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
