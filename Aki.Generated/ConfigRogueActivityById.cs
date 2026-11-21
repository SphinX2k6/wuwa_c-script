using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000837 RID: 2103
	public class ConfigRogueActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600315C RID: 12636 RVA: 0x00173C50 File Offset: 0x00171E50
		static ConfigRogueActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueActivityById.CreateStaticDefaultValue), new Action(ConfigRogueActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x00173C70 File Offset: 0x00171E70
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogueactivity.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽活动.xlsx"),
				new ValueTuple<string, object>("表名", "RogueActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueActivity` where Id=?")
			});
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00173CEF File Offset: 0x00171EEF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueActivityById.LogPair = null;
			ConfigRogueActivityById.HandleId = 0;
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x00173CFD File Offset: 0x00171EFD
		public static void Init()
		{
			ConfigRogueActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueActivityById.HandleId, "db_rogueactivity.db", "select BinData from `RogueActivity` where Id=?");
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00173D18 File Offset: 0x00171F18
		public static RogueActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueActivityById.HandleId, ConfigRogueActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueActivity?(RogueActivity.GetRootAsRogueActivity(configBuffer));
				}
			}
			ConfigRogueActivityById.LogPair.Clear();
			ConfigRogueActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueActivityById.HandleId, 1, p0Id, ConfigRogueActivityById.LogPair) || ConfigCommon.Step(ConfigRogueActivityById.HandleId, true, ConfigRogueActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueActivityById.HandleId, ConfigRogueActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueActivityById.HandleId, 0, ConfigRogueActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueActivityById.HandleId, ConfigRogueActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueActivity rootAsRogueActivity = RogueActivity.GetRootAsRogueActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueActivityById.HandleId, ConfigRogueActivityById.LogPair);
			return new RogueActivity?(rootAsRogueActivity);
		}

		// Token: 0x04003967 RID: 14695
		private const string DB = "db_rogueactivity.db";

		// Token: 0x04003968 RID: 14696
		private const string FILE = "r.肉鸽活动.xlsx";

		// Token: 0x04003969 RID: 14697
		private const string TABLE = "RogueActivity";

		// Token: 0x0400396A RID: 14698
		private const string COMMAND = "select BinData from `RogueActivity` where Id=?";

		// Token: 0x0400396B RID: 14699
		private const string KEY_PREFIX = "RogueActivityById";

		// Token: 0x0400396C RID: 14700
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400396D RID: 14701
		private static int HandleId;
	}
}
