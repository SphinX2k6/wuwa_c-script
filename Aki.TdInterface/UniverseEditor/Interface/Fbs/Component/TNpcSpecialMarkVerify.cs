using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C77 RID: 23671
	public static class TNpcSpecialMarkVerify
	{
		// Token: 0x060288E4 RID: 166116 RVA: 0x005938DC File Offset: 0x00591ADC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || INpcSpecialMarkTrafficLightVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INpcSpecialMarkIgnoreCameraHideNpcVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
