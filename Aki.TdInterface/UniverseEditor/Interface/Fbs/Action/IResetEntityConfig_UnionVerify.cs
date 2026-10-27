using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E84 RID: 28292
	public static class IResetEntityConfig_UnionVerify
	{
		// Token: 0x06032008 RID: 204808 RVA: 0x006C37BC File Offset: 0x006C19BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IResetEntityConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IResetTeleControlEntityVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IJigsawItemEntityVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
