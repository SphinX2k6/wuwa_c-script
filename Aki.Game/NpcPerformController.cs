using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using Google.Protobuf;

// Token: 0x020031F1 RID: 12785
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class NpcPerformController : ControllerBase
{
	// Token: 0x0601B956 RID: 112982 RVA: 0x007923F0 File Offset: 0x007905F0
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.SetNpcPerformStateNotify, new Action<IMessage, Net.CallbackStatus>(this.SetPerformStateNotify));
		EventSystem.Instance.Add<ITrackData>(EEventName.TrackMark, new Action<ITrackData>(this.OnTrackMark));
		EventSystem.Instance.Add<ITrackData>(EEventName.UnTrackMark, new Action<ITrackData>(this.OnUnTrackMark));
		Net.Instance.Register(ENotifyMessageId.ShopBuyNotify, new Action<IMessage, Net.CallbackStatus>(this.OnShopBuyNotify));
		return true;
	}

	// Token: 0x0601B957 RID: 112983 RVA: 0x00792470 File Offset: 0x00790670
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SetNpcPerformStateNotify);
		EventSystem.Instance.Remove(EEventName.TrackMark, new Action<ITrackData>(this.OnTrackMark));
		EventSystem.Instance.Remove(EEventName.UnTrackMark, new Action<ITrackData>(this.OnUnTrackMark));
		Net.Instance.UnRegister(ENotifyMessageId.ShopBuyNotify);
		return true;
	}

	// Token: 0x0601B958 RID: 112984 RVA: 0x007924D8 File Offset: 0x007906D8
	[NullableContext(2)]
	protected void SetPerformStateNotify(IMessage msg, Net.CallbackStatus status)
	{
		SetNpcPerformStateNotify setNpcPerformStateNotify = (SetNpcPerformStateNotify)msg;
		EntityHandle entity = CreatureModel.Instance.GetEntity(setNpcPerformStateNotify.EntityId);
		bool flag;
		if (entity == null)
		{
			flag = true;
		}
		else
		{
			WorldEntity entity2 = entity.Entity;
			flag = !((entity2 != null) ? new bool?(entity2.IsInit) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		entity.Entity.GetComponent<CommonNpcPerformComponent>().PerformGroupController.SwitchPerformState(setNpcPerformStateNotify.State);
	}

	// Token: 0x0601B959 RID: 112985 RVA: 0x0079254C File Offset: 0x0079074C
	protected void OnTrackMark(ITrackData data)
	{
		TTrackTarget_Int ttrackTarget_Int = data.TrackTarget as TTrackTarget_Int;
		if (ttrackTarget_Int == null)
		{
			return;
		}
		int value = ttrackTarget_Int.Value;
		if (value == 0)
		{
			return;
		}
		this.ForceSetNpcDitherVisible(true, value, EForceVisibleReason.TrackMark);
	}

	// Token: 0x0601B95A RID: 112986 RVA: 0x00792580 File Offset: 0x00790780
	protected void OnUnTrackMark(ITrackData data)
	{
		TTrackTarget_Int ttrackTarget_Int = data.TrackTarget as TTrackTarget_Int;
		if (ttrackTarget_Int == null)
		{
			return;
		}
		int value = ttrackTarget_Int.Value;
		if (value == 0)
		{
			return;
		}
		this.ForceSetNpcDitherVisible(false, value, EForceVisibleReason.TrackMark);
	}

	// Token: 0x0601B95B RID: 112987 RVA: 0x007925B4 File Offset: 0x007907B4
	public void ForceSetNpcDitherVisible(bool enable, int pbDataId, EForceVisibleReason reason)
	{
		if (enable)
		{
			if (this.ForceNpcDitherVisibleMap.ContainsKey(pbDataId))
			{
				this.ForceNpcDitherVisibleMap[pbDataId].Add(reason);
				return;
			}
			this.ForceNpcDitherVisibleMap[pbDataId] = new HashSet<EForceVisibleReason>
			{
				reason
			};
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
			if (entityByPbDataId == null || !entityByPbDataId.IsInit)
			{
				return;
			}
			NpcPerformComponent component = entityByPbDataId.Entity.GetComponent<NpcPerformComponent>();
			if (component == null)
			{
				return;
			}
			component.SetForceInShowRange(true);
			return;
		}
		else
		{
			if (!this.ForceNpcDitherVisibleMap.ContainsKey(pbDataId))
			{
				return;
			}
			HashSet<EForceVisibleReason> hashSet = this.ForceNpcDitherVisibleMap[pbDataId];
			hashSet.Remove(reason);
			if (hashSet.Count > 0)
			{
				return;
			}
			this.ForceNpcDitherVisibleMap.Remove(pbDataId);
			EntityHandle entityByPbDataId2 = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
			if (entityByPbDataId2 == null || !entityByPbDataId2.IsInit)
			{
				return;
			}
			NpcPerformComponent component2 = entityByPbDataId2.Entity.GetComponent<NpcPerformComponent>();
			if (component2 == null)
			{
				return;
			}
			component2.SetForceInShowRange(false);
			return;
		}
	}

	// Token: 0x0601B95C RID: 112988 RVA: 0x007926A4 File Offset: 0x007908A4
	[NullableContext(2)]
	protected void OnShopBuyNotify(IMessage msg, Net.CallbackStatus status)
	{
		ShopBuyNotify shopBuyNotify = (ShopBuyNotify)msg;
		ErrorCodeController.Instance.OpenErrorCodeScrollingTipsView(shopBuyNotify.ErrorCode, Array.Empty<string>());
	}

	// Token: 0x0601B95D RID: 112989 RVA: 0x007926D0 File Offset: 0x007908D0
	public void AddNpcLookAtParams(INpcInterestLookAtParamGroup param)
	{
		if (this.EntityLookAtCacheForKey.ContainsKey(param.Key))
		{
			return;
		}
		this.EntityLookAtCacheForKey[param.Key] = param;
		foreach (int num in param.PbDataIds)
		{
			HashSet<string> hashSet;
			if (!this.EntityLookAtCacheForId.TryGetValue(num, out hashSet))
			{
				hashSet = new HashSet<string>();
				this.EntityLookAtCacheForId[num] = hashSet;
			}
			hashSet.Add(param.Key);
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
			WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
			CommonNpcPerformComponent commonNpcPerformComponent = (worldEntity != null) ? worldEntity.GetComponent<CommonNpcPerformComponent>() : null;
			if (worldEntity != null && worldEntity.IsInit && commonNpcPerformComponent != null)
			{
				commonNpcPerformComponent.InterestEventController.AddExternalLookAtInterestEvents(param);
			}
		}
	}

	// Token: 0x0601B95E RID: 112990 RVA: 0x007927B4 File Offset: 0x007909B4
	public void RemoveNpcLookAtParams(string key)
	{
		INpcInterestLookAtParamGroup npcInterestLookAtParamGroup;
		if (!this.EntityLookAtCacheForKey.TryGetValue(key, out npcInterestLookAtParamGroup))
		{
			return;
		}
		foreach (int num in npcInterestLookAtParamGroup.PbDataIds)
		{
			HashSet<string> hashSet;
			if (this.EntityLookAtCacheForId.TryGetValue(num, out hashSet))
			{
				hashSet.Remove(key);
				if (hashSet.Count == 0)
				{
					this.EntityLookAtCacheForId.Remove(num);
				}
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(num);
				WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
				CommonNpcPerformComponent commonNpcPerformComponent = (worldEntity != null) ? worldEntity.GetComponent<CommonNpcPerformComponent>() : null;
				if (worldEntity != null && worldEntity.IsInit && commonNpcPerformComponent != null)
				{
					commonNpcPerformComponent.InterestEventController.RemoveExternalInterestEvent(key);
				}
			}
		}
		this.EntityLookAtCacheForKey.Remove(npcInterestLookAtParamGroup.Key);
	}

	// Token: 0x1700262B RID: 9771
	// (get) Token: 0x0601B95F RID: 112991 RVA: 0x00792894 File Offset: 0x00790A94
	public static NpcPerformController Instance
	{
		get
		{
			return NpcPerformController._Instance;
		}
	}

	// Token: 0x0601B960 RID: 112992 RVA: 0x0079289B File Offset: 0x00790A9B
	public static NpcPerformController GetOrCreateInstance()
	{
		if (NpcPerformController._Instance == null)
		{
			NpcPerformController.CreateInstance();
		}
		return NpcPerformController._Instance;
	}

	// Token: 0x0601B961 RID: 112993 RVA: 0x007928AF File Offset: 0x00790AAF
	public static bool CreateInstance()
	{
		if (NpcPerformController._Instance != null)
		{
			return true;
		}
		NpcPerformController._Instance = new NpcPerformController();
		return true;
	}

	// Token: 0x0601B962 RID: 112994 RVA: 0x007928C5 File Offset: 0x00790AC5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B963 RID: 112995 RVA: 0x007928C7 File Offset: 0x00790AC7
	public static void ResetStaticDefaultValue()
	{
		NpcPerformController._Instance = null;
	}

	// Token: 0x0601B964 RID: 112996 RVA: 0x007928CF File Offset: 0x00790ACF
	static NpcPerformController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NpcPerformController.CreateStaticDefaultValue), new Action(NpcPerformController.ResetStaticDefaultValue));
	}

	// Token: 0x0400D8D3 RID: 55507
	public Dictionary<int, HashSet<EForceVisibleReason>> ForceNpcDitherVisibleMap = new Dictionary<int, HashSet<EForceVisibleReason>>();

	// Token: 0x0400D8D4 RID: 55508
	public Dictionary<int, HashSet<string>> EntityLookAtCacheForId = new Dictionary<int, HashSet<string>>();

	// Token: 0x0400D8D5 RID: 55509
	public Dictionary<string, INpcInterestLookAtParamGroup> EntityLookAtCacheForKey = new Dictionary<string, INpcInterestLookAtParamGroup>();

	// Token: 0x0400D8D6 RID: 55510
	[Nullable(2)]
	private static NpcPerformController _Instance;
}
