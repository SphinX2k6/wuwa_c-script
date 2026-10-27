using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B2 RID: 30386
	public static class TElementalBoxTargetPosTypeVerify
	{
		// Token: 0x0603746B RID: 226411 RVA: 0x0077D808 File Offset: 0x0077BA08
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IElementalBoxTargetRelativePosVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IElementalBoxTargetPrefabPosVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
