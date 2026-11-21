using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x02004271 RID: 17009
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSelectCardData
	{
		// Token: 0x0602B118 RID: 176408 RVA: 0x00C1C468 File Offset: 0x00C1A668
		private void AddSelectCardData(PhantomBattleHandCardInfo dataInfo)
		{
			PhantomCardData phantomCardData = new PhantomCardData(false);
			phantomCardData.InitData(dataInfo);
			this.SelectCardDataList.Add(phantomCardData);
		}

		// Token: 0x0602B119 RID: 176409 RVA: 0x00C1C490 File Offset: 0x00C1A690
		public void SetSelectCardDataList(IReadOnlyList<PhantomBattleHandCardInfo> dataList)
		{
			this.SelectCardDataList = new List<PhantomCardData>();
			foreach (PhantomBattleHandCardInfo dataInfo in dataList)
			{
				this.AddSelectCardData(dataInfo);
			}
		}

		// Token: 0x0602B11A RID: 176410 RVA: 0x00C1C4E4 File Offset: 0x00C1A6E4
		public List<PhantomCardData> GetSelectCardDataList()
		{
			return this.SelectCardDataList;
		}

		// Token: 0x04017484 RID: 95364
		protected List<PhantomCardData> SelectCardDataList = new List<PhantomCardData>();

		// Token: 0x04017485 RID: 95365
		public int SelectNum;
	}
}
