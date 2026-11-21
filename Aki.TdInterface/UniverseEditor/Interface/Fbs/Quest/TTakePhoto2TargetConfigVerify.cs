using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004781 RID: 18305
	public static class TTakePhoto2TargetConfigVerify
	{
		// Token: 0x0601AF52 RID: 110418 RVA: 0x003D25F0 File Offset: 0x003D07F0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITakePhoto2EntityTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITakePhoto2PhotoTargetEntityTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITakePhoto2TaggedActorTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITakePhoto2TargetEntityTypeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
