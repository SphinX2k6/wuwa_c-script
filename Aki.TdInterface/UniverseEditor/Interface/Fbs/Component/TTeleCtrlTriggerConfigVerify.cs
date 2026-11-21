using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062F3 RID: 25331
	public static class TTeleCtrlTriggerConfigVerify
	{
		// Token: 0x0602B0A4 RID: 176292 RVA: 0x005DE344 File Offset: 0x005DC544
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMechascoutJavelinTriggerConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMechascoutExplosiveBarrelTriggerConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
