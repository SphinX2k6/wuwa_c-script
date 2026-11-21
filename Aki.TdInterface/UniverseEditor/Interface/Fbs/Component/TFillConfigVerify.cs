using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006242 RID: 25154
	public static class TFillConfigVerify
	{
		// Token: 0x0602AD2A RID: 175402 RVA: 0x005D9064 File Offset: 0x005D7264
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFixedFillVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDirectionFillVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
