using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FE RID: 26622
	public static class IAlertValueSpeedChangeType_UnionVerify
	{
		// Token: 0x0602D794 RID: 186260 RVA: 0x00639C64 File Offset: 0x00637E64
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAlertValueSpeedChangeTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAddOrSubAlertValueChangeSpeedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICustomAlertValueChangeSpeedVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
