using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BD4 RID: 31700
	public static class ITimeScaleType_UnionVerify
	{
		// Token: 0x06039227 RID: 234023 RVA: 0x007B86DC File Offset: 0x007B68DC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetGlobalTimeScaleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITimeScaleTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
