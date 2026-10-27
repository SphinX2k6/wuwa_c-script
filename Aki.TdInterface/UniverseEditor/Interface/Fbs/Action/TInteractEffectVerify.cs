using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076FA RID: 30458
	public static class TInteractEffectVerify
	{
		// Token: 0x060375D3 RID: 226771 RVA: 0x0077F974 File Offset: 0x0077DB74
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
