using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200773F RID: 30527
	public static class TNpcLookAtTypeVerify
	{
		// Token: 0x0603777D RID: 227197 RVA: 0x00782478 File Offset: 0x00780678
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
