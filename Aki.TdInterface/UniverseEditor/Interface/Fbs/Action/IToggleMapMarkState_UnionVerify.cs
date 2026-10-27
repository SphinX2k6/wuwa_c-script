using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007414 RID: 29716
	public static class IToggleMapMarkState_UnionVerify
	{
		// Token: 0x06035FBC RID: 221116 RVA: 0x007582F0 File Offset: 0x007564F0
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
