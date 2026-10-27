using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x020061FF RID: 25087
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class RhythmShipConfig : ConfigBase
	{
		// Token: 0x0603F4B2 RID: 259250 RVA: 0x00F4B6B2 File Offset: 0x00F498B2
		public RhythmShipPlanet? GetRhythmShipPlanetById(int id)
		{
			return ConfigRhythmShipPlanetById.GetConfig(id, true);
		}

		// Token: 0x0603F4B3 RID: 259251 RVA: 0x00F4B6BC File Offset: 0x00F498BC
		public List<int> GetRhythmShipPlanetIdListByType(int type, int activityId)
		{
			List<int> list = new List<int>();
			foreach (RhythmShipPlanet rhythmShipPlanet in (ConfigRhythmShipPlanetByType.GetConfigList(type, true) ?? new List<RhythmShipPlanet>()))
			{
				if (type == 2 || rhythmShipPlanet.ActivityId == activityId)
				{
					list.Add(rhythmShipPlanet.Id);
				}
			}
			return list;
		}

		// Token: 0x0603F4B4 RID: 259252 RVA: 0x00F4B730 File Offset: 0x00F49930
		public RhythmShipLevel? GetRhythmShipLevelById(int id)
		{
			return ConfigRhythmShipLevelById.GetConfig(id, true);
		}

		// Token: 0x0603F4B5 RID: 259253 RVA: 0x00F4B739 File Offset: 0x00F49939
		public RhythmSubLevel? GetRhythmShipSubLevelById(int id)
		{
			return ConfigRhythmSubLevelById.GetConfig(id, true);
		}

		// Token: 0x0603F4B6 RID: 259254 RVA: 0x00F4B742 File Offset: 0x00F49942
		[NullableContext(2)]
		public IReadOnlyList<RhythmSubLevel> GetRhythmShipSubLevelByLevelId(int id)
		{
			return ConfigRhythmSubLevelByLevelId.GetConfigList(id, true);
		}

		// Token: 0x0603F4B7 RID: 259255 RVA: 0x00F4B74C File Offset: 0x00F4994C
		public List<int> GetRhythmShipSubLevelIdByLevelId(int id)
		{
			List<int> list = new List<int>();
			foreach (RhythmSubLevel rhythmSubLevel in (ConfigRhythmSubLevelByLevelId.GetConfigList(id, true) ?? new List<RhythmSubLevel>()))
			{
				list.Add(rhythmSubLevel.Id);
			}
			return list;
		}

		// Token: 0x0603F4B8 RID: 259256 RVA: 0x00F4B7B0 File Offset: 0x00F499B0
		public List<int> GetRhythmShipLevelIdListByPlanet(int planet)
		{
			List<int> list = new List<int>();
			foreach (RhythmShipLevel rhythmShipLevel in (ConfigRhythmShipLevelByPlanet.GetConfigList(planet, true) ?? new List<RhythmShipLevel>()))
			{
				list.Add(rhythmShipLevel.Id);
			}
			return list;
		}

		// Token: 0x0603F4B9 RID: 259257 RVA: 0x00F4B814 File Offset: 0x00F49A14
		public RhythmRole? GetRhythmRoleById(int id)
		{
			return ConfigRhythmRoleById.GetConfig(id, true);
		}

		// Token: 0x0603F4BA RID: 259258 RVA: 0x00F4B820 File Offset: 0x00F49A20
		public RhythmEffect? GetRhythmRoleEffectById(int id)
		{
			RhythmEffect? config = ConfigRhythmEffectById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RhythmGame;
				ELogAuthor author = ELogAuthor.BB;
				string message = "RhythmEffect not found";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0603F4BB RID: 259259 RVA: 0x00F4B878 File Offset: 0x00F49A78
		public List<int> GetRhythmRoleAll()
		{
			List<int> list = new List<int>();
			foreach (RhythmRole rhythmRole in (ConfigRhythmRoleAll.GetConfigList(true) ?? new List<RhythmRole>()))
			{
				list.Add(rhythmRole.Id);
			}
			return list;
		}

		// Token: 0x0603F4BC RID: 259260 RVA: 0x00F4B8DC File Offset: 0x00F49ADC
		public RhythmTask? GetRhythmShipTaskById(int id)
		{
			return ConfigRhythmTaskById.GetConfig(id, true);
		}

		// Token: 0x0603F4BD RID: 259261 RVA: 0x00F4B8E8 File Offset: 0x00F49AE8
		public List<int> GetRhythmShipTaskIdByTypeAndActivityId(int type, int activityData)
		{
			List<int> list = new List<int>();
			foreach (RhythmTask rhythmTask in (ConfigRhythmTaskByActivityIdAndTaskType.GetConfigList(activityData, type, true) ?? new List<RhythmTask>()))
			{
				list.Add(rhythmTask.Id);
			}
			return list;
		}

		// Token: 0x0603F4BE RID: 259262 RVA: 0x00F4B950 File Offset: 0x00F49B50
		public RhythmTaskTab? GetRhythmShipTaskTabById(int id)
		{
			return ConfigRhythmTaskTabById.GetConfig(id, true);
		}

		// Token: 0x0603F4BF RID: 259263 RVA: 0x00F4B95C File Offset: 0x00F49B5C
		public List<int> GetRhythmShipTaskTabByTabIdAndActivityId(int tab, int activityData)
		{
			List<int> list = new List<int>();
			foreach (RhythmTask rhythmTask in (ConfigRhythmTaskByActivityIdAndTaskTab.GetConfigList(activityData, tab, true) ?? new List<RhythmTask>()))
			{
				list.Add(rhythmTask.Id);
			}
			return list;
		}

		// Token: 0x0603F4C0 RID: 259264 RVA: 0x00F4B9C4 File Offset: 0x00F49BC4
		public RhythmBg? GetRhythmShipBgById(int id)
		{
			return ConfigRhythmBgById.GetConfig(id, true);
		}

		// Token: 0x0603F4C1 RID: 259265 RVA: 0x00F4B9D0 File Offset: 0x00F49BD0
		public List<int> GetRhythmShipActionAll()
		{
			List<int> list = new List<int>();
			foreach (RhythmShipAction rhythmShipAction in (ConfigRhythmShipActionAll.GetConfigList(true) ?? new List<RhythmShipAction>()))
			{
				list.Add(rhythmShipAction.Id);
			}
			return list;
		}

		// Token: 0x0603F4C2 RID: 259266 RVA: 0x00F4BA34 File Offset: 0x00F49C34
		public RhythmShipAction? GetRhythmShipActionById(int id)
		{
			return ConfigRhythmShipActionById.GetConfig(id, true);
		}

		// Token: 0x0603F4C3 RID: 259267 RVA: 0x00F4BA3D File Offset: 0x00F49C3D
		public RhythmActivity? GetRhythmShipActivity(int id)
		{
			return ConfigRhythmActivityByActivityId.GetConfig(id, true);
		}

		// Token: 0x1700922E RID: 37422
		// (get) Token: 0x0603F4C4 RID: 259268 RVA: 0x00F4BA46 File Offset: 0x00F49C46
		public static RhythmShipConfig Instance
		{
			get
			{
				return RhythmShipConfig._Instance;
			}
		}

		// Token: 0x0603F4C5 RID: 259269 RVA: 0x00F4BA4D File Offset: 0x00F49C4D
		public static RhythmShipConfig GetOrCreateInstance()
		{
			if (RhythmShipConfig._Instance == null)
			{
				RhythmShipConfig.CreateInstance();
			}
			return RhythmShipConfig._Instance;
		}

		// Token: 0x0603F4C6 RID: 259270 RVA: 0x00F4BA61 File Offset: 0x00F49C61
		public static bool CreateInstance()
		{
			if (RhythmShipConfig._Instance != null)
			{
				return true;
			}
			RhythmShipConfig._Instance = new RhythmShipConfig();
			return true;
		}

		// Token: 0x0603F4C7 RID: 259271 RVA: 0x00F4BA77 File Offset: 0x00F49C77
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F4C8 RID: 259272 RVA: 0x00F4BA79 File Offset: 0x00F49C79
		public static void ResetStaticDefaultValue()
		{
			RhythmShipConfig._Instance = null;
		}

		// Token: 0x0603F4C9 RID: 259273 RVA: 0x00F4BA81 File Offset: 0x00F49C81
		static RhythmShipConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RhythmShipConfig.CreateStaticDefaultValue), new Action(RhythmShipConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0402103B RID: 135227
		[Nullable(2)]
		private static RhythmShipConfig _Instance;
	}
}
