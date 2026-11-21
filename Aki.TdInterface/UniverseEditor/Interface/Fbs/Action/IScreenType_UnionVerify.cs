using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007707 RID: 30471
	public static class IScreenType_UnionVerify
	{
		// Token: 0x06035768 RID: 218984 RVA: 0x0072B438 File Offset: 0x00729638
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IScreenTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMainScreenVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISubScreenVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
