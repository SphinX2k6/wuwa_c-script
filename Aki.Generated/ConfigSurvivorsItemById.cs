using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099B RID: 2459
	public class ConfigSurvivorsItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039B6 RID: 14774 RVA: 0x0019FF3F File Offset: 0x0019E13F
		static ConfigSurvivorsItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsItemById.CreateStaticDefaultValue), new Action(ConfigSurvivorsItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x0019FF60 File Offset: 0x0019E160
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

		// Token: 0x060039B8 RID: 14776 RVA: 0x0019FFDF File Offset: 0x0019E1DF
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsItemById.LogPair = null;
			ConfigSurvivorsItemById.HandleId = 0;
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x0019FFED File Offset: 0x0019E1ED
		public static void Init()
		{
			ConfigSurvivorsItemById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsItemById.HandleId, "db_survivors.db", "select BinData from `SurvivorsItem` where Id=?");
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x001A0008 File Offset: 0x0019E208
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

		// Token: 0x04004323 RID: 17187
		private const string DB = "db_survivors.db";

		// Token: 0x04004324 RID: 17188
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x04004325 RID: 17189
		private const string TABLE = "SurvivorsItem";

		// Token: 0x04004326 RID: 17190
		private const string COMMAND = "select BinData from `SurvivorsItem` where Id=?";

		// Token: 0x04004327 RID: 17191
		private const string KEY_PREFIX = "SurvivorsItemById";

		// Token: 0x04004328 RID: 17192
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004329 RID: 17193
		private static int HandleId;
	}
}
