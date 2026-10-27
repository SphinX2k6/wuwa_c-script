using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BossPiling;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058E8 RID: 22760
	public class BossPilingExitHandler : InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D03 RID: 236803 RVA: 0x00DBB764 File Offset: 0x00DB9964
		public override bool Checker()
		{
			return BossPilingModel.Instance.CheckIsBossPiling();
		}

		// Token: 0x06039D04 RID: 236804 RVA: 0x00DBB770 File Offset: 0x00DB9970
		[NullableContext(2)]
		public override void HandleExit(InstanceDungeonExitHandlerData data)
		{
			BossPilingController.Instance.OpenPauseView();
		}
	}
}
