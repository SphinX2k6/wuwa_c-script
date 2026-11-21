using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058D8 RID: 22744
	public static class IGroupFinishConfig_UnionVerify
	{
		// Token: 0x06024EF9 RID: 151289 RVA: 0x00512318 File Offset: 0x00510518
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGroupFinishConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGroupFinishSilenceVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGroupFinishDestroyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
