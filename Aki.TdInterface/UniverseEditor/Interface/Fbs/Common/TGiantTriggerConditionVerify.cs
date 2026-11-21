using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064CC RID: 25804
	public static class TGiantTriggerConditionVerify
	{
		// Token: 0x0602BDD9 RID: 179673 RVA: 0x005F7028 File Offset: 0x005F5228
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IGiantTriggerEnterAreaVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IGiantTriggerRoleStateVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IGiantTriggerStableValueVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
