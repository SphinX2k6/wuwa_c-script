using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053BB RID: 21435
	public static class IHookFetchMoveModeBase_UnionVerify
	{
		// Token: 0x06023209 RID: 143881 RVA: 0x004DCD28 File Offset: 0x004DAF28
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
