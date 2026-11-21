using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip
{
	// Token: 0x0200517D RID: 20861
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class RhythmShipConfig : ConfigBase
	{
		// Token: 0x06034173 RID: 213363 RVA: 0x00E9260A File Offset: 0x00E9080A
		public RhythmShipPlanet? GetRhythmShipPlanetById(int id)
		{
			return ConfigRhythmShipPlanetById.GetConfig(id, true);
		}

		// Token: 0x06034174 RID: 213364 RVA: 0x00E92614 File Offset: 0x00E90814
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

		// Token: 0x06034175 RID: 213365 RVA: 0x00E92688 File Offset: 0x00E90888
		public RhythmShipLevel? GetRhythmShipLevelById(int id)
		{
			return ConfigRhythmShipLevelById.GetConfig(id, true);
		}

		// Token: 0x06034176 RID: 213366 RVA: 0x00E92691 File Offset: 0x00E90891
		public RhythmSubLevel? GetRhythmShipSubLevelById(int id)
		{
			return ConfigRhythmSubLevelById.GetConfig(id, true);
		}

		// Token: 0x06034177 RID: 213367 RVA: 0x00E9269A File Offset: 0x00E9089A
		[NullableContext(2)]
		public IReadOnlyList<RhythmSubLevel> GetRhythmShipSubLevelByLevelId(int id)
		{
			return ConfigRhythmSubLevelByLevelId.GetConfigList(id, true);
		}

		// Token: 0x06034178 RID: 213368 RVA: 0x00E926A4 File Offset: 0x00E908A4
		public List<int> GetRhythmShipSubLevelIdByLevelId(int id)
		{
			List<int> list = new List<int>();
			foreach (RhythmSubLevel rhythmSubLevel in (ConfigRhythmSubLevelByLevelId.GetConfigList(id, true) ?? new List<RhythmSubLevel>()))
			{
				list.Add(rhythmSubLevel.Id);
			}
			return list;
		}

		// Token: 0x06034179 RID: 213369 RVA: 0x00E92708 File Offset: 0x00E90908
		public List<int> GetRhythmShipLevelIdListByPlanet(int planet)
		{
			List<int> list = new List<int>();
			foreach (RhythmShipLevel rhythmShipLevel in (ConfigRhythmShipLevelByPlanet.GetConfigList(planet, true) ?? new List<RhythmShipLevel>()))
			{
				list.Add(rhythmShipLevel.Id);
			}
			return list;
		}

		// Token: 0x0603417A RID: 213370 RVA: 0x00E9276C File Offset: 0x00E9096C
		public RhythmRole? GetRhythmRoleById(int id)
		{
			return ConfigRhythmRoleById.GetConfig(id, true);
		}

		// Token: 0x0603417B RID: 213371 RVA: 0x00E92778 File Offset: 0x00E90978
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

		// Token: 0x0603417C RID: 213372 RVA: 0x00E927D0 File Offset: 0x00E909D0
		public List<int> GetRhythmRoleAll()
		{
			List<int> list = new List<int>();
			foreach (RhythmRole rhythmRole in (ConfigRhythmRoleAll.GetConfigList(true) ?? new List<RhythmRole>()))
			{
				list.Add(rhythmRole.Id);
			}
			return list;
		}

		// Token: 0x0603417D RID: 213373 RVA: 0x00E92834 File Offset: 0x00E90A34
		public RhythmTask? GetRhythmShipTaskById(int id)
		{
			return ConfigRhythmTaskById.GetConfig(id, true);
		}

		// Token: 0x0603417E RID: 213374 RVA: 0x00E92840 File Offset: 0x00E90A40
		public List<int> GetRhythmShipTaskIdByTypeAndActivityId(int type, int activityData)
		{
			List<int> list = new List<int>();
			foreach (RhythmTask rhythmTask in (ConfigRhythmTaskByActivityIdAndTaskType.GetConfigList(activityData, type, true) ?? new List<RhythmTask>()))
			{
				list.Add(rhythmTask.Id);
			}
			return list;
		}

		// Token: 0x0603417F RID: 213375 RVA: 0x00E928A8 File Offset: 0x00E90AA8
		public RhythmTaskTab? GetRhythmShipTaskTabById(int id)
		{
			return ConfigRhythmTaskTabById.GetConfig(id, true);
		}

		// Token: 0x06034180 RID: 213376 RVA: 0x00E928B4 File Offset: 0x00E90AB4
		public List<int> GetRhythmShipTaskTabByTabIdAndActivityId(int tab, int activityData)
		{
			List<int> list = new List<int>();
			foreach (RhythmTask rhythmTask in (ConfigRhythmTaskByActivityIdAndTaskTab.GetConfigList(activityData, tab, true) ?? new List<RhythmTask>()))
			{
				list.Add(rhythmTask.Id);
			}
			return list;
		}

		// Token: 0x06034181 RID: 213377 RVA: 0x00E9291C File Offset: 0x00E90B1C
		public RhythmBg? GetRhythmShipBgById(int id)
		{
			return ConfigRhythmBgById.GetConfig(id, true);
		}

		// Token: 0x06034182 RID: 213378 RVA: 0x00E92928 File Offset: 0x00E90B28
		public List<int> GetRhythmShipActionAll()
		{
			List<int> list = new List<int>();
			foreach (RhythmShipAction rhythmShipAction in (ConfigRhythmShipActionAll.GetConfigList(true) ?? new List<RhythmShipAction>()))
			{
				list.Add(rhythmShipAction.Id);
			}
			return list;
		}

		// Token: 0x06034183 RID: 213379 RVA: 0x00E9298C File Offset: 0x00E90B8C
		public RhythmShipAction? GetRhythmShipActionById(int id)
		{
			return ConfigRhythmShipActionById.GetConfig(id, true);
		}

		// Token: 0x06034184 RID: 213380 RVA: 0x00E92995 File Offset: 0x00E90B95
		public RhythmActivity? GetRhythmShipActivity(int id)
		{
			return ConfigRhythmActivityByActivityId.GetConfig(id, true);
		}

		// Token: 0x17006590 RID: 26000
		// (get) Token: 0x06034185 RID: 213381 RVA: 0x00E9299E File Offset: 0x00E90B9E
		public static RhythmShipConfig Instance
		{
			get
			{
				return RhythmShipConfig._Instance;
			}
		}

		// Token: 0x06034186 RID: 213382 RVA: 0x00E929A5 File Offset: 0x00E90BA5
		public static RhythmShipConfig GetOrCreateInstance()
		{
			if (RhythmShipConfig._Instance == null)
			{
				RhythmShipConfig.CreateInstance();
			}
			return RhythmShipConfig._Instance;
		}

		// Token: 0x06034187 RID: 213383 RVA: 0x00E929B9 File Offset: 0x00E90BB9
		public static bool CreateInstance()
		{
			if (RhythmShipConfig._Instance != null)
			{
				return true;
			}
			RhythmShipConfig._Instance = new RhythmShipConfig();
			return true;
		}

		// Token: 0x06034188 RID: 213384 RVA: 0x00E929CF File Offset: 0x00E90BCF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034189 RID: 213385 RVA: 0x00E929D1 File Offset: 0x00E90BD1
		public static void ResetStaticDefaultValue()
		{
			RhythmShipConfig._Instance = null;
		}

		// Token: 0x0603418A RID: 213386 RVA: 0x00E929D9 File Offset: 0x00E90BD9
		static RhythmShipConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RhythmShipConfig.CreateStaticDefaultValue), new Action(RhythmShipConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B96A RID: 113002
		[Nullable(2)]
		private static RhythmShipConfig _Instance;
	}
}
