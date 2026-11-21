using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GameMainView.TrapDefense;
using CSharpScript.Game.Module.TowerDefenseEvent;
using CSharpScript.Game.Module.TrapDefense;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020011FB RID: 4603
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseMiniMapPanel : BattleChildViewPanel
{
	// Token: 0x0600B6CB RID: 46795 RVA: 0x0035FB64 File Offset: 0x0035DD64
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OpenMap))
		};
	}

	// Token: 0x0600B6CC RID: 46796 RVA: 0x0035FC50 File Offset: 0x0035DE50
	public override void InitializeTemp()
	{
		this.MapType = (((this.OpenParam as EBattleUiChild?).GetValueOrDefault() != EBattleUiChild.MiniMap) ? 1 : 0);
		this.SetUp();
	}

	// Token: 0x0600B6CD RID: 46797 RVA: 0x0035FC88 File Offset: 0x0035DE88
	public void OnTowerDefenseStepUpdate(ETowerDefenseEventProcessStatus status)
	{
		foreach (KeyValuePair<int, TrapDefenseMarkView> keyValuePair in this.MarkViewMap)
		{
			keyValuePair.Value.OnTowerDefenseStepUpdate(status);
		}
		this.ProcessPhantomPointVisible();
		if (status == ETowerDefenseEventProcessStatus.Ready)
		{
			TrapDefenseModel.Instance.MapData.InitSplineData();
			this.ShowPhantomPreviewRoute();
			return;
		}
		this.StopShowPhantomPreviewRoute();
	}

	// Token: 0x0600B6CE RID: 46798 RVA: 0x0035FD08 File Offset: 0x0035DF08
	private void ProcessPhantomPointVisible()
	{
		List<TrapDefensePhantomPointMarkItem> dynamicMarksByMarkType = TrapDefenseModel.Instance.MapData.GetDynamicMarksByMarkType<TrapDefensePhantomPointMarkItem>(TrapDefenseDefine.ETrapDefenseMarkType.PhantomPoint);
		dynamicMarksByMarkType.Sort(delegate(TrapDefensePhantomPointMarkItem a, TrapDefensePhantomPointMarkItem b)
		{
			if (a.IsActivated() == b.IsActivated())
			{
				return a.MarkId - b.MarkId;
			}
			if (!a.IsActivated())
			{
				return -1;
			}
			return 1;
		});
		List<global::Vector> list = new List<global::Vector>();
		foreach (TrapDefensePhantomPointMarkItem trapDefensePhantomPointMarkItem in dynamicMarksByMarkType)
		{
			list.Add(trapDefensePhantomPointMarkItem.WorldPosition);
		}
		global::Vector vector = global::Vector.Create();
		for (int i = 0; i < dynamicMarksByMarkType.Count; i++)
		{
			bool uiActive = true;
			for (int j = i + 1; j < dynamicMarksByMarkType.Count; j++)
			{
				list[j].Subtraction(list[i], vector);
				if (vector.IsNearlyZero(9.999999747378752E-05))
				{
					uiActive = false;
					break;
				}
			}
			TrapDefenseMarkView trapDefenseMarkView;
			if (this.MarkViewMap.TryGetValue(dynamicMarksByMarkType[i].MarkId, out trapDefenseMarkView))
			{
				trapDefenseMarkView.SetUiActive(uiActive);
			}
		}
	}

	// Token: 0x0600B6CF RID: 46799 RVA: 0x0035FE24 File Offset: 0x0035E024
	private void RefreshMap(int mapId)
	{
		TrapDefenseMap? trapDefenseMapConfigById = TrapDefenseConfig.Instance.GetTrapDefenseMapConfigById(mapId);
		if (trapDefenseMapConfigById == null)
		{
			this.RootItem.SetUIActive(false);
			return;
		}
		string path = (this.MapType == 0) ? trapDefenseMapConfigById.Value.MiniMapResourcePath : trapDefenseMapConfigById.Value.MapResourcePath;
		this.Scale = ((this.MapType == 0) ? trapDefenseMapConfigById.Value.MiniMapScale : trapDefenseMapConfigById.Value.MapScale);
		float[] array = (this.MapType == 0) ? trapDefenseMapConfigById.Value.GetUiOffsetArray() : trapDefenseMapConfigById.Value.GetBigMapUiOffsetArray();
		if (array != null && array.Length >= 2)
		{
			this.UiOffset.Set((double)array[0], (double)array[1]);
		}
		else
		{
			this.UiOffset.Reset();
		}
		if (trapDefenseMapConfigById.Value.GetCenterOffsetArray() != null && trapDefenseMapConfigById.Value.GetCenterOffsetArray().Length >= 2)
		{
			this.CenterOffset.Set((double)trapDefenseMapConfigById.Value.GetCenterOffsetArray()[0], (double)trapDefenseMapConfigById.Value.GetCenterOffsetArray()[1]);
			if (this.MapType == 1)
			{
				this.CenterOffset.MultiplyEqual(2.0);
			}
		}
		AActor owner = base.GetButton(7).GetOwner();
		UUIItem uuiitem = ((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem;
		if (uuiitem != null)
		{
			uuiitem.SetAnchorOffset(this.UiOffset.ToUeVector2D(false));
		}
		base.SetTextureByPath(path, base.GetTexture(0), null, null);
		base.GetItem(1).SetUIActive(false);
		base.SetTextureByPath(trapDefenseMapConfigById.Value.MiniMapLightResourcePath, base.GetTexture(6), null, null);
	}

	// Token: 0x0600B6D0 RID: 46800 RVA: 0x0035FFF9 File Offset: 0x0035E1F9
	protected override void OnStart()
	{
		this.TimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Update), 50f, 1f, null, null, true);
	}

	// Token: 0x0600B6D1 RID: 46801 RVA: 0x00360024 File Offset: 0x0035E224
	protected override void OnBeforeDestroy()
	{
		if (this.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			this.TimerId = null;
		}
		this.StopShowPhantomPreviewRoute();
		if (this.MapType == 0)
		{
			TrapDefenseModel.Instance.MapData.ClearAllSpline();
			TrapDefenseModel.Instance.MapData.ClearMapChanged();
		}
		foreach (KeyValuePair<int, TrapDefenseMarkView> keyValuePair in this.MarkViewMap)
		{
			keyValuePair.Value.Destroy(null);
		}
		this.MarkViewMap.Clear();
	}

	// Token: 0x0600B6D2 RID: 46802 RVA: 0x003600D4 File Offset: 0x0035E2D4
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TrapDefenseActivityDataUpdate, new Action(this.SetUp));
		EventSystem.Instance.Add(EEventName.TrapDefenseMapMarkRemoved, new Action<int>(this.RemoveMark));
		EventSystem.Instance.Add(EEventName.TrapDefenseMapChanged, new Action<int>(this.OnChangeMap));
	}

	// Token: 0x0600B6D3 RID: 46803 RVA: 0x00360138 File Offset: 0x0035E338
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TrapDefenseActivityDataUpdate, new Action(this.SetUp));
		EventSystem.Instance.Remove(EEventName.TrapDefenseMapMarkRemoved, new Action<int>(this.RemoveMark));
		EventSystem.Instance.Remove(EEventName.TrapDefenseMapChanged, new Action<int>(this.OnChangeMap));
	}

	// Token: 0x0600B6D4 RID: 46804 RVA: 0x0036019C File Offset: 0x0035E39C
	private void SetUp()
	{
		if (TrapDefenseModel.Instance.MapData.MapId != 0)
		{
			this.RootItem.SetUIActive(true);
			this.CreateAllMarks();
			this.RefreshMap(TrapDefenseModel.Instance.MapData.MapId);
			ETowerDefenseEventProcessStatus processStatus = TowerDefenseEventController.Instance.ProcessStatus;
			this.OnTowerDefenseStepUpdate(processStatus);
		}
	}

	// Token: 0x0600B6D5 RID: 46805 RVA: 0x003601F4 File Offset: 0x0035E3F4
	public override void Reset()
	{
		if (this.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			this.TimerId = null;
		}
		base.Reset();
	}

	// Token: 0x0600B6D6 RID: 46806 RVA: 0x0036021C File Offset: 0x0035E41C
	private UniTask CreateAllMarks()
	{
		TrapDefenseMiniMapPanel.<CreateAllMarks>d__22 <CreateAllMarks>d__;
		<CreateAllMarks>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllMarks>d__.<>4__this = this;
		<CreateAllMarks>d__.<>1__state = -1;
		<CreateAllMarks>d__.<>t__builder.Start<TrapDefenseMiniMapPanel.<CreateAllMarks>d__22>(ref <CreateAllMarks>d__);
		return <CreateAllMarks>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6D7 RID: 46807 RVA: 0x00360260 File Offset: 0x0035E460
	private UniTask CreateMark(int markId)
	{
		TrapDefenseMiniMapPanel.<CreateMark>d__23 <CreateMark>d__;
		<CreateMark>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateMark>d__.<>4__this = this;
		<CreateMark>d__.markId = markId;
		<CreateMark>d__.<>1__state = -1;
		<CreateMark>d__.<>t__builder.Start<TrapDefenseMiniMapPanel.<CreateMark>d__23>(ref <CreateMark>d__);
		return <CreateMark>d__.<>t__builder.Task;
	}

	// Token: 0x0600B6D8 RID: 46808 RVA: 0x003602AB File Offset: 0x0035E4AB
	private void Update(float deltaTime)
	{
		this.UpdateEnemyPosition();
		this.UpdateAllMarkItems(false);
		this.UpdatePointPositions();
	}

	// Token: 0x0600B6D9 RID: 46809 RVA: 0x003602C0 File Offset: 0x0035E4C0
	private void UpdateAllMarkItems(bool force = false)
	{
		foreach (KeyValuePair<int, TrapDefenseMarkView> keyValuePair in this.MarkViewMap)
		{
			TrapDefenseMarkView value = keyValuePair.Value;
			if ((value.NeedUpdatePosition || force) && value.IsShow && value.GetMarkData() != null)
			{
				value.UpdatePosition(this.Scale, this.CenterOffset);
			}
		}
	}

	// Token: 0x0600B6DA RID: 46810 RVA: 0x00360340 File Offset: 0x0035E540
	private void UpdateEnemyPosition()
	{
		TrapDefenseController.Instance.UpdateEnemyPositions();
		foreach (TrapDefenseMonsterMarkItem trapDefenseMonsterMarkItem in TrapDefenseModel.Instance.MapData.GetDynamicMarksByMarkType<TrapDefenseMonsterMarkItem>(TrapDefenseDefine.ETrapDefenseMarkType.Phantom))
		{
			TrapDefenseMarkView trapDefenseMarkView;
			if (this.MarkViewMap.TryGetValue(trapDefenseMonsterMarkItem.MarkId, out trapDefenseMarkView))
			{
				if (trapDefenseMarkView.NeedUpdatePosition && trapDefenseMarkView.IsShow && trapDefenseMarkView.GetMarkData() != null)
				{
					trapDefenseMarkView.UpdatePosition(this.Scale, this.CenterOffset);
				}
			}
			else
			{
				this.CreateMark(trapDefenseMonsterMarkItem.MarkId);
			}
		}
	}

	// Token: 0x0600B6DB RID: 46811 RVA: 0x003603F0 File Offset: 0x0035E5F0
	private void RemoveMark(int markId)
	{
		TrapDefenseMarkView trapDefenseMarkView;
		if (this.MarkViewMap.TryGetValue(markId, out trapDefenseMarkView))
		{
			trapDefenseMarkView.Destroy(null);
			this.MarkViewMap.Remove(markId);
		}
	}

	// Token: 0x0600B6DC RID: 46812 RVA: 0x00360421 File Offset: 0x0035E621
	private void OnChangeMap(int mapId)
	{
		this.RefreshMap(mapId);
	}

	// Token: 0x0600B6DD RID: 46813 RVA: 0x0036042A File Offset: 0x0035E62A
	private void ShowPhantomPreviewRoute()
	{
		if (this.PreviewRouteTimerId != null)
		{
			return;
		}
		this.PreviewRouteTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.GenerateRoutePreviewGroup), (float)TrapDefenseConfig.Instance.GetTrapDefenseRoutePreviewInterval(), 1f, null, null, true);
	}

	// Token: 0x0600B6DE RID: 46814 RVA: 0x00360464 File Offset: 0x0035E664
	private void GenerateRoutePreviewGroup(float deltaTime)
	{
		List<TrapDefensePhantomPointMarkItem> dynamicMarksByMarkType = TrapDefenseModel.Instance.MapData.GetDynamicMarksByMarkType<TrapDefensePhantomPointMarkItem>(TrapDefenseDefine.ETrapDefenseMarkType.PhantomPoint);
		List<int> list = new List<int>();
		foreach (TrapDefensePhantomPointMarkItem trapDefensePhantomPointMarkItem in dynamicMarksByMarkType)
		{
			if (trapDefensePhantomPointMarkItem.IsActivated())
			{
				list.Add(trapDefensePhantomPointMarkItem.SplineId);
			}
		}
		foreach (int key in list)
		{
			if (!this.SplinePointView.ContainsKey(key))
			{
				this.SplinePointView[key] = new List<List<TrapDefenseRoutePointView>>();
			}
			this.SplinePointView[key].Add(new List<TrapDefenseRoutePointView>());
			List<List<TrapDefenseRoutePointView>> list2 = this.SplinePointView[key];
			List<TrapDefenseRoutePointView> list3 = list2[list2.Count - 1];
			int trapDefenseRoutePointShootInterval = TrapDefenseConfig.Instance.GetTrapDefenseRoutePointShootInterval();
			for (int i = 0; i < TrapDefenseConfig.Instance.GetTrapDefenseRoutePointNum(); i++)
			{
				TrapDefenseRoutePointView trapDefenseRoutePointView = new TrapDefenseRoutePointView();
				trapDefenseRoutePointView.StartTimestamp = TimerSystem.GameplayTimeInstance.Now + (double)(trapDefenseRoutePointShootInterval * i);
				trapDefenseRoutePointView.Index = i;
				trapDefenseRoutePointView.CreateThenShowByPathAsync("/Game/Aki/UI/UIResources/UiFight/Prefabs/Activity/TowerDefense/DynMapPointIcon.DynMapPointIcon", base.GetItem(3), false);
				list3.Add(trapDefenseRoutePointView);
			}
		}
	}

	// Token: 0x0600B6DF RID: 46815 RVA: 0x003605D0 File Offset: 0x0035E7D0
	private void UpdatePointPositions()
	{
		int trapDefenseRoutePreviewTime = TrapDefenseConfig.Instance.GetTrapDefenseRoutePreviewTime();
		foreach (KeyValuePair<int, List<List<TrapDefenseRoutePointView>>> keyValuePair in this.SplinePointView)
		{
			int key = keyValuePair.Key;
			List<List<TrapDefenseRoutePointView>> value = keyValuePair.Value;
			USplineComponent splineComponent = TrapDefenseModel.Instance.MapData.GetSplineComponent(key);
			float splineLength = splineComponent.GetSplineLength();
			for (int i = 0; i < value.Count; i++)
			{
				List<TrapDefenseRoutePointView> list = value[i];
				List<TrapDefenseRoutePointView> list2 = new List<TrapDefenseRoutePointView>();
				for (int j = 0; j < list.Count; j++)
				{
					TrapDefenseRoutePointView trapDefenseRoutePointView = list[j];
					double num = TimerSystem.GameplayTimeInstance.Now - trapDefenseRoutePointView.StartTimestamp;
					if (num >= (double)trapDefenseRoutePreviewTime)
					{
						trapDefenseRoutePointView.Destroy(null);
					}
					else
					{
						double num2 = (double)splineLength * Math.Min((double)trapDefenseRoutePreviewTime, num) / (double)trapDefenseRoutePreviewTime;
						FVectorDouble fvectorDouble = splineComponent.D_GetLocationAtDistanceAlongSpline((float)num2, ESplineCoordinateSpace.World);
						trapDefenseRoutePointView.UpdatePosition(fvectorDouble, this.Scale, this.CenterOffset);
						list2.Add(trapDefenseRoutePointView);
					}
				}
				value[i] = list2;
			}
		}
	}

	// Token: 0x0600B6E0 RID: 46816 RVA: 0x00360728 File Offset: 0x0035E928
	private void StopShowPhantomPreviewRoute()
	{
		this.StopSplineTimers();
		this.ClearPreviewRoute();
		if (this.MapType == 0)
		{
			TrapDefenseModel.Instance.MapData.ClearAllSpline();
		}
	}

	// Token: 0x0600B6E1 RID: 46817 RVA: 0x0036074D File Offset: 0x0035E94D
	private void StopSplineTimers()
	{
		if (this.PreviewRouteTimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.PreviewRouteTimerId);
			this.PreviewRouteTimerId = null;
		}
	}

	// Token: 0x0600B6E2 RID: 46818 RVA: 0x00360770 File Offset: 0x0035E970
	private void ClearPreviewRoute()
	{
		foreach (List<List<TrapDefenseRoutePointView>> list in this.SplinePointView.Values)
		{
			foreach (List<TrapDefenseRoutePointView> list2 in list)
			{
				foreach (TrapDefenseRoutePointView trapDefenseRoutePointView in list2)
				{
					trapDefenseRoutePointView.Destroy(null);
				}
			}
		}
		this.SplinePointView.Clear();
	}

	// Token: 0x0600B6E3 RID: 46819 RVA: 0x0036083C File Offset: 0x0035EA3C
	private void OpenMap()
	{
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseMapView, null, null);
	}

	// Token: 0x0600B6E4 RID: 46820 RVA: 0x00360850 File Offset: 0x0035EA50
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (configParams[0] != "DynActivityTowerMap")
		{
			return null;
		}
		UUIItem guideUiItem = base.GetGuideUiItem("0");
		if (guideUiItem == null)
		{
			return null;
		}
		UUIButtonComponent button = base.GetButton(7);
		UUIItem uuiitem = (button != null) ? button.GetRootComponent() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			guideUiItem
		};
	}

	// Token: 0x040069AA RID: 27050
	private const int UPDATE_INTERVAL = 50;

	// Token: 0x040069AB RID: 27051
	private int MapType;

	// Token: 0x040069AC RID: 27052
	private readonly Dictionary<int, TrapDefenseMarkView> MarkViewMap = new Dictionary<int, TrapDefenseMarkView>();

	// Token: 0x040069AD RID: 27053
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x040069AE RID: 27054
	private readonly Vector2D UiOffset = Vector2D.Create();

	// Token: 0x040069AF RID: 27055
	private readonly Vector2D CenterOffset = Vector2D.Create();

	// Token: 0x040069B0 RID: 27056
	private float Scale = 1f;

	// Token: 0x040069B1 RID: 27057
	[Nullable(2)]
	private TimerHandle PreviewRouteTimerId;

	// Token: 0x040069B2 RID: 27058
	private readonly Dictionary<int, List<List<TrapDefenseRoutePointView>>> SplinePointView = new Dictionary<int, List<List<TrapDefenseRoutePointView>>>();

	// Token: 0x020074CF RID: 29903
	[NullableContext(0)]
	private static class EChildComponentType
	{
		// Token: 0x04026001 RID: 155649
		public const int TextureMap = 0;

		// Token: 0x04026002 RID: 155650
		public const int PanelAnim = 1;

		// Token: 0x04026003 RID: 155651
		public const int Arrow = 2;

		// Token: 0x04026004 RID: 155652
		public const int MiniMapRoot = 3;

		// Token: 0x04026005 RID: 155653
		public const int PlayerItem = 4;

		// Token: 0x04026006 RID: 155654
		public const int PlayerSight = 5;

		// Token: 0x04026007 RID: 155655
		public const int TextureLight = 6;

		// Token: 0x04026008 RID: 155656
		public const int PanelPos = 7;
	}

	// Token: 0x020074D0 RID: 29904
	[NullableContext(0)]
	private static class EMapShowType
	{
		// Token: 0x04026009 RID: 155657
		public const int MiniMap = 0;

		// Token: 0x0402600A RID: 155658
		public const int BigMap = 1;
	}
}
