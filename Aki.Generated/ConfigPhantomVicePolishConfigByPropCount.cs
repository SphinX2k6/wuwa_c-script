using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B8 RID: 1720
	public class ConfigPhantomVicePolishConfigByPropCount : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002860 RID: 10336 RVA: 0x0013DE57 File Offset: 0x0013C057
		static ConfigPhantomVicePolishConfigByPropCount()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomVicePolishConfigByPropCount.CreateStaticDefaultValue), new Action(ConfigPhantomVicePolishConfigByPropCount.ResetStaticDefaultValue));
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x0013DE78 File Offset: 0x0013C078
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

		// Token: 0x06002862 RID: 10338 RVA: 0x0013DEF7 File Offset: 0x0013C0F7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomVicePolishConfigByPropCount.LogPair = null;
			ConfigPhantomVicePolishConfigByPropCount.HandleId = 0;
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x0013DF05 File Offset: 0x0013C105
		public static void Init()
		{
			ConfigPhantomVicePolishConfigByPropCount.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomVicePolishConfigByPropCount.HandleId, "db_phantom.db", "select BinData from `PhantomVicePolishConfig` where PropCount=?");
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0013DF20 File Offset: 0x0013C120
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

		// Token: 0x04002EEE RID: 12014
		private const string DB = "db_phantom.db";

		// Token: 0x04002EEF RID: 12015
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EF0 RID: 12016
		private const string TABLE = "PhantomVicePolishConfig";

		// Token: 0x04002EF1 RID: 12017
		private const string COMMAND = "select BinData from `PhantomVicePolishConfig` where PropCount=?";

		// Token: 0x04002EF2 RID: 12018
		private const string KEY_PREFIX = "PhantomVicePolishConfigByPropCount";

		// Token: 0x04002EF3 RID: 12019
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EF4 RID: 12020
		private static int HandleId;
	}
}
