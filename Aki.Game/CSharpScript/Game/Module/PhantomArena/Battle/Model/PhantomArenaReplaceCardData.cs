using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x020052A0 RID: 21152
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaReplaceCardData
	{
		// Token: 0x06036219 RID: 221721 RVA: 0x00CCECD8 File Offset: 0x00CCCED8
		public void SetReplaceCardData(PhantomBattleHandCardInfo[] cardInfoList)
		{
			foreach (PhantomBattleHandCardInfo dataInfo in cardInfoList)
			{
				PhantomCardData phantomCardData = new PhantomCardData(false);
				phantomCardData.InitData(dataInfo);
				this.DataMap[phantomCardData.CardId] = phantomCardData;
			}
		}

		// Token: 0x0603621A RID: 221722 RVA: 0x00CCED19 File Offset: 0x00CCCF19
		public List<PhantomCardData> GetReplaceCardDataList()
		{
			return this.DataMap.Values.ToList<PhantomCardData>();
		}

		// Token: 0x0603621B RID: 221723 RVA: 0x00CCED2B File Offset: 0x00CCCF2B
		public void ClearReplaceCardData()
		{
			this.DataMap.Clear();
		}

		// Token: 0x0401CA4D RID: 117325
		private readonly Dictionary<int, PhantomCardData> DataMap = new Dictionary<int, PhantomCardData>();

		// Token: 0x0401CA4E RID: 117326
		public int ReplaceNum;
	}
}
