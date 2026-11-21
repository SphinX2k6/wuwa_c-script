using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044EC RID: 17644
	public static class IRhythmSpaceshipConditionStepBase_UnionVerify
	{
		// Token: 0x06019873 RID: 104563 RVA: 0x003A4014 File Offset: 0x003A2214
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IRhythmSpaceshipConditionStepInteractVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRhythmSpaceshipConditionStepBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
