using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005652 RID: 22098
	public static class INpcSpecialMarkBase_UnionVerify
	{
		// Token: 0x06024BC4 RID: 150468 RVA: 0x00511A14 File Offset: 0x0050FC14
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcSpecialMarkBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcSpecialMarkTrafficLightVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = INpcSpecialMarkIgnoreCameraHideNpcVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
