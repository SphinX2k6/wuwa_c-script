using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D19 RID: 23833
	public class LevelEventSystemFunction : LevelEventBase
	{
		// Token: 0x0603A445 RID: 238661 RVA: 0x01077D2E File Offset: 0x01075F2E
		public LevelEventSystemFunction(int id) : base(id)
		{
		}

		// Token: 0x0603A446 RID: 238662 RVA: 0x01077D38 File Offset: 0x01075F38
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			IBuyGoods systemFunction = ((RequestSystemFunction)inParams).SystemFunction;
			if (systemFunction != null)
			{
				IBuyGoods buyGoods = systemFunction;
				PayShopController.Instance.SendRequestPayShopBuy(buyGoods.GoodsId, 1);
			}
		}
	}
}
