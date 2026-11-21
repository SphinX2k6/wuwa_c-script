using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089B RID: 2203
	public class ConfigRogueWeekTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033B4 RID: 13236 RVA: 0x00181224 File Offset: 0x0017F424
		static ConfigRogueWeekTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeekTagById.CreateStaticDefaultValue), new Action(ConfigRogueWeekTagById.ResetStaticDefaultValue));
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00181244 File Offset: 0x0017F444
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeekTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeekTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeekTag"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeekTag` where Id=?")
			});
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x001812C3 File Offset: 0x0017F4C3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeekTagById.LogPair = null;
			ConfigRogueWeekTagById.HandleId = 0;
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x001812D1 File Offset: 0x0017F4D1
		public static void Init()
		{
			ConfigRogueWeekTagById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeekTagById.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeekTag` where Id=?");
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x001812EC File Offset: 0x0017F4EC
		public static RogueWeekTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeekTagById.HandleId, ConfigRogueWeekTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeekTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueWeekTag?(RogueWeekTag.GetRootAsRogueWeekTag(configBuffer));
				}
			}
			ConfigRogueWeekTagById.LogPair.Clear();
			ConfigRogueWeekTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueWeekTagById.HandleId, 1, p0Id, ConfigRogueWeekTagById.LogPair) || ConfigCommon.Step(ConfigRogueWeekTagById.HandleId, true, ConfigRogueWeekTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueWeekTagById.HandleId, ConfigRogueWeekTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeekTagById.HandleId, 0, ConfigRogueWeekTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueWeekTagById.HandleId, ConfigRogueWeekTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueWeekTag rootAsRogueWeekTag = RogueWeekTag.GetRootAsRogueWeekTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeekTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueWeekTagById.HandleId, ConfigRogueWeekTagById.LogPair);
			return new RogueWeekTag?(rootAsRogueWeekTag);
		}

		// Token: 0x04003C23 RID: 15395
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003C24 RID: 15396
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003C25 RID: 15397
		private const string TABLE = "RogueWeekTag";

		// Token: 0x04003C26 RID: 15398
		private const string COMMAND = "select BinData from `RogueWeekTag` where Id=?";

		// Token: 0x04003C27 RID: 15399
		private const string KEY_PREFIX = "RogueWeekTagById";

		// Token: 0x04003C28 RID: 15400
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C29 RID: 15401
		private static int HandleId;
	}
}
