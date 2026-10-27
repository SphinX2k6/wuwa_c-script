using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006193 RID: 24979
	public static class IAlertValueSpeedChangeType_UnionVerify
	{
		// Token: 0x0602B063 RID: 176227 RVA: 0x005EF3F0 File Offset: 0x005ED5F0
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
