using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200764C RID: 30284
	public static class TBlendAnimTypeVerify
	{
		// Token: 0x06037247 RID: 225863 RVA: 0x0077A094 File Offset: 0x00778294
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetStateMachineBlendAnimTypeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetAnimSequenceBlendAnimTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
