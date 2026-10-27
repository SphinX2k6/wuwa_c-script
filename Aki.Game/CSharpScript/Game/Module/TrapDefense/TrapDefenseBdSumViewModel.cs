using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A84 RID: 19076
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdSumViewModel
	{
		// Token: 0x06031710 RID: 202512 RVA: 0x00B74AA5 File Offset: 0x00B72CA5
		public static TrapDefenseBdSumViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseBdSumViewModel
			{
				Model = model
			};
		}

		// Token: 0x06031711 RID: 202513 RVA: 0x00B74AB3 File Offset: 0x00B72CB3
		private TrapDefenseBdSumViewModel()
		{
		}

		// Token: 0x06031712 RID: 202514 RVA: 0x00B74ABC File Offset: 0x00B72CBC
		public unsafe List<ITrapDefenseTab<ETrapDefenseBdTabType>> GetTabList()
		{
			int num = 2;
			List<ITrapDefenseTab<ETrapDefenseBdTabType>> list = new List<ITrapDefenseTab<ETrapDefenseBdTabType>>(num);
			CollectionsMarshal.SetCount<ITrapDefenseTab<ETrapDefenseBdTabType>>(list, num);
			Span<ITrapDefenseTab<ETrapDefenseBdTabType>> span = CollectionsMarshal.AsSpan<ITrapDefenseTab<ETrapDefenseBdTabType>>(list);
			int num2 = 0;
			*span[num2] = new TrapDefenseTab<ETrapDefenseBdTabType>
			{
				TabType = ETrapDefenseBdTabType.BdProgress,
				TabNameKey = ETrapDefenseTextKey.BdSumTabBdProgress.ToString()
			};
			num2++;
			*span[num2] = new TrapDefenseTab<ETrapDefenseBdTabType>
			{
				TabType = ETrapDefenseBdTabType.BuffSum,
				TabNameKey = ETrapDefenseTextKey.BdSumTabBuffSum.ToString()
			};
			return list;
		}

		// Token: 0x06031713 RID: 202515 RVA: 0x00B74B3C File Offset: 0x00B72D3C
		public List<TrapDefenseBdData> GetBdListForProgress()
		{
			if (this.IsInstance)
			{
				TrapDefenseLevelData curInstToLevelData = this.Model.GetCurInstToLevelData();
				if (curInstToLevelData != null)
				{
					List<TrapDefenseBdData> showBdList = curInstToLevelData.GetShowBdList();
					showBdList.Sort(new Comparison<TrapDefenseBdData>(this.SortBdProgress));
					return showBdList;
				}
			}
			List<TrapDefenseBdData> bdDataListIgnoreZero = this.Model.RougeModeData.BdDataListIgnoreZero;
			bdDataListIgnoreZero.Sort(new Comparison<TrapDefenseBdData>(this.SortBdUnlock));
			return bdDataListIgnoreZero;
		}

		// Token: 0x06031714 RID: 202516 RVA: 0x00B74B9C File Offset: 0x00B72D9C
		public int SortBdProgress(TrapDefenseBdData a, TrapDefenseBdData b)
		{
			int currentActiveProgressNum = a.GetCurrentActiveProgressNum();
			int currentActiveProgressNum2 = b.GetCurrentActiveProgressNum();
			if (currentActiveProgressNum != currentActiveProgressNum2)
			{
				return currentActiveProgressNum2 - currentActiveProgressNum;
			}
			return this.SortBdId(a, b);
		}

		// Token: 0x06031715 RID: 202517 RVA: 0x00B74BC7 File Offset: 0x00B72DC7
		public int SortBdUnlock(TrapDefenseBdData a, TrapDefenseBdData b)
		{
			if (a.IsUnlock == b.IsUnlock)
			{
				return this.SortBdId(a, b);
			}
			if (!a.IsUnlock)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06031716 RID: 202518 RVA: 0x00B74BEB File Offset: 0x00B72DEB
		public int SortBdId(TrapDefenseBdData a, TrapDefenseBdData b)
		{
			return a.Id - b.Id;
		}

		// Token: 0x06031717 RID: 202519 RVA: 0x00B74BFC File Offset: 0x00B72DFC
		public List<TrapDefenseBdData> GetBdListForBuffSum()
		{
			if (this.IsInstance)
			{
				List<TrapDefenseBdData> bdDataListIsActive = this.Model.RougeModeData.GetBdDataListIsActive();
				bdDataListIsActive.Sort(new Comparison<TrapDefenseBdData>(this.SortBdProgress));
				return bdDataListIsActive;
			}
			List<TrapDefenseBdData> bdDataList = this.Model.RougeModeData.BdDataList;
			bdDataList.Sort(new Comparison<TrapDefenseBdData>(this.SortBdUnlock));
			return bdDataList;
		}

		// Token: 0x06031718 RID: 202520 RVA: 0x00B74C56 File Offset: 0x00B72E56
		public void SetIsInstance(bool isInstance)
		{
			this.IsInstance = isInstance;
		}

		// Token: 0x06031719 RID: 202521 RVA: 0x00B74C5F File Offset: 0x00B72E5F
		public void SetSelectBdBuffData(TrapDefenseBdBuffData data)
		{
			this.CurSelectBdBuffData = data;
		}

		// Token: 0x0603171A RID: 202522 RVA: 0x00B74C68 File Offset: 0x00B72E68
		public void SetSelectBdData(TrapDefenseBdData data)
		{
			this.CurSelectBdData = data;
		}

		// Token: 0x0603171B RID: 202523 RVA: 0x00B74C71 File Offset: 0x00B72E71
		public void SetJumpTabType(ETrapDefenseBdTabType? tab)
		{
			this.JumpTabType = tab;
		}

		// Token: 0x0603171C RID: 202524 RVA: 0x00B74C7A File Offset: 0x00B72E7A
		public void SetJumpBdId(int? id)
		{
			this.JumpBdId = id;
		}

		// Token: 0x0603171D RID: 202525 RVA: 0x00B74C83 File Offset: 0x00B72E83
		public bool IsShowBuffLockState(TrapDefenseBdBuffData data)
		{
			if (this.IsInstance)
			{
				return !data.IsActive;
			}
			return !data.IsUnlock;
		}

		// Token: 0x0603171E RID: 202526 RVA: 0x00B74CA0 File Offset: 0x00B72EA0
		public void OnViewClose()
		{
			this.CurSelectBdData = null;
			this.CurSelectBdBuffData = null;
			this.IsInstance = false;
		}

		// Token: 0x0401A70E RID: 108302
		public TrapDefenseModel Model;

		// Token: 0x0401A70F RID: 108303
		public ETrapDefenseBdTabType? JumpTabType;

		// Token: 0x0401A710 RID: 108304
		public int? JumpBdBuffId;

		// Token: 0x0401A711 RID: 108305
		public int? JumpBdId;

		// Token: 0x0401A712 RID: 108306
		public bool IsInstance;

		// Token: 0x0401A713 RID: 108307
		[Nullable(2)]
		public TrapDefenseBdBuffData CurSelectBdBuffData;

		// Token: 0x0401A714 RID: 108308
		[Nullable(2)]
		public TrapDefenseBdData CurSelectBdData;
	}
}
