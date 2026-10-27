using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A45 RID: 23109
	public static class ITeleControlDestroyCondition_UnionVerify
	{
		// Token: 0x060274C3 RID: 160963 RVA: 0x0056854C File Offset: 0x0056674C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITeleControlDestroyConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILetGoDestroyConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICreateBulletDestroyConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IThrowDestroyConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
