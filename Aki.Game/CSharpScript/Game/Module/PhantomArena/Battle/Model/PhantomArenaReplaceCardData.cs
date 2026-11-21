using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004270 RID: 17008
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaReplaceCardData
	{
		// Token: 0x0602B114 RID: 176404 RVA: 0x00C1C3F4 File Offset: 0x00C1A5F4
		public void SetReplaceCardData(PhantomBattleHandCardInfo[] cardInfoList)
		{
			foreach (PhantomBattleHandCardInfo dataInfo in cardInfoList)
			{
				PhantomCardData phantomCardData = new PhantomCardData(false);
				phantomCardData.InitData(dataInfo);
				this.DataMap[phantomCardData.CardId] = phantomCardData;
			}
		}

		// Token: 0x0602B115 RID: 176405 RVA: 0x00C1C435 File Offset: 0x00C1A635
		public List<PhantomCardData> GetReplaceCardDataList()
		{
			return new List<PhantomCardData>(this.DataMap.Values);
		}

		// Token: 0x0602B116 RID: 176406 RVA: 0x00C1C447 File Offset: 0x00C1A647
		public void ClearReplaceCardData()
		{
			this.DataMap.Clear();
		}

		// Token: 0x04017482 RID: 95362
		private readonly Dictionary<int, PhantomCardData> DataMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x04017483 RID: 95363
		public int ReplaceNum;
	}
}
