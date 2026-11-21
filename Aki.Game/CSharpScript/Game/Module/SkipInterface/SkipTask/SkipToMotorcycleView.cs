using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Functional;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B7D RID: 15229
	public class SkipToMotorcycleView : SkipTask
	{
		// Token: 0x060270C7 RID: 159943 RVA: 0x00AEE988 File Offset: 0x00AECB88
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
