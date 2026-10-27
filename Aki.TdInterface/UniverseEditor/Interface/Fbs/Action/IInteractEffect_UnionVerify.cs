using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006986 RID: 27014
	public static class IInteractEffect_UnionVerify
	{
		// Token: 0x0602F2DF RID: 193247 RVA: 0x0066D328 File Offset: 0x0066B528
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
