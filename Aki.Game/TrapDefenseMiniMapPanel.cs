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

// Token: 0x02001D39 RID: 7481
[NullableContext(1)]
[Nullable(0)]
public class TrapDefenseMiniMapPanel : BattleChildViewPanel
{
	// Token: 0x0600E2AE RID: 58030 RVA: 0x00354134 File Offset: 0x00352334
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

	// Token: 0x0600E2AF RID: 58031 RVA: 0x00354220 File Offset: 0x00352420
	public override void InitializeTemp()
	{
		this.MapType = (((this.OpenParam as EBattleUiChild?).GetValueOrDefault() != EBattleUiChild.MiniMap) ? 1 : 0);
		this.SetUp();
	}

	// Token: 0x0600E2B0 RID: 58032 RVA: 0x00354258 File Offset: 0x00352458
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

	// Token: 0x0600E2B1 RID: 58033 RVA: 0x003542D8 File Offset: 0x003524D8
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

	// Token: 0x0600E2B2 RID: 58034 RVA: 0x003543F4 File Offset: 0x003525F4
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

	// Token: 0x0600E2B3 RID: 58035 RVA: 0x003545C9 File Offset: 0x003527C9
	protected override void OnStart()
	{
		this.TimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.Update), 50f, 1f, null, null, true);
	}

	// Token: 0x0600E2B4 RID: 58036 RVA: 0x003545F4 File Offset: 0x003527F4
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

	// Token: 0x0600E2B5 RID: 58037 RVA: 0x003546A4 File Offset: 0x003528A4
	protected override void AddEvents()
	{
		EventSystem.Instance.Add(EEventName.TrapDefenseActivityDataUpdate, new Action(this.SetUp));
		EventSystem.Instance.Add(EEventName.TrapDefenseMapMarkRemoved, new Action<int>(this.RemoveMark));
		EventSystem.Instance.Add(EEventName.TrapDefenseMapChanged, new Action<int>(this.OnChangeMap));
	}

	// Token: 0x0600E2B6 RID: 58038 RVA: 0x00354708 File Offset: 0x00352908
	protected override void RemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.TrapDefenseActivityDataUpdate, new Action(this.SetUp));
		EventSystem.Instance.Remove(EEventName.TrapDefenseMapMarkRemoved, new Action<int>(this.RemoveMark));
		EventSystem.Instance.Remove(EEventName.TrapDefenseMapChanged, new Action<int>(this.OnChangeMap));
	}

	// Token: 0x0600E2B7 RID: 58039 RVA: 0x0035476C File Offset: 0x0035296C
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

	// Token: 0x0600E2B8 RID: 58040 RVA: 0x003547C4 File Offset: 0x003529C4
	public override void Reset()
	{
		if (this.TimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerId);
			this.TimerId = null;
		}
		base.Reset();
	}

	// Token: 0x0600E2B9 RID: 58041 RVA: 0x003547EC File Offset: 0x003529EC
	private UniTask CreateAllMarks()
	{
		TrapDefenseMiniMapPanel.<CreateAllMarks>d__22 <CreateAllMarks>d__;
		<CreateAllMarks>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateAllMarks>d__.<>4__this = this;
		<CreateAllMarks>d__.<>1__state = -1;
		<CreateAllMarks>d__.<>t__builder.Start<TrapDefenseMiniMapPanel.<CreateAllMarks>d__22>(ref <CreateAllMarks>d__);
		return <CreateAllMarks>d__.<>t__builder.Task;
	}

	// Token: 0x0600E2BA RID: 58042 RVA: 0x00354830 File Offset: 0x00352A30
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

	// Token: 0x0600E2BB RID: 58043 RVA: 0x0035487B File Offset: 0x00352A7B
	private void Update(float deltaTime)
	{
		this.UpdateEnemyPosition();
		this.UpdateAllMarkItems(false);
		this.UpdatePointPositions();
	}

	// Token: 0x0600E2BC RID: 58044 RVA: 0x00354890 File Offset: 0x00352A90
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

	// Token: 0x0600E2BD RID: 58045 RVA: 0x00354910 File Offset: 0x00352B10
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

	// Token: 0x0600E2BE RID: 58046 RVA: 0x003549C0 File Offset: 0x00352BC0
	private void RemoveMark(int markId)
	{
		TrapDefenseMarkView trapDefenseMarkView;
		if (this.MarkViewMap.TryGetValue(markId, out trapDefenseMarkView))
		{
			trapDefenseMarkView.Destroy(null);
			this.MarkViewMap.Remove(markId);
		}
	}

	// Token: 0x0600E2BF RID: 58047 RVA: 0x003549F1 File Offset: 0x00352BF1
	private void OnChangeMap(int mapId)
	{
		this.RefreshMap(mapId);
	}

	// Token: 0x0600E2C0 RID: 58048 RVA: 0x003549FA File Offset: 0x00352BFA
	private void ShowPhantomPreviewRoute()
	{
		if (this.PreviewRouteTimerId != null)
		{
			return;
		}
		this.PreviewRouteTimerId = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.GenerateRoutePreviewGroup), (float)TrapDefenseConfig.Instance.GetTrapDefenseRoutePreviewInterval(), 1f, null, null, true);
	}

	// Token: 0x0600E2C1 RID: 58049 RVA: 0x00354A34 File Offset: 0x00352C34
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

	// Token: 0x0600E2C2 RID: 58050 RVA: 0x00354BA0 File Offset: 0x00352DA0
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

	// Token: 0x0600E2C3 RID: 58051 RVA: 0x00354CF8 File Offset: 0x00352EF8
	private void StopShowPhantomPreviewRoute()
	{
		this.StopSplineTimers();
		this.ClearPreviewRoute();
		if (this.MapType == 0)
		{
			TrapDefenseModel.Instance.MapData.ClearAllSpline();
		}
	}

	// Token: 0x0600E2C4 RID: 58052 RVA: 0x00354D1D File Offset: 0x00352F1D
	private void StopSplineTimers()
	{
		if (this.PreviewRouteTimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.PreviewRouteTimerId);
			this.PreviewRouteTimerId = null;
		}
	}

	// Token: 0x0600E2C5 RID: 58053 RVA: 0x00354D40 File Offset: 0x00352F40
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

	// Token: 0x0600E2C6 RID: 58054 RVA: 0x00354E0C File Offset: 0x0035300C
	private void OpenMap()
	{
		UiManager.Instance.OpenView(EUiViewName.TrapDefenseMapView, null, null);
	}

	// Token: 0x0600E2C7 RID: 58055 RVA: 0x00354E20 File Offset: 0x00353020
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

	// Token: 0x040068CB RID: 26827
	private const int UPDATE_INTERVAL = 50;

	// Token: 0x040068CC RID: 26828
	private int MapType;

	// Token: 0x040068CD RID: 26829
	private readonly Dictionary<int, TrapDefenseMarkView> MarkViewMap = new Dictionary<int, TrapDefenseMarkView>();

	// Token: 0x040068CE RID: 26830
	[Nullable(2)]
	private TimerHandle TimerId;

	// Token: 0x040068CF RID: 26831
	private readonly Vector2D UiOffset = Vector2D.Create();

	// Token: 0x040068D0 RID: 26832
	private readonly Vector2D CenterOffset = Vector2D.Create();

	// Token: 0x040068D1 RID: 26833
	private float Scale = 1f;

	// Token: 0x040068D2 RID: 26834
	[Nullable(2)]
	private TimerHandle PreviewRouteTimerId;

	// Token: 0x040068D3 RID: 26835
	private readonly Dictionary<int, List<List<TrapDefenseRoutePointView>>> SplinePointView = new Dictionary<int, List<List<TrapDefenseRoutePointView>>>();

	// Token: 0x02008346 RID: 33606
	[NullableContext(0)]
	private static class EChildComponentType
	{
		// Token: 0x0402ACD9 RID: 175321
		public const int TextureMap = 0;

		// Token: 0x0402ACDA RID: 175322
		public const int PanelAnim = 1;

		// Token: 0x0402ACDB RID: 175323
		public const int Arrow = 2;

		// Token: 0x0402ACDC RID: 175324
		public const int MiniMapRoot = 3;

		// Token: 0x0402ACDD RID: 175325
		public const int PlayerItem = 4;

		// Token: 0x0402ACDE RID: 175326
		public const int PlayerSight = 5;

		// Token: 0x0402ACDF RID: 175327
		public const int TextureLight = 6;

		// Token: 0x0402ACE0 RID: 175328
		public const int PanelPos = 7;
	}

	// Token: 0x02008347 RID: 33607
	[NullableContext(0)]
	private static class EMapShowType
	{
		// Token: 0x0402ACE1 RID: 175329
		public const int MiniMap = 0;

		// Token: 0x0402ACE2 RID: 175330
		public const int BigMap = 1;
	}
}
