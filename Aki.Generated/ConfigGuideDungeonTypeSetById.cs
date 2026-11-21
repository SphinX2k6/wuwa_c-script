using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D2 RID: 978
	public class ConfigGuideDungeonTypeSetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016F3 RID: 5875 RVA: 0x000DECC5 File Offset: 0x000DCEC5
		static ConfigGuideDungeonTypeSetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDungeonTypeSetById.CreateStaticDefaultValue), new Action(ConfigGuideDungeonTypeSetById.ResetStaticDefaultValue));
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000DECE4 File Offset: 0x000DCEE4
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideDungeonTypeSetById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideDungeonTypeSetById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideDungeonTypeSet"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideDungeonTypeSet` where Id=?")
			});
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x000DED63 File Offset: 0x000DCF63
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDungeonTypeSetById.LogPair = null;
			ConfigGuideDungeonTypeSetById.HandleId = 0;
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x000DED71 File Offset: 0x000DCF71
		public static void Init()
		{
			ConfigGuideDungeonTypeSetById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDungeonTypeSetById.HandleId, "db_guide_new.db", "select BinData from `GuideDungeonTypeSet` where Id=?");
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x000DED8C File Offset: 0x000DCF8C
		public static GuideDungeonTypeSet? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideDungeonTypeSetById.HandleId, ConfigGuideDungeonTypeSetById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideDungeonTypeSetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideDungeonTypeSet?(GuideDungeonTypeSet.GetRootAsGuideDungeonTypeSet(configBuffer));
				}
			}
			ConfigGuideDungeonTypeSetById.LogPair.Clear();
			ConfigGuideDungeonTypeSetById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuideDungeonTypeSetById.HandleId, 1, p0Id, ConfigGuideDungeonTypeSetById.LogPair) || ConfigCommon.Step(ConfigGuideDungeonTypeSetById.HandleId, true, ConfigGuideDungeonTypeSetById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideDungeonTypeSetById.HandleId, ConfigGuideDungeonTypeSetById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideDungeonTypeSetById.HandleId, 0, ConfigGuideDungeonTypeSetById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideDungeonTypeSetById.HandleId, ConfigGuideDungeonTypeSetById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideDungeonTypeSet rootAsGuideDungeonTypeSet = GuideDungeonTypeSet.GetRootAsGuideDungeonTypeSet(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideDungeonTypeSetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideDungeonTypeSetById.HandleId, ConfigGuideDungeonTypeSetById.LogPair);
			return new GuideDungeonTypeSet?(rootAsGuideDungeonTypeSet);
		}

		// Token: 0x04001AA2 RID: 6818
		private const string DB = "db_guide_new.db";

		// Token: 0x04001AA3 RID: 6819
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001AA4 RID: 6820
		private const string TABLE = "GuideDungeonTypeSet";

		// Token: 0x04001AA5 RID: 6821
		private const string COMMAND = "select BinData from `GuideDungeonTypeSet` where Id=?";

		// Token: 0x04001AA6 RID: 6822
		private const string KEY_PREFIX = "GuideDungeonTypeSetById";

		// Token: 0x04001AA7 RID: 6823
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AA8 RID: 6824
		private static int HandleId;
	}
}
