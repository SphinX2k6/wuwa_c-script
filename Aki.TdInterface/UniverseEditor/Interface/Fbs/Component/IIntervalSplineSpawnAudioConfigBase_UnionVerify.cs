using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A13 RID: 23059
	public static class IIntervalSplineSpawnAudioConfigBase_UnionVerify
	{
		// Token: 0x06025AA2 RID: 154274 RVA: 0x00529D04 File Offset: 0x00527F04
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IIntervalSplineSpawnAllActorAudioVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IIntervalSplineSpawnAudioConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
