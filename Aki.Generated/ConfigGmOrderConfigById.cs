using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A4 RID: 932
	public class ConfigGmOrderConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015DF RID: 5599 RVA: 0x000D52A7 File Offset: 0x000D34A7
		static ConfigGmOrderConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmOrderConfigById.CreateStaticDefaultValue), new Action(ConfigGmOrderConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x000D52C8 File Offset: 0x000D34C8
		public static void CreateStaticDefaultValue()
		{
			ConfigGmOrderConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmOrderConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmOrderConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GmOrderConfig` where Id=?")
			});
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x000D5347 File Offset: 0x000D3547
		public static void ResetStaticDefaultValue()
		{
			ConfigGmOrderConfigById.LogPair = null;
			ConfigGmOrderConfigById.HandleId = 0;
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x000D5355 File Offset: 0x000D3555
		public static void Init()
		{
			ConfigGmOrderConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGmOrderConfigById.HandleId, "db_gm.db", "select BinData from `GmOrderConfig` where Id=?");
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x000D5370 File Offset: 0x000D3570
		public static GmOrderConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmOrderConfigById.HandleId, ConfigGmOrderConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmOrderConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GmOrderConfig?(GmOrderConfig.GetRootAsGmOrderConfig(configBuffer));
				}
			}
			ConfigGmOrderConfigById.LogPair.Clear();
			ConfigGmOrderConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGmOrderConfigById.HandleId, 1, p0Id, ConfigGmOrderConfigById.LogPair) || ConfigCommon.Step(ConfigGmOrderConfigById.HandleId, true, ConfigGmOrderConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGmOrderConfigById.HandleId, ConfigGmOrderConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmOrderConfigById.HandleId, 0, ConfigGmOrderConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGmOrderConfigById.HandleId, ConfigGmOrderConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GmOrderConfig rootAsGmOrderConfig = GmOrderConfig.GetRootAsGmOrderConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmOrderConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGmOrderConfigById.HandleId, ConfigGmOrderConfigById.LogPair);
			return new GmOrderConfig?(rootAsGmOrderConfig);
		}

		// Token: 0x04001960 RID: 6496
		private const string DB = "db_gm.db";

		// Token: 0x04001961 RID: 6497
		private const string FILE = "g.GM.xlsx";

		// Token: 0x04001962 RID: 6498
		private const string TABLE = "GmOrderConfig";

		// Token: 0x04001963 RID: 6499
		private const string COMMAND = "select BinData from `GmOrderConfig` where Id=?";

		// Token: 0x04001964 RID: 6500
		private const string KEY_PREFIX = "GmOrderConfigById";

		// Token: 0x04001965 RID: 6501
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001966 RID: 6502
		private static int HandleId;
	}
}
