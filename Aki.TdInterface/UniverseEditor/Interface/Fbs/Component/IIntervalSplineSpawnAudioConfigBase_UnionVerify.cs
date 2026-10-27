using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548D RID: 21645
	public static class IIntervalSplineSpawnAudioConfigBase_UnionVerify
	{
		// Token: 0x060239EA RID: 145898 RVA: 0x004ECC90 File Offset: 0x004EAE90
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
