using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A2A RID: 14890
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdBuffSelectViewModel
	{
		// Token: 0x06026487 RID: 156807 RVA: 0x00AB8684 File Offset: 0x00AB6884
		public static TrapDefenseBdBuffSelectViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseBdBuffSelectViewModel
			{
				Model = model
			};
		}

		// Token: 0x06026488 RID: 156808 RVA: 0x00AB8692 File Offset: 0x00AB6892
		private TrapDefenseBdBuffSelectViewModel()
		{
		}

		// Token: 0x06026489 RID: 156809 RVA: 0x00AB86B8 File Offset: 0x00AB68B8
		public bool SetBuffList(List<int> idList, int? selectId = null)
		{
			this.BdBuffDataList.Clear();
			foreach (int key in idList)
			{
				TrapDefenseBdBuffData trapDefenseBdBuffData;
				this.Model.RougeModeData.BdBuffDataMap.TryGetValue(key, out trapDefenseBdBuffData);
				if (trapDefenseBdBuffData != null)
				{
					this.BdBuffDataList.Add(trapDefenseBdBuffData);
				}
			}
			this.SetSelectBuffId(selectId);
			return true;
		}

		// Token: 0x0602648A RID: 156810 RVA: 0x00AB873C File Offset: 0x00AB693C
		public void SetSelectBuffId(int? id)
		{
			TrapDefenseBdBuffData selectBuff = this.BdBuffDataList.Find(delegate(TrapDefenseBdBuffData data)
			{
				int id2 = data.Id;
				int? id3 = id;
				return id2 == id3.GetValueOrDefault() & id3 != null;
			});
			this.SetSelectBuff(selectBuff);
		}

		// Token: 0x0602648B RID: 156811 RVA: 0x00AB8778 File Offset: 0x00AB6978
		[NullableContext(2)]
		public void SetSelectBuff(TrapDefenseBdBuffData buff)
		{
			TrapDefenseBdBuffData curSelectBdBuffData = this.CurSelectBdBuffData;
			if (curSelectBdBuffData != null)
			{
				curSelectBdBuffData.GetBelongBdData().SetPreAddedBuff(null);
			}
			this.CurSelectBdBuffData = buff;
			if (buff != null)
			{
				buff.GetBelongBdData().SetPreAddedBuff(buff);
			}
			if (buff != null)
			{
				EventSystem.Instance.Emit<TrapDefenseBdBuffData, TrapDefenseBdData>(EEventName.TrapDefenseBdBuffSelectChange, buff, buff.GetBelongBdData());
			}
		}

		// Token: 0x0602648C RID: 156812 RVA: 0x00AB87CC File Offset: 0x00AB69CC
		public List<TrapDefenseBdData> GetShowBdDataList()
		{
			TrapDefenseLevelData curInstToLevelData = this.Model.GetCurInstToLevelData();
			return ((curInstToLevelData != null) ? curInstToLevelData.GetShowBdList() : null) ?? this.Model.RougeModeData.BdDataListIgnoreZero;
		}

		// Token: 0x0602648D RID: 156813 RVA: 0x00AB87F9 File Offset: 0x00AB69F9
		public int GetRefreshBuffCostId()
		{
			return TrapDefenseConfig.Instance.GetBattleGoldToItemId();
		}

		// Token: 0x0602648E RID: 156814 RVA: 0x00AB8805 File Offset: 0x00AB6A05
		public long GetRefreshBuffCostRemainNum()
		{
			return this.Model.BattleData.GetGoldNum();
		}

		// Token: 0x0602648F RID: 156815 RVA: 0x00AB8817 File Offset: 0x00AB6A17
		public void SetRefreshBuffCostNum(int num)
		{
			this.RefreshBuffCostNum = num;
		}

		// Token: 0x06026490 RID: 156816 RVA: 0x00AB8820 File Offset: 0x00AB6A20
		public void SetMaxRefreshCount(int count)
		{
			this.MaxRefreshCount = count;
		}

		// Token: 0x06026491 RID: 156817 RVA: 0x00AB8829 File Offset: 0x00AB6A29
		public void SetRemainRefreshCount(int count)
		{
			this.RemainRefreshCount = count;
		}

		// Token: 0x06026492 RID: 156818 RVA: 0x00AB8834 File Offset: 0x00AB6A34
		public string GetRefreshBuffCostIconPath(int? id)
		{
			int itemConfigId = id ?? this.GetRefreshBuffCostId();
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemConfigId);
			return ((itemConfig != null) ? itemConfig.GetValueOrDefault().IconSmall : null) ?? itemConfigId.ToString();
		}

		// Token: 0x06026493 RID: 156819 RVA: 0x00AB8890 File Offset: 0x00AB6A90
		public bool RefreshBuffIsEnoughCost(int? costNum = null)
		{
			long refreshBuffCostRemainNum = this.GetRefreshBuffCostRemainNum();
			int num = costNum ?? this.RefreshBuffCostNum;
			return refreshBuffCostRemainNum >= (long)num;
		}

		// Token: 0x06026494 RID: 156820 RVA: 0x00AB88C5 File Offset: 0x00AB6AC5
		public void OnOpenView()
		{
			this.ShowingViewProcess = true;
		}

		// Token: 0x06026495 RID: 156821 RVA: 0x00AB88D0 File Offset: 0x00AB6AD0
		public void OnViewClose()
		{
			if (this.BdBuffDataList.Count <= 0)
			{
				this.Model.BdBuffSelectProcessFinish();
				return;
			}
			if (this.CurSelectBdBuffData == null)
			{
				return;
			}
			this.CurSelectBdBuffData.GetBelongBdData().SetPreAddedBuff(null);
			if (!this.CurSelectBdBuffData.IsStrengthenFinish())
			{
				this.Model.BdBuffSelectProcessFinish();
			}
		}

		// Token: 0x06026496 RID: 156822 RVA: 0x00AB8929 File Offset: 0x00AB6B29
		public void ViewProcessFinish()
		{
			this.ShowingViewProcess = false;
		}

		// Token: 0x06026497 RID: 156823 RVA: 0x00AB8934 File Offset: 0x00AB6B34
		[NullableContext(0)]
		public UniTask<bool> RequestSureBuffSelect()
		{
			TrapDefenseBdBuffSelectViewModel.<RequestSureBuffSelect>d__24 <RequestSureBuffSelect>d__;
			<RequestSureBuffSelect>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestSureBuffSelect>d__.<>4__this = this;
			<RequestSureBuffSelect>d__.<>1__state = -1;
			<RequestSureBuffSelect>d__.<>t__builder.Start<TrapDefenseBdBuffSelectViewModel.<RequestSureBuffSelect>d__24>(ref <RequestSureBuffSelect>d__);
			return <RequestSureBuffSelect>d__.<>t__builder.Task;
		}

		// Token: 0x06026498 RID: 156824 RVA: 0x00AB8978 File Offset: 0x00AB6B78
		[NullableContext(0)]
		public UniTask<bool> RequestUpdateBdBuffList()
		{
			TrapDefenseBdBuffSelectViewModel.<RequestUpdateBdBuffList>d__25 <RequestUpdateBdBuffList>d__;
			<RequestUpdateBdBuffList>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestUpdateBdBuffList>d__.<>1__state = -1;
			<RequestUpdateBdBuffList>d__.<>t__builder.Start<TrapDefenseBdBuffSelectViewModel.<RequestUpdateBdBuffList>d__25>(ref <RequestUpdateBdBuffList>d__);
			return <RequestUpdateBdBuffList>d__.<>t__builder.Task;
		}

		// Token: 0x04015053 RID: 86099
		public TrapDefenseModel Model;

		// Token: 0x04015054 RID: 86100
		public List<TrapDefenseBdBuffData> BdBuffDataList = new List<TrapDefenseBdBuffData>();

		// Token: 0x04015055 RID: 86101
		[Nullable(2)]
		public TrapDefenseBdBuffData CurSelectBdBuffData;

		// Token: 0x04015056 RID: 86102
		public int MaxRefreshCount = 1;

		// Token: 0x04015057 RID: 86103
		public int RemainRefreshCount;

		// Token: 0x04015058 RID: 86104
		public int RefreshBuffCostNum;

		// Token: 0x04015059 RID: 86105
		public bool ShowingViewProcess;

		// Token: 0x0401505A RID: 86106
		public List<List<int>> BackupIdList = new List<List<int>>();
	}
}
