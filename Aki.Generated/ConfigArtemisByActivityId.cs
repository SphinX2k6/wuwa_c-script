using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B1 RID: 177
	public class ConfigArtemisByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x000712CC File Offset: 0x0006F4CC
		static ConfigArtemisByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigArtemisByActivityId.CreateStaticDefaultValue), new Action(ConfigArtemisByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000712EC File Offset: 0x0006F4EC
		public static void CreateStaticDefaultValue()
		{
			ConfigArtemisByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigArtemisByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_artemis.db"),
				new ValueTuple<string, object>("文件", "a.爱弥斯预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "Artemis"),
				new ValueTuple<string, object>("语句", "select BinData from `Artemis` where ActivityId=?")
			});
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0007136B File Offset: 0x0006F56B
		public static void ResetStaticDefaultValue()
		{
			ConfigArtemisByActivityId.LogPair = null;
			ConfigArtemisByActivityId.HandleId = 0;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00071379 File Offset: 0x0006F579
		public static void Init()
		{
			ConfigArtemisByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigArtemisByActivityId.HandleId, "db_artemis.db", "select BinData from `Artemis` where ActivityId=?");
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00071394 File Offset: 0x0006F594
		[NullableContext(2)]
		public static IReadOnlyList<Artemis> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigArtemisByActivityId.HandleId, ConfigArtemisByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ArtemisByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<Artemis> readOnlyList = (IReadOnlyList<Artemis>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigArtemisByActivityId.LogPair.Clear();
			ConfigArtemisByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigArtemisByActivityId.HandleId, 1, p0ActivityId, ConfigArtemisByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigArtemisByActivityId.HandleId, ConfigArtemisByActivityId.LogPair);
				return null;
			}
			List<Artemis> list = new List<Artemis>();
			while (ConfigCommon.Step(ConfigArtemisByActivityId.HandleId, false, ConfigArtemisByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigArtemisByActivityId.HandleId, 0, ConfigArtemisByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigArtemisByActivityId.HandleId, ConfigArtemisByActivityId.LogPair);
					return null;
				}
				Artemis rootAsArtemis = Artemis.GetRootAsArtemis(new ByteBuffer(item2));
				list.Add(rootAsArtemis);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ArtemisByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigArtemisByActivityId.HandleId, ConfigArtemisByActivityId.LogPair);
			return list;
		}

		// Token: 0x040004BB RID: 1211
		private const string DB = "db_artemis.db";

		// Token: 0x040004BC RID: 1212
		private const string FILE = "a.爱弥斯预热签到活动.xlsx";

		// Token: 0x040004BD RID: 1213
		private const string TABLE = "Artemis";

		// Token: 0x040004BE RID: 1214
		private const string COMMAND = "select BinData from `Artemis` where ActivityId=?";

		// Token: 0x040004BF RID: 1215
		private const string KEY_PREFIX = "ArtemisByActivityId";

		// Token: 0x040004C0 RID: 1216
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004C1 RID: 1217
		private static int HandleId;
	}
}
