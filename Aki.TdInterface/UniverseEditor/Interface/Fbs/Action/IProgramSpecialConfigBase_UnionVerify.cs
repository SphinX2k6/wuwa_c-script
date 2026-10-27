using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB5 RID: 28085
	public static class IProgramSpecialConfigBase_UnionVerify
	{
		// Token: 0x060319B4 RID: 203188 RVA: 0x006B8BE4 File Offset: 0x006B6DE4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMp4UiReplaceMaterialVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IProgramSpecialConfigBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
