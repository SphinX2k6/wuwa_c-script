using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006052 RID: 24658
	public static class ITeleControlDestroyCondition_UnionVerify
	{
		// Token: 0x06029A3B RID: 170555 RVA: 0x005AF558 File Offset: 0x005AD758
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
