using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC2 RID: 23746
	public static class TTeleCtrlTriggerConfigVerify
	{
		// Token: 0x06028A5C RID: 166492 RVA: 0x00595BD0 File Offset: 0x00593DD0
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
