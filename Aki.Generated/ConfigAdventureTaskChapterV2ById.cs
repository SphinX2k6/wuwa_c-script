using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000067 RID: 103
	public class ConfigAdventureTaskChapterV2ById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0006AD1C File Offset: 0x00068F1C
		static ConfigAdventureTaskChapterV2ById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskChapterV2ById.CreateStaticDefaultValue), new Action(ConfigAdventureTaskChapterV2ById.ResetStaticDefaultValue));
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0006AD3C File Offset: 0x00068F3C
		public static void CreateStaticDefaultValue()
		{
			ConfigAdventureTaskChapterV2ById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdventureTaskChapterV2ById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手开拓任务活动.xlsx"),
				new ValueTuple<string, object>("表名", "AdventureTaskChapterV2"),
				new ValueTuple<string, object>("语句", "select BinData from `AdventureTaskChapterV2` where Id=?")
			});
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0006ADBB File Offset: 0x00068FBB
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskChapterV2ById.LogPair = null;
			ConfigAdventureTaskChapterV2ById.HandleId = 0;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0006ADC9 File Offset: 0x00068FC9
		public static void Init()
		{
			ConfigAdventureTaskChapterV2ById.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskChapterV2ById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `AdventureTaskChapterV2` where Id=?");
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0006ADE4 File Offset: 0x00068FE4
		public static AdventureTaskChapterV2? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdventureTaskChapterV2ById.HandleId, ConfigAdventureTaskChapterV2ById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskChapterV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdventureTaskChapterV2?(AdventureTaskChapterV2.GetRootAsAdventureTaskChapterV2(configBuffer));
				}
			}
			ConfigAdventureTaskChapterV2ById.LogPair.Clear();
			ConfigAdventureTaskChapterV2ById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdventureTaskChapterV2ById.HandleId, 1, p0Id, ConfigAdventureTaskChapterV2ById.LogPair) || ConfigCommon.Step(ConfigAdventureTaskChapterV2ById.HandleId, true, ConfigAdventureTaskChapterV2ById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdventureTaskChapterV2ById.HandleId, ConfigAdventureTaskChapterV2ById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdventureTaskChapterV2ById.HandleId, 0, ConfigAdventureTaskChapterV2ById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdventureTaskChapterV2ById.HandleId, ConfigAdventureTaskChapterV2ById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdventureTaskChapterV2 rootAsAdventureTaskChapterV = AdventureTaskChapterV2.GetRootAsAdventureTaskChapterV2(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdventureTaskChapterV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdventureTaskChapterV2ById.HandleId, ConfigAdventureTaskChapterV2ById.LogPair);
			return new AdventureTaskChapterV2?(rootAsAdventureTaskChapterV);
		}

		// Token: 0x040002B5 RID: 693
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x040002B6 RID: 694
		private const string FILE = "x.新手开拓任务活动.xlsx";

		// Token: 0x040002B7 RID: 695
		private const string TABLE = "AdventureTaskChapterV2";

		// Token: 0x040002B8 RID: 696
		private const string COMMAND = "select BinData from `AdventureTaskChapterV2` where Id=?";

		// Token: 0x040002B9 RID: 697
		private const string KEY_PREFIX = "AdventureTaskChapterV2ById";

		// Token: 0x040002BA RID: 698
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002BB RID: 699
		private static int HandleId;
	}
}
