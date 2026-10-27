using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EDD RID: 24285
	public static class TCommonBtNodeVerify
	{
		// Token: 0x06029B71 RID: 170865 RVA: 0x005B9A88 File Offset: 0x005B7C88
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonBtProbabilityVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonBtSelectorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICommonBtSequenceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICommonBtStartVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICommonBtTaskVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
