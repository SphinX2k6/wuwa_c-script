using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BossPiling;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048C0 RID: 18624
	public class BossPilingExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC26 RID: 191526 RVA: 0x00D0A6BC File Offset: 0x00D088BC
		public override bool Checker()
		{
			return BossPilingModel.Instance.CheckIsBossPiling();
		}

		// Token: 0x0602EC27 RID: 191527 RVA: 0x00D0A6C8 File Offset: 0x00D088C8
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			BossPilingController.Instance.OpenPauseView();
		}
	}
}
