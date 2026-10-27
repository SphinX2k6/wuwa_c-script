using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200720D RID: 29197
	public static class ISubScreenInitData_UnionVerify
	{
		// Token: 0x06033C9B RID: 212123 RVA: 0x006F84CC File Offset: 0x006F66CC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISubScreenInitDataVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISubScreenPresetInitDataVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISubScreenCustomInitDataVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
