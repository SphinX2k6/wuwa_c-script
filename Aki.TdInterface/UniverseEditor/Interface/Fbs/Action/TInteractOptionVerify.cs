using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FD RID: 30461
	public static class TInteractOptionVerify
	{
		// Token: 0x060375DF RID: 226783 RVA: 0x0077FA94 File Offset: 0x0077DC94
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IInteractFlowVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractActionsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
