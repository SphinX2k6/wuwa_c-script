using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006211 RID: 25105
	public static class IBlendAnimTypeBase_UnionVerify
	{
		// Token: 0x0602B462 RID: 177250 RVA: 0x005F5F20 File Offset: 0x005F4120
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
