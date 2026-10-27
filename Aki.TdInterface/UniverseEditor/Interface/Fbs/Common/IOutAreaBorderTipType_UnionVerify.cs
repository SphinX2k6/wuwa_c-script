using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E26 RID: 24102
	public static class IOutAreaBorderTipType_UnionVerify
	{
		// Token: 0x0602943B RID: 169019 RVA: 0x005A8D80 File Offset: 0x005A6F80
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOutAreaBorderDownTimeTextTipVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IOutAreaBorderTipTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
