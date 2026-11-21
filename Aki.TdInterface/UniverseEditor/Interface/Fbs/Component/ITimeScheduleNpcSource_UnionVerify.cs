using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060BA RID: 24762
	public static class ITimeScheduleNpcSource_UnionVerify
	{
		// Token: 0x06029E57 RID: 171607 RVA: 0x005B8014 File Offset: 0x005B6214
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
