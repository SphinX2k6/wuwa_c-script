using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E2C RID: 24108
	public static class IOutAreaBorderType_UnionVerify
	{
		// Token: 0x06029459 RID: 169049 RVA: 0x005A8FF4 File Offset: 0x005A71F4
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
