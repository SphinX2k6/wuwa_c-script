using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043DB RID: 17371
	public static class IPhotographTarget_UnionVerify
	{
		// Token: 0x06018AAE RID: 101038 RVA: 0x0038467C File Offset: 0x0038287C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPhotographTargetVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPhotographTargetPlayerVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPhotographTargetRolesOnSceneVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
