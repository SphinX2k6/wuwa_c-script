using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200772D RID: 30509
	public static class TMoveOperationVerify
	{
		// Token: 0x06037723 RID: 227107 RVA: 0x00781C18 File Offset: 0x0077FE18
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
