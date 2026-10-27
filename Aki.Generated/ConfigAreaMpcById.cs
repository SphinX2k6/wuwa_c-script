using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A7 RID: 167
	public class ConfigAreaMpcById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003EB RID: 1003 RVA: 0x0006FCDC File Offset: 0x0006DEDC
		static ConfigAreaMpcById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaMpcById.CreateStaticDefaultValue), new Action(ConfigAreaMpcById.ResetStaticDefaultValue));
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0006FCFC File Offset: 0x0006DEFC
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaMpcById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaMpcById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areampc.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/q.区域Mpc/*.csv*"),
				new ValueTuple<string, object>("表名", "AreaMpc"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaMpc` where Id=?")
			});
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0006FD7B File Offset: 0x0006DF7B
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaMpcById.LogPair = null;
			ConfigAreaMpcById.HandleId = 0;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0006FD89 File Offset: 0x0006DF89
		public static void Init()
		{
			ConfigAreaMpcById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaMpcById.HandleId, "db_areampc.db", "select BinData from `AreaMpc` where Id=?");
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0006FDA4 File Offset: 0x0006DFA4
		public static AreaMpc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaMpcById.HandleId, ConfigAreaMpcById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaMpcById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AreaMpc?(AreaMpc.GetRootAsAreaMpc(configBuffer));
				}
			}
			ConfigAreaMpcById.LogPair.Clear();
			ConfigAreaMpcById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAreaMpcById.HandleId, 1, p0Id, ConfigAreaMpcById.LogPair) || ConfigCommon.Step(ConfigAreaMpcById.HandleId, true, ConfigAreaMpcById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaMpcById.HandleId, ConfigAreaMpcById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaMpcById.HandleId, 0, ConfigAreaMpcById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaMpcById.HandleId, ConfigAreaMpcById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaMpc rootAsAreaMpc = AreaMpc.GetRootAsAreaMpc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AreaMpcById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaMpcById.HandleId, ConfigAreaMpcById.LogPair);
			return new AreaMpc?(rootAsAreaMpc);
		}

		// Token: 0x04000475 RID: 1141
		private const string DB = "db_areampc.db";

		// Token: 0x04000476 RID: 1142
		private const string FILE = "k.可视化编辑/c.Csv/q.区域Mpc/*.csv*";

		// Token: 0x04000477 RID: 1143
		private const string TABLE = "AreaMpc";

		// Token: 0x04000478 RID: 1144
		private const string COMMAND = "select BinData from `AreaMpc` where Id=?";

		// Token: 0x04000479 RID: 1145
		private const string KEY_PREFIX = "AreaMpcById";

		// Token: 0x0400047A RID: 1146
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400047B RID: 1147
		private static int HandleId;
	}
}
