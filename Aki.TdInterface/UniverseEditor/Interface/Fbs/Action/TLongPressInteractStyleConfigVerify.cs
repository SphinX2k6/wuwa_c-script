using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F32 RID: 32562
	public static class TLongPressInteractStyleConfigVerify
	{
		// Token: 0x0603ABC0 RID: 240576 RVA: 0x007E5DC0 File Offset: 0x007E3FC0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILongPressInteractStyleConfigDefaultVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILongPressInteractStyleConfigTimeBackInteractVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILongPressInteractStyleCoreFixVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILongPressInteractStyleSwordRiderVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
