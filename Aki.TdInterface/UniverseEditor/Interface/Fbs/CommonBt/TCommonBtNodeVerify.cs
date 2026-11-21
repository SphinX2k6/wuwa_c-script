using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006520 RID: 25888
	public static class TCommonBtNodeVerify
	{
		// Token: 0x0602C225 RID: 180773 RVA: 0x00602F6C File Offset: 0x0060116C
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
