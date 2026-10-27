using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007700 RID: 30464
	public static class TInteractOptionConfirmBoxOptionVerify
	{
		// Token: 0x060375ED RID: 226797 RVA: 0x0077FBC8 File Offset: 0x0077DDC8
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
