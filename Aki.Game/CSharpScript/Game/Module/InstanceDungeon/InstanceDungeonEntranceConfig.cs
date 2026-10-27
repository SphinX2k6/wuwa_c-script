using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.Define;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200586C RID: 22636
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonEntranceConfig : ConfigBase
	{
		// Token: 0x17008A5E RID: 35422
		// (get) Token: 0x060398D3 RID: 235731 RVA: 0x00DAAEC8 File Offset: 0x00DA90C8
		private unsafe Dictionary<int, InstanceDungeonEntrance> InstanceId2EntranceCfg
		{
			get
			{
				if (this.InstanceId2EntranceCfgInternal == null)
				{
					this.InstanceId2EntranceCfgInternal = new Dictionary<int, InstanceDungeonEntrance>();
					foreach (InstanceDungeonEntrance value in ConfigInstanceDungeonEntranceAll.GetConfigList(true))
					{
						Span<int> instanceDungeonListBytes = value.GetInstanceDungeonListBytes();
						for (int i = 0; i < instanceDungeonListBytes.Length; i++)
						{
							int key = *instanceDungeonListBytes[i];
							this.InstanceId2EntranceCfgInternal[key] = value;
						}
					}
				}
				return this.InstanceId2EntranceCfgInternal;
			}
		}

		// Token: 0x060398D4 RID: 235732 RVA: 0x00DAAF5C File Offset: 0x00DA915C
		protected override bool OnInit()
		{
			this.FlowMap[EInstanceEntranceFlowType.Normal] = new InstanceDungeonEntranceFlowNormal();
			this.FlowMap[EInstanceEntranceFlowType.SkipEditFormation] = new InstanceDungeonEntranceFlowSkipEditFormation();
			this.FlowMap[EInstanceEntranceFlowType.Roguelike] = new InstanceDungeonEntranceFlowRoguelike();
			this.FlowMap[EInstanceEntranceFlowType.TowerDefense] = new InstanceDungeonEntranceFlowTowerDefense();
			this.FlowMap[EInstanceEntranceFlowType.Attached] = new InstanceDungeonEntranceFlowAttached();
			this.FlowMap[EInstanceEntranceFlowType.FarmGold] = new InstanceDungeonEntranceFlowFarmGold();
			this.FlowMap[EInstanceEntranceFlowType.MowingRisk] = new InstanceDungeonEntranceFlowMowingRisk();
			this.FlowMap[EInstanceEntranceFlowType.Abyss] = new InstanceDungeonEntranceFlowAbyss();
			this.FlowMap[EInstanceEntranceFlowType.TrapDefense] = new InstanceDungeonEntranceFlowTrapDefense();
			this.FlowMap[EInstanceEntranceFlowType.LordGym] = new InstanceDungeonEntranceFlowLordGym();
			this.FlowMap[EInstanceEntranceFlowType.AdamSmasher] = new InstanceDungeonEntranceFlowAdamSmasher();
			this.FlowMap[EInstanceEntranceFlowType.LordGymFirst] = new InstanceDungeonEntranceFlowLordGymFirst();
			this.FlowMap[EInstanceEntranceFlowType.LordGymSecond] = new InstanceDungeonEntranceFlowLordGymSecond();
			this.FlowMap[EInstanceEntranceFlowType.LordGymThird5] = new InstanceDungeonEntranceFlowLordGymThird5();
			return true;
		}

		// Token: 0x060398D5 RID: 235733 RVA: 0x00DAB064 File Offset: 0x00DA9264
		public InstanceDungeonEntrance? GetConfig(int id)
		{
			InstanceDungeonEntrance? config = ConfigInstanceDungeonEntranceById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InstanceDungeon;
				ELogAuthor author = ELogAuthor.TL;
				string message = "获取副本入口配置错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x060398D6 RID: 235734 RVA: 0x00DAB0BC File Offset: 0x00DA92BC
		[NullableContext(2)]
		public string GetConfigValueByParam(int id, string param, [Nullable(1)] string tag)
		{
			InstanceDungeonEntrance? config = this.GetConfig(id);
			if (config == null || param == null)
			{
				return null;
			}
			if (param == "MapBgPath")
			{
				return config.Value.MapBgPath;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LguiUtil;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "配置的表格字段查询到的资源路径不是字符串类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("配置的表格字段", tag);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060398D7 RID: 235735 RVA: 0x00DAB128 File Offset: 0x00DA9328
		public int GetInstanceDungeonEntranceFlowId(int id)
		{
			InstanceDungeonEntrance? config = this.GetConfig(id);
			int? num = (config != null) ? new int?(config.GetValueOrDefault().FlowId) : null;
			bool flag = (num ?? 0) == 0;
			if (flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InstanceDungeon;
				ELogAuthor author = ELogAuthor.TL;
				string message = "获取副本入口流程错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("flowId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				num = new int?(1);
			}
			return num.Value;
		}

		// Token: 0x060398D8 RID: 235736 RVA: 0x00DAB1C0 File Offset: 0x00DA93C0
		[NullableContext(2)]
		public InstanceDungeonEntranceFlowBase GetInstanceDungeonEntranceFlow(int id)
		{
			InstanceDungeonEntrance? config = this.GetConfig(id);
			int? num = (config != null) ? new int?(config.GetValueOrDefault().FlowId) : null;
			bool flag = (num ?? 0) == 0;
			if (flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InstanceDungeon;
				ELogAuthor author = ELogAuthor.TL;
				string message = "获取副本入口流程错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("flowId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				num = new int?(1);
			}
			return this.FlowMap.GetValueOrDefault((EInstanceEntranceFlowType)num.Value);
		}

		// Token: 0x060398D9 RID: 235737 RVA: 0x00DAB264 File Offset: 0x00DA9464
		public void OnEditBattleViewClose()
		{
			foreach (InstanceDungeonEntranceFlowBase instanceDungeonEntranceFlowBase in this.FlowMap.Values)
			{
				instanceDungeonEntranceFlowBase.OnEditBattleViewClose();
			}
		}

		// Token: 0x060398DA RID: 235738 RVA: 0x00DAB2BC File Offset: 0x00DA94BC
		public int GetEntranceIdByMarkId(int markId)
		{
			int result;
			if (!this.GetEntranceMarkIdMap().TryGetValue(markId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x060398DB RID: 235739 RVA: 0x00DAB2DC File Offset: 0x00DA94DC
		public bool CheckMarkIdLinkDungeonEntrance(int markId)
		{
			return this.GetEntranceIdByMarkId(markId) > 0;
		}

		// Token: 0x060398DC RID: 235740 RVA: 0x00DAB2E8 File Offset: 0x00DA94E8
		public bool CheckMarkIdIsTowerEntrance(int markId)
		{
			int id;
			if (!this.GetEntranceMarkIdMap().TryGetValue(markId, out id))
			{
				return false;
			}
			InstanceDungeonEntrance? config = this.GetConfig(id);
			return (config != null && config.GetValueOrDefault().FlowId == 4) || (config != null && config.GetValueOrDefault().FlowId == 3) || (config != null && config.GetValueOrDefault().FlowId == 5);
		}

		// Token: 0x060398DD RID: 235741 RVA: 0x00DAB370 File Offset: 0x00DA9570
		public bool CheckMarkIdIsShipTowerEntrance(int markId)
		{
			int id;
			if (!this.GetEntranceMarkIdMap().TryGetValue(markId, out id))
			{
				return false;
			}
			InstanceDungeonEntrance? config = this.GetConfig(id);
			return config != null && config.GetValueOrDefault().FlowId == 11;
		}

		// Token: 0x060398DE RID: 235742 RVA: 0x00DAB3B8 File Offset: 0x00DA95B8
		public bool CheckMarkIdIsRoguelike(int markId)
		{
			int id;
			if (!this.GetEntranceMarkIdMap().TryGetValue(markId, out id))
			{
				return false;
			}
			InstanceDungeonEntrance? config = this.GetConfig(id);
			return config != null && config.GetValueOrDefault().FlowId == 6;
		}

		// Token: 0x060398DF RID: 235743 RVA: 0x00DAB3FC File Offset: 0x00DA95FC
		public bool CheckMarkIdIsRogueRes(int markId)
		{
			int id;
			if (!this.GetEntranceMarkIdMap().TryGetValue(markId, out id))
			{
				return false;
			}
			InstanceDungeonEntrance? config = this.GetConfig(id);
			return config != null && config.GetValueOrDefault().FlowId == 14;
		}

		// Token: 0x060398E0 RID: 235744 RVA: 0x00DAB444 File Offset: 0x00DA9644
		public bool CheckInstanceIdIsTowerDefense(int instanceId)
		{
			InstanceDungeonEntrance instanceDungeonEntrance;
			return this.InstanceId2EntranceCfg.TryGetValue(instanceId, out instanceDungeonEntrance) && instanceDungeonEntrance.FlowId == 8;
		}

		// Token: 0x060398E1 RID: 235745 RVA: 0x00DAB470 File Offset: 0x00DA9670
		public bool CheckMarkIdIsWheelTower(int markId)
		{
			int id;
			if (!this.GetEntranceMarkIdMap().TryGetValue(markId, out id))
			{
				return false;
			}
			InstanceDungeonEntrance? config = this.GetConfig(id);
			return config != null && config.GetValueOrDefault().FlowId == 17;
		}

		// Token: 0x060398E2 RID: 235746 RVA: 0x00DAB4B8 File Offset: 0x00DA96B8
		public int GetEntranceIdByInstanceId(int instanceId)
		{
			InstanceDungeonEntrance instanceDungeonEntrance;
			if (!this.InstanceId2EntranceCfg.TryGetValue(instanceId, out instanceDungeonEntrance))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.InstanceDungeon;
				ELogAuthor author = ELogAuthor.WZ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(29, 1);
				defaultInterpolatedStringHandler.AppendLiteral("未找到副本入口，请检查副本表配置，instanceId: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(instanceId);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return 0;
			}
			return instanceDungeonEntrance.Id;
		}

		// Token: 0x060398E3 RID: 235747 RVA: 0x00DAB51C File Offset: 0x00DA971C
		public Dictionary<int, int> GetEntranceMarkIdMap()
		{
			if (this.EntranceMarkIdMap == null)
			{
				this.EntranceMarkIdMap = new Dictionary<int, int>();
				foreach (InstanceDungeonEntrance instanceDungeonEntrance in ConfigInstanceDungeonEntranceAll.GetConfigList(true))
				{
					if (instanceDungeonEntrance.MarkId != 0)
					{
						this.EntranceMarkIdMap[instanceDungeonEntrance.MarkId] = instanceDungeonEntrance.Id;
					}
				}
			}
			return this.EntranceMarkIdMap;
		}

		// Token: 0x17008A5F RID: 35423
		// (get) Token: 0x060398E4 RID: 235748 RVA: 0x00DAB5A0 File Offset: 0x00DA97A0
		public static InstanceDungeonEntranceConfig Instance
		{
			get
			{
				return InstanceDungeonEntranceConfig._Instance;
			}
		}

		// Token: 0x060398E5 RID: 235749 RVA: 0x00DAB5A7 File Offset: 0x00DA97A7
		public static InstanceDungeonEntranceConfig GetOrCreateInstance()
		{
			if (InstanceDungeonEntranceConfig._Instance == null)
			{
				InstanceDungeonEntranceConfig.CreateInstance();
			}
			return InstanceDungeonEntranceConfig._Instance;
		}

		// Token: 0x060398E6 RID: 235750 RVA: 0x00DAB5BB File Offset: 0x00DA97BB
		public static bool CreateInstance()
		{
			if (InstanceDungeonEntranceConfig._Instance != null)
			{
				return true;
			}
			InstanceDungeonEntranceConfig._Instance = new InstanceDungeonEntranceConfig();
			return true;
		}

		// Token: 0x060398E7 RID: 235751 RVA: 0x00DAB5D1 File Offset: 0x00DA97D1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060398E8 RID: 235752 RVA: 0x00DAB5D3 File Offset: 0x00DA97D3
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonEntranceConfig._Instance = null;
		}

		// Token: 0x060398E9 RID: 235753 RVA: 0x00DAB5DB File Offset: 0x00DA97DB
		static InstanceDungeonEntranceConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonEntranceConfig.CreateStaticDefaultValue), new Action(InstanceDungeonEntranceConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401E196 RID: 123286
		private readonly Dictionary<EInstanceEntranceFlowType, InstanceDungeonEntranceFlowBase> FlowMap = new Dictionary<EInstanceEntranceFlowType, InstanceDungeonEntranceFlowBase>();

		// Token: 0x0401E197 RID: 123287
		[Nullable(2)]
		private Dictionary<int, int> EntranceMarkIdMap;

		// Token: 0x0401E198 RID: 123288
		[Nullable(2)]
		private Dictionary<int, InstanceDungeonEntrance> InstanceId2EntranceCfgInternal;

		// Token: 0x0401E199 RID: 123289
		[Nullable(2)]
		private static InstanceDungeonEntranceConfig _Instance;
	}
}
