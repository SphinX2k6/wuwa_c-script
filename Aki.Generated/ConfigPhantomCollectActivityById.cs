using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068B RID: 1675
	public class ConfigPhantomCollectActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002752 RID: 10066 RVA: 0x001380BC File Offset: 0x001362BC
		static ConfigPhantomCollectActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomCollectActivityById.CreateStaticDefaultValue), new Action(ConfigPhantomCollectActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x001380DC File Offset: 0x001362DC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomCollectActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomCollectActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantomcollectactivity.db"),
				new ValueTuple<string, object>("文件", "s.声骸收集活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomCollectActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomCollectActivity` where Id=?")
			});
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x0013815B File Offset: 0x0013635B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomCollectActivityById.LogPair = null;
			ConfigPhantomCollectActivityById.HandleId = 0;
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00138169 File Offset: 0x00136369
		public static void Init()
		{
			ConfigPhantomCollectActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomCollectActivityById.HandleId, "db_phantomcollectactivity.db", "select BinData from `PhantomCollectActivity` where Id=?");
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00138184 File Offset: 0x00136384
		public static PhantomCollectActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomCollectActivityById.HandleId, ConfigPhantomCollectActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCollectActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomCollectActivity?(PhantomCollectActivity.GetRootAsPhantomCollectActivity(configBuffer));
				}
			}
			ConfigPhantomCollectActivityById.LogPair.Clear();
			ConfigPhantomCollectActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomCollectActivityById.HandleId, 1, p0Id, ConfigPhantomCollectActivityById.LogPair) || ConfigCommon.Step(ConfigPhantomCollectActivityById.HandleId, true, ConfigPhantomCollectActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomCollectActivityById.HandleId, ConfigPhantomCollectActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomCollectActivityById.HandleId, 0, ConfigPhantomCollectActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomCollectActivityById.HandleId, ConfigPhantomCollectActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomCollectActivity rootAsPhantomCollectActivity = PhantomCollectActivity.GetRootAsPhantomCollectActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCollectActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomCollectActivityById.HandleId, ConfigPhantomCollectActivityById.LogPair);
			return new PhantomCollectActivity?(rootAsPhantomCollectActivity);
		}

		// Token: 0x04002DB3 RID: 11699
		private const string DB = "db_phantomcollectactivity.db";

		// Token: 0x04002DB4 RID: 11700
		private const string FILE = "s.声骸收集活动.xlsx";

		// Token: 0x04002DB5 RID: 11701
		private const string TABLE = "PhantomCollectActivity";

		// Token: 0x04002DB6 RID: 11702
		private const string COMMAND = "select BinData from `PhantomCollectActivity` where Id=?";

		// Token: 0x04002DB7 RID: 11703
		private const string KEY_PREFIX = "PhantomCollectActivityById";

		// Token: 0x04002DB8 RID: 11704
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DB9 RID: 11705
		private static int HandleId;
	}
}
