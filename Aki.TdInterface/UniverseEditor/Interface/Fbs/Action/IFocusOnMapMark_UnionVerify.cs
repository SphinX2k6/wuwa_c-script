using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200684B RID: 26699
	public static class IFocusOnMapMark_UnionVerify
	{
		// Token: 0x0602E8D0 RID: 190672 RVA: 0x00659E28 File Offset: 0x00658028
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFocusOnMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFocusOnCustomMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFocusOnQuestMapMarkVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
