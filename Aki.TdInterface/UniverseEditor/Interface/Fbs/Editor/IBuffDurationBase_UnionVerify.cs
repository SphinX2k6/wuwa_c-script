using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200482E RID: 18478
	public static class IBuffDurationBase_UnionVerify
	{
		// Token: 0x0601C902 RID: 116994 RVA: 0x0040A064 File Offset: 0x00408264
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBuffDurationBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBuffDurationInstantVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IBuffDurationPermanentVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBuffHasDurationVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
