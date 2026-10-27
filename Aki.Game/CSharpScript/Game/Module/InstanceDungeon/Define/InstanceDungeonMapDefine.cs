using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058E3 RID: 22755
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonMapDefine : IStaticVariableResetter
	{
		// Token: 0x17008AC4 RID: 35524
		// (get) Token: 0x06039CDA RID: 236762 RVA: 0x00DBB394 File Offset: 0x00DB9594
		public static Dictionary<EDungeonSubType, InstanceDetectItemGetterData> InstanceDetectItemGetterDataMap
		{
			get
			{
				if (InstanceDungeonMapDefine._InstanceDetectItemGetterDataMap == null)
				{
					Dictionary<EDungeonSubType, InstanceDetectItemGetterData> dictionary = new Dictionary<EDungeonSubType, InstanceDetectItemGetterData>();
					dictionary[EDungeonSubType.MowingRisk] = new InstanceDetectItemGetterData
					{
						SubtitleTextIdGetter = new TInstanceSubtitleTextIdGetter(ActivityMowingRiskController.Instance.GetInstanceSubtitleTextIdByInstanceId),
						SubtitleArgsGetter = new TInstanceSubtitleArgsGetter(ActivityMowingRiskController.Instance.GetInstanceSubtitleArgsByInstanceId),
						CheckFinishedGetter = new TInstanceCheckFinishedGetter(ActivityMowingRiskController.Instance.CheckInstanceFinishedByInstanceId)
					};
					dictionary[EDungeonSubType.SolarSpeed] = new InstanceDetectItemGetterData
					{
						SubtitleTextIdGetter = new TInstanceSubtitleTextIdGetter(ActivitySolarSpeedController.Instance.GetInstanceSubtitleTextIdByInstanceId),
						SubtitleArgsGetter = new TInstanceSubtitleArgsGetter(ActivitySolarSpeedController.Instance.GetInstanceSubtitleArgsByInstanceId)
					};
					InstanceDungeonMapDefine._InstanceDetectItemGetterDataMap = dictionary;
				}
				return InstanceDungeonMapDefine._InstanceDetectItemGetterDataMap;
			}
		}

		// Token: 0x17008AC5 RID: 35525
		// (get) Token: 0x06039CDB RID: 236763 RVA: 0x00DBB442 File Offset: 0x00DB9642
		public static Dictionary<EInstanceEntranceFlowType, InstanceDungeonEntranceViewGetterData> InstanceDungeonEntranceViewGetterDataMap
		{
			get
			{
				if (InstanceDungeonMapDefine._InstanceDungeonEntranceViewGetterDataMap == null)
				{
					Dictionary<EInstanceEntranceFlowType, InstanceDungeonEntranceViewGetterData> dictionary = new Dictionary<EInstanceEntranceFlowType, InstanceDungeonEntranceViewGetterData>();
					dictionary[EInstanceEntranceFlowType.MowingRisk] = new InstanceDungeonEntranceViewGetterData
					{
						DefaultSelectDataGetter = new TInstanceDungeonEntranceViewDefaultSelectDataGetter(ActivityMowingRiskController.Instance.GetEntranceViewDefaultSelectData)
					};
					InstanceDungeonMapDefine._InstanceDungeonEntranceViewGetterDataMap = dictionary;
				}
				return InstanceDungeonMapDefine._InstanceDungeonEntranceViewGetterDataMap;
			}
		}

		// Token: 0x06039CDC RID: 236764 RVA: 0x00DBB47D File Offset: 0x00DB967D
		static InstanceDungeonMapDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonMapDefine.CreateStaticDefaultValue), new Action(InstanceDungeonMapDefine.ResetStaticDefaultValue));
		}

		// Token: 0x06039CDD RID: 236765 RVA: 0x00DBB49C File Offset: 0x00DB969C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039CDE RID: 236766 RVA: 0x00DBB49E File Offset: 0x00DB969E
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonMapDefine._InstanceDetectItemGetterDataMap = null;
			InstanceDungeonMapDefine._InstanceDungeonEntranceViewGetterDataMap = null;
		}

		// Token: 0x0401E2C7 RID: 123591
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EDungeonSubType, InstanceDetectItemGetterData> _InstanceDetectItemGetterDataMap;

		// Token: 0x0401E2C8 RID: 123592
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EInstanceEntranceFlowType, InstanceDungeonEntranceViewGetterData> _InstanceDungeonEntranceViewGetterDataMap;
	}
}
