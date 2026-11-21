using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using Google.Protobuf;

// Token: 0x02002760 RID: 10080
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class NpcPerformController : ControllerBase
{
	// Token: 0x060194DB RID: 103643 RVA: 0x007BAB1C File Offset: 0x007B8D1C
	protected override bool OnInit()
	{
		Net.Instance.Register(ENotifyMessageId.SetNpcPerformStateNotify, new Action<IMessage, Net.CallbackStatus>(this.SetPerformStateNotify));
		EventSystem.Instance.Add<ITrackData>(EEventName.TrackMark, new Action<ITrackData>(this.OnTrackMark));
		EventSystem.Instance.Add<ITrackData>(EEventName.UnTrackMark, new Action<ITrackData>(this.OnUnTrackMark));
		Net.Instance.Register(ENotifyMessageId.ShopBuyNotify, new Action<IMessage, Net.CallbackStatus>(this.OnShopBuyNotify));
		return true;
	}

	// Token: 0x060194DC RID: 103644 RVA: 0x007BAB9C File Offset: 0x007B8D9C
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.SetNpcPerformStateNotify);
		EventSystem.Instance.Remove(EEventName.TrackMark, new Action<ITrackData>(this.OnTrackMark));
		EventSystem.Instance.Remove(EEventName.UnTrackMark, new Action<ITrackData>(this.OnUnTrackMark));
		Net.Instance.UnRegister(ENotifyMessageId.ShopBuyNotify);
		return true;
	}

	// Token: 0x060194DD RID: 103645 RVA: 0x007BAC04 File Offset: 0x007B8E04
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

	// Token: 0x060194DE RID: 103646 RVA: 0x007BAC78 File Offset: 0x007B8E78
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

	// Token: 0x060194DF RID: 103647 RVA: 0x007BACAC File Offset: 0x007B8EAC
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

	// Token: 0x060194E0 RID: 103648 RVA: 0x007BACE0 File Offset: 0x007B8EE0
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

	// Token: 0x060194E1 RID: 103649 RVA: 0x007BADD0 File Offset: 0x007B8FD0
	[NullableContext(2)]
	protected void OnShopBuyNotify(IMessage msg, Net.CallbackStatus status)
	{
		ShopBuyNotify shopBuyNotify = (ShopBuyNotify)msg;
		ErrorCodeController.Instance.OpenErrorCodeScrollingTipsView(shopBuyNotify.ErrorCode, Array.Empty<string>());
	}

	// Token: 0x060194E2 RID: 103650 RVA: 0x007BADFC File Offset: 0x007B8FFC
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

	// Token: 0x060194E3 RID: 103651 RVA: 0x007BAEE0 File Offset: 0x007B90E0
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

	// Token: 0x1700286C RID: 10348
	// (get) Token: 0x060194E4 RID: 103652 RVA: 0x007BAFC0 File Offset: 0x007B91C0
	public static NpcPerformController Instance
	{
		get
		{
			return NpcPerformController._Instance;
		}
	}

	// Token: 0x060194E5 RID: 103653 RVA: 0x007BAFC7 File Offset: 0x007B91C7
	public static NpcPerformController GetOrCreateInstance()
	{
		if (NpcPerformController._Instance == null)
		{
			NpcPerformController.CreateInstance();
		}
		return NpcPerformController._Instance;
	}

	// Token: 0x060194E6 RID: 103654 RVA: 0x007BAFDB File Offset: 0x007B91DB
	public static bool CreateInstance()
	{
		if (NpcPerformController._Instance != null)
		{
			return true;
		}
		NpcPerformController._Instance = new NpcPerformController();
		return true;
	}

	// Token: 0x060194E7 RID: 103655 RVA: 0x007BAFF1 File Offset: 0x007B91F1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060194E8 RID: 103656 RVA: 0x007BAFF3 File Offset: 0x007B91F3
	public static void ResetStaticDefaultValue()
	{
		NpcPerformController._Instance = null;
	}

	// Token: 0x060194E9 RID: 103657 RVA: 0x007BAFFB File Offset: 0x007B91FB
	static NpcPerformController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NpcPerformController.CreateStaticDefaultValue), new Action(NpcPerformController.ResetStaticDefaultValue));
	}

	// Token: 0x0400DD71 RID: 56689
	public Dictionary<int, HashSet<EForceVisibleReason>> ForceNpcDitherVisibleMap = new Dictionary<int, HashSet<EForceVisibleReason>>();

	// Token: 0x0400DD72 RID: 56690
	public Dictionary<int, HashSet<string>> EntityLookAtCacheForId = new Dictionary<int, HashSet<string>>();

	// Token: 0x0400DD73 RID: 56691
	public Dictionary<string, INpcInterestLookAtParamGroup> EntityLookAtCacheForKey = new Dictionary<string, INpcInterestLookAtParamGroup>();

	// Token: 0x0400DD74 RID: 56692
	[Nullable(2)]
	private static NpcPerformController _Instance;
}
