using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A3 RID: 1699
	public class ConfigPhantomLevelByGroupIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027E2 RID: 10210 RVA: 0x0013B1EF File Offset: 0x001393EF
		static ConfigPhantomLevelByGroupIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomLevelByGroupIdAndLevel.CreateStaticDefaultValue), new Action(ConfigPhantomLevelByGroupIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x0013B210 File Offset: 0x00139410
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

		// Token: 0x060027E4 RID: 10212 RVA: 0x0013B28F File Offset: 0x0013948F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomLevelByGroupIdAndLevel.LogPair = null;
			ConfigPhantomLevelByGroupIdAndLevel.HandleId = 0;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x0013B29D File Offset: 0x0013949D
		public static void Init()
		{
			ConfigPhantomLevelByGroupIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomLevelByGroupIdAndLevel.HandleId, "db_phantom.db", "select BinData from `PhantomLevel` where GroupId=? AND Level=?");
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x0013B2B8 File Offset: 0x001394B8
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

		// Token: 0x04002E5B RID: 11867
		private const string DB = "db_phantom.db";

		// Token: 0x04002E5C RID: 11868
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E5D RID: 11869
		private const string TABLE = "PhantomLevel";

		// Token: 0x04002E5E RID: 11870
		private const string COMMAND = "select BinData from `PhantomLevel` where GroupId=? AND Level=?";

		// Token: 0x04002E5F RID: 11871
		private const string KEY_PREFIX = "PhantomLevelByGroupIdAndLevel";

		// Token: 0x04002E60 RID: 11872
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E61 RID: 11873
		private static int HandleId;
	}
}
