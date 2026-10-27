using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F4C RID: 28492
	[NullableContext(1)]
	[Nullable(0)]
	public class BigStuffedGameInfo
	{
		// Token: 0x06045501 RID: 283905 RVA: 0x01125F48 File Offset: 0x01124148
		public BigStuffedRingInfo AddRingInfo(int id, EArrowDirection arrowDirection)
		{
			BigStuffedRingInfo bigStuffedRingInfo = new BigStuffedRingInfo(id, arrowDirection);
			this.RingInfosMap[id] = bigStuffedRingInfo;
			this.RingInfosArr.Add(bigStuffedRingInfo);
			return bigStuffedRingInfo;
		}

		// Token: 0x06045502 RID: 283906 RVA: 0x01125F78 File Offset: 0x01124178
		public void Clear()
		{
			foreach (KeyValuePair<int, BigStuffedRingInfo> keyValuePair in this.RingInfosMap)
			{
				keyValuePair.Value.Clear();
			}
			this.RingInfosMap.Clear();
			this.RingInfosArr.Clear();
			this.CurrentArrowStayTotalIndex = -1;
			this.CurrentArrowStayRingId = -1;
			this.CurrentArrowStayRelativeValidAreaIndex = -1;
			this.CurrentArrowStayCellIndex = 0;
		}

		// Token: 0x06045503 RID: 283907 RVA: 0x01126004 File Offset: 0x01124204
		[NullableContext(2)]
		public BigStuffedRingInfo GetRingInfo(int id)
		{
			BigStuffedRingInfo result;
			if (this.RingInfosMap.TryGetValue(id, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06045504 RID: 283908 RVA: 0x01126024 File Offset: 0x01124224
		public void UpdateCurrentArrowStayInfo()
		{
			if (this.RingInfosArr.Count == 0)
			{
				return;
			}
			int num = 0;
			int num2 = 0;
			foreach (BigStuffedRingInfo bigStuffedRingInfo in this.RingInfosArr)
			{
				num += bigStuffedRingInfo.ValidAreas.Count;
				if (this.CurrentArrowStayTotalIndex < num)
				{
					this.CurrentArrowStayRingId = bigStuffedRingInfo.RingId;
					this.CurrentArrowStayRelativeValidAreaIndex = this.CurrentArrowStayTotalIndex - num2;
					break;
				}
				num2 = num;
			}
		}

		// Token: 0x06045505 RID: 283909 RVA: 0x011260B8 File Offset: 0x011242B8
		public int GetValidAreaNum()
		{
			int num = 0;
			foreach (BigStuffedRingInfo bigStuffedRingInfo in this.RingInfosArr)
			{
				num += bigStuffedRingInfo.ValidAreas.Count;
			}
			return num;
		}

		// Token: 0x06045506 RID: 283910 RVA: 0x01126118 File Offset: 0x01124318
		public void OnArrowDirectionReverse()
		{
			foreach (BigStuffedRingInfo bigStuffedRingInfo in this.RingInfosArr)
			{
				bigStuffedRingInfo.OnArrowDirectionReverse();
			}
		}

		// Token: 0x04024260 RID: 148064
		private readonly Dictionary<int, BigStuffedRingInfo> RingInfosMap = new Dictionary<int, BigStuffedRingInfo>();

		// Token: 0x04024261 RID: 148065
		private readonly List<BigStuffedRingInfo> RingInfosArr = new List<BigStuffedRingInfo>();

		// Token: 0x04024262 RID: 148066
		public int CurrentArrowStayTotalIndex = -1;

		// Token: 0x04024263 RID: 148067
		public int CurrentArrowStayRingId = -1;

		// Token: 0x04024264 RID: 148068
		public int CurrentArrowStayRelativeValidAreaIndex = -1;

		// Token: 0x04024265 RID: 148069
		public int CurrentArrowStayCellIndex;
	}
}
