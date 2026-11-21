using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062F0 RID: 25328
	public static class TTeleControlDestroyConditionVerify
	{
		// Token: 0x0602B098 RID: 176280 RVA: 0x005DE234 File Offset: 0x005DC434
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
