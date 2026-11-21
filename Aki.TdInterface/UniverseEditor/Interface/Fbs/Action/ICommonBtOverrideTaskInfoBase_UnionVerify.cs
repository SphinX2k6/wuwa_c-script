using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ADB RID: 27355
	public static class ICommonBtOverrideTaskInfoBase_UnionVerify
	{
		// Token: 0x0602EFEF RID: 192495 RVA: 0x00668CC8 File Offset: 0x00666EC8
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
