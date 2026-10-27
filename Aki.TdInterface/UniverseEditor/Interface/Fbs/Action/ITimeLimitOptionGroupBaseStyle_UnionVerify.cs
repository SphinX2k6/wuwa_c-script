using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E1 RID: 29665
	public static class ITimeLimitOptionGroupBaseStyle_UnionVerify
	{
		// Token: 0x06035E3C RID: 220732 RVA: 0x00755A54 File Offset: 0x00753C54
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITimeLimitOptionGroupDefaultVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITimeLimitOptionGroupBaseStyleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
