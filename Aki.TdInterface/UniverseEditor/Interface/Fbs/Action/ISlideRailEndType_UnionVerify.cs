using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714D RID: 29005
	public static class ISlideRailEndType_UnionVerify
	{
		// Token: 0x060336B1 RID: 210609 RVA: 0x006EDB70 File Offset: 0x006EBD70
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISlideRailEndTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayerSlideRailEndVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAiFollowerSlideRailEndVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
