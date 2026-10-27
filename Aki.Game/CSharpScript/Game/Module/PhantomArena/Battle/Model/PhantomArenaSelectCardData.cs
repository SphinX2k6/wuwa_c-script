using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Model
{
	// Token: 0x020052A1 RID: 21153
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaSelectCardData
	{
		// Token: 0x0603621D RID: 221725 RVA: 0x00CCED4C File Offset: 0x00CCCF4C
		private void AddSelectCardData(PhantomBattleHandCardInfo dataInfo)
		{
			PhantomCardData phantomCardData = new PhantomCardData(false);
			phantomCardData.InitData(dataInfo);
			this.SelectCardDataList.Add(phantomCardData);
		}

		// Token: 0x0603621E RID: 221726 RVA: 0x00CCED74 File Offset: 0x00CCCF74
		public void SetSelectCardDataList(PhantomBattleHandCardInfo[] dataList)
		{
			this.SelectCardDataList = new List<PhantomCardData>();
			foreach (PhantomBattleHandCardInfo dataInfo in dataList)
			{
				this.AddSelectCardData(dataInfo);
			}
		}

		// Token: 0x0603621F RID: 221727 RVA: 0x00CCEDA7 File Offset: 0x00CCCFA7
		public List<PhantomCardData> GetSelectCardDataList()
		{
			return this.SelectCardDataList;
		}

		// Token: 0x0401CA4F RID: 117327
		protected List<PhantomCardData> SelectCardDataList = new List<PhantomCardData>();

		// Token: 0x0401CA50 RID: 117328
		public int SelectNum;
	}
}
