using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200705A RID: 28762
	public static class IInteractPointInteraction_UnionVerify
	{
		// Token: 0x06031DF4 RID: 204276 RVA: 0x006C045C File Offset: 0x006BE65C
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
