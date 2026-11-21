using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000224 RID: 548
	public class ConfigDollGrabItemsCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CDB RID: 3291 RVA: 0x000A5D24 File Offset: 0x000A3F24
		static ConfigDollGrabItemsCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDollGrabItemsCsvById.CreateStaticDefaultValue), new Action(ConfigDollGrabItemsCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x000A5D44 File Offset: 0x000A3F44
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

		// Token: 0x06000CDD RID: 3293 RVA: 0x000A5DC3 File Offset: 0x000A3FC3
		public static void ResetStaticDefaultValue()
		{
			ConfigDollGrabItemsCsvById.LogPair = null;
			ConfigDollGrabItemsCsvById.HandleId = 0;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x000A5DD1 File Offset: 0x000A3FD1
		public static void Init()
		{
			ConfigDollGrabItemsCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigDollGrabItemsCsvById.HandleId, "db_dollgrabitemscsv.db", "select BinData from `DollGrabItemsCsv` where Id=?");
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000A5DEC File Offset: 0x000A3FEC
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

		// Token: 0x04000EE0 RID: 3808
		private const string DB = "db_dollgrabitemscsv.db";

		// Token: 0x04000EE1 RID: 3809
		private const string FILE = "k.可视化编辑/c.Csv/j.夹娃娃机物品/*.csv*";

		// Token: 0x04000EE2 RID: 3810
		private const string TABLE = "DollGrabItemsCsv";

		// Token: 0x04000EE3 RID: 3811
		private const string COMMAND = "select BinData from `DollGrabItemsCsv` where Id=?";

		// Token: 0x04000EE4 RID: 3812
		private const string KEY_PREFIX = "DollGrabItemsCsvById";

		// Token: 0x04000EE5 RID: 3813
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EE6 RID: 3814
		private static int HandleId;
	}
}
