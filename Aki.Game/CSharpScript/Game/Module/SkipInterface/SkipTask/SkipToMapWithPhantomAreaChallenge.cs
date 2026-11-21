using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02003B7B RID: 15227
	public class SkipToMapWithPhantomAreaChallenge : SkipTask
	{
		// Token: 0x060270C2 RID: 159938 RVA: 0x00AEE8EC File Offset: 0x00AECAEC
		protected override void OnRun([Nullable(new byte[]
		{
			1,
			2
		})] params object[] data)
		{
			PhantomArenaBattleController.OpenPhantomArenaMapEntrance(new int?((int)data[0]), new bool?(true));
			base.Finish();
		}
	}
}
