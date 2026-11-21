using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008059 RID: 32857
	public static class TVisualNovelPlayScreenEffectConfigVerify
	{
		// Token: 0x0603B1A2 RID: 242082 RVA: 0x007EEB88 File Offset: 0x007ECD88
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IVisualNovelPlayScreenEffectCustomVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IVisualNovelPlayScreenEffectOneShotVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IVisualNovelPlayScreenEffectPersistentVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
