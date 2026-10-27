using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076F RID: 1903
	public class ConfigQualityInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CAB RID: 11435 RVA: 0x00155A17 File Offset: 0x00153C17
		static ConfigQualityInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQualityInfoById.CreateStaticDefaultValue), new Action(ConfigQualityInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x00155A38 File Offset: 0x00153C38
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

		// Token: 0x06002CAD RID: 11437 RVA: 0x00155AB7 File Offset: 0x00153CB7
		public static void ResetStaticDefaultValue()
		{
			ConfigQualityInfoById.LogPair = null;
			ConfigQualityInfoById.HandleId = 0;
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x00155AC5 File Offset: 0x00153CC5
		public static void Init()
		{
			ConfigQualityInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigQualityInfoById.HandleId, "db_item.db", "select BinData from `QualityInfo` where Id=?");
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x00155AE0 File Offset: 0x00153CE0
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

		// Token: 0x040033EF RID: 13295
		private const string DB = "db_item.db";

		// Token: 0x040033F0 RID: 13296
		private const string FILE = "d.道具.xlsx";

		// Token: 0x040033F1 RID: 13297
		private const string TABLE = "QualityInfo";

		// Token: 0x040033F2 RID: 13298
		private const string COMMAND = "select BinData from `QualityInfo` where Id=?";

		// Token: 0x040033F3 RID: 13299
		private const string KEY_PREFIX = "QualityInfoById";

		// Token: 0x040033F4 RID: 13300
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033F5 RID: 13301
		private static int HandleId;
	}
}
