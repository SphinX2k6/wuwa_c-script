using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064C0 RID: 25792
	public static class TEaseCurveTypeVerify
	{
		// Token: 0x0602BDA7 RID: 179623 RVA: 0x005F6C00 File Offset: 0x005F4E00
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
