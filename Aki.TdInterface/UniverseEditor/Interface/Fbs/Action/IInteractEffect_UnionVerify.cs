using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007039 RID: 28729
	public static class IInteractEffect_UnionVerify
	{
		// Token: 0x06031CAF RID: 203951 RVA: 0x006BD810 File Offset: 0x006BBA10
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInteractEffectVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IModifyTipTextVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IExecuteTagVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITriggerDialoguesVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
