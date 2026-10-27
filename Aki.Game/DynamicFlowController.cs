using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Google.Protobuf;

// Token: 0x020030AA RID: 12458
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class DynamicFlowController : ControllerBase
{
	// Token: 0x0601AB12 RID: 109330 RVA: 0x00730C78 File Offset: 0x0072EE78
	protected override bool OnInit()
	{
		this.SetUpDynamicFlowTypePriority();
		Net.Instance.Register(ENotifyMessageId.EntityAddBubbleNotify, new Action<IMessage, Net.CallbackStatus>(this.AddDynamicFlowNotify));
		Net.Instance.Register(ENotifyMessageId.EntityRemoveBubbleNotify, new Action<IMessage, Net.CallbackStatus>(this.ClearDynamicFlowNotify));
		return true;
	}

	// Token: 0x0601AB13 RID: 109331 RVA: 0x00730CC4 File Offset: 0x0072EEC4
	protected override bool OnClear()
	{
		Net.Instance.UnRegister(ENotifyMessageId.EntityAddBubbleNotify);
		Net.Instance.UnRegister(ENotifyMessageId.EntityRemoveBubbleNotify);
		return true;
	}

	// Token: 0x0601AB14 RID: 109332 RVA: 0x00730CE7 File Offset: 0x0072EEE7
	private void SetUpDynamicFlowTypePriority()
	{
		this.DynamicFlowTypePriority[EDynamicFlowType.LevelAi] = 5;
		this.DynamicFlowTypePriority[EDynamicFlowType.LevelEventClient] = 20;
		this.DynamicFlowTypePriority[EDynamicFlowType.LevelEventServer] = 20;
		this.DynamicFlowTypePriority[EDynamicFlowType.FlowAction] = 20;
	}

	// Token: 0x0601AB15 RID: 109333 RVA: 0x00730D20 File Offset: 0x0072EF20
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

	// Token: 0x0601AB16 RID: 109334 RVA: 0x00730D84 File Offset: 0x0072EF84
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

	// Token: 0x0601AB17 RID: 109335 RVA: 0x00730DF4 File Offset: 0x0072EFF4
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

	// Token: 0x0601AB18 RID: 109336 RVA: 0x00730E48 File Offset: 0x0072F048
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

	// Token: 0x0601AB19 RID: 109337 RVA: 0x00730E84 File Offset: 0x0072F084
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

	// Token: 0x0601AB1A RID: 109338 RVA: 0x00730FA4 File Offset: 0x0072F1A4
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

	// Token: 0x0601AB1B RID: 109339 RVA: 0x00731028 File Offset: 0x0072F228
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

	// Token: 0x0601AB1C RID: 109340 RVA: 0x00731184 File Offset: 0x0072F384
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

	// Token: 0x0601AB1D RID: 109341 RVA: 0x007311D4 File Offset: 0x0072F3D4
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

	// Token: 0x0601AB1E RID: 109342 RVA: 0x007311FA File Offset: 0x0072F3FA
	[NullableContext(2)]
	public CharacterDynamicFlowData GetDynamicFlowByMasterActorPbDataId(int masterPbDataId)
	{
		if (masterPbDataId == 0)
		{
			return null;
		}
		return this.PbDataIdFlowDataMap.GetValueOrDefault(masterPbDataId);
	}

	// Token: 0x0601AB1F RID: 109343 RVA: 0x00731210 File Offset: 0x0072F410
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

	// Token: 0x0601AB20 RID: 109344 RVA: 0x0073128C File Offset: 0x0072F48C
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

	// Token: 0x0601AB21 RID: 109345 RVA: 0x007312BC File Offset: 0x0072F4BC
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

	// Token: 0x0601AB22 RID: 109346 RVA: 0x0073132E File Offset: 0x0072F52E
	public int GetDynamicFlowPriority(EDynamicFlowType? type)
	{
		if (type == null || !this.DynamicFlowTypePriority.ContainsKey(type.Value))
		{
			return 1;
		}
		return this.DynamicFlowTypePriority[type.Value];
	}

	// Token: 0x0601AB23 RID: 109347 RVA: 0x00731364 File Offset: 0x0072F564
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

	// Token: 0x170024AA RID: 9386
	// (get) Token: 0x0601AB24 RID: 109348 RVA: 0x007313E3 File Offset: 0x0072F5E3
	public static DynamicFlowController Instance
	{
		get
		{
			return DynamicFlowController._Instance;
		}
	}

	// Token: 0x0601AB25 RID: 109349 RVA: 0x007313EA File Offset: 0x0072F5EA
	public static DynamicFlowController GetOrCreateInstance()
	{
		if (DynamicFlowController._Instance == null)
		{
			DynamicFlowController.CreateInstance();
		}
		return DynamicFlowController._Instance;
	}

	// Token: 0x0601AB26 RID: 109350 RVA: 0x007313FE File Offset: 0x0072F5FE
	public static bool CreateInstance()
	{
		if (DynamicFlowController._Instance != null)
		{
			return true;
		}
		DynamicFlowController._Instance = new DynamicFlowController();
		return true;
	}

	// Token: 0x0601AB27 RID: 109351 RVA: 0x00731414 File Offset: 0x0072F614
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601AB28 RID: 109352 RVA: 0x00731416 File Offset: 0x0072F616
	public static void ResetStaticDefaultValue()
	{
		DynamicFlowController._Instance = null;
	}

	// Token: 0x0601AB29 RID: 109353 RVA: 0x0073141E File Offset: 0x0072F61E
	static DynamicFlowController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DynamicFlowController.CreateStaticDefaultValue), new Action(DynamicFlowController.ResetStaticDefaultValue));
	}

	// Token: 0x0400CDFC RID: 52732
	public const float DEFAULT_BUBBLE_ENTER_RANGE = 500f;

	// Token: 0x0400CDFD RID: 52733
	public const float DEFAULT_BUBBLE_LEAVE_RANGE = 1500f;

	// Token: 0x0400CDFE RID: 52734
	public const float DEFAULT_BUBBLE_LEAVE_HEIGHT = 3000f;

	// Token: 0x0400CDFF RID: 52735
	private readonly Dictionary<int, CharacterDynamicFlowData> PbDataIdFlowDataMap = new Dictionary<int, CharacterDynamicFlowData>();

	// Token: 0x0400CE00 RID: 52736
	private readonly Dictionary<long, CharacterDynamicFlowData> CreatureIdFlowDataMap = new Dictionary<long, CharacterDynamicFlowData>();

	// Token: 0x0400CE01 RID: 52737
	private readonly Dictionary<int, DynamicFlowActorInfo> PbDataIdFlowActors = new Dictionary<int, DynamicFlowActorInfo>();

	// Token: 0x0400CE02 RID: 52738
	private readonly Dictionary<long, DynamicFlowActorInfo> CreatureIdFlowActors = new Dictionary<long, DynamicFlowActorInfo>();

	// Token: 0x0400CE03 RID: 52739
	private readonly Dictionary<EDynamicFlowType, int> DynamicFlowTypePriority = new Dictionary<EDynamicFlowType, int>();

	// Token: 0x0400CE04 RID: 52740
	private const int DEFAULT_TYPE_PRIORITY = 1;

	// Token: 0x0400CE05 RID: 52741
	[Nullable(2)]
	private static DynamicFlowController _Instance;
}
