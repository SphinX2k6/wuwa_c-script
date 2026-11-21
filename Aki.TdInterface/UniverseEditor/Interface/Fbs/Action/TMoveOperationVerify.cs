using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F56 RID: 32598
	public static class TMoveOperationVerify
	{
		// Token: 0x0603AC5E RID: 240734 RVA: 0x007E6BA8 File Offset: 0x007E4DA8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEnableMoveOperationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDisableMoveOperationVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
