using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A7 RID: 679
	public class ConfigExploreTypeByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FEF RID: 4079 RVA: 0x000B3800 File Offset: 0x000B1A00
		static ConfigExploreTypeByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreTypeByType.CreateStaticDefaultValue), new Action(ConfigExploreTypeByType.ResetStaticDefaultValue));
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x000B3820 File Offset: 0x000B1A20
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreTypeByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreTypeByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreType"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreType` where ExploreTypeKey=?")
			});
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x000B389F File Offset: 0x000B1A9F
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreTypeByType.LogPair = null;
			ConfigExploreTypeByType.HandleId = 0;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x000B38AD File Offset: 0x000B1AAD
		public static void Init()
		{
			ConfigExploreTypeByType.HandleId = ConfigCommon.InitDataStatement(ConfigExploreTypeByType.HandleId, "db_explore_progress.db", "select BinData from `ExploreType` where ExploreTypeKey=?");
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x000B38C8 File Offset: 0x000B1AC8
		public static ExploreType? GetConfig(int p0ExploreTypeKey, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreTypeByType.HandleId, ConfigExploreTypeByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ExploreTypeKey);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreType?(ExploreType.GetRootAsExploreType(configBuffer));
				}
			}
			ConfigExploreTypeByType.LogPair.Clear();
			ConfigExploreTypeByType.LogPair.Add(new ValueTuple<string, object>("ExploreTypeKey", p0ExploreTypeKey));
			if (!ConfigCommon.BindInt(ConfigExploreTypeByType.HandleId, 1, p0ExploreTypeKey, ConfigExploreTypeByType.LogPair) || ConfigCommon.Step(ConfigExploreTypeByType.HandleId, true, ConfigExploreTypeByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreTypeByType.HandleId, ConfigExploreTypeByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreTypeByType.HandleId, 0, ConfigExploreTypeByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreTypeByType.HandleId, ConfigExploreTypeByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreType rootAsExploreType = ExploreType.GetRootAsExploreType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ExploreTypeKey);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreTypeByType.HandleId, ConfigExploreTypeByType.LogPair);
			return new ExploreType?(rootAsExploreType);
		}

		// Token: 0x04001275 RID: 4725
		private const string DB = "db_explore_progress.db";

		// Token: 0x04001276 RID: 4726
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04001277 RID: 4727
		private const string TABLE = "ExploreType";

		// Token: 0x04001278 RID: 4728
		private const string COMMAND = "select BinData from `ExploreType` where ExploreTypeKey=?";

		// Token: 0x04001279 RID: 4729
		private const string KEY_PREFIX = "ExploreTypeByType";

		// Token: 0x0400127A RID: 4730
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400127B RID: 4731
		private static int HandleId;
	}
}
