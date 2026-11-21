using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006209 RID: 25097
	public static class TAudioControlTypeVerify
	{
		// Token: 0x0602AB1A RID: 174874 RVA: 0x005D21F8 File Offset: 0x005D03F8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITrafficAudioControlVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGramophoneAudioControlVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
