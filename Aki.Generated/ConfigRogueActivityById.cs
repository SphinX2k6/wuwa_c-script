using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081B RID: 2075
	public class ConfigRogueActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030B4 RID: 12468 RVA: 0x0016C968 File Offset: 0x0016AB68
		static ConfigRogueActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueActivityById.CreateStaticDefaultValue), new Action(ConfigRogueActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0016C988 File Offset: 0x0016AB88
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

		// Token: 0x060030B6 RID: 12470 RVA: 0x0016CA07 File Offset: 0x0016AC07
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueActivityById.LogPair = null;
			ConfigRogueActivityById.HandleId = 0;
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x0016CA15 File Offset: 0x0016AC15
		public static void Init()
		{
			ConfigRogueActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueActivityById.HandleId, "db_rogueactivity.db", "select BinData from `RogueActivity` where Id=?");
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0016CA30 File Offset: 0x0016AC30
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

		// Token: 0x040038A3 RID: 14499
		private const string DB = "db_rogueactivity.db";

		// Token: 0x040038A4 RID: 14500
		private const string FILE = "r.肉鸽活动.xlsx";

		// Token: 0x040038A5 RID: 14501
		private const string TABLE = "RogueActivity";

		// Token: 0x040038A6 RID: 14502
		private const string COMMAND = "select BinData from `RogueActivity` where Id=?";

		// Token: 0x040038A7 RID: 14503
		private const string KEY_PREFIX = "RogueActivityById";

		// Token: 0x040038A8 RID: 14504
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038A9 RID: 14505
		private static int HandleId;
	}
}
