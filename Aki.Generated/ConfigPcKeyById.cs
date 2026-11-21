using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000663 RID: 1635
	public class ConfigPcKeyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002662 RID: 9826 RVA: 0x001361EB File Offset: 0x001343EB
		static ConfigPcKeyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPcKeyById.CreateStaticDefaultValue), new Action(ConfigPcKeyById.ResetStaticDefaultValue));
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x0013620C File Offset: 0x0013440C
		public static void CreateStaticDefaultValue()
		{
			ConfigPcKeyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPcKeyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_key.db"),
				new ValueTuple<string, object>("文件", "a.按键.xlsx"),
				new ValueTuple<string, object>("表名", "PcKey"),
				new ValueTuple<string, object>("语句", "select BinData from `PcKey` where Id=?")
			});
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x0013628B File Offset: 0x0013448B
		public static void ResetStaticDefaultValue()
		{
			ConfigPcKeyById.LogPair = null;
			ConfigPcKeyById.HandleId = 0;
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00136299 File Offset: 0x00134499
		public static void Init()
		{
			ConfigPcKeyById.HandleId = ConfigCommon.InitDataStatement(ConfigPcKeyById.HandleId, "db_key.db", "select BinData from `PcKey` where Id=?");
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x001362B4 File Offset: 0x001344B4
		public static PcKey? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPcKeyById.HandleId, ConfigPcKeyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PcKeyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PcKey?(PcKey.GetRootAsPcKey(configBuffer));
				}
			}
			ConfigPcKeyById.LogPair.Clear();
			ConfigPcKeyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPcKeyById.HandleId, 1, p0Id, ConfigPcKeyById.LogPair) || ConfigCommon.Step(ConfigPcKeyById.HandleId, true, ConfigPcKeyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPcKeyById.HandleId, ConfigPcKeyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPcKeyById.HandleId, 0, ConfigPcKeyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPcKeyById.HandleId, ConfigPcKeyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PcKey rootAsPcKey = PcKey.GetRootAsPcKey(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PcKeyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPcKeyById.HandleId, ConfigPcKeyById.LogPair);
			return new PcKey?(rootAsPcKey);
		}

		// Token: 0x04002C9B RID: 11419
		private const string DB = "db_key.db";

		// Token: 0x04002C9C RID: 11420
		private const string FILE = "a.按键.xlsx";

		// Token: 0x04002C9D RID: 11421
		private const string TABLE = "PcKey";

		// Token: 0x04002C9E RID: 11422
		private const string COMMAND = "select BinData from `PcKey` where Id=?";

		// Token: 0x04002C9F RID: 11423
		private const string KEY_PREFIX = "PcKeyById";

		// Token: 0x04002CA0 RID: 11424
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CA1 RID: 11425
		private static int HandleId;
	}
}
