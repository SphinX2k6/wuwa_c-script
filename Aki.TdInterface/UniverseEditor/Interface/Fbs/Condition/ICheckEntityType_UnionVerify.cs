using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A20 RID: 18976
	public static class ICheckEntityType_UnionVerify
	{
		// Token: 0x0601DB14 RID: 121620 RVA: 0x0042D530 File Offset: 0x0042B730
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICheckEntityTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICheckOnlinePlayerVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICheckTargetEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
