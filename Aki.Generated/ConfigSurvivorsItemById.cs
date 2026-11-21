using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A70 RID: 2672
	public class ConfigSurvivorsItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EB4 RID: 16052 RVA: 0x001BF2D3 File Offset: 0x001BD4D3
		static ConfigSurvivorsItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsItemById.CreateStaticDefaultValue), new Action(ConfigSurvivorsItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x001BF2F4 File Offset: 0x001BD4F4
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局外.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsItem"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsItem` where Id=?")
			});
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x001BF373 File Offset: 0x001BD573
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsItemById.LogPair = null;
			ConfigSurvivorsItemById.HandleId = 0;
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x001BF381 File Offset: 0x001BD581
		public static void Init()
		{
			ConfigSurvivorsItemById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsItemById.HandleId, "db_survivors.db", "select BinData from `SurvivorsItem` where Id=?");
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x001BF39C File Offset: 0x001BD59C
		public static SurvivorsItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsItemById.HandleId, ConfigSurvivorsItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsItem?(SurvivorsItem.GetRootAsSurvivorsItem(configBuffer));
				}
			}
			ConfigSurvivorsItemById.LogPair.Clear();
			ConfigSurvivorsItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsItemById.HandleId, 1, p0Id, ConfigSurvivorsItemById.LogPair) || ConfigCommon.Step(ConfigSurvivorsItemById.HandleId, true, ConfigSurvivorsItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsItemById.HandleId, ConfigSurvivorsItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsItemById.HandleId, 0, ConfigSurvivorsItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsItemById.HandleId, ConfigSurvivorsItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsItem rootAsSurvivorsItem = SurvivorsItem.GetRootAsSurvivorsItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsItemById.HandleId, ConfigSurvivorsItemById.LogPair);
			return new SurvivorsItem?(rootAsSurvivorsItem);
		}

		// Token: 0x040048F6 RID: 18678
		private const string DB = "db_survivors.db";

		// Token: 0x040048F7 RID: 18679
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x040048F8 RID: 18680
		private const string TABLE = "SurvivorsItem";

		// Token: 0x040048F9 RID: 18681
		private const string COMMAND = "select BinData from `SurvivorsItem` where Id=?";

		// Token: 0x040048FA RID: 18682
		private const string KEY_PREFIX = "SurvivorsItemById";

		// Token: 0x040048FB RID: 18683
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048FC RID: 18684
		private static int HandleId;
	}
}
