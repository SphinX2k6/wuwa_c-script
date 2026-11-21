using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007919 RID: 31001
	public static class ISlideRailEndType_UnionVerify
	{
		// Token: 0x0603695B RID: 223579 RVA: 0x0074E37C File Offset: 0x0074C57C
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
