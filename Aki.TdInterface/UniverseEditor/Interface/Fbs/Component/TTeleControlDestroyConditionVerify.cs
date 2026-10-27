using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CBF RID: 23743
	public static class TTeleControlDestroyConditionVerify
	{
		// Token: 0x06028A50 RID: 166480 RVA: 0x00595AC0 File Offset: 0x00593CC0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICreateBulletDestroyConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILetGoDestroyConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
