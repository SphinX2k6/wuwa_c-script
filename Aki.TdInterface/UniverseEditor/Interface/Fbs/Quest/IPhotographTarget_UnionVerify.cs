using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F9A RID: 16282
	public static class IPhotographTarget_UnionVerify
	{
		// Token: 0x0601741F RID: 95263 RVA: 0x0035AA64 File Offset: 0x00358C64
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
