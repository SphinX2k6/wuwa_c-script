using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BCB RID: 31691
	public static class ITimeLimitOptionGroupBaseStyle_UnionVerify
	{
		// Token: 0x060391EF RID: 233967 RVA: 0x007B81C8 File Offset: 0x007B63C8
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
