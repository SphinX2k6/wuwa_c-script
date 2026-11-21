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
	// Token: 0x02003AA7 RID: 15015
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseHeadStateManager
	{
		// Token: 0x06026913 RID: 157971 RVA: 0x00ACFD40 File Offset: 0x00ACDF40
		public void Init()
		{
			this.MaxDistanceSquared = (double)ConfigCommonParamById.GetIntConfig("TowerDefenseHeadStateShowMaxDistance").Value;
			this.MinDistanceSquared = (double)ConfigCommonParamById.GetIntConfig("TowerDefenseHeadStateShowMinDistance").Value;
		}

		// Token: 0x06026914 RID: 157972 RVA: 0x00ACFD7F File Offset: 0x00ACDF7F
		public void OnWorldDone()
		{
			this.LoadDynamicBatchView();
		}

		// Token: 0x06026915 RID: 157973 RVA: 0x00ACFD87 File Offset: 0x00ACDF87
		public void LoadDynamicBatchView()
		{
			this.DynamicBatchView = new TowerDefenseHeadStateDynamicBatchView();
			this.DynamicBatchView.CreateThenShowByResourceIdAsync("UiItem_TowerDefenseHPDynamicBatch", UiLayer.Instance.WorldSpaceUiRootItem, true).Forget();
		}

		// Token: 0x06026916 RID: 157974 RVA: 0x00ACFDB4 File Offset: 0x00ACDFB4
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

		// Token: 0x06026917 RID: 157975 RVA: 0x00ACFE18 File Offset: 0x00ACE018
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

		// Token: 0x06026918 RID: 157976 RVA: 0x00ACFE64 File Offset: 0x00ACE064
		public void RemoveEntity(int entityId)
		{
			TowerDefenseHeadStateData item;
			if (this.HeadStateMap.Remove(entityId, out item))
			{
				this.DestroyList.Add(item);
			}
		}

		// Token: 0x06026919 RID: 157977 RVA: 0x00ACFE90 File Offset: 0x00ACE090
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

		// Token: 0x0602691A RID: 157978 RVA: 0x00AD00D4 File Offset: 0x00ACE2D4
		public UCurveFloat GetScaleCurve()
		{
			if (this.ScaleCurve == null)
			{
				string stringConfig = ConfigCommonParamById.GetStringConfig("HeadStateScaleCurvePath");
				this.ScaleCurve = ResourceSystem.Instance.Load<UCurveFloat>(stringConfig, "Ui.TrapDefenseUi");
			}
			return this.ScaleCurve;
		}

		// Token: 0x0602691B RID: 157979 RVA: 0x00AD0110 File Offset: 0x00ACE310
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

		// Token: 0x04015220 RID: 86560
		private readonly Dictionary<int, TowerDefenseHeadStateData> HeadStateMap = new Dictionary<int, TowerDefenseHeadStateData>();

		// Token: 0x04015221 RID: 86561
		private readonly List<TowerDefenseHeadStateData> CreateList = new List<TowerDefenseHeadStateData>();

		// Token: 0x04015222 RID: 86562
		private readonly List<TowerDefenseHeadStateData> ModifyHpList = new List<TowerDefenseHeadStateData>();

		// Token: 0x04015223 RID: 86563
		private readonly List<TowerDefenseHeadStateData> DestroyList = new List<TowerDefenseHeadStateData>();

		// Token: 0x04015224 RID: 86564
		private readonly List<TowerDefenseHeadStateData> SortList = new List<TowerDefenseHeadStateData>();

		// Token: 0x04015225 RID: 86565
		[Nullable(2)]
		private UCurveFloat ScaleCurve;

		// Token: 0x04015226 RID: 86566
		private double MaxDistanceSquared;

		// Token: 0x04015227 RID: 86567
		private double MinDistanceSquared;

		// Token: 0x04015228 RID: 86568
		[Nullable(2)]
		private TowerDefenseHeadStateDynamicBatchView DynamicBatchView;
	}
}
