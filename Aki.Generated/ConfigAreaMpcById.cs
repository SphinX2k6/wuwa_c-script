using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AF RID: 175
	public class ConfigAreaMpcById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600041B RID: 1051 RVA: 0x00074590 File Offset: 0x00072790
		static ConfigAreaMpcById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaMpcById.CreateStaticDefaultValue), new Action(ConfigAreaMpcById.ResetStaticDefaultValue));
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000745B0 File Offset: 0x000727B0
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

		// Token: 0x0600041D RID: 1053 RVA: 0x0007462F File Offset: 0x0007282F
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaMpcById.LogPair = null;
			ConfigAreaMpcById.HandleId = 0;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0007463D File Offset: 0x0007283D
		public static void Init()
		{
			ConfigAreaMpcById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaMpcById.HandleId, "db_areampc.db", "select BinData from `AreaMpc` where Id=?");
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00074658 File Offset: 0x00072858
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

		// Token: 0x040004AD RID: 1197
		private const string DB = "db_areampc.db";

		// Token: 0x040004AE RID: 1198
		private const string FILE = "k.可视化编辑/c.Csv/q.区域Mpc/*.csv*";

		// Token: 0x040004AF RID: 1199
		private const string TABLE = "AreaMpc";

		// Token: 0x040004B0 RID: 1200
		private const string COMMAND = "select BinData from `AreaMpc` where Id=?";

		// Token: 0x040004B1 RID: 1201
		private const string KEY_PREFIX = "AreaMpcById";

		// Token: 0x040004B2 RID: 1202
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004B3 RID: 1203
		private static int HandleId;
	}
}
