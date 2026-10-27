using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200770F RID: 30479
	public static class TLongPressInteractStyleConfigVerify
	{
		// Token: 0x060376A3 RID: 226979 RVA: 0x00781108 File Offset: 0x0077F308
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
