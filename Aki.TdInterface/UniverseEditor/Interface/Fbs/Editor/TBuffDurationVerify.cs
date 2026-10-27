using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048E9 RID: 18665
	public static class TBuffDurationVerify
	{
		// Token: 0x0601D30D RID: 119565 RVA: 0x0041E8BC File Offset: 0x0041CABC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBuffDurationInstantVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBuffDurationPermanentVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
