using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000504 RID: 1284
	public class ConfigMainLineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E23 RID: 7715 RVA: 0x0010389B File Offset: 0x00101A9B
		static ConfigMainLineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainLineById.CreateStaticDefaultValue), new Action(ConfigMainLineById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x001038BC File Offset: 0x00101ABC
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

		// Token: 0x06001E25 RID: 7717 RVA: 0x0010393B File Offset: 0x00101B3B
		public static void ResetStaticDefaultValue()
		{
			ConfigMainLineById.LogPair = null;
			ConfigMainLineById.HandleId = 0;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00103949 File Offset: 0x00101B49
		public static void Init()
		{
			ConfigMainLineById.HandleId = ConfigCommon.InitDataStatement(ConfigMainLineById.HandleId, "db_moonchasing.db", "select BinData from `MainLine` where Id=?");
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00103964 File Offset: 0x00101B64
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

		// Token: 0x04002300 RID: 8960
		private const string DB = "db_moonchasing.db";

		// Token: 0x04002301 RID: 8961
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04002302 RID: 8962
		private const string TABLE = "MainLine";

		// Token: 0x04002303 RID: 8963
		private const string COMMAND = "select BinData from `MainLine` where Id=?";

		// Token: 0x04002304 RID: 8964
		private const string KEY_PREFIX = "MainLineById";

		// Token: 0x04002305 RID: 8965
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002306 RID: 8966
		private static int HandleId;
	}
}
