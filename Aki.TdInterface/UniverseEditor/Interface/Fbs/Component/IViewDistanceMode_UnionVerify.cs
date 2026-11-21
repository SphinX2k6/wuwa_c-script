using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200614D RID: 24909
	public static class IViewDistanceMode_UnionVerify
	{
		// Token: 0x0602A44B RID: 173131 RVA: 0x005C4574 File Offset: 0x005C2774
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IViewDistanceModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILowViewDistanceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMidViewDistanceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHighViewDistanceVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICustomViewDistanceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
