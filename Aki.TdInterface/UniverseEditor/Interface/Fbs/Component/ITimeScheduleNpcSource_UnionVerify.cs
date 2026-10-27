using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAD RID: 23213
	public static class ITimeScheduleNpcSource_UnionVerify
	{
		// Token: 0x060278D5 RID: 162005 RVA: 0x00570DD4 File Offset: 0x0056EFD4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITimeScheduleEntityTemplateNpcSourceVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITimeScheduleNpcSourceVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
