using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BC RID: 956
	public class ConfigGuideDungeonTypeSetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600166F RID: 5743 RVA: 0x000D8571 File Offset: 0x000D6771
		static ConfigGuideDungeonTypeSetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDungeonTypeSetById.CreateStaticDefaultValue), new Action(ConfigGuideDungeonTypeSetById.ResetStaticDefaultValue));
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x000D8590 File Offset: 0x000D6790
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

		// Token: 0x06001671 RID: 5745 RVA: 0x000D860F File Offset: 0x000D680F
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDungeonTypeSetById.LogPair = null;
			ConfigGuideDungeonTypeSetById.HandleId = 0;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x000D861D File Offset: 0x000D681D
		public static void Init()
		{
			ConfigGuideDungeonTypeSetById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDungeonTypeSetById.HandleId, "db_guide_new.db", "select BinData from `GuideDungeonTypeSet` where Id=?");
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x000D8638 File Offset: 0x000D6838
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

		// Token: 0x04001A08 RID: 6664
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A09 RID: 6665
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A0A RID: 6666
		private const string TABLE = "GuideDungeonTypeSet";

		// Token: 0x04001A0B RID: 6667
		private const string COMMAND = "select BinData from `GuideDungeonTypeSet` where Id=?";

		// Token: 0x04001A0C RID: 6668
		private const string KEY_PREFIX = "GuideDungeonTypeSetById";

		// Token: 0x04001A0D RID: 6669
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A0E RID: 6670
		private static int HandleId;
	}
}
