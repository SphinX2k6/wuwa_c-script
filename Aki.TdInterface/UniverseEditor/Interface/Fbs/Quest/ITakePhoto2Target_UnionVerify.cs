using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A4 RID: 16804
	public static class ITakePhoto2Target_UnionVerify
	{
		// Token: 0x06018BBB RID: 101307 RVA: 0x0038FA94 File Offset: 0x0038DC94
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ITakePhoto2TargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ITakePhoto2EntityTargetVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ITakePhoto2PhotoTargetEntityTargetVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ITakePhoto2TargetEntityTypeVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = ITakePhoto2TaggedActorTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
