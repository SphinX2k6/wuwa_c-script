using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006463 RID: 25699
	public static class IOutAreaBorderTipType_UnionVerify
	{
		// Token: 0x0602BAC5 RID: 178885 RVA: 0x005F1AB0 File Offset: 0x005EFCB0
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
