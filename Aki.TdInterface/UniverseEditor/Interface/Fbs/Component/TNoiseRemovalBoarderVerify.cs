using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006296 RID: 25238
	public static class TNoiseRemovalBoarderVerify
	{
		// Token: 0x0602AEDA RID: 175834 RVA: 0x005DB8FC File Offset: 0x005D9AFC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || INoiseRemovalSphereBoarderVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INoiseRemovalBoxBoarderVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
