using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716E RID: 29038
	public static class ILongPressInteractStyleConfig_UnionVerify
	{
		// Token: 0x06032783 RID: 206723 RVA: 0x006D24AC File Offset: 0x006D06AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILongPressInteractStyleConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ILongPressInteractStyleConfigDefaultVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ILongPressInteractStyleConfigTimeBackInteractVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ILongPressInteractStyleSwordRiderVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ILongPressInteractStyleCoreFixVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
