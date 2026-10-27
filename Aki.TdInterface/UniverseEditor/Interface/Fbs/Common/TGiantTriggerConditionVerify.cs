using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E89 RID: 24201
	public static class TGiantTriggerConditionVerify
	{
		// Token: 0x06029731 RID: 169777 RVA: 0x005AE084 File Offset: 0x005AC284
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
