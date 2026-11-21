using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E5A RID: 32346
	public static class TBlendAnimTypeVerify
	{
		// Token: 0x0603A6EC RID: 239340 RVA: 0x007DE190 File Offset: 0x007DC390
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetStateMachineBlendAnimTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetAnimSequenceBlendAnimTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
