using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045FD RID: 17917
	public static class ITakePhoto2Target_UnionVerify
	{
		// Token: 0x0601A311 RID: 107281 RVA: 0x003BAEE8 File Offset: 0x003B90E8
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
