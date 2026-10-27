using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005771 RID: 22385
	public static class IPortalMode_UnionVerify
	{
		// Token: 0x06025840 RID: 153664 RVA: 0x0052CD68 File Offset: 0x0052AF68
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPortalModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IStaticPortalVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDynamicPortalVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
