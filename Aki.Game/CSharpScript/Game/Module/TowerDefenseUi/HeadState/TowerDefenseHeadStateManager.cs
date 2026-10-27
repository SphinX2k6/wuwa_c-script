using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseUi.HeadState
{
	// Token: 0x02004AFF RID: 19199
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseHeadStateManager
	{
		// Token: 0x06031B83 RID: 203651 RVA: 0x00B8BCE4 File Offset: 0x00B89EE4
		public void Init()
		{
			this.MaxDistanceSquared = (double)ConfigCommonParamById.GetIntConfig("TowerDefenseHeadStateShowMaxDistance").Value;
			this.MinDistanceSquared = (double)ConfigCommonParamById.GetIntConfig("TowerDefenseHeadStateShowMinDistance").Value;
		}

		// Token: 0x06031B84 RID: 203652 RVA: 0x00B8BD23 File Offset: 0x00B89F23
		public void OnWorldDone()
		{
			this.LoadDynamicBatchView();
		}

		// Token: 0x06031B85 RID: 203653 RVA: 0x00B8BD2B File Offset: 0x00B89F2B
		public void LoadDynamicBatchView()
		{
			this.DynamicBatchView = new TowerDefenseHeadStateDynamicBatchView();
			this.DynamicBatchView.CreateThenShowByResourceIdAsync("UiItem_TowerDefenseHPDynamicBatch", UiLayer.Instance.WorldSpaceUiRootItem, true).Forget();
		}

		// Token: 0x06031B86 RID: 203654 RVA: 0x00B8BD58 File Offset: 0x00B89F58
		public void AddEntity(int entityId, global::Vector position, int maxHp, int hp, int shield)
		{
			if (this.HeadStateMap.ContainsKey(entityId))
			{
				return;
			}
			TowerDefenseHeadStateData towerDefenseHeadStateData = new TowerDefenseHeadStateData();
			towerDefenseHeadStateData.EntityId = entityId;
			towerDefenseHeadStateData.UpdatePosition(position);
			towerDefenseHeadStateData.UpdateHp(hp, maxHp, shield);
			this.HeadStateMap[entityId] = towerDefenseHeadStateData;
			this.CreateList.Add(towerDefenseHeadStateData);
			this.ModifyHpList.Add(towerDefenseHeadStateData);
		}

		// Token: 0x06031B87 RID: 203655 RVA: 0x00B8BDBC File Offset: 0x00B89FBC
		public void HandleMsg(int entityId, global::Vector position, int maxHp, int hp, int shield)
		{
			TowerDefenseHeadStateData towerDefenseHeadStateData;
			if (!this.HeadStateMap.TryGetValue(entityId, out towerDefenseHeadStateData))
			{
				this.AddEntity(entityId, position, maxHp, hp, shield);
				return;
			}
			towerDefenseHeadStateData.UpdatePosition(position);
			if (towerDefenseHeadStateData.UpdateHp(hp, maxHp, shield))
			{
				this.ModifyHpList.Add(towerDefenseHeadStateData);
			}
		}

		// Token: 0x06031B88 RID: 203656 RVA: 0x00B8BE08 File Offset: 0x00B8A008
		public void RemoveEntity(int entityId)
		{
			TowerDefenseHeadStateData item;
			if (this.HeadStateMap.Remove(entityId, out item))
			{
				this.DestroyList.Add(item);
			}
		}

		// Token: 0x06031B89 RID: 203657 RVA: 0x00B8BE34 File Offset: 0x00B8A034
		public void Tick(float delta)
		{
			foreach (TowerDefenseHeadStateData towerDefenseHeadStateData in this.CreateList)
			{
				towerDefenseHeadStateData.ScaleCurve = this.GetScaleCurve();
			}
			this.CreateList.Clear();
			foreach (TowerDefenseHeadStateData towerDefenseHeadStateData2 in this.ModifyHpList)
			{
				towerDefenseHeadStateData2.RefreshHpAndShield();
			}
			this.ModifyHpList.Clear();
			this.SortList.Clear();
			global::Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
			foreach (TowerDefenseHeadStateData towerDefenseHeadStateData3 in this.HeadStateMap.Values)
			{
				towerDefenseHeadStateData3.RefreshDistance(cameraLocation);
				if (towerDefenseHeadStateData3.DistanceSquared < this.MaxDistanceSquared && towerDefenseHeadStateData3.DistanceSquared > this.MinDistanceSquared)
				{
					towerDefenseHeadStateData3.SetVisible(true);
					towerDefenseHeadStateData3.Tick(delta);
					this.SortList.Add(towerDefenseHeadStateData3);
				}
				else
				{
					towerDefenseHeadStateData3.SetVisible(false);
				}
			}
			foreach (TowerDefenseHeadStateData towerDefenseHeadStateData4 in this.DestroyList)
			{
				towerDefenseHeadStateData4.Destroy();
			}
			this.DestroyList.Clear();
			TowerDefenseHeadStateDynamicBatchView dynamicBatchView = this.DynamicBatchView;
			if (dynamicBatchView != null && dynamicBatchView.GetIsEnable())
			{
				this.DynamicBatchView.ClearDynamicBatchMesh();
				if (this.SortList.Count > 0)
				{
					this.SortList.Sort((TowerDefenseHeadStateData a, TowerDefenseHeadStateData b) => b.DistanceSquared.CompareTo(a.DistanceSquared));
					int num = 15;
					for (int i = Math.Max(this.SortList.Count - num, 0); i < this.SortList.Count; i++)
					{
						this.DynamicBatchView.AddToDynamicBatchMesh(this.SortList[i]);
					}
					this.SortList.Clear();
				}
			}
		}

		// Token: 0x06031B8A RID: 203658 RVA: 0x00B8C078 File Offset: 0x00B8A278
		public UCurveFloat GetScaleCurve()
		{
			if (this.ScaleCurve == null)
			{
				string stringConfig = ConfigCommonParamById.GetStringConfig("HeadStateScaleCurvePath");
				this.ScaleCurve = ResourceSystem.Instance.Load<UCurveFloat>(stringConfig, "Ui.TrapDefenseUi");
			}
			return this.ScaleCurve;
		}

		// Token: 0x06031B8B RID: 203659 RVA: 0x00B8C0B4 File Offset: 0x00B8A2B4
		public void Clear()
		{
			this.CreateList.Clear();
			this.ModifyHpList.Clear();
			foreach (TowerDefenseHeadStateData towerDefenseHeadStateData in this.HeadStateMap.Values)
			{
				towerDefenseHeadStateData.Destroy();
			}
			this.HeadStateMap.Clear();
			foreach (TowerDefenseHeadStateData towerDefenseHeadStateData2 in this.DestroyList)
			{
				towerDefenseHeadStateData2.Destroy();
			}
			this.DestroyList.Clear();
			this.ScaleCurve = null;
			TowerDefenseHeadStateDynamicBatchView dynamicBatchView = this.DynamicBatchView;
			if (dynamicBatchView != null)
			{
				dynamicBatchView.Destroy(null);
			}
			this.DynamicBatchView = null;
		}

		// Token: 0x0401A8CE RID: 108750
		private readonly Dictionary<int, TowerDefenseHeadStateData> HeadStateMap = new Dictionary<int, TowerDefenseHeadStateData>();

		// Token: 0x0401A8CF RID: 108751
		private readonly List<TowerDefenseHeadStateData> CreateList = new List<TowerDefenseHeadStateData>();

		// Token: 0x0401A8D0 RID: 108752
		private readonly List<TowerDefenseHeadStateData> ModifyHpList = new List<TowerDefenseHeadStateData>();

		// Token: 0x0401A8D1 RID: 108753
		private readonly List<TowerDefenseHeadStateData> DestroyList = new List<TowerDefenseHeadStateData>();

		// Token: 0x0401A8D2 RID: 108754
		private readonly List<TowerDefenseHeadStateData> SortList = new List<TowerDefenseHeadStateData>();

		// Token: 0x0401A8D3 RID: 108755
		[Nullable(2)]
		private UCurveFloat ScaleCurve;

		// Token: 0x0401A8D4 RID: 108756
		private double MaxDistanceSquared;

		// Token: 0x0401A8D5 RID: 108757
		private double MinDistanceSquared;

		// Token: 0x0401A8D6 RID: 108758
		[Nullable(2)]
		private TowerDefenseHeadStateDynamicBatchView DynamicBatchView;
	}
}
