using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068C6 RID: 26822
	public static class IHandInHandInitiatorType_UnionVerify
	{
		// Token: 0x0602EC8B RID: 191627 RVA: 0x006628F4 File Offset: 0x00660AF4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHandInHandInitiatorTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlayerHandInHandInitiatorVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEntityHandInHandInitiatorVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
