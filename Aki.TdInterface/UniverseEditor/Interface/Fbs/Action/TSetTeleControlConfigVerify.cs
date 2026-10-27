using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200778B RID: 30603
	public static class TSetTeleControlConfigVerify
	{
		// Token: 0x060378F5 RID: 227573 RVA: 0x007847A4 File Offset: 0x007829A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetResetPositionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IOpenGravityVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
