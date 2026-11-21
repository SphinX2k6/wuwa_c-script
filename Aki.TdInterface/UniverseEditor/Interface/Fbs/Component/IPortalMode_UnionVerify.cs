using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D78 RID: 23928
	public static class IPortalMode_UnionVerify
	{
		// Token: 0x06027D60 RID: 163168 RVA: 0x00572EF4 File Offset: 0x005710F4
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
