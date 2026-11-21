using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FD5 RID: 32725
	public static class TSplineMoveModelVerify
	{
		// Token: 0x0603AEBC RID: 241340 RVA: 0x007EA328 File Offset: 0x007E8528
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOpenSplineMoveVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICloseSplineMoveVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
