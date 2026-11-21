using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088E RID: 2190
	public class ConfigRogueWeeklyBuffPoolByRelatedArtifactId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003366 RID: 13158 RVA: 0x0017F820 File Offset: 0x0017DA20
		static ConfigRogueWeeklyBuffPoolByRelatedArtifactId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.ResetStaticDefaultValue));
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x0017F840 File Offset: 0x0017DA40
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyBuffPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyBuffPool` where RelatedArtifactId=?")
			});
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x0017F8BF File Offset: 0x0017DABF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair = null;
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId = 0;
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x0017F8CD File Offset: 0x0017DACD
		public static void Init()
		{
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyBuffPool` where RelatedArtifactId=?");
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x0017F8E8 File Offset: 0x0017DAE8
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeeklyBuffPool> GetConfigList(int p0RelatedArtifactId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBuffPoolByRelatedArtifactId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RelatedArtifactId);
				IReadOnlyList<RogueWeeklyBuffPool> readOnlyList = (IReadOnlyList<RogueWeeklyBuffPool>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair.Clear();
			ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair.Add(new ValueTuple<string, object>("RelatedArtifactId", p0RelatedArtifactId));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, 1, p0RelatedArtifactId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair))
			{
				ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair);
				return null;
			}
			List<RogueWeeklyBuffPool> list = new List<RogueWeeklyBuffPool>();
			while (ConfigCommon.Step(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, false, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, 0, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair);
					return null;
				}
				RogueWeeklyBuffPool rootAsRogueWeeklyBuffPool = RogueWeeklyBuffPool.GetRootAsRogueWeeklyBuffPool(new ByteBuffer(item2));
				list.Add(rootAsRogueWeeklyBuffPool);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyBuffPoolByRelatedArtifactId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RelatedArtifactId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyBuffPoolByRelatedArtifactId.HandleId, ConfigRogueWeeklyBuffPoolByRelatedArtifactId.LogPair);
			return list;
		}

		// Token: 0x04003BC8 RID: 15304
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BC9 RID: 15305
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BCA RID: 15306
		private const string TABLE = "RogueWeeklyBuffPool";

		// Token: 0x04003BCB RID: 15307
		private const string COMMAND = "select BinData from `RogueWeeklyBuffPool` where RelatedArtifactId=?";

		// Token: 0x04003BCC RID: 15308
		private const string KEY_PREFIX = "RogueWeeklyBuffPoolByRelatedArtifactId";

		// Token: 0x04003BCD RID: 15309
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BCE RID: 15310
		private static int HandleId;
	}
}
