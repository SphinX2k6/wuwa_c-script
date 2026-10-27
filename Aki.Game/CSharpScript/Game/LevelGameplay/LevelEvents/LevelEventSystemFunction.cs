using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BA1 RID: 27553
	public class LevelEventSystemFunction : LevelEventBase
	{
		// Token: 0x060442F1 RID: 279281 RVA: 0x010CDEF6 File Offset: 0x010CC0F6
		public LevelEventSystemFunction(int id) : base(id)
		{
		}

		// Token: 0x060442F2 RID: 279282 RVA: 0x010CDF00 File Offset: 0x010CC100
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
