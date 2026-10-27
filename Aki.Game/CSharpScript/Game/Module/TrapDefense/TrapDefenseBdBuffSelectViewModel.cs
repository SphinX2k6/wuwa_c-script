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
	// Token: 0x02004A82 RID: 19074
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdBuffSelectViewModel
	{
		// Token: 0x060316F7 RID: 202487 RVA: 0x00B74700 File Offset: 0x00B72900
		public static TrapDefenseBdBuffSelectViewModel Create(TrapDefenseModel model)
		{
			return new TrapDefenseBdBuffSelectViewModel
			{
				Model = model
			};
		}

		// Token: 0x060316F8 RID: 202488 RVA: 0x00B7470E File Offset: 0x00B7290E
		private TrapDefenseBdBuffSelectViewModel()
		{
		}

		// Token: 0x060316F9 RID: 202489 RVA: 0x00B74734 File Offset: 0x00B72934
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

		// Token: 0x060316FA RID: 202490 RVA: 0x00B747B8 File Offset: 0x00B729B8
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

		// Token: 0x060316FB RID: 202491 RVA: 0x00B747F4 File Offset: 0x00B729F4
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

		// Token: 0x060316FC RID: 202492 RVA: 0x00B74848 File Offset: 0x00B72A48
		public List<TrapDefenseBdData> GetShowBdDataList()
		{
			TrapDefenseLevelData curInstToLevelData = this.Model.GetCurInstToLevelData();
			return ((curInstToLevelData != null) ? curInstToLevelData.GetShowBdList() : null) ?? this.Model.RougeModeData.BdDataListIgnoreZero;
		}

		// Token: 0x060316FD RID: 202493 RVA: 0x00B74875 File Offset: 0x00B72A75
		public int GetRefreshBuffCostId()
		{
			return TrapDefenseConfig.Instance.GetBattleGoldToItemId();
		}

		// Token: 0x060316FE RID: 202494 RVA: 0x00B74881 File Offset: 0x00B72A81
		public long GetRefreshBuffCostRemainNum()
		{
			return this.Model.BattleData.GetGoldNum();
		}

		// Token: 0x060316FF RID: 202495 RVA: 0x00B74893 File Offset: 0x00B72A93
		public void SetRefreshBuffCostNum(int num)
		{
			this.RefreshBuffCostNum = num;
		}

		// Token: 0x06031700 RID: 202496 RVA: 0x00B7489C File Offset: 0x00B72A9C
		public void SetMaxRefreshCount(int count)
		{
			this.MaxRefreshCount = count;
		}

		// Token: 0x06031701 RID: 202497 RVA: 0x00B748A5 File Offset: 0x00B72AA5
		public void SetRemainRefreshCount(int count)
		{
			this.RemainRefreshCount = count;
		}

		// Token: 0x06031702 RID: 202498 RVA: 0x00B748B0 File Offset: 0x00B72AB0
		public string GetRefreshBuffCostIconPath(int? id)
		{
			int itemConfigId = id ?? this.GetRefreshBuffCostId();
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemConfigId);
			return ((itemConfig != null) ? itemConfig.GetValueOrDefault().IconSmall : null) ?? itemConfigId.ToString();
		}

		// Token: 0x06031703 RID: 202499 RVA: 0x00B7490C File Offset: 0x00B72B0C
		public bool RefreshBuffIsEnoughCost(int? costNum = null)
		{
			long refreshBuffCostRemainNum = this.GetRefreshBuffCostRemainNum();
			int num = costNum ?? this.RefreshBuffCostNum;
			return refreshBuffCostRemainNum >= (long)num;
		}

		// Token: 0x06031704 RID: 202500 RVA: 0x00B74941 File Offset: 0x00B72B41
		public void OnOpenView()
		{
			this.ShowingViewProcess = true;
		}

		// Token: 0x06031705 RID: 202501 RVA: 0x00B7494C File Offset: 0x00B72B4C
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

		// Token: 0x06031706 RID: 202502 RVA: 0x00B749A5 File Offset: 0x00B72BA5
		public void ViewProcessFinish()
		{
			this.ShowingViewProcess = false;
		}

		// Token: 0x06031707 RID: 202503 RVA: 0x00B749B0 File Offset: 0x00B72BB0
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

		// Token: 0x06031708 RID: 202504 RVA: 0x00B749F4 File Offset: 0x00B72BF4
		[NullableContext(0)]
		public UniTask<bool> RequestUpdateBdBuffList()
		{
			TrapDefenseBdBuffSelectViewModel.<RequestUpdateBdBuffList>d__25 <RequestUpdateBdBuffList>d__;
			<RequestUpdateBdBuffList>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RequestUpdateBdBuffList>d__.<>1__state = -1;
			<RequestUpdateBdBuffList>d__.<>t__builder.Start<TrapDefenseBdBuffSelectViewModel.<RequestUpdateBdBuffList>d__25>(ref <RequestUpdateBdBuffList>d__);
			return <RequestUpdateBdBuffList>d__.<>t__builder.Task;
		}

		// Token: 0x0401A701 RID: 108289
		public TrapDefenseModel Model;

		// Token: 0x0401A702 RID: 108290
		public List<TrapDefenseBdBuffData> BdBuffDataList = new List<TrapDefenseBdBuffData>();

		// Token: 0x0401A703 RID: 108291
		[Nullable(2)]
		public TrapDefenseBdBuffData CurSelectBdBuffData;

		// Token: 0x0401A704 RID: 108292
		public int MaxRefreshCount = 1;

		// Token: 0x0401A705 RID: 108293
		public int RemainRefreshCount;

		// Token: 0x0401A706 RID: 108294
		public int RefreshBuffCostNum;

		// Token: 0x0401A707 RID: 108295
		public bool ShowingViewProcess;

		// Token: 0x0401A708 RID: 108296
		public List<List<int>> BackupIdList = new List<List<int>>();
	}
}
