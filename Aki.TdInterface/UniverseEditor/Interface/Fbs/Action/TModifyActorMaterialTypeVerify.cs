using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F3E RID: 32574
	public static class TModifyActorMaterialTypeVerify
	{
		// Token: 0x0603ABF8 RID: 240632 RVA: 0x007E62E8 File Offset: 0x007E44E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IChangeActorMPCVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IChangeActorMaterialDataVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
