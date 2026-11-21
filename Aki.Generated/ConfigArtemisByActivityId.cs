using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B9 RID: 185
	public class ConfigArtemisByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x00075B80 File Offset: 0x00073D80
		static ConfigArtemisByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigArtemisByActivityId.CreateStaticDefaultValue), new Action(ConfigArtemisByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00075BA0 File Offset: 0x00073DA0
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

		// Token: 0x06000459 RID: 1113 RVA: 0x00075C1F File Offset: 0x00073E1F
		public static void ResetStaticDefaultValue()
		{
			ConfigArtemisByActivityId.LogPair = null;
			ConfigArtemisByActivityId.HandleId = 0;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00075C2D File Offset: 0x00073E2D
		public static void Init()
		{
			ConfigArtemisByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigArtemisByActivityId.HandleId, "db_artemis.db", "select BinData from `Artemis` where ActivityId=?");
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00075C48 File Offset: 0x00073E48
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

		// Token: 0x040004F3 RID: 1267
		private const string DB = "db_artemis.db";

		// Token: 0x040004F4 RID: 1268
		private const string FILE = "a.爱弥斯预热签到活动.xlsx";

		// Token: 0x040004F5 RID: 1269
		private const string TABLE = "Artemis";

		// Token: 0x040004F6 RID: 1270
		private const string COMMAND = "select BinData from `Artemis` where ActivityId=?";

		// Token: 0x040004F7 RID: 1271
		private const string KEY_PREFIX = "ArtemisByActivityId";

		// Token: 0x040004F8 RID: 1272
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004F9 RID: 1273
		private static int HandleId;
	}
}
