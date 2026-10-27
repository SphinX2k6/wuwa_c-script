using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061BA RID: 25018
	public static class IAudioTypeBase_UnionVerify
	{
		// Token: 0x0602B1BD RID: 176573 RVA: 0x005F191C File Offset: 0x005EFB1C
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
