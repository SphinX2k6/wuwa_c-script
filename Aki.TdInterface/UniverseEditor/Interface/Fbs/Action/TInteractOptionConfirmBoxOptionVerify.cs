using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F14 RID: 32532
	public static class TInteractOptionConfirmBoxOptionVerify
	{
		// Token: 0x0603AABA RID: 240314 RVA: 0x007E40D4 File Offset: 0x007E22D4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICommonConfirmBoxVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHonamiStoryCorruptedChestConfirmBoxVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHonamiStoryEvacuateConfirmBoxVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
