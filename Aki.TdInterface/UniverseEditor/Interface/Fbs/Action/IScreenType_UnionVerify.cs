using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F4D RID: 28493
	public static class IScreenType_UnionVerify
	{
		// Token: 0x06032568 RID: 206184 RVA: 0x006CC17C File Offset: 0x006CA37C
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
