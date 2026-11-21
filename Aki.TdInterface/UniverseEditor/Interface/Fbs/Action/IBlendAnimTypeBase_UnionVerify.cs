using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006882 RID: 26754
	public static class IBlendAnimTypeBase_UnionVerify
	{
		// Token: 0x0602DBBB RID: 187323 RVA: 0x00640B0C File Offset: 0x0063ED0C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBlendAnimTypeBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISetStateMachineBlendAnimTypeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISetAnimSequenceBlendAnimTypeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
