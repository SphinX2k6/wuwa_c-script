using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006473 RID: 25715
	public static class ICommonBtOverrideTaskInfoBase_UnionVerify
	{
		// Token: 0x0602C89E RID: 182430 RVA: 0x0061D6BC File Offset: 0x0061B8BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonBtOverrideTaskInfoBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICommonBtOverrideActionInfoVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICommonBtOverrideConditionInfoVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
