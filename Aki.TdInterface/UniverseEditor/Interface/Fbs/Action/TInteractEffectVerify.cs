using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F0E RID: 32526
	public static class TInteractEffectVerify
	{
		// Token: 0x0603AAA0 RID: 240288 RVA: 0x007E3E80 File Offset: 0x007E2080
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IExecuteTagVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IModifyTipTextVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITriggerDialoguesVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITriggerVoiceDialoguesVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
