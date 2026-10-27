using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064B RID: 1611
	public class ConfigPcKeyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025D2 RID: 9682 RVA: 0x0012F76F File Offset: 0x0012D96F
		static ConfigPcKeyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPcKeyById.CreateStaticDefaultValue), new Action(ConfigPcKeyById.ResetStaticDefaultValue));
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x0012F790 File Offset: 0x0012D990
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

		// Token: 0x060025D4 RID: 9684 RVA: 0x0012F80F File Offset: 0x0012DA0F
		public static void ResetStaticDefaultValue()
		{
			ConfigPcKeyById.LogPair = null;
			ConfigPcKeyById.HandleId = 0;
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x0012F81D File Offset: 0x0012DA1D
		public static void Init()
		{
			ConfigPcKeyById.HandleId = ConfigCommon.InitDataStatement(ConfigPcKeyById.HandleId, "db_key.db", "select BinData from `PcKey` where Id=?");
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x0012F838 File Offset: 0x0012DA38
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

		// Token: 0x04002BF3 RID: 11251
		private const string DB = "db_key.db";

		// Token: 0x04002BF4 RID: 11252
		private const string FILE = "a.按键.xlsx";

		// Token: 0x04002BF5 RID: 11253
		private const string TABLE = "PcKey";

		// Token: 0x04002BF6 RID: 11254
		private const string COMMAND = "select BinData from `PcKey` where Id=?";

		// Token: 0x04002BF7 RID: 11255
		private const string KEY_PREFIX = "PcKeyById";

		// Token: 0x04002BF8 RID: 11256
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BF9 RID: 11257
		private static int HandleId;
	}
}
