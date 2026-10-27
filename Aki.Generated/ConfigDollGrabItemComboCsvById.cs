using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000211 RID: 529
	public class ConfigDollGrabItemComboCsvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x0009FBA3 File Offset: 0x0009DDA3
		static ConfigDollGrabItemComboCsvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDollGrabItemComboCsvById.CreateStaticDefaultValue), new Action(ConfigDollGrabItemComboCsvById.ResetStaticDefaultValue));
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0009FBC4 File Offset: 0x0009DDC4
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

		// Token: 0x06000C6B RID: 3179 RVA: 0x0009FC43 File Offset: 0x0009DE43
		public static void ResetStaticDefaultValue()
		{
			ConfigDollGrabItemComboCsvById.LogPair = null;
			ConfigDollGrabItemComboCsvById.HandleId = 0;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0009FC51 File Offset: 0x0009DE51
		public static void Init()
		{
			ConfigDollGrabItemComboCsvById.HandleId = ConfigCommon.InitDataStatement(ConfigDollGrabItemComboCsvById.HandleId, "db_dollgrabitemcombocsv.db", "select BinData from `DollGrabItemComboCsv` where Id=?");
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0009FC6C File Offset: 0x0009DE6C
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

		// Token: 0x04000E5B RID: 3675
		private const string DB = "db_dollgrabitemcombocsv.db";

		// Token: 0x04000E5C RID: 3676
		private const string FILE = "k.可视化编辑/c.Csv/j.夹娃娃机物品组合/*.csv*";

		// Token: 0x04000E5D RID: 3677
		private const string TABLE = "DollGrabItemComboCsv";

		// Token: 0x04000E5E RID: 3678
		private const string COMMAND = "select BinData from `DollGrabItemComboCsv` where Id=?";

		// Token: 0x04000E5F RID: 3679
		private const string KEY_PREFIX = "DollGrabItemComboCsvById";

		// Token: 0x04000E60 RID: 3680
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E61 RID: 3681
		private static int HandleId;
	}
}
