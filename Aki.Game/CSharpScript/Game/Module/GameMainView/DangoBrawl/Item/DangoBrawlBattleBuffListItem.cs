using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x02005A0E RID: 23054
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBuffListItem : UiPanelBase
	{
		// Token: 0x0603A76A RID: 239466 RVA: 0x00DE90D5 File Offset: 0x00DE72D5
		public DangoBrawlBattleBuffListItem(EDangoBrawlBuffType buffType)
		{
			this.TargetBuffType = buffType;
		}

		// Token: 0x0603A76B RID: 239467 RVA: 0x00DE9108 File Offset: 0x00DE7308
		private List<DangoBrawlBattleBuffItemData> GetDefaultBuffItemDataList()
		{
			IEnumerable<DangoBrawlBuff> buffConfigList = DangoBrawlConfig.Instance.GetBuffConfigList();
			List<DangoBrawlBattleBuffItemData> list = new List<DangoBrawlBattleBuffItemData>();
			foreach (DangoBrawlBuff dangoBrawlBuff in buffConfigList)
			{
				if (dangoBrawlBuff.BuffType == (int)this.TargetBuffType)
				{
					list.Add(new DangoBrawlBattleBuffItemData
					{
						ConfigId = dangoBrawlBuff.Id,
						SortIndex = dangoBrawlBuff.SortIndex,
						FloorValue = 0,
						IsActivate = false
					});
				}
			}
			list.Sort((DangoBrawlBattleBuffItemData a, DangoBrawlBattleBuffItemData b) => a.SortIndex - b.SortIndex);
			List<DangoBrawlBattleBuffItemData> list2 = new List<DangoBrawlBattleBuffItemData>();
			int num = Math.Min(list.Count, 5);
			for (int i = 0; i < num; i++)
			{
				DangoBrawlBattleBuffItemData dangoBrawlBattleBuffItemData = list[i];
				this.FixedShowIds.Add(dangoBrawlBattleBuffItemData.ConfigId);
				list2.Add(dangoBrawlBattleBuffItemData);
			}
			return list2;
		}

		// Token: 0x0603A76C RID: 239468 RVA: 0x00DE9208 File Offset: 0x00DE7408
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnBuffDetail));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603A76D RID: 239469 RVA: 0x00DE92D0 File Offset: 0x00DE74D0
		protected override void OnStart()
		{
			this.LayoutBuffDataList = this.GetDefaultBuffItemDataList();
			this.BuffLayout = new GenericLayout<DangoBrawlBattleBuffItem, DangoBrawlBattleBuffItemData>(base.GetHorizontalLayout(1), new Func<DangoBrawlBattleBuffItem>(this.CreateBuffItem), null, false, true);
			this.BuffLayout.RefreshByData(this.LayoutBuffDataList, null, false);
		}

		// Token: 0x0603A76E RID: 239470 RVA: 0x00DE931D File Offset: 0x00DE751D
		private DangoBrawlBattleBuffItem CreateBuffItem()
		{
			return new DangoBrawlBattleBuffItem
			{
				OnClickBuff = new Action<int>(this.OnClickOneBuff)
			};
		}

		// Token: 0x0603A76F RID: 239471 RVA: 0x00DE9336 File Offset: 0x00DE7536
		private bool IsFixedShowBuffId(int configId)
		{
			return this.FixedShowIds.Contains(configId);
		}

		// Token: 0x0603A770 RID: 239472 RVA: 0x00DE9344 File Offset: 0x00DE7544
		public void RestoreFromSnapshot(List<BuffInfo> buffs)
		{
			this.CurExistBuffDataList.Clear();
			foreach (DangoBrawlBattleBuffItemData dangoBrawlBattleBuffItemData in this.LayoutBuffDataList)
			{
				dangoBrawlBattleBuffItemData.IsActivate = false;
				dangoBrawlBattleBuffItemData.FloorValue = 0;
				dangoBrawlBattleBuffItemData.Operation = null;
			}
			using (List<BuffInfo>.Enumerator enumerator2 = buffs.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					BuffInfo buff = enumerator2.Current;
					DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(buff.BuffConfigId);
					if (buffConfigById != null && buffConfigById.Value.BuffType == (int)this.TargetBuffType)
					{
						DangoBrawlBattleBuffItemData dangoBrawlBattleBuffItemData2 = this.CurExistBuffDataList.Find((DangoBrawlBattleBuffItemData data) => data.ConfigId == buff.BuffConfigId);
						if (dangoBrawlBattleBuffItemData2 != null)
						{
							dangoBrawlBattleBuffItemData2.FloorValue = buff.Stack;
						}
						else
						{
							this.CurExistBuffDataList.Add(new DangoBrawlBattleBuffItemData
							{
								ConfigId = buff.BuffConfigId,
								SortIndex = buffConfigById.Value.SortIndex,
								FloorValue = buff.Stack,
								IsActivate = true
							});
						}
						DangoBrawlBattleBuffItemData dangoBrawlBattleBuffItemData3 = this.LayoutBuffDataList.Find((DangoBrawlBattleBuffItemData data) => data.ConfigId == buff.BuffConfigId);
						if (dangoBrawlBattleBuffItemData3 != null)
						{
							dangoBrawlBattleBuffItemData3.IsActivate = true;
							dangoBrawlBattleBuffItemData3.FloorValue = buff.Stack;
						}
					}
				}
			}
			GenericLayout<DangoBrawlBattleBuffItem, DangoBrawlBattleBuffItemData> buffLayout = this.BuffLayout;
			if (buffLayout == null)
			{
				return;
			}
			buffLayout.RefreshByData(this.LayoutBuffDataList, null, false);
		}

		// Token: 0x0603A771 RID: 239473 RVA: 0x00DE9520 File Offset: 0x00DE7720
		private void UpdateCurExistBuffDataList(BuffVisualDelta visualDelta)
		{
			int buffConfigId = visualDelta.BuffConfigId;
			DangoBrawlBuff? buffConfigById = DangoBrawlConfig.Instance.GetBuffConfigById(buffConfigId);
			DangoBrawlBattleBuffItemData dangoBrawlBattleBuffItemData = this.CurExistBuffDataList.Find((DangoBrawlBattleBuffItemData data) => data.ConfigId == buffConfigId);
			EDangoBrawlBuffVisualOp op = visualDelta.Op;
			if (op - EDangoBrawlBuffVisualOp.Add > 1)
			{
				if (op != EDangoBrawlBuffVisualOp.Remove)
				{
					return;
				}
				if (dangoBrawlBattleBuffItemData != null)
				{
					this.CurExistBuffDataList.Remove(dangoBrawlBattleBuffItemData);
				}
				return;
			}
			else
			{
				if (dangoBrawlBattleBuffItemData != null)
				{
					dangoBrawlBattleBuffItemData.FloorValue = visualDelta.NewStack;
					dangoBrawlBattleBuffItemData.IsActivate = true;
					return;
				}
				this.CurExistBuffDataList.Add(new DangoBrawlBattleBuffItemData
				{
					ConfigId = buffConfigId,
					SortIndex = ((buffConfigById != null) ? buffConfigById.GetValueOrDefault().SortIndex : 0),
					FloorValue = visualDelta.NewStack,
					IsActivate = true
				});
				return;
			}
		}

		// Token: 0x0603A772 RID: 239474 RVA: 0x00DE95F4 File Offset: 0x00DE77F4
		private void RefreshFixedLayoutBuffItem(DangoBrawlBattleBuffItemData layoutData, BuffVisualDelta visualDelta)
		{
			layoutData.Operation = new EDangoBrawlBuffVisualOp?(visualDelta.Op);
			EDangoBrawlBuffVisualOp op = visualDelta.Op;
			if (op - EDangoBrawlBuffVisualOp.Add > 1)
			{
				if (op == EDangoBrawlBuffVisualOp.Remove)
				{
					layoutData.IsActivate = false;
					layoutData.FloorValue = 0;
				}
			}
			else
			{
				layoutData.IsActivate = true;
				layoutData.FloorValue = visualDelta.NewStack;
			}
			GenericLayout<DangoBrawlBattleBuffItem, DangoBrawlBattleBuffItemData> buffLayout = this.BuffLayout;
			if (buffLayout == null)
			{
				return;
			}
			buffLayout.RefreshGridProxyByKey<int>(layoutData.ConfigId);
		}

		// Token: 0x0603A773 RID: 239475 RVA: 0x00DE9660 File Offset: 0x00DE7860
		public void Refresh(BuffVisualDelta visualDelta)
		{
			this.UpdateCurExistBuffDataList(visualDelta);
			int buffConfigId = visualDelta.BuffConfigId;
			if (!this.IsFixedShowBuffId(buffConfigId))
			{
				return;
			}
			DangoBrawlBattleBuffItemData dangoBrawlBattleBuffItemData = this.LayoutBuffDataList.Find((DangoBrawlBattleBuffItemData itemData) => buffConfigId == itemData.ConfigId);
			if (dangoBrawlBattleBuffItemData == null)
			{
				return;
			}
			this.RefreshFixedLayoutBuffItem(dangoBrawlBattleBuffItemData, visualDelta);
		}

		// Token: 0x0603A774 RID: 239476 RVA: 0x00DE96BC File Offset: 0x00DE78BC
		public List<DangoBrawlBattleBuffDetailItemData> BuildBuffDetailDataList(int selectId = 0)
		{
			List<DangoBrawlBattleBuffDetailItemData> list = new List<DangoBrawlBattleBuffDetailItemData>();
			foreach (DangoBrawlBattleBuffItemData dangoBrawlBattleBuffItemData in this.CurExistBuffDataList)
			{
				list.Add(new DangoBrawlBattleBuffDetailItemData
				{
					BaseData = dangoBrawlBattleBuffItemData,
					IsSelected = (selectId == dangoBrawlBattleBuffItemData.ConfigId)
				});
			}
			return list;
		}

		// Token: 0x0603A775 RID: 239477 RVA: 0x00DE9730 File Offset: 0x00DE7930
		private void OnClickBtnBuffDetail()
		{
			Action<EDangoBrawlBuffType, int> onOpenDetailView = this.OnOpenDetailView;
			if (onOpenDetailView == null)
			{
				return;
			}
			onOpenDetailView(this.TargetBuffType, 0);
		}

		// Token: 0x0603A776 RID: 239478 RVA: 0x00DE9749 File Offset: 0x00DE7949
		private void OnClickOneBuff(int configId)
		{
			Action<EDangoBrawlBuffType, int> onOpenDetailView = this.OnOpenDetailView;
			if (onOpenDetailView == null)
			{
				return;
			}
			onOpenDetailView(this.TargetBuffType, configId);
		}

		// Token: 0x0401E75F RID: 124767
		private readonly EDangoBrawlBuffType TargetBuffType;

		// Token: 0x0401E760 RID: 124768
		[Nullable(2)]
		public Action<EDangoBrawlBuffType, int> OnOpenDetailView;

		// Token: 0x0401E761 RID: 124769
		private const int FIXED_SHOW_BUFF_NUM = 5;

		// Token: 0x0401E762 RID: 124770
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DangoBrawlBattleBuffItem, DangoBrawlBattleBuffItemData> BuffLayout;

		// Token: 0x0401E763 RID: 124771
		private List<DangoBrawlBattleBuffItemData> LayoutBuffDataList = new List<DangoBrawlBattleBuffItemData>();

		// Token: 0x0401E764 RID: 124772
		private List<DangoBrawlBattleBuffItemData> CurExistBuffDataList = new List<DangoBrawlBattleBuffItemData>();

		// Token: 0x0401E765 RID: 124773
		private readonly List<int> FixedShowIds = new List<int>();

		// Token: 0x0200BC78 RID: 48248
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04038DDB RID: 232923
			BtnBuffDetail,
			// Token: 0x04038DDC RID: 232924
			BuffLayout,
			// Token: 0x04038DDD RID: 232925
			BuffItem
		}
	}
}
