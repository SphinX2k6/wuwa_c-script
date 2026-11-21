using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057A4 RID: 22436
	public static class IFanInteractType_UnionVerify
	{
		// Token: 0x0602436C RID: 148332 RVA: 0x004FA768 File Offset: 0x004F8968
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFanInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFanInteractByHitVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFanInteractByFKeyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
