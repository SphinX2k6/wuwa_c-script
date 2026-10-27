using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000212 RID: 530
	public class ConfigDollGrabItemsCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C6F RID: 3183 RVA: 0x0009FDEC File Offset: 0x0009DFEC
		static ConfigDollGrabItemsCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDollGrabItemsCsvById.CreateStaticDefaultValue), new Action(ConfigDollGrabItemsCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0009FE0C File Offset: 0x0009E00C
		public static void CreateStaticDefaultValue()
		{
			ConfigDollGrabItemsCsvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDollGrabItemsCsvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dollgrabitemscsv.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/j.夹娃娃机物品/*.csv*"),
				new ValueTuple<string, object>("表名", "DollGrabItemsCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `DollGrabItemsCsv` where Id=?")
			});
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0009FE8B File Offset: 0x0009E08B
		public static void ResetStaticDefaultValue()
		{
			ConfigDollGrabItemsCsvById.LogPair = null;
			ConfigDollGrabItemsCsvById.HandleId = 0;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0009FE99 File Offset: 0x0009E099
		public static void Init()
		{
			ConfigDollGrabItemsCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigDollGrabItemsCsvById.HandleId, "db_dollgrabitemscsv.db", "select BinData from `DollGrabItemsCsv` where Id=?");
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0009FEB4 File Offset: 0x0009E0B4
		public static DollGrabItemsCsv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDollGrabItemsCsvById.HandleId, ConfigDollGrabItemsCsvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DollGrabItemsCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DollGrabItemsCsv?(DollGrabItemsCsv.GetRootAsDollGrabItemsCsv(configBuffer));
				}
			}
			ConfigDollGrabItemsCsvById.LogPair.Clear();
			ConfigDollGrabItemsCsvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDollGrabItemsCsvById.HandleId, 1, p0Id, ConfigDollGrabItemsCsvById.LogPair) || ConfigCommon.Step(ConfigDollGrabItemsCsvById.HandleId, true, ConfigDollGrabItemsCsvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDollGrabItemsCsvById.HandleId, ConfigDollGrabItemsCsvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDollGrabItemsCsvById.HandleId, 0, ConfigDollGrabItemsCsvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDollGrabItemsCsvById.HandleId, ConfigDollGrabItemsCsvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DollGrabItemsCsv rootAsDollGrabItemsCsv = DollGrabItemsCsv.GetRootAsDollGrabItemsCsv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DollGrabItemsCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDollGrabItemsCsvById.HandleId, ConfigDollGrabItemsCsvById.LogPair);
			return new DollGrabItemsCsv?(rootAsDollGrabItemsCsv);
		}

		// Token: 0x04000E62 RID: 3682
		private const string DB = "db_dollgrabitemscsv.db";

		// Token: 0x04000E63 RID: 3683
		private const string FILE = "k.可视化编辑/c.Csv/j.夹娃娃机物品/*.csv*";

		// Token: 0x04000E64 RID: 3684
		private const string TABLE = "DollGrabItemsCsv";

		// Token: 0x04000E65 RID: 3685
		private const string COMMAND = "select BinData from `DollGrabItemsCsv` where Id=?";

		// Token: 0x04000E66 RID: 3686
		private const string KEY_PREFIX = "DollGrabItemsCsvById";

		// Token: 0x04000E67 RID: 3687
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E68 RID: 3688
		private static int HandleId;
	}
}
