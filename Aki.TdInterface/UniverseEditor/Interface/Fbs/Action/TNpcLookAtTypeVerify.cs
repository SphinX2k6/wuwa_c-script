using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F68 RID: 32616
	public static class TNpcLookAtTypeVerify
	{
		// Token: 0x0603ACB8 RID: 240824 RVA: 0x007E7408 File Offset: 0x007E5608
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcLookAtEntityVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcLookAtPlayerVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcLookAtPositionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
