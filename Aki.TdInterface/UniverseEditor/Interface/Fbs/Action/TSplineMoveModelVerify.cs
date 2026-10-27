using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200779D RID: 30621
	public static class TSplineMoveModelVerify
	{
		// Token: 0x06037941 RID: 227649 RVA: 0x00784E28 File Offset: 0x00783028
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
