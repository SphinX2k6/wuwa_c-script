using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BB RID: 1723
	public class ConfigPhantomLevelByGroupIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002872 RID: 10354 RVA: 0x00141C6B File Offset: 0x0013FE6B
		static ConfigPhantomLevelByGroupIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomLevelByGroupIdAndLevel.CreateStaticDefaultValue), new Action(ConfigPhantomLevelByGroupIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00141C8C File Offset: 0x0013FE8C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomLevelByGroupIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomLevelByGroupIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomLevel` where GroupId=? AND Level=?")
			});
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00141D0B File Offset: 0x0013FF0B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomLevelByGroupIdAndLevel.LogPair = null;
			ConfigPhantomLevelByGroupIdAndLevel.HandleId = 0;
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00141D19 File Offset: 0x0013FF19
		public static void Init()
		{
			ConfigPhantomLevelByGroupIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomLevelByGroupIdAndLevel.HandleId, "db_phantom.db", "select BinData from `PhantomLevel` where GroupId=? AND Level=?");
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00141D34 File Offset: 0x0013FF34
		public static PhantomLevel? GetConfig(int p0GroupId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomLevelByGroupIdAndLevel.HandleId, ConfigPhantomLevelByGroupIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomLevelByGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomLevel?(PhantomLevel.GetRootAsPhantomLevel(configBuffer));
				}
			}
			ConfigPhantomLevelByGroupIdAndLevel.LogPair.Clear();
			ConfigPhantomLevelByGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			ConfigPhantomLevelByGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigPhantomLevelByGroupIdAndLevel.HandleId, 1, p0GroupId, ConfigPhantomLevelByGroupIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigPhantomLevelByGroupIdAndLevel.HandleId, 2, p1Level, ConfigPhantomLevelByGroupIdAndLevel.LogPair) || ConfigCommon.Step(ConfigPhantomLevelByGroupIdAndLevel.HandleId, true, ConfigPhantomLevelByGroupIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomLevelByGroupIdAndLevel.HandleId, ConfigPhantomLevelByGroupIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomLevelByGroupIdAndLevel.HandleId, 0, ConfigPhantomLevelByGroupIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomLevelByGroupIdAndLevel.HandleId, ConfigPhantomLevelByGroupIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomLevel rootAsPhantomLevel = PhantomLevel.GetRootAsPhantomLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomLevelByGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomLevelByGroupIdAndLevel.HandleId, ConfigPhantomLevelByGroupIdAndLevel.LogPair);
			return new PhantomLevel?(rootAsPhantomLevel);
		}

		// Token: 0x04002F03 RID: 12035
		private const string DB = "db_phantom.db";

		// Token: 0x04002F04 RID: 12036
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F05 RID: 12037
		private const string TABLE = "PhantomLevel";

		// Token: 0x04002F06 RID: 12038
		private const string COMMAND = "select BinData from `PhantomLevel` where GroupId=? AND Level=?";

		// Token: 0x04002F07 RID: 12039
		private const string KEY_PREFIX = "PhantomLevelByGroupIdAndLevel";

		// Token: 0x04002F08 RID: 12040
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F09 RID: 12041
		private static int HandleId;
	}
}
