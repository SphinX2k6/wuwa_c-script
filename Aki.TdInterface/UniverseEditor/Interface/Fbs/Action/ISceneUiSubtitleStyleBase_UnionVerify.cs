using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F5 RID: 30453
	public static class ISceneUiSubtitleStyleBase_UnionVerify
	{
		// Token: 0x060356FA RID: 218874 RVA: 0x0072A9F8 File Offset: 0x00728BF8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISceneUiSubtitleStyleBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ISceneUiSubtitleScatterVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISceneUiSubtitleAppearVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
