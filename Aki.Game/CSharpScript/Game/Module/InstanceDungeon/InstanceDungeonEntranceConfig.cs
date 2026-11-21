using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.Define;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004844 RID: 18500
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonEntranceConfig : ConfigBase
	{
		// Token: 0x17005E2A RID: 24106
		// (get) Token: 0x0602E7F0 RID: 190448 RVA: 0x00CF9C18 File Offset: 0x00CF7E18
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

		// Token: 0x0602E7F1 RID: 190449 RVA: 0x00CF9CAC File Offset: 0x00CF7EAC
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

		// Token: 0x0602E7F2 RID: 190450 RVA: 0x00CF9DB4 File Offset: 0x00CF7FB4
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

		// Token: 0x0602E7F3 RID: 190451 RVA: 0x00CF9E0C File Offset: 0x00CF800C
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

		// Token: 0x0602E7F4 RID: 190452 RVA: 0x00CF9E78 File Offset: 0x00CF8078
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

		// Token: 0x0602E7F5 RID: 190453 RVA: 0x00CF9F10 File Offset: 0x00CF8110
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

		// Token: 0x0602E7F6 RID: 190454 RVA: 0x00CF9FB4 File Offset: 0x00CF81B4
		public void OnEditBattleViewClose()
		{
			foreach (InstanceDungeonEntranceFlowBase instanceDungeonEntranceFlowBase in this.FlowMap.Values)
			{
				instanceDungeonEntranceFlowBase.OnEditBattleViewClose();
			}
		}

		// Token: 0x0602E7F7 RID: 190455 RVA: 0x00CFA00C File Offset: 0x00CF820C
		public int GetEntranceIdByMarkId(int markId)
		{
			int result;
			if (!this.GetEntranceMarkIdMap().TryGetValue(markId, out result))
			{
				return 0;
			}
			return result;
		}

		// Token: 0x0602E7F8 RID: 190456 RVA: 0x00CFA02C File Offset: 0x00CF822C
		public bool CheckMarkIdLinkDungeonEntrance(int markId)
		{
			return this.GetEntranceIdByMarkId(markId) > 0;
		}

		// Token: 0x0602E7F9 RID: 190457 RVA: 0x00CFA038 File Offset: 0x00CF8238
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

		// Token: 0x0602E7FA RID: 190458 RVA: 0x00CFA0C0 File Offset: 0x00CF82C0
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

		// Token: 0x0602E7FB RID: 190459 RVA: 0x00CFA108 File Offset: 0x00CF8308
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

		// Token: 0x0602E7FC RID: 190460 RVA: 0x00CFA14C File Offset: 0x00CF834C
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

		// Token: 0x0602E7FD RID: 190461 RVA: 0x00CFA194 File Offset: 0x00CF8394
		public bool CheckInstanceIdIsTowerDefense(int instanceId)
		{
			InstanceDungeonEntrance instanceDungeonEntrance;
			return this.InstanceId2EntranceCfg.TryGetValue(instanceId, out instanceDungeonEntrance) && instanceDungeonEntrance.FlowId == 8;
		}

		// Token: 0x0602E7FE RID: 190462 RVA: 0x00CFA1C0 File Offset: 0x00CF83C0
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

		// Token: 0x0602E7FF RID: 190463 RVA: 0x00CFA208 File Offset: 0x00CF8408
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

		// Token: 0x0602E800 RID: 190464 RVA: 0x00CFA26C File Offset: 0x00CF846C
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

		// Token: 0x17005E2B RID: 24107
		// (get) Token: 0x0602E801 RID: 190465 RVA: 0x00CFA2F0 File Offset: 0x00CF84F0
		public static InstanceDungeonEntranceConfig Instance
		{
			get
			{
				return InstanceDungeonEntranceConfig._Instance;
			}
		}

		// Token: 0x0602E802 RID: 190466 RVA: 0x00CFA2F7 File Offset: 0x00CF84F7
		public static InstanceDungeonEntranceConfig GetOrCreateInstance()
		{
			if (InstanceDungeonEntranceConfig._Instance == null)
			{
				InstanceDungeonEntranceConfig.CreateInstance();
			}
			return InstanceDungeonEntranceConfig._Instance;
		}

		// Token: 0x0602E803 RID: 190467 RVA: 0x00CFA30B File Offset: 0x00CF850B
		public static bool CreateInstance()
		{
			if (InstanceDungeonEntranceConfig._Instance != null)
			{
				return true;
			}
			InstanceDungeonEntranceConfig._Instance = new InstanceDungeonEntranceConfig();
			return true;
		}

		// Token: 0x0602E804 RID: 190468 RVA: 0x00CFA321 File Offset: 0x00CF8521
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E805 RID: 190469 RVA: 0x00CFA323 File Offset: 0x00CF8523
		public static void ResetStaticDefaultValue()
		{
			InstanceDungeonEntranceConfig._Instance = null;
		}

		// Token: 0x0602E806 RID: 190470 RVA: 0x00CFA32B File Offset: 0x00CF852B
		static InstanceDungeonEntranceConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InstanceDungeonEntranceConfig.CreateStaticDefaultValue), new Action(InstanceDungeonEntranceConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018C33 RID: 101427
		private readonly Dictionary<EInstanceEntranceFlowType, InstanceDungeonEntranceFlowBase> FlowMap = new Dictionary<EInstanceEntranceFlowType, InstanceDungeonEntranceFlowBase>();

		// Token: 0x04018C34 RID: 101428
		[Nullable(2)]
		private Dictionary<int, int> EntranceMarkIdMap;

		// Token: 0x04018C35 RID: 101429
		[Nullable(2)]
		private Dictionary<int, InstanceDungeonEntrance> InstanceId2EntranceCfgInternal;

		// Token: 0x04018C36 RID: 101430
		[Nullable(2)]
		private static InstanceDungeonEntranceConfig _Instance;
	}
}
