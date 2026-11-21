using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051A RID: 1306
	public class ConfigMainLineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EA7 RID: 7847 RVA: 0x00109FEF File Offset: 0x001081EF
		static ConfigMainLineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainLineById.CreateStaticDefaultValue), new Action(ConfigMainLineById.ResetStaticDefaultValue));
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0010A010 File Offset: 0x00108210
		public static void CreateStaticDefaultValue()
		{
			ConfigMainLineById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainLineById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "MainLine"),
				new ValueTuple<string, object>("语句", "select BinData from `MainLine` where Id=?")
			});
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0010A08F File Offset: 0x0010828F
		public static void ResetStaticDefaultValue()
		{
			ConfigMainLineById.LogPair = null;
			ConfigMainLineById.HandleId = 0;
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0010A09D File Offset: 0x0010829D
		public static void Init()
		{
			ConfigMainLineById.HandleId = ConfigCommon.InitDataStatement(ConfigMainLineById.HandleId, "db_moonchasing.db", "select BinData from `MainLine` where Id=?");
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0010A0B8 File Offset: 0x001082B8
		public static MainLine? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainLineById.HandleId, ConfigMainLineById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainLineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MainLine?(MainLine.GetRootAsMainLine(configBuffer));
				}
			}
			ConfigMainLineById.LogPair.Clear();
			ConfigMainLineById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMainLineById.HandleId, 1, p0Id, ConfigMainLineById.LogPair) || ConfigCommon.Step(ConfigMainLineById.HandleId, true, ConfigMainLineById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMainLineById.HandleId, ConfigMainLineById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainLineById.HandleId, 0, ConfigMainLineById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMainLineById.HandleId, ConfigMainLineById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MainLine rootAsMainLine = MainLine.GetRootAsMainLine(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainLineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMainLineById.HandleId, ConfigMainLineById.LogPair);
			return new MainLine?(rootAsMainLine);
		}

		// Token: 0x0400239A RID: 9114
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400239B RID: 9115
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400239C RID: 9116
		private const string TABLE = "MainLine";

		// Token: 0x0400239D RID: 9117
		private const string COMMAND = "select BinData from `MainLine` where Id=?";

		// Token: 0x0400239E RID: 9118
		private const string KEY_PREFIX = "MainLineById";

		// Token: 0x0400239F RID: 9119
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023A0 RID: 9120
		private static int HandleId;
	}
}
