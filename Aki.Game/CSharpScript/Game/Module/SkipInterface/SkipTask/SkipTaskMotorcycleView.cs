using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BB0 RID: 19376
	public class SkipTaskMotorcycleView : SkipTask
	{
		// Token: 0x060322EE RID: 205550 RVA: 0x00BA9253 File Offset: 0x00BA7453
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			FunctionController.Instance.OpenFunctionRelateView(EFunctionType.MotorDevelop);
		}
	}
}
