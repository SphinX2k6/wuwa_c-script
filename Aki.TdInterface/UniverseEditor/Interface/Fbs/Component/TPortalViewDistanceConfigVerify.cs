using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C8C RID: 23692
	public static class TPortalViewDistanceConfigVerify
	{
		// Token: 0x06028956 RID: 166230 RVA: 0x005943A0 File Offset: 0x005925A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICustomViewDistanceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHighViewDistanceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILowViewDistanceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IMidViewDistanceVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
