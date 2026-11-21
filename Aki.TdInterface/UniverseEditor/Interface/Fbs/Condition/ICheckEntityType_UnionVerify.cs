using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EE0 RID: 20192
	public static class ICheckEntityType_UnionVerify
	{
		// Token: 0x0601F587 RID: 128391 RVA: 0x0045E19C File Offset: 0x0045C39C
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
