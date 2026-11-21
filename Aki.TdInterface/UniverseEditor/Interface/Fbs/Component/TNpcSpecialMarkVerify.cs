using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200629F RID: 25247
	public static class TNpcSpecialMarkVerify
	{
		// Token: 0x0602AF06 RID: 175878 RVA: 0x005DBD08 File Offset: 0x005D9F08
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = INpcSpecialMarkIgnoreCameraHideNpcVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = INpcSpecialMarkTrafficLightVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
