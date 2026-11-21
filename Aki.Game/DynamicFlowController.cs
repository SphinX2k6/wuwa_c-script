using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Google.Protobuf;

// Token: 0x02002601 RID: 9729
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class DynamicFlowController : ControllerBase
{
	// Token: 0x06018520 RID: 99616 RVA: 0x00756178 File Offset: 0x00754378
	protected override bool OnInit()
	{
		this.SetUpDynamicFlowTypePriority();
		Net.Instance.Register(ENotifyMessageId.EntityAddBubbleNotify, new Action<IMessage, Net.CallbackStatus>(this.AddDynamicFlowNotify));
		Net.Instance.Register(ENotifyMessageId.EntityRemoveBubbleNotify, new Action<IMessage, Net.CallbackStatus>(this.ClearDynamicFlowNotify));
		return true;
	}

	// Token: 0x06018521 RID: 99617 RVA: 0x007561C4 File Offset: 0x007543C4
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.EntityAddBubbleNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityRemoveBubbleNotify);
		return true;
	}

	// Token: 0x06018522 RID: 99618 RVA: 0x007561E7 File Offset: 0x007543E7
	private void SetUpDynamicFlowTypePriority()
	{
		this.DynamicFlowTypePriority[EDynamicFlowType.LevelAi] = 5;
		this.DynamicFlowTypePriority[EDynamicFlowType.LevelEventClient] = 20;
		this.DynamicFlowTypePriority[EDynamicFlowType.LevelEventServer] = 20;
		this.DynamicFlowTypePriority[EDynamicFlowType.FlowAction] = 20;
	}

	// Token: 0x06018523 RID: 99619 RVA: 0x00756220 File Offset: 0x00754420
	[NullableContext(2)]
	private void AddDynamicFlowNotify(IMessage msg, Net.CallbackStatus status)
	{
		EntityAddBubbleNotify entityAddBubbleNotify = (EntityAddBubbleNotify)msg;
		AddPlayBubble bubbleData = BubbleConfig.Instance.GetBubbleData(entityAddBubbleNotify.ActionGuid);
		long creatureId = MathUtils.Instance.LongToNumber(entityAddBubbleNotify.EntityId);
		if (bubbleData == null)
		{
			return;
		}
		CharacterDynamicFlowData data = (bubbleData.EntityIds.Count != 0) ? this.CreateCharacterFlowData(bubbleData) : this.CreateCharacterFlowDataForMasterCreatureId(creatureId, bubbleData);
		this.AddDynamicFlow(data);
	}

	// Token: 0x06018524 RID: 99620 RVA: 0x00756284 File Offset: 0x00754484
	[NullableContext(2)]
	private void ClearDynamicFlowNotify(IMessage msg, Net.CallbackStatus status)
	{
		EntityRemoveBubbleNotify entityRemoveBubbleNotify = (EntityRemoveBubbleNotify)msg;
		AddPlayBubble bubbleData = BubbleConfig.Instance.GetBubbleData(entityRemoveBubbleNotify.ActionGuid);
		long creatureId = MathUtils.Instance.LongToNumber(entityRemoveBubbleNotify.EntityId);
		if (bubbleData == null)
		{
			return;
		}
		DynamicFlowActorInfo dynamicFlowActorInfo = new DynamicFlowActorInfo();
		if (bubbleData.EntityIds.Count != 0)
		{
			dynamicFlowActorInfo.PbDataId = bubbleData.EntityIds[0];
		}
		else
		{
			dynamicFlowActorInfo.CreatureId = creatureId;
		}
		this.RemoveDynamicFlow(dynamicFlowActorInfo);
	}

	// Token: 0x06018525 RID: 99621 RVA: 0x007562F4 File Offset: 0x007544F4
	public CharacterDynamicFlowData CreateCharacterFlowData(AddPlayBubble flowData)
	{
		return new CharacterDynamicFlowData
		{
			MasterInfo = new DynamicFlowActorInfo
			{
				PbDataId = ((flowData.EntityIds.Count != 0) ? flowData.EntityIds[0] : 0)
			},
			BubbleData = flowData,
			Type = new EDynamicFlowType?(EDynamicFlowType.LevelEventServer)
		};
	}

	// Token: 0x06018526 RID: 99622 RVA: 0x00756348 File Offset: 0x00754548
	public CharacterDynamicFlowData CreateCharacterFlowDataForMasterCreatureId(long creatureId, AddPlayBubble flowData)
	{
		return new CharacterDynamicFlowData
		{
			MasterInfo = new DynamicFlowActorInfo
			{
				CreatureId = creatureId
			},
			BubbleData = flowData,
			Type = new EDynamicFlowType?(EDynamicFlowType.LevelEventServer)
		};
	}

	// Token: 0x06018527 RID: 99623 RVA: 0x00756384 File Offset: 0x00754584
	public bool AddDynamicFlow(CharacterDynamicFlowData data)
	{
		if (((data != null) ? data.BubbleData : null) == null)
		{
			return false;
		}
		int dynamicFlowPriority = this.GetDynamicFlowPriority(data.Type);
		foreach (int num in data.BubbleData.EntityIds)
		{
			if (this.PbDataIdFlowActors.ContainsKey(num))
			{
				CharacterDynamicFlowData dynamicFlowByActorPbDataId = this.GetDynamicFlowByActorPbDataId(num);
				int dynamicFlowPriority2 = this.GetDynamicFlowPriority(dynamicFlowByActorPbDataId.Type);
				if (dynamicFlowPriority <= dynamicFlowPriority2)
				{
					return false;
				}
			}
		}
		DynamicFlowActorInfo masterInfo = data.MasterInfo;
		if (masterInfo == null || !masterInfo.IsValid())
		{
			return false;
		}
		EntityHandle flowActorEntityHandle = this.GetFlowActorEntityHandle(data.MasterInfo);
		if (flowActorEntityHandle != null)
		{
			WorldEntity entity = flowActorEntityHandle.Entity;
			if (((entity != null) ? new bool?(entity.IsInit) : null).GetValueOrDefault())
			{
				WorldEntity entity2 = flowActorEntityHandle.Entity;
				CharacterFlowComponent characterFlowComponent = (entity2 != null) ? entity2.GetComponent<CharacterFlowComponent>() : null;
				if (characterFlowComponent != null)
				{
					characterFlowComponent.PlayDynamicFlowBegin(data);
				}
			}
		}
		this.UpdateDynamicFlowCache(data, true);
		return true;
	}

	// Token: 0x06018528 RID: 99624 RVA: 0x007564A4 File Offset: 0x007546A4
	public bool RemoveDynamicFlow(DynamicFlowActorInfo actorInfo)
	{
		DynamicFlowActorInfo masterActorInfoByActorInfo = this.GetMasterActorInfoByActorInfo(actorInfo);
		if (masterActorInfoByActorInfo == null)
		{
			return false;
		}
		CharacterDynamicFlowData dynamicFlowByMasterActorInfo = this.GetDynamicFlowByMasterActorInfo(masterActorInfoByActorInfo);
		if (dynamicFlowByMasterActorInfo == null)
		{
			return false;
		}
		EntityHandle flowActorEntityHandle = this.GetFlowActorEntityHandle(masterActorInfoByActorInfo);
		if (flowActorEntityHandle != null)
		{
			WorldEntity entity = flowActorEntityHandle.Entity;
			if (((entity != null) ? new bool?(entity.IsInit) : null).GetValueOrDefault())
			{
				WorldEntity entity2 = flowActorEntityHandle.Entity;
				CharacterFlowComponent characterFlowComponent = (entity2 != null) ? entity2.GetComponent<CharacterFlowComponent>() : null;
				if (characterFlowComponent != null)
				{
					characterFlowComponent.PlayDynamicFlowEnd();
				}
			}
		}
		this.UpdateDynamicFlowCache(dynamicFlowByMasterActorInfo, false);
		return true;
	}

	// Token: 0x06018529 RID: 99625 RVA: 0x00756528 File Offset: 0x00754728
	protected void UpdateDynamicFlowCache(CharacterDynamicFlowData data, bool isAdd)
	{
		DynamicFlowActorInfo masterInfo = data.MasterInfo;
		if (isAdd)
		{
			if (masterInfo.PbDataId != 0)
			{
				this.PbDataIdFlowDataMap[masterInfo.PbDataId] = data;
				this.PbDataIdFlowActors[masterInfo.PbDataId] = masterInfo;
			}
			if (masterInfo.CreatureId != 0L)
			{
				this.CreatureIdFlowDataMap[masterInfo.CreatureId] = data;
				this.CreatureIdFlowActors[masterInfo.CreatureId] = masterInfo;
			}
			using (List<int>.Enumerator enumerator = data.BubbleData.EntityIds.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int key = enumerator.Current;
					this.PbDataIdFlowActors[key] = masterInfo;
				}
				return;
			}
		}
		foreach (int key2 in data.BubbleData.EntityIds)
		{
			this.PbDataIdFlowActors.Remove(key2);
		}
		this.PbDataIdFlowDataMap.Remove(masterInfo.PbDataId);
		this.PbDataIdFlowActors.Remove(masterInfo.PbDataId);
		this.CreatureIdFlowDataMap.Remove(masterInfo.CreatureId);
		this.CreatureIdFlowActors.Remove(masterInfo.CreatureId);
	}

	// Token: 0x0601852A RID: 99626 RVA: 0x00756684 File Offset: 0x00754884
	[NullableContext(2)]
	public EntityHandle GetFlowActorEntityHandle(DynamicFlowActorInfo actorInfo)
	{
		if (actorInfo == null)
		{
			return null;
		}
		EntityHandle entityHandle = null;
		if (entityHandle == null && actorInfo.PbDataId != 0)
		{
			entityHandle = CreatureModel.Instance.GetEntityByPbDataId(actorInfo.PbDataId);
		}
		if (entityHandle == null && actorInfo.CreatureId != 0L)
		{
			entityHandle = CreatureModel.Instance.GetEntity(actorInfo.CreatureId);
		}
		return entityHandle;
	}

	// Token: 0x0601852B RID: 99627 RVA: 0x007566D4 File Offset: 0x007548D4
	[NullableContext(2)]
	public CharacterDynamicFlowData GetDynamicFlowByActorPbDataId(int pbDataId)
	{
		DynamicFlowActorInfo valueOrDefault = this.PbDataIdFlowActors.GetValueOrDefault(pbDataId);
		if (valueOrDefault == null)
		{
			return null;
		}
		return this.GetDynamicFlowByMasterActorInfo(valueOrDefault);
	}

	// Token: 0x0601852C RID: 99628 RVA: 0x007566FA File Offset: 0x007548FA
	[NullableContext(2)]
	public CharacterDynamicFlowData GetDynamicFlowByMasterActorPbDataId(int masterPbDataId)
	{
		if (masterPbDataId == 0)
		{
			return null;
		}
		return this.PbDataIdFlowDataMap.GetValueOrDefault(masterPbDataId);
	}

	// Token: 0x0601852D RID: 99629 RVA: 0x00756710 File Offset: 0x00754910
	[return: Nullable(2)]
	public DynamicFlowActorInfo GetMasterActorInfoByActorInfo(DynamicFlowActorInfo actorInfo)
	{
		if (actorInfo == null || !actorInfo.IsValid())
		{
			return null;
		}
		if (actorInfo.PbDataId != 0 && this.PbDataIdFlowActors.ContainsKey(actorInfo.PbDataId))
		{
			return this.PbDataIdFlowActors.GetValueOrDefault(actorInfo.PbDataId);
		}
		if (actorInfo.CreatureId != 0L && this.CreatureIdFlowActors.ContainsKey(actorInfo.CreatureId))
		{
			return this.CreatureIdFlowActors.GetValueOrDefault(actorInfo.CreatureId);
		}
		return null;
	}

	// Token: 0x0601852E RID: 99630 RVA: 0x0075678C File Offset: 0x0075498C
	[return: Nullable(2)]
	public CharacterDynamicFlowData GetDynamicFlowByActorInfo(DynamicFlowActorInfo actorInfo)
	{
		DynamicFlowActorInfo masterActorInfoByActorInfo = this.GetMasterActorInfoByActorInfo(actorInfo);
		if (masterActorInfoByActorInfo == null || !masterActorInfoByActorInfo.IsValid())
		{
			return null;
		}
		return this.GetDynamicFlowByMasterActorInfo(masterActorInfoByActorInfo);
	}

	// Token: 0x0601852F RID: 99631 RVA: 0x007567BC File Offset: 0x007549BC
	[return: Nullable(2)]
	public CharacterDynamicFlowData GetDynamicFlowByMasterActorInfo(DynamicFlowActorInfo masterInfo)
	{
		if (!masterInfo.IsValid())
		{
			return null;
		}
		if (masterInfo.PbDataId != 0 && this.PbDataIdFlowDataMap.ContainsKey(masterInfo.PbDataId))
		{
			return this.PbDataIdFlowDataMap.GetValueOrDefault(masterInfo.PbDataId);
		}
		if (masterInfo.CreatureId != 0L && this.CreatureIdFlowDataMap.ContainsKey(masterInfo.CreatureId))
		{
			return this.CreatureIdFlowDataMap.GetValueOrDefault(masterInfo.CreatureId);
		}
		return null;
	}

	// Token: 0x06018530 RID: 99632 RVA: 0x0075682E File Offset: 0x00754A2E
	public int GetDynamicFlowPriority(EDynamicFlowType? type)
	{
		if (type == null || !this.DynamicFlowTypePriority.ContainsKey(type.Value))
		{
			return 1;
		}
		return this.DynamicFlowTypePriority[type.Value];
	}

	// Token: 0x06018531 RID: 99633 RVA: 0x00756864 File Offset: 0x00754A64
	public FlowRangeInfo GetRangeInfoFromConfig(float minRadius, float maxRadius, [Nullable(2)] IBubbleRangeCylinderConfig config)
	{
		FlowRangeInfo flowRangeInfo = new FlowRangeInfo();
		flowRangeInfo.MinRadius = minRadius;
		flowRangeInfo.MaxRadius = maxRadius;
		flowRangeInfo.MinHeight = 0f;
		flowRangeInfo.MaxHeight = 0f;
		if (config != null)
		{
			flowRangeInfo.MinRadius = config.InnerConfig.Radius;
			flowRangeInfo.MaxRadius = config.OuterConfig.Radius;
			flowRangeInfo.MinHeight = config.InnerConfig.Height;
			flowRangeInfo.MaxHeight = config.OuterConfig.Height;
		}
		return flowRangeInfo;
	}

	// Token: 0x1700262D RID: 9773
	// (get) Token: 0x06018532 RID: 99634 RVA: 0x007568E3 File Offset: 0x00754AE3
	public static DynamicFlowController Instance
	{
		get
		{
			return DynamicFlowController._Instance;
		}
	}

	// Token: 0x06018533 RID: 99635 RVA: 0x007568EA File Offset: 0x00754AEA
	public static DynamicFlowController GetOrCreateInstance()
	{
		if (DynamicFlowController._Instance == null)
		{
			DynamicFlowController.CreateInstance();
		}
		return DynamicFlowController._Instance;
	}

	// Token: 0x06018534 RID: 99636 RVA: 0x007568FE File Offset: 0x00754AFE
	public static bool CreateInstance()
	{
		if (DynamicFlowController._Instance != null)
		{
			return true;
		}
		DynamicFlowController._Instance = new DynamicFlowController();
		return true;
	}

	// Token: 0x06018535 RID: 99637 RVA: 0x00756914 File Offset: 0x00754B14
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06018536 RID: 99638 RVA: 0x00756916 File Offset: 0x00754B16
	public static void ResetStaticDefaultValue()
	{
		DynamicFlowController._Instance = null;
	}

	// Token: 0x06018537 RID: 99639 RVA: 0x0075691E File Offset: 0x00754B1E
	static DynamicFlowController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DynamicFlowController.CreateStaticDefaultValue), new Action(DynamicFlowController.ResetStaticDefaultValue));
	}

	// Token: 0x0400D1E0 RID: 53728
	public const float DEFAULT_BUBBLE_ENTER_RANGE = 500f;

	// Token: 0x0400D1E1 RID: 53729
	public const float DEFAULT_BUBBLE_LEAVE_RANGE = 1500f;

	// Token: 0x0400D1E2 RID: 53730
	public const float DEFAULT_BUBBLE_LEAVE_HEIGHT = 3000f;

	// Token: 0x0400D1E3 RID: 53731
	private readonly Dictionary<int, CharacterDynamicFlowData> PbDataIdFlowDataMap = new Dictionary<int, CharacterDynamicFlowData>();

	// Token: 0x0400D1E4 RID: 53732
	private readonly Dictionary<long, CharacterDynamicFlowData> CreatureIdFlowDataMap = new Dictionary<long, CharacterDynamicFlowData>();

	// Token: 0x0400D1E5 RID: 53733
	private readonly Dictionary<int, DynamicFlowActorInfo> PbDataIdFlowActors = new Dictionary<int, DynamicFlowActorInfo>();

	// Token: 0x0400D1E6 RID: 53734
	private readonly Dictionary<long, DynamicFlowActorInfo> CreatureIdFlowActors = new Dictionary<long, DynamicFlowActorInfo>();

	// Token: 0x0400D1E7 RID: 53735
	private readonly Dictionary<EDynamicFlowType, int> DynamicFlowTypePriority = new Dictionary<EDynamicFlowType, int>();

	// Token: 0x0400D1E8 RID: 53736
	private const int DEFAULT_TYPE_PRIORITY = 1;

	// Token: 0x0400D1E9 RID: 53737
	[Nullable(2)]
	private static DynamicFlowController _Instance;
}
