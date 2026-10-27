using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E5 RID: 30437
	public static class THandInHandInitiatorVerify
	{
		// Token: 0x0603756B RID: 226667 RVA: 0x0077EFE4 File Offset: 0x0077D1E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlayerHandInHandInitiatorVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEntityHandInHandInitiatorVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
