using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006828 RID: 26664
	public static class IAudioTypeBase_UnionVerify
	{
		// Token: 0x0602D904 RID: 186628 RVA: 0x0063C390 File Offset: 0x0063A590
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRoleSceneVoiceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAudioTypeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
