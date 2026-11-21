using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B77 RID: 15223
	public class SkipToGachaView : SkipToMoonChasingBase
	{
		// Token: 0x060270BA RID: 159930 RVA: 0x00AEE743 File Offset: 0x00AEC943
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.Gacha);
		}
	}
}
