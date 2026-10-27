using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A7 RID: 27047
	public static class IInteractPointInteraction_UnionVerify
	{
		// Token: 0x0602F418 RID: 193560 RVA: 0x0066FD58 File Offset: 0x0066DF58
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IDragInteractPointInteractionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInteractPointInteractionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
