using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena;

namespace CSharpScript.Game.Module.SkipInterface.SkipTask
{
	// Token: 0x02004BD1 RID: 19409
	public class SkipToMapWithPhantomAreaChallenge : SkipTask
	{
		// Token: 0x06032331 RID: 205617 RVA: 0x00BAA634 File Offset: 0x00BA8834
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
