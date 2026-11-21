using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006469 RID: 25705
	public static class IOutAreaBorderType_UnionVerify
	{
		// Token: 0x0602BAE3 RID: 178915 RVA: 0x005F1D24 File Offset: 0x005EFF24
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOutAreaBorderTimerConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IOutAreaBorderTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
