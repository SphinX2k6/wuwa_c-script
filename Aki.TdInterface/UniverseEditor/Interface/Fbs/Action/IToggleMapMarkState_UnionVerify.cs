using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BFE RID: 31742
	public static class IToggleMapMarkState_UnionVerify
	{
		// Token: 0x0603936F RID: 234351 RVA: 0x007BAA64 File Offset: 0x007B8C64
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IToggleMapMarkStateVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IShowMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHideMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IDisableMapMarkVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
