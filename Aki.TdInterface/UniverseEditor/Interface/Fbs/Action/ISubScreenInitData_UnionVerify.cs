using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079E2 RID: 31202
	public static class ISubScreenInitData_UnionVerify
	{
		// Token: 0x06036F9D RID: 225181 RVA: 0x0075982C File Offset: 0x00757A2C
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
