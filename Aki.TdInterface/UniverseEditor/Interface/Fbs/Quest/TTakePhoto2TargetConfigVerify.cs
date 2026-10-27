using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200431F RID: 17183
	public static class TTakePhoto2TargetConfigVerify
	{
		// Token: 0x060197C4 RID: 104388 RVA: 0x003A6BC8 File Offset: 0x003A4DC8
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
