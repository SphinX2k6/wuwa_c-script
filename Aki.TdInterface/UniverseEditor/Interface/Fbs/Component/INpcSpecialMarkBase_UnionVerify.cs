using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BF0 RID: 23536
	public static class INpcSpecialMarkBase_UnionVerify
	{
		// Token: 0x06026DE5 RID: 159205 RVA: 0x0055236C File Offset: 0x0055056C
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
			case 4:
				result = INpcSpecialMarkTriggerBlueprintFootprintEventVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
