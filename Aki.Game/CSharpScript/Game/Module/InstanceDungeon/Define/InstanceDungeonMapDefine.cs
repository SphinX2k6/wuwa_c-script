using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.AdventureGuide;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048BB RID: 18619
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonMapDefine : IStaticVariableResetter
	{
		// Token: 0x17005E90 RID: 24208
		// (get) Token: 0x0602EBFD RID: 191485 RVA: 0x00D0A2EC File Offset: 0x00D084EC
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

		// Token: 0x17005E91 RID: 24209
		// (get) Token: 0x0602EBFE RID: 191486 RVA: 0x00D0A39A File Offset: 0x00D0859A
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

		// Token: 0x0602EBFF RID: 191487 RVA: 0x00D0A3D5 File Offset: 0x00D085D5
		static InstanceDungeonMapDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonMapDefine.CreateStaticDefaultValue), new Action(InstanceDungeonMapDefine.ResetStaticDefaultValue));
		}

		// Token: 0x0602EC00 RID: 191488 RVA: 0x00D0A3F4 File Offset: 0x00D085F4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EC01 RID: 191489 RVA: 0x00D0A3F6 File Offset: 0x00D085F6
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonMapDefine._InstanceDetectItemGetterDataMap = null;
			InstanceDungeonMapDefine._InstanceDungeonEntranceViewGetterDataMap = null;
		}

		// Token: 0x04018D64 RID: 101732
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EDungeonSubType, InstanceDetectItemGetterData> _InstanceDetectItemGetterDataMap;

		// Token: 0x04018D65 RID: 101733
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<EInstanceEntranceFlowType, InstanceDungeonEntranceViewGetterData> _InstanceDungeonEntranceViewGetterDataMap;
	}
}
