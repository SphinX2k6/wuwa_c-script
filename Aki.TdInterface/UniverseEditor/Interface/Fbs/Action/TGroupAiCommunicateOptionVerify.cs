using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076DF RID: 30431
	public static class TGroupAiCommunicateOptionVerify
	{
		// Token: 0x06037553 RID: 226643 RVA: 0x0077EDEC File Offset: 0x0077CFEC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IGroupAiCommunicateRemoveTagVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IGroupAiCommunicateAddTagVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
