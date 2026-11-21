using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005941 RID: 22849
	public static class IHookFetchMoveModeBase_UnionVerify
	{
		// Token: 0x060252BD RID: 152253 RVA: 0x00519BFC File Offset: 0x00517DFC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IHookFetchMoveUniformVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IHookFetchMoveModeBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
