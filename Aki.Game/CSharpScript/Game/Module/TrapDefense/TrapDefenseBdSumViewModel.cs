using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A2C RID: 14892
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdSumViewModel
	{
		// Token: 0x060264A0 RID: 156832 RVA: 0x00AB8A29 File Offset: 0x00AB6C29
		public static TrapDefenseBdSumViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseBdSumViewModel
			{
				Model = model
			};
		}

		// Token: 0x060264A1 RID: 156833 RVA: 0x00AB8A37 File Offset: 0x00AB6C37
		private TrapDefenseBdSumViewModel()
		{
		}

		// Token: 0x060264A2 RID: 156834 RVA: 0x00AB8A40 File Offset: 0x00AB6C40
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

		// Token: 0x060264A3 RID: 156835 RVA: 0x00AB8AC0 File Offset: 0x00AB6CC0
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

		// Token: 0x060264A4 RID: 156836 RVA: 0x00AB8B20 File Offset: 0x00AB6D20
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

		// Token: 0x060264A5 RID: 156837 RVA: 0x00AB8B4B File Offset: 0x00AB6D4B
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

		// Token: 0x060264A6 RID: 156838 RVA: 0x00AB8B6F File Offset: 0x00AB6D6F
		public int SortBdId(TrapDefenseBdData a, TrapDefenseBdData b)
		{
			return a.Id - b.Id;
		}

		// Token: 0x060264A7 RID: 156839 RVA: 0x00AB8B80 File Offset: 0x00AB6D80
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

		// Token: 0x060264A8 RID: 156840 RVA: 0x00AB8BDA File Offset: 0x00AB6DDA
		public void SetIsInstance(bool isInstance)
		{
			this.IsInstance = isInstance;
		}

		// Token: 0x060264A9 RID: 156841 RVA: 0x00AB8BE3 File Offset: 0x00AB6DE3
		public void SetSelectBdBuffData(TrapDefenseBdBuffData data)
		{
			this.CurSelectBdBuffData = data;
		}

		// Token: 0x060264AA RID: 156842 RVA: 0x00AB8BEC File Offset: 0x00AB6DEC
		public void SetSelectBdData(TrapDefenseBdData data)
		{
			this.CurSelectBdData = data;
		}

		// Token: 0x060264AB RID: 156843 RVA: 0x00AB8BF5 File Offset: 0x00AB6DF5
		public void SetJumpTabType(ETrapDefenseBdTabType? tab)
		{
			this.JumpTabType = tab;
		}

		// Token: 0x060264AC RID: 156844 RVA: 0x00AB8BFE File Offset: 0x00AB6DFE
		public void SetJumpBdId(int? id)
		{
			this.JumpBdId = id;
		}

		// Token: 0x060264AD RID: 156845 RVA: 0x00AB8C07 File Offset: 0x00AB6E07
		public bool IsShowBuffLockState(TrapDefenseBdBuffData data)
		{
			if (this.IsInstance)
			{
				return !data.IsActive;
			}
			return !data.IsUnlock;
		}

		// Token: 0x060264AE RID: 156846 RVA: 0x00AB8C24 File Offset: 0x00AB6E24
		public void OnViewClose()
		{
			this.CurSelectBdData = null;
			this.CurSelectBdBuffData = null;
			this.IsInstance = false;
		}

		// Token: 0x04015060 RID: 86112
		public TrapDefenseModel Model;

		// Token: 0x04015061 RID: 86113
		public ETrapDefenseBdTabType? JumpTabType;

		// Token: 0x04015062 RID: 86114
		public int? JumpBdBuffId;

		// Token: 0x04015063 RID: 86115
		public int? JumpBdId;

		// Token: 0x04015064 RID: 86116
		public bool IsInstance;

		// Token: 0x04015065 RID: 86117
		[Nullable(2)]
		public TrapDefenseBdBuffData CurSelectBdBuffData;

		// Token: 0x04015066 RID: 86118
		[Nullable(2)]
		public TrapDefenseBdData CurSelectBdData;
	}
}
