using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005352 RID: 21330
	public static class IGroupFinishConfig_UnionVerify
	{
		// Token: 0x06022E45 RID: 142917 RVA: 0x004D5444 File Offset: 0x004D3644
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
