using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorParkour
{
	// Token: 0x02005368 RID: 21352
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MotorParkourConfig : ConfigBase
	{
		// Token: 0x06035228 RID: 217640 RVA: 0x00ED6BCF File Offset: 0x00ED4DCF
		public IReadOnlyList<MotorParkour> GetMotorParkourLevelByActivityId(int activityId)
		{
			return ConfigMotorParkourByActivityId.GetConfigList(activityId, true) ?? Array.Empty<MotorParkour>();
		}

		// Token: 0x06035229 RID: 217641 RVA: 0x00ED6BE1 File Offset: 0x00ED4DE1
		public MotorParkour? GetMotorParkourLevelById(int id)
		{
			return ConfigMotorParkourById.GetConfig(id, true);
		}

		// Token: 0x0603522A RID: 217642 RVA: 0x00ED6BEA File Offset: 0x00ED4DEA
		public MotorParkour? GetMotorParkourLevelByInstId(int instId)
		{
			return ConfigMotorParkourByInstId.GetConfig(instId, true);
		}

		// Token: 0x0603522B RID: 217643 RVA: 0x00ED6BF3 File Offset: 0x00ED4DF3
		public MotorParkourReward? GetMotorParkourTaskById(int id)
		{
			return ConfigMotorParkourRewardById.GetConfig(id, true);
		}

		// Token: 0x0603522C RID: 217644 RVA: 0x00ED6BFC File Offset: 0x00ED4DFC
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

		// Token: 0x0603522D RID: 217645 RVA: 0x00ED6C54 File Offset: 0x00ED4E54
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

		// Token: 0x0603522E RID: 217646 RVA: 0x00ED6CAC File Offset: 0x00ED4EAC
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

		// Token: 0x1700678F RID: 26511
		// (get) Token: 0x0603522F RID: 217647 RVA: 0x00ED6D04 File Offset: 0x00ED4F04
		public static MotorParkourConfig Instance
		{
			get
			{
				return MotorParkourConfig._Instance;
			}
		}

		// Token: 0x06035230 RID: 217648 RVA: 0x00ED6D0B File Offset: 0x00ED4F0B
		public static MotorParkourConfig GetOrCreateInstance()
		{
			if (MotorParkourConfig._Instance == null)
			{
				MotorParkourConfig.CreateInstance();
			}
			return MotorParkourConfig._Instance;
		}

		// Token: 0x06035231 RID: 217649 RVA: 0x00ED6D1F File Offset: 0x00ED4F1F
		public static bool CreateInstance()
		{
			if (MotorParkourConfig._Instance != null)
			{
				return true;
			}
			MotorParkourConfig._Instance = new MotorParkourConfig();
			return true;
		}

		// Token: 0x06035232 RID: 217650 RVA: 0x00ED6D35 File Offset: 0x00ED4F35
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035233 RID: 217651 RVA: 0x00ED6D37 File Offset: 0x00ED4F37
		public static void ResetStaticDefaultValue()
		{
			MotorParkourConfig._Instance = null;
		}

		// Token: 0x06035234 RID: 217652 RVA: 0x00ED6D3F File Offset: 0x00ED4F3F
		static MotorParkourConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorParkourConfig.CreateStaticDefaultValue), new Action(MotorParkourConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C0A9 RID: 114857
		[Nullable(2)]
		private static MotorParkourConfig _Instance;
	}
}
