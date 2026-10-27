using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Weather;

// Token: 0x02003261 RID: 12897
[NullableContext(1)]
[Nullable(0)]
public class SimpleNpcController : ControllerBase
{
	// Token: 0x1700265D RID: 9821
	// (get) Token: 0x0601BDBD RID: 114109 RVA: 0x007B4FDE File Offset: 0x007B31DE
	private bool IsClearOut
	{
		get
		{
			return this.ClearOutFlags.Count > 0;
		}
	}

	// Token: 0x0601BDBE RID: 114110 RVA: 0x007B4FEE File Offset: 0x007B31EE
	protected override bool OnInit()
	{
		this.OnAddEvents();
		return true;
	}

	// Token: 0x0601BDBF RID: 114111 RVA: 0x007B4FF7 File Offset: 0x007B31F7
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x0601BDC0 RID: 114112 RVA: 0x007B5000 File Offset: 0x007B3200
	public void OnAddEvents()
	{
		EventSystem.Instance.Add<IReadOnlyDictionary<string, VarDefinePb>>(EEventName.OnReceivePlayerVar, new Action<IReadOnlyDictionary<string, VarDefinePb>>(this.OnReceivePlayerVar));
		EventSystem.Instance.Add(EEventName.WeatherChange, new Action(this.OnWeatherChange));
		EventSystem.Instance.Add(EEventName.SetImageQuality, new Action(this.OnImageQualityChanged));
	}

	// Token: 0x0601BDC1 RID: 114113 RVA: 0x007B5061 File Offset: 0x007B3261
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WeatherChange, new Action(this.OnWeatherChange));
		EventSystem.Instance.Remove(EEventName.SetImageQuality, new Action(this.OnImageQualityChanged));
	}

	// Token: 0x0601BDC2 RID: 114114 RVA: 0x007B509B File Offset: 0x007B329B
	protected override bool OnLeaveLevel()
	{
		this.SimpleNpcElements.Clear();
		this.InLogicRangeElements.Clear();
		this.PendingLoadSet.Clear();
		this.PendingUnloadSet.Clear();
		return true;
	}

	// Token: 0x0601BDC3 RID: 114115 RVA: 0x007B50CC File Offset: 0x007B32CC
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

	// Token: 0x0601BDC4 RID: 114116 RVA: 0x007B5112 File Offset: 0x007B3312
	public void Remove(TsSimpleNpc npc)
	{
		this.SimpleNpcElements.Remove(npc);
		this.InLogicRangeElements.Remove(npc);
		this.PendingLoadSet.Remove(npc);
		this.PendingUnloadSet.Remove(npc);
	}

	// Token: 0x0601BDC5 RID: 114117 RVA: 0x007B5148 File Offset: 0x007B3348
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

	// Token: 0x0601BDC6 RID: 114118 RVA: 0x007B51EC File Offset: 0x007B33EC
	protected override void OnTick(float deltaTime)
	{
		this.HandleLoadingNpc(deltaTime);
		this.HandleUnloadingNpc(deltaTime);
	}

	// Token: 0x0601BDC7 RID: 114119 RVA: 0x007B51FC File Offset: 0x007B33FC
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

	// Token: 0x0601BDC8 RID: 114120 RVA: 0x007B528C File Offset: 0x007B348C
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

	// Token: 0x0601BDC9 RID: 114121 RVA: 0x007B52B8 File Offset: 0x007B34B8
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

	// Token: 0x0601BDCA RID: 114122 RVA: 0x007B5338 File Offset: 0x007B3538
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

	// Token: 0x0601BDCB RID: 114123 RVA: 0x007B5384 File Offset: 0x007B3584
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

	// Token: 0x0601BDCC RID: 114124 RVA: 0x007B53E6 File Offset: 0x007B35E6
	private void AddToPendingLoadSet(TsSimpleNpc npc)
	{
		npc.CurDither = 0f;
		npc.IsNotUnload = true;
		npc.SetDitherEffect(0f, ECharacterDitherType.Fight);
		this.PendingLoadSet.Add(npc);
		this.PendingUnloadSet.Remove(npc);
	}

	// Token: 0x0601BDCD RID: 114125 RVA: 0x007B5420 File Offset: 0x007B3620
	private void AddToPendingUnloadSet(TsSimpleNpc npc)
	{
		npc.CurDither = 1f;
		npc.IsNotUnload = false;
		npc.SetDitherEffect(1f, ECharacterDitherType.Fight);
		this.PendingUnloadSet.Add(npc);
		this.PendingLoadSet.Remove(npc);
	}

	// Token: 0x0601BDCE RID: 114126 RVA: 0x007B545C File Offset: 0x007B365C
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

	// Token: 0x0601BDCF RID: 114127 RVA: 0x007B5584 File Offset: 0x007B3784
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

	// Token: 0x0601BDD0 RID: 114128 RVA: 0x007B56AC File Offset: 0x007B38AC
	private void SetNpcShowStateImmediately(TsSimpleNpc npc, bool showState)
	{
		npc.CurDither = (showState ? 1f : 0f);
		npc.IsNotUnload = showState;
		npc.SetDitherEffect(npc.CurDither, ECharacterDitherType.Fight);
		this.PendingLoadSet.Remove(npc);
		this.PendingUnloadSet.Remove(npc);
	}

	// Token: 0x0601BDD1 RID: 114129 RVA: 0x007B56FC File Offset: 0x007B38FC
	private void OnWeatherChange()
	{
		foreach (TsSimpleNpc npc in this.InLogicRangeElements)
		{
			this.CheckNpcShowState(npc, false, true);
		}
	}

	// Token: 0x0601BDD2 RID: 114130 RVA: 0x007B5754 File Offset: 0x007B3954
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

	// Token: 0x0601BDD3 RID: 114131 RVA: 0x007B57CC File Offset: 0x007B39CC
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

	// Token: 0x0601BDD4 RID: 114132 RVA: 0x007B5846 File Offset: 0x007B3A46
	private void OnReceivePlayerVar(IReadOnlyDictionary<string, VarDefinePb> varInfos)
	{
		this.OnChangeWorldState();
	}

	// Token: 0x0601BDD5 RID: 114133 RVA: 0x007B5850 File Offset: 0x007B3A50
	private void OnChangeWorldState()
	{
		foreach (TsSimpleNpc tsSimpleNpc in this.SimpleNpcElements)
		{
			tsSimpleNpc.FilterFlowWorldState();
		}
	}

	// Token: 0x0601BDD6 RID: 114134 RVA: 0x007B58A0 File Offset: 0x007B3AA0
	private void UpdateLodSetting()
	{
		foreach (TsSimpleNpc npc in this.SimpleNpcElements)
		{
			this.UpdateLodSingle(npc);
		}
	}

	// Token: 0x0601BDD7 RID: 114135 RVA: 0x007B58F4 File Offset: 0x007B3AF4
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

	// Token: 0x0601BDD8 RID: 114136 RVA: 0x007B5924 File Offset: 0x007B3B24
	private void OnImageQualityChanged()
	{
		this.UpdateLodSetting();
	}

	// Token: 0x1700265E RID: 9822
	// (get) Token: 0x0601BDD9 RID: 114137 RVA: 0x007B592C File Offset: 0x007B3B2C
	public static SimpleNpcController Instance
	{
		get
		{
			return SimpleNpcController._Instance;
		}
	}

	// Token: 0x0601BDDA RID: 114138 RVA: 0x007B5933 File Offset: 0x007B3B33
	public static SimpleNpcController GetOrCreateInstance()
	{
		if (SimpleNpcController._Instance == null)
		{
			SimpleNpcController.CreateInstance();
		}
		return SimpleNpcController._Instance;
	}

	// Token: 0x0601BDDB RID: 114139 RVA: 0x007B5947 File Offset: 0x007B3B47
	public static bool CreateInstance()
	{
		if (SimpleNpcController._Instance != null)
		{
			return true;
		}
		SimpleNpcController._Instance = new SimpleNpcController();
		return true;
	}

	// Token: 0x0601BDDC RID: 114140 RVA: 0x007B595D File Offset: 0x007B3B5D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BDDD RID: 114141 RVA: 0x007B595F File Offset: 0x007B3B5F
	public static void ResetStaticDefaultValue()
	{
		SimpleNpcController._Instance = null;
	}

	// Token: 0x0601BDDE RID: 114142 RVA: 0x007B5967 File Offset: 0x007B3B67
	static SimpleNpcController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SimpleNpcController.CreateStaticDefaultValue), new Action(SimpleNpcController.ResetStaticDefaultValue));
	}

	// Token: 0x0400DBD7 RID: 56279
	private readonly HashSet<TsSimpleNpc> SimpleNpcElements = new HashSet<TsSimpleNpc>();

	// Token: 0x0400DBD8 RID: 56280
	private readonly HashSet<TsSimpleNpc> InLogicRangeElements = new HashSet<TsSimpleNpc>();

	// Token: 0x0400DBD9 RID: 56281
	private readonly HashSet<TsSimpleNpc> PendingLoadSet = new HashSet<TsSimpleNpc>();

	// Token: 0x0400DBDA RID: 56282
	private readonly HashSet<TsSimpleNpc> PendingUnloadSet = new HashSet<TsSimpleNpc>();

	// Token: 0x0400DBDB RID: 56283
	private readonly HashSet<ESimpleNpcClearOutModuleDefine> ClearOutFlags = new HashSet<ESimpleNpcClearOutModuleDefine>();

	// Token: 0x0400DBDC RID: 56284
	private float CheckLogicRangeSquared;

	// Token: 0x0400DBDD RID: 56285
	private bool IsInit;

	// Token: 0x0400DBDE RID: 56286
	private const int PC_CHECK_RANGE = 6000;

	// Token: 0x0400DBDF RID: 56287
	private const int PC_CHECK_RANGE_SQUARED = 36000000;

	// Token: 0x0400DBE0 RID: 56288
	private const int MOBILE_CHECK_RANGE = 3000;

	// Token: 0x0400DBE1 RID: 56289
	private const int MOBILE_CHECK_RANGE_SQUARED = 9000000;

	// Token: 0x0400DBE2 RID: 56290
	private const float DITHER_STEP = 0.33f;

	// Token: 0x0400DBE3 RID: 56291
	private const float DITHER_MAX = 1f;

	// Token: 0x0400DBE4 RID: 56292
	private const float DITHER_MIN = 0f;

	// Token: 0x0400DBE5 RID: 56293
	private const float MILLISECOND_TO_SECOND = 0.001f;

	// Token: 0x0400DBE6 RID: 56294
	[Nullable(2)]
	private static SimpleNpcController _Instance;
}
