using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000223 RID: 547
	public class ConfigDollGrabItemComboCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CD5 RID: 3285 RVA: 0x000A5ADB File Offset: 0x000A3CDB
		static ConfigDollGrabItemComboCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDollGrabItemComboCsvById.CreateStaticDefaultValue), new Action(ConfigDollGrabItemComboCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x000A5AFC File Offset: 0x000A3CFC
		public static void CreateStaticDefaultValue()
		{
			ConfigDollGrabItemComboCsvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDollGrabItemComboCsvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dollgrabitemcombocsv.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/j.夹娃娃机物品组合/*.csv*"),
				new ValueTuple<string, object>("表名", "DollGrabItemComboCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `DollGrabItemComboCsv` where Id=?")
			});
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x000A5B7B File Offset: 0x000A3D7B
		public static void ResetStaticDefaultValue()
		{
			ConfigDollGrabItemComboCsvById.LogPair = null;
			ConfigDollGrabItemComboCsvById.HandleId = 0;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x000A5B89 File Offset: 0x000A3D89
		public static void Init()
		{
			ConfigDollGrabItemComboCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigDollGrabItemComboCsvById.HandleId, "db_dollgrabitemcombocsv.db", "select BinData from `DollGrabItemComboCsv` where Id=?");
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x000A5BA4 File Offset: 0x000A3DA4
		public static DollGrabItemComboCsv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDollGrabItemComboCsvById.HandleId, ConfigDollGrabItemComboCsvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DollGrabItemComboCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DollGrabItemComboCsv?(DollGrabItemComboCsv.GetRootAsDollGrabItemComboCsv(configBuffer));
				}
			}
			ConfigDollGrabItemComboCsvById.LogPair.Clear();
			ConfigDollGrabItemComboCsvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDollGrabItemComboCsvById.HandleId, 1, p0Id, ConfigDollGrabItemComboCsvById.LogPair) || ConfigCommon.Step(ConfigDollGrabItemComboCsvById.HandleId, true, ConfigDollGrabItemComboCsvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDollGrabItemComboCsvById.HandleId, ConfigDollGrabItemComboCsvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDollGrabItemComboCsvById.HandleId, 0, ConfigDollGrabItemComboCsvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDollGrabItemComboCsvById.HandleId, ConfigDollGrabItemComboCsvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DollGrabItemComboCsv rootAsDollGrabItemComboCsv = DollGrabItemComboCsv.GetRootAsDollGrabItemComboCsv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DollGrabItemComboCsvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDollGrabItemComboCsvById.HandleId, ConfigDollGrabItemComboCsvById.LogPair);
			return new DollGrabItemComboCsv?(rootAsDollGrabItemComboCsv);
		}

		// Token: 0x04000ED9 RID: 3801
		private const string DB = "db_dollgrabitemcombocsv.db";

		// Token: 0x04000EDA RID: 3802
		private const string FILE = "k.可视化编辑/c.Csv/j.夹娃娃机物品组合/*.csv*";

		// Token: 0x04000EDB RID: 3803
		private const string TABLE = "DollGrabItemComboCsv";

		// Token: 0x04000EDC RID: 3804
		private const string COMMAND = "select BinData from `DollGrabItemComboCsv` where Id=?";

		// Token: 0x04000EDD RID: 3805
		private const string KEY_PREFIX = "DollGrabItemComboCsvById";

		// Token: 0x04000EDE RID: 3806
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EDF RID: 3807
		private static int HandleId;
	}
}
