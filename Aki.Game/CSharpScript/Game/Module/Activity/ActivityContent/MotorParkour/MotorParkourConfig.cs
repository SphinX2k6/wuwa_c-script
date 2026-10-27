using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x020063EA RID: 25578
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MotorParkourConfig : ConfigBase
	{
		// Token: 0x06040567 RID: 263527 RVA: 0x00F8FC37 File Offset: 0x00F8DE37
		public IReadOnlyList<MotorParkour> GetMotorParkourLevelByActivityId(int activityId)
		{
			return ConfigMotorParkourByActivityId.GetConfigList(activityId, true) ?? Array.Empty<MotorParkour>();
		}

		// Token: 0x06040568 RID: 263528 RVA: 0x00F8FC49 File Offset: 0x00F8DE49
		public MotorParkour? GetMotorParkourLevelById(int id)
		{
			return ConfigMotorParkourById.GetConfig(id, true);
		}

		// Token: 0x06040569 RID: 263529 RVA: 0x00F8FC52 File Offset: 0x00F8DE52
		public MotorParkour? GetMotorParkourLevelByInstId(int instId)
		{
			return ConfigMotorParkourByInstId.GetConfig(instId, true);
		}

		// Token: 0x0604056A RID: 263530 RVA: 0x00F8FC5B File Offset: 0x00F8DE5B
		public MotorParkourReward? GetMotorParkourTaskById(int id)
		{
			return ConfigMotorParkourRewardById.GetConfig(id, true);
		}

		// Token: 0x0604056B RID: 263531 RVA: 0x00F8FC64 File Offset: 0x00F8DE64
		public MotorParkourRecord? GetMotorParkourRecordById(int id)
		{
			MotorParkourRecord? config = ConfigMotorParkourRecordById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorParkour;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "摩托跑酷记录配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0604056C RID: 263532 RVA: 0x00F8FCBC File Offset: 0x00F8DEBC
		public MotorParkourNPC? GetMotorParkourNpcById(int id)
		{
			MotorParkourNPC? config = ConfigMotorParkourNPCById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorParkour;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "摩托跑酷npc配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0604056D RID: 263533 RVA: 0x00F8FD14 File Offset: 0x00F8DF14
		public MotorParkourRank? GetMotorParkourRankById(int id)
		{
			MotorParkourRank? config = ConfigMotorParkourRankById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MotorParkour;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "摩托跑酷排名配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x1700942D RID: 37933
		// (get) Token: 0x0604056E RID: 263534 RVA: 0x00F8FD6C File Offset: 0x00F8DF6C
		public static MotorParkourConfig Instance
		{
			get
			{
				return MotorParkourConfig._Instance;
			}
		}

		// Token: 0x0604056F RID: 263535 RVA: 0x00F8FD73 File Offset: 0x00F8DF73
		public static MotorParkourConfig GetOrCreateInstance()
		{
			if (MotorParkourConfig._Instance == null)
			{
				MotorParkourConfig.CreateInstance();
			}
			return MotorParkourConfig._Instance;
		}

		// Token: 0x06040570 RID: 263536 RVA: 0x00F8FD87 File Offset: 0x00F8DF87
		public static bool CreateInstance()
		{
			if (MotorParkourConfig._Instance != null)
			{
				return true;
			}
			MotorParkourConfig._Instance = new MotorParkourConfig();
			return true;
		}

		// Token: 0x06040571 RID: 263537 RVA: 0x00F8FD9D File Offset: 0x00F8DF9D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040572 RID: 263538 RVA: 0x00F8FD9F File Offset: 0x00F8DF9F
		public static void ResetStaticDefaultValue()
		{
			MotorParkourConfig._Instance = null;
		}

		// Token: 0x06040573 RID: 263539 RVA: 0x00F8FDA7 File Offset: 0x00F8DFA7
		static MotorParkourConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorParkourConfig.CreateStaticDefaultValue), new Action(MotorParkourConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0402177A RID: 137082
		[Nullable(2)]
		private static MotorParkourConfig _Instance;
	}
}
