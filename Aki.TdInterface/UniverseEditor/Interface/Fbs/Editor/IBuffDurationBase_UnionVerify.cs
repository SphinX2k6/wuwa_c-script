using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004C96 RID: 19606
	public static class IBuffDurationBase_UnionVerify
	{
		// Token: 0x0601E0FF RID: 123135 RVA: 0x004369B4 File Offset: 0x00434BB4
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
