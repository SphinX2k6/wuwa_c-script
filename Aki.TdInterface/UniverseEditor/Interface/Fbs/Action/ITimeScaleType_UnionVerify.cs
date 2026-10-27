using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073EA RID: 29674
	public static class ITimeScaleType_UnionVerify
	{
		// Token: 0x06035E74 RID: 220788 RVA: 0x00755F68 File Offset: 0x00754168
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetGlobalTimeScaleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITimeScaleTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
