using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF0 RID: 23536
	public static class TAudioControlTypeVerify
	{
		// Token: 0x06028548 RID: 165192 RVA: 0x0058A61C File Offset: 0x0058881C
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
