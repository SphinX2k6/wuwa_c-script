using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060CD RID: 24781
	[NullableContext(1)]
	[Nullable(0)]
	public class BigStuffedGameInfo
	{
		// Token: 0x0603B6AF RID: 243375 RVA: 0x010CFEF4 File Offset: 0x010CE0F4
		public BigStuffedRingInfo AddRingInfo(int id, EArrowDirection arrowDirection)
		{
			BigStuffedRingInfo bigStuffedRingInfo = new BigStuffedRingInfo(id, arrowDirection);
			this.RingInfosMap[id] = bigStuffedRingInfo;
			this.RingInfosArr.Add(bigStuffedRingInfo);
			return bigStuffedRingInfo;
		}

		// Token: 0x0603B6B0 RID: 243376 RVA: 0x010CFF24 File Offset: 0x010CE124
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

		// Token: 0x0603B6B1 RID: 243377 RVA: 0x010CFFB0 File Offset: 0x010CE1B0
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

		// Token: 0x0603B6B2 RID: 243378 RVA: 0x010CFFD0 File Offset: 0x010CE1D0
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

		// Token: 0x0603B6B3 RID: 243379 RVA: 0x010D0064 File Offset: 0x010CE264
		public int GetValidAreaNum()
		{
			int num = 0;
			foreach (BigStuffedRingInfo bigStuffedRingInfo in this.RingInfosArr)
			{
				num += bigStuffedRingInfo.ValidAreas.Count;
			}
			return num;
		}

		// Token: 0x0603B6B4 RID: 243380 RVA: 0x010D00C4 File Offset: 0x010CE2C4
		public void OnArrowDirectionReverse()
		{
			foreach (BigStuffedRingInfo bigStuffedRingInfo in this.RingInfosArr)
			{
				bigStuffedRingInfo.OnArrowDirectionReverse();
			}
		}

		// Token: 0x0401F515 RID: 128277
		private readonly Dictionary<int, BigStuffedRingInfo> RingInfosMap = new Dictionary<int, BigStuffedRingInfo>();

		// Token: 0x0401F516 RID: 128278
		private readonly List<BigStuffedRingInfo> RingInfosArr = new List<BigStuffedRingInfo>();

		// Token: 0x0401F517 RID: 128279
		public int CurrentArrowStayTotalIndex = -1;

		// Token: 0x0401F518 RID: 128280
		public int CurrentArrowStayRingId = -1;

		// Token: 0x0401F519 RID: 128281
		public int CurrentArrowStayRelativeValidAreaIndex = -1;

		// Token: 0x0401F51A RID: 128282
		public int CurrentArrowStayCellIndex;
	}
}
