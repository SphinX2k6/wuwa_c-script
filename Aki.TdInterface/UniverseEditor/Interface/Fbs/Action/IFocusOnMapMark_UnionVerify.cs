using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED1 RID: 28369
	public static class IFocusOnMapMark_UnionVerify
	{
		// Token: 0x06031158 RID: 201048 RVA: 0x006A7D68 File Offset: 0x006A5F68
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
