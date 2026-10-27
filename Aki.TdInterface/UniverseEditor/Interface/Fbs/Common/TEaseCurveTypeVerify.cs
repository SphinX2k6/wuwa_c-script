using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E7D RID: 24189
	public static class TEaseCurveTypeVerify
	{
		// Token: 0x060296FF RID: 169727 RVA: 0x005ADC5C File Offset: 0x005ABE5C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEaseCurvePresetVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEaseCurveCustomVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
