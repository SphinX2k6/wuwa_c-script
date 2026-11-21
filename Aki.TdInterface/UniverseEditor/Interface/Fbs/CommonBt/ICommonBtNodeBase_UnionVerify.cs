using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006505 RID: 25861
	public static class ICommonBtNodeBase_UnionVerify
	{
		// Token: 0x0602C05E RID: 180318 RVA: 0x005FE3DC File Offset: 0x005FC5DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonBtNodeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonBtStartVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICommonBtSequenceVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICommonBtSelectorVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ICommonBtTaskVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = ICommonBtProbabilityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
