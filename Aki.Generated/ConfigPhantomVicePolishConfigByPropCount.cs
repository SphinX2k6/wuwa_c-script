using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D0 RID: 1744
	public class ConfigPhantomVicePolishConfigByPropCount : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028F0 RID: 10480 RVA: 0x001448D3 File Offset: 0x00142AD3
		static ConfigPhantomVicePolishConfigByPropCount()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomVicePolishConfigByPropCount.CreateStaticDefaultValue), new Action(ConfigPhantomVicePolishConfigByPropCount.ResetStaticDefaultValue));
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x001448F4 File Offset: 0x00142AF4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomVicePolishConfigByPropCount.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomVicePolishConfigByPropCount.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomVicePolishConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomVicePolishConfig` where PropCount=?")
			});
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00144973 File Offset: 0x00142B73
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomVicePolishConfigByPropCount.LogPair = null;
			ConfigPhantomVicePolishConfigByPropCount.HandleId = 0;
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00144981 File Offset: 0x00142B81
		public static void Init()
		{
			ConfigPhantomVicePolishConfigByPropCount.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomVicePolishConfigByPropCount.HandleId, "db_phantom.db", "select BinData from `PhantomVicePolishConfig` where PropCount=?");
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0014499C File Offset: 0x00142B9C
		public static PhantomVicePolishConfig? GetConfig(int p0PropCount, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomVicePolishConfigByPropCount.HandleId, ConfigPhantomVicePolishConfigByPropCount.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomVicePolishConfigByPropCount");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PropCount);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomVicePolishConfig?(PhantomVicePolishConfig.GetRootAsPhantomVicePolishConfig(configBuffer));
				}
			}
			ConfigPhantomVicePolishConfigByPropCount.LogPair.Clear();
			ConfigPhantomVicePolishConfigByPropCount.LogPair.Add(new ValueTuple<string, object>("PropCount", p0PropCount));
			if (!ConfigCommon.BindInt(ConfigPhantomVicePolishConfigByPropCount.HandleId, 1, p0PropCount, ConfigPhantomVicePolishConfigByPropCount.LogPair) || ConfigCommon.Step(ConfigPhantomVicePolishConfigByPropCount.HandleId, true, ConfigPhantomVicePolishConfigByPropCount.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomVicePolishConfigByPropCount.HandleId, ConfigPhantomVicePolishConfigByPropCount.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomVicePolishConfigByPropCount.HandleId, 0, ConfigPhantomVicePolishConfigByPropCount.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomVicePolishConfigByPropCount.HandleId, ConfigPhantomVicePolishConfigByPropCount.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomVicePolishConfig rootAsPhantomVicePolishConfig = PhantomVicePolishConfig.GetRootAsPhantomVicePolishConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomVicePolishConfigByPropCount");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PropCount);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomVicePolishConfigByPropCount.HandleId, ConfigPhantomVicePolishConfigByPropCount.LogPair);
			return new PhantomVicePolishConfig?(rootAsPhantomVicePolishConfig);
		}

		// Token: 0x04002F96 RID: 12182
		private const string DB = "db_phantom.db";

		// Token: 0x04002F97 RID: 12183
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F98 RID: 12184
		private const string TABLE = "PhantomVicePolishConfig";

		// Token: 0x04002F99 RID: 12185
		private const string COMMAND = "select BinData from `PhantomVicePolishConfig` where PropCount=?";

		// Token: 0x04002F9A RID: 12186
		private const string KEY_PREFIX = "PhantomVicePolishConfigByPropCount";

		// Token: 0x04002F9B RID: 12187
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F9C RID: 12188
		private static int HandleId;
	}
}
