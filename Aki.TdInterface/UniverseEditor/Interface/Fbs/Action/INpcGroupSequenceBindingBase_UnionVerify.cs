using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200730F RID: 29455
	public static class INpcGroupSequenceBindingBase_UnionVerify
	{
		// Token: 0x060335CE RID: 210382 RVA: 0x006ED180 File Offset: 0x006EB380
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || INpcGroupSequenceStaticEntityBindingVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = INpcGroupSequenceBindingBaseVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
