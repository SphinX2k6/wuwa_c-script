using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FB1 RID: 32689
	public static class TScreenVerify
	{
		// Token: 0x0603AE1A RID: 241178 RVA: 0x007E94CC File Offset: 0x007E76CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISubScreenVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMainScreenVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
