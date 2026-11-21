using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Weather;

// Token: 0x020027D0 RID: 10192
[NullableContext(1)]
[Nullable(0)]
public class SimpleNpcController : ControllerBase
{
	// Token: 0x170028F0 RID: 10480
	// (get) Token: 0x06019994 RID: 104852 RVA: 0x007DD152 File Offset: 0x007DB352
	private bool IsClearOut
	{
		get
		{
			return this.ClearOutFlags.Count > 0;
		}
	}

	// Token: 0x06019995 RID: 104853 RVA: 0x007DD162 File Offset: 0x007DB362
	protected override bool OnInit()
	{
		this.OnAddEvents();
		return true;
	}

	// Token: 0x06019996 RID: 104854 RVA: 0x007DD16B File Offset: 0x007DB36B
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x06019997 RID: 104855 RVA: 0x007DD174 File Offset: 0x007DB374
	public void OnAddEvents()
	{
		EventSystem.Instance.Add<IReadOnlyDictionary<string, VarDefinePb>>(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
		EventSystem.Instance.Add(EEventName.WeatherChange, new Action(this.OnWeatherChange));
		EventSystem.Instance.Add(EEventName.SetImageQuality, new Action(this.OnImageQualityChanged));
	}

	// Token: 0x06019998 RID: 104856 RVA: 0x007DD1D5 File Offset: 0x007DB3D5
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WeatherChange, new Action(this.OnWeatherChange));
		EventSystem.Instance.Remove(EEventName.SetImageQuality, new Action(this.OnImageQualityChanged));
	}

	// Token: 0x06019999 RID: 104857 RVA: 0x007DD20F File Offset: 0x007DB40F
	protected override bool OnLeaveLevel()
	{
		this.SimpleNpcElements.Clear();
		this.InLogicRangeElements.Clear();
		this.PendingLoadSet.Clear();
		this.PendingUnloadSet.Clear();
		return true;
	}

	// Token: 0x0601999A RID: 104858 RVA: 0x007DD240 File Offset: 0x007DB440
	public void Add(TsSimpleNpc npc)
	{
		this.SimpleNpcElements.Add(npc);
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter != null)
		{
			this.UpdateNpcDistanceLogic(npc, baseCharacter.CharacterActorComponent.ActorLocationProxy, false);
		}
		this.CheckNpcShowState(npc, true, true);
		this.UpdateLodSingle(npc);
	}

	// Token: 0x0601999B RID: 104859 RVA: 0x007DD286 File Offset: 0x007DB486
	public void Remove(TsSimpleNpc npc)
	{
		this.SimpleNpcElements.Remove(npc);
		this.InLogicRangeElements.Remove(npc);
		this.PendingLoadSet.Remove(npc);
		this.PendingUnloadSet.Remove(npc);
	}

	// Token: 0x0601999C RID: 104860 RVA: 0x007DD2BC File Offset: 0x007DB4BC
	public void SetClearOutState(ESimpleNpcClearOutModuleDefine flag, bool isClearOut)
	{
		bool flag2 = false;
		if (isClearOut && !this.ClearOutFlags.Contains(flag))
		{
			this.ClearOutFlags.Add(flag);
			flag2 = true;
		}
		else if (!isClearOut && this.ClearOutFlags.Contains(flag))
		{
			this.ClearOutFlags.Remove(flag);
			flag2 = true;
		}
		if (flag2)
		{
			foreach (TsSimpleNpc tsSimpleNpc in this.InLogicRangeElements)
			{
				this.CheckNpcShowState(tsSimpleNpc, true, false);
				tsSimpleNpc.ChangeLogicRangeState(false);
			}
		}
	}

	// Token: 0x0601999D RID: 104861 RVA: 0x007DD360 File Offset: 0x007DB560
	protected override void OnTick(float deltaTime)
	{
		this.HandleLoadingNpc(deltaTime);
		this.HandleUnloadingNpc(deltaTime);
	}

	// Token: 0x0601999E RID: 104862 RVA: 0x007DD370 File Offset: 0x007DB570
	public List<TsSimpleNpc> GetSimpleNpcListByRange(float range)
	{
		List<TsSimpleNpc> list = new List<TsSimpleNpc>();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null)
		{
			return list;
		}
		float num = range * range;
		global::Vector actorLocationProxy = baseCharacter.CharacterActorComponent.ActorLocationProxy;
		foreach (TsSimpleNpc tsSimpleNpc in this.SimpleNpcElements)
		{
			global::Vector selfLocationProxy = tsSimpleNpc.SelfLocationProxy;
			if (global::Vector.DistSquared(actorLocationProxy, selfLocationProxy) <= (double)num)
			{
				list.Add(tsSimpleNpc);
			}
		}
		return list;
	}

	// Token: 0x0601999F RID: 104863 RVA: 0x007DD400 File Offset: 0x007DB600
	private void ExecuteInitLogic()
	{
		if (Info.Instance.IsPcOrGamepadPlatform())
		{
			this.CheckLogicRangeSquared = 36000000f;
		}
		else
		{
			this.CheckLogicRangeSquared = 9000000f;
		}
		this.UpdateLodSetting();
	}

	// Token: 0x060199A0 RID: 104864 RVA: 0x007DD42C File Offset: 0x007DB62C
	public void UpdateDistanceLogic()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null)
		{
			return;
		}
		if (!this.IsInit)
		{
			this.ExecuteInitLogic();
			this.IsInit = true;
		}
		global::Vector actorLocationProxy = baseCharacter.CharacterActorComponent.ActorLocationProxy;
		foreach (TsSimpleNpc npc in this.SimpleNpcElements)
		{
			this.UpdateNpcDistanceLogic(npc, actorLocationProxy, true);
		}
	}

	// Token: 0x060199A1 RID: 104865 RVA: 0x007DD4AC File Offset: 0x007DB6AC
	private void UpdateNpcDistanceLogic(TsSimpleNpc npc, global::Vector playerLocation, bool checkNpcShowState = true)
	{
		if (!npc.IsNotUnload)
		{
			return;
		}
		global::Vector selfLocationProxy = npc.SelfLocationProxy;
		double num = global::Vector.DistSquared(playerLocation, selfLocationProxy);
		if (num > (double)this.CheckLogicRangeSquared)
		{
			this.SetSimpleNpcRangeLogic(npc, false, checkNpcShowState);
		}
		else
		{
			this.SetSimpleNpcRangeLogic(npc, true, checkNpcShowState);
		}
		npc.TempDistanceSquared = num;
	}

	// Token: 0x060199A2 RID: 104866 RVA: 0x007DD4F8 File Offset: 0x007DB6F8
	private void SetSimpleNpcRangeLogic(TsSimpleNpc npc, bool newState, bool checkNpcShowState = true)
	{
		bool isInLogicRange = npc.IsInLogicRange;
		npc.ChangeLogicRangeState(newState);
		if (isInLogicRange != newState)
		{
			npc.SetTickEnabled(newState);
			npc.SetMainShadowEnabled(newState);
			if (!isInLogicRange && newState)
			{
				this.InLogicRangeElements.Add(npc);
				if (checkNpcShowState)
				{
					this.CheckNpcShowState(npc, false, true);
					return;
				}
			}
			else if (isInLogicRange && !newState)
			{
				this.InLogicRangeElements.Remove(npc);
			}
		}
	}

	// Token: 0x060199A3 RID: 104867 RVA: 0x007DD55A File Offset: 0x007DB75A
	private void AddToPendingLoadSet(TsSimpleNpc npc)
	{
		npc.CurDither = 0f;
		npc.IsNotUnload = true;
		npc.SetDitherEffect(0f, ECharacterDitherType.Fight);
		this.PendingLoadSet.Add(npc);
		this.PendingUnloadSet.Remove(npc);
	}

	// Token: 0x060199A4 RID: 104868 RVA: 0x007DD594 File Offset: 0x007DB794
	private void AddToPendingUnloadSet(TsSimpleNpc npc)
	{
		npc.CurDither = 1f;
		npc.IsNotUnload = false;
		npc.SetDitherEffect(1f, ECharacterDitherType.Fight);
		this.PendingUnloadSet.Add(npc);
		this.PendingLoadSet.Remove(npc);
	}

	// Token: 0x060199A5 RID: 104869 RVA: 0x007DD5D0 File Offset: 0x007DB7D0
	private void HandleLoadingNpc(float deltaTime)
	{
		if (this.PendingLoadSet.Count <= 0)
		{
			return;
		}
		List<TsSimpleNpc> list = null;
		foreach (TsSimpleNpc tsSimpleNpc in this.PendingLoadSet)
		{
			tsSimpleNpc.CurDither += 0.33f * deltaTime * 0.001f;
			tsSimpleNpc.CurDither = MathUtils.Instance.Clamp(tsSimpleNpc.CurDither, 0f, 1f);
			tsSimpleNpc.SetDitherEffect(tsSimpleNpc.CurDither, ECharacterDitherType.Fight);
			if (MathUtils.Instance.IsNearlyEqual((double)tsSimpleNpc.CurDither, 1.0, null))
			{
				if (list == null)
				{
					list = new List<TsSimpleNpc>();
				}
				list.Add(tsSimpleNpc);
			}
		}
		if (list != null)
		{
			foreach (TsSimpleNpc item in list)
			{
				this.PendingLoadSet.Remove(item);
			}
		}
	}

	// Token: 0x060199A6 RID: 104870 RVA: 0x007DD6F8 File Offset: 0x007DB8F8
	private void HandleUnloadingNpc(float deltaTime)
	{
		if (this.PendingUnloadSet.Count <= 0)
		{
			return;
		}
		List<TsSimpleNpc> list = null;
		foreach (TsSimpleNpc tsSimpleNpc in this.PendingUnloadSet)
		{
			tsSimpleNpc.CurDither -= 0.33f * deltaTime * 0.001f;
			tsSimpleNpc.CurDither = MathUtils.Instance.Clamp(tsSimpleNpc.CurDither, 0f, 1f);
			tsSimpleNpc.SetDitherEffect(tsSimpleNpc.CurDither, ECharacterDitherType.Fight);
			if (MathUtils.Instance.IsNearlyEqual((double)tsSimpleNpc.CurDither, 0.0, null))
			{
				if (list == null)
				{
					list = new List<TsSimpleNpc>();
				}
				list.Add(tsSimpleNpc);
			}
		}
		if (list != null)
		{
			foreach (TsSimpleNpc item in list)
			{
				this.PendingUnloadSet.Remove(item);
			}
		}
	}

	// Token: 0x060199A7 RID: 104871 RVA: 0x007DD820 File Offset: 0x007DBA20
	private void SetNpcShowStateImmediately(TsSimpleNpc npc, bool showState)
	{
		npc.CurDither = (showState ? 1f : 0f);
		npc.IsNotUnload = showState;
		npc.SetDitherEffect(npc.CurDither, ECharacterDitherType.Fight);
		this.PendingLoadSet.Remove(npc);
		this.PendingUnloadSet.Remove(npc);
	}

	// Token: 0x060199A8 RID: 104872 RVA: 0x007DD870 File Offset: 0x007DBA70
	private void OnWeatherChange()
	{
		foreach (TsSimpleNpc npc in this.InLogicRangeElements)
		{
			this.CheckNpcShowState(npc, false, true);
		}
	}

	// Token: 0x060199A9 RID: 104873 RVA: 0x007DD8C8 File Offset: 0x007DBAC8
	public void CheckNpcShowState(TsSimpleNpc npc, bool isInit, bool useDitherAnimation = true)
	{
		bool flag = !this.IsClearOut && this.CheckNpcShowInWeather(npc);
		if (flag && !npc.IsLodShow)
		{
			return;
		}
		if (!useDitherAnimation)
		{
			this.SetNpcShowStateImmediately(npc, flag);
			return;
		}
		if (isInit)
		{
			if (!flag)
			{
				this.SetNpcShowStateImmediately(npc, flag);
				return;
			}
			this.AddToPendingLoadSet(npc);
			return;
		}
		else
		{
			if (npc.IsNotUnload && !flag)
			{
				this.AddToPendingUnloadSet(npc);
				return;
			}
			if (!npc.IsNotUnload && flag)
			{
				this.AddToPendingLoadSet(npc);
			}
			return;
		}
	}

	// Token: 0x060199AA RID: 104874 RVA: 0x007DD940 File Offset: 0x007DBB40
	private bool CheckNpcShowInWeather(TsSimpleNpc npc)
	{
		WeatherModel instance = WeatherModel.Instance;
		if (instance == null)
		{
			return true;
		}
		bool result = true;
		switch (instance.CurrentWeatherId)
		{
		case 1:
			if (npc.DisappearOnSunny)
			{
				result = false;
			}
			break;
		case 2:
			if (npc.DisappearOnCloudy)
			{
				result = false;
			}
			break;
		case 3:
			if (npc.DisappearOnRainy)
			{
				result = false;
			}
			break;
		case 4:
			if (npc.DisappearOnThunderRain)
			{
				result = false;
			}
			break;
		case 5:
			if (npc.DisappearOnSnowy)
			{
				result = false;
			}
			break;
		}
		return result;
	}

	// Token: 0x060199AB RID: 104875 RVA: 0x007DD9BA File Offset: 0x007DBBBA
	private void OnReceivePlayerVar(IReadOnlyDictionary<string, VarDefinePb> varInfos)
	{
		this.OnChangeWorldState();
	}

	// Token: 0x060199AC RID: 104876 RVA: 0x007DD9C4 File Offset: 0x007DBBC4
	private void OnChangeWorldState()
	{
		foreach (TsSimpleNpc tsSimpleNpc in this.SimpleNpcElements)
		{
			tsSimpleNpc.FilterFlowWorldState();
		}
	}

	// Token: 0x060199AD RID: 104877 RVA: 0x007DDA14 File Offset: 0x007DBC14
	private void UpdateLodSetting()
	{
		foreach (TsSimpleNpc npc in this.SimpleNpcElements)
		{
			this.UpdateLodSingle(npc);
		}
	}

	// Token: 0x060199AE RID: 104878 RVA: 0x007DDA68 File Offset: 0x007DBC68
	private void UpdateLodSingle(TsSimpleNpc npc)
	{
		if (npc.IsLodShow)
		{
			if (!npc.IsNotUnload)
			{
				this.AddToPendingLoadSet(npc);
				return;
			}
		}
		else if (npc.IsNotUnload)
		{
			this.AddToPendingUnloadSet(npc);
			npc.ChangeLogicRangeState(false);
		}
	}

	// Token: 0x060199AF RID: 104879 RVA: 0x007DDA98 File Offset: 0x007DBC98
	private void OnImageQualityChanged()
	{
		this.UpdateLodSetting();
	}

	// Token: 0x170028F1 RID: 10481
	// (get) Token: 0x060199B0 RID: 104880 RVA: 0x007DDAA0 File Offset: 0x007DBCA0
	public static SimpleNpcController Instance
	{
		get
		{
			return SimpleNpcController._Instance;
		}
	}

	// Token: 0x060199B1 RID: 104881 RVA: 0x007DDAA7 File Offset: 0x007DBCA7
	public static SimpleNpcController GetOrCreateInstance()
	{
		if (SimpleNpcController._Instance == null)
		{
			SimpleNpcController.CreateInstance();
		}
		return SimpleNpcController._Instance;
	}

	// Token: 0x060199B2 RID: 104882 RVA: 0x007DDABB File Offset: 0x007DBCBB
	public static bool CreateInstance()
	{
		if (SimpleNpcController._Instance != null)
		{
			return true;
		}
		SimpleNpcController._Instance = new SimpleNpcController();
		return true;
	}

	// Token: 0x060199B3 RID: 104883 RVA: 0x007DDAD1 File Offset: 0x007DBCD1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060199B4 RID: 104884 RVA: 0x007DDAD3 File Offset: 0x007DBCD3
	public static void ResetStaticDefaultValue()
	{
		SimpleNpcController._Instance = null;
	}

	// Token: 0x060199B5 RID: 104885 RVA: 0x007DDADB File Offset: 0x007DBCDB
	static SimpleNpcController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SimpleNpcController.CreateStaticDefaultValue), new Action(SimpleNpcController.ResetStaticDefaultValue));
	}

	// Token: 0x0400E076 RID: 57462
	private readonly HashSet<TsSimpleNpc> SimpleNpcElements = new HashSet<TsSimpleNpc>();

	// Token: 0x0400E077 RID: 57463
	private readonly HashSet<TsSimpleNpc> InLogicRangeElements = new HashSet<TsSimpleNpc>();

	// Token: 0x0400E078 RID: 57464
	private readonly HashSet<TsSimpleNpc> PendingLoadSet = new HashSet<TsSimpleNpc>();

	// Token: 0x0400E079 RID: 57465
	private readonly HashSet<TsSimpleNpc> PendingUnloadSet = new HashSet<TsSimpleNpc>();

	// Token: 0x0400E07A RID: 57466
	private readonly HashSet<ESimpleNpcClearOutModuleDefine> ClearOutFlags = new HashSet<ESimpleNpcClearOutModuleDefine>();

	// Token: 0x0400E07B RID: 57467
	private float CheckLogicRangeSquared;

	// Token: 0x0400E07C RID: 57468
	private bool IsInit;

	// Token: 0x0400E07D RID: 57469
	private const int PC_CHECK_RANGE = 6000;

	// Token: 0x0400E07E RID: 57470
	private const int PC_CHECK_RANGE_SQUARED = 36000000;

	// Token: 0x0400E07F RID: 57471
	private const int MOBILE_CHECK_RANGE = 3000;

	// Token: 0x0400E080 RID: 57472
	private const int MOBILE_CHECK_RANGE_SQUARED = 9000000;

	// Token: 0x0400E081 RID: 57473
	private const float DITHER_STEP = 0.33f;

	// Token: 0x0400E082 RID: 57474
	private const float DITHER_MAX = 1f;

	// Token: 0x0400E083 RID: 57475
	private const float DITHER_MIN = 0f;

	// Token: 0x0400E084 RID: 57476
	private const float MILLISECOND_TO_SECOND = 0.001f;

	// Token: 0x0400E085 RID: 57477
	[Nullable(2)]
	private static SimpleNpcController _Instance;
}
