using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000789 RID: 1929
	public class ConfigQualityInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D47 RID: 11591 RVA: 0x0015C923 File Offset: 0x0015AB23
		static ConfigQualityInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQualityInfoById.CreateStaticDefaultValue), new Action(ConfigQualityInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x0015C944 File Offset: 0x0015AB44
		public static void CreateStaticDefaultValue()
		{
			ConfigQualityInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQualityInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "QualityInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `QualityInfo` where Id=?")
			});
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x0015C9C3 File Offset: 0x0015ABC3
		public static void ResetStaticDefaultValue()
		{
			ConfigQualityInfoById.LogPair = null;
			ConfigQualityInfoById.HandleId = 0;
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x0015C9D1 File Offset: 0x0015ABD1
		public static void Init()
		{
			ConfigQualityInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigQualityInfoById.HandleId, "db_item.db", "select BinData from `QualityInfo` where Id=?");
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x0015C9EC File Offset: 0x0015ABEC
		public static QualityInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQualityInfoById.HandleId, ConfigQualityInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new QualityInfo?(QualityInfo.GetRootAsQualityInfo(configBuffer));
				}
			}
			ConfigQualityInfoById.LogPair.Clear();
			ConfigQualityInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigQualityInfoById.HandleId, 1, p0Id, ConfigQualityInfoById.LogPair) || ConfigCommon.Step(ConfigQualityInfoById.HandleId, true, ConfigQualityInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigQualityInfoById.HandleId, ConfigQualityInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQualityInfoById.HandleId, 0, ConfigQualityInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigQualityInfoById.HandleId, ConfigQualityInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			QualityInfo rootAsQualityInfo = QualityInfo.GetRootAsQualityInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("QualityInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigQualityInfoById.HandleId, ConfigQualityInfoById.LogPair);
			return new QualityInfo?(rootAsQualityInfo);
		}

		// Token: 0x040034A5 RID: 13477
		private const string DB = "db_item.db";

		// Token: 0x040034A6 RID: 13478
		private const string FILE = "d.道具.xlsx";

		// Token: 0x040034A7 RID: 13479
		private const string TABLE = "QualityInfo";

		// Token: 0x040034A8 RID: 13480
		private const string COMMAND = "select BinData from `QualityInfo` where Id=?";

		// Token: 0x040034A9 RID: 13481
		private const string KEY_PREFIX = "QualityInfoById";

		// Token: 0x040034AA RID: 13482
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040034AB RID: 13483
		private static int HandleId;
	}
}
