using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200801D RID: 32797
	public static class TToggleMapMarkStateVerify
	{
		// Token: 0x0603B03A RID: 241722 RVA: 0x007EC7A4 File Offset: 0x007EA9A4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDisableMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHideMapMarkVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IShowMapMarkVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
