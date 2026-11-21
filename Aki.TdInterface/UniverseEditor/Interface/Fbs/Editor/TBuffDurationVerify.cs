using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D4E RID: 19790
	public static class TBuffDurationVerify
	{
		// Token: 0x0601EAFA RID: 125690 RVA: 0x0044B058 File Offset: 0x00449258
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
