using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Infrastructure;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B78 RID: 15224
	public class SkipToInfrastructureMainView : SkipTask
	{
		// Token: 0x060270BC RID: 159932 RVA: 0x00AEE75C File Offset: 0x00AEC95C
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			InfrastructureController.Instance.OpenInfrastructureMainView(null).Forget<int?>();
			base.Finish();
		}
	}
}
