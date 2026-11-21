using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A72 RID: 2674
	public class ConfigSurvivorsLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EC0 RID: 16064 RVA: 0x001BF753 File Offset: 0x001BD953
		static ConfigSurvivorsLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsLevelById.CreateStaticDefaultValue), new Action(ConfigSurvivorsLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EC1 RID: 16065 RVA: 0x001BF774 File Offset: 0x001BD974
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsLevel` where Id=?")
			});
		}

		// Token: 0x06003EC2 RID: 16066 RVA: 0x001BF7F3 File Offset: 0x001BD9F3
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsLevelById.LogPair = null;
			ConfigSurvivorsLevelById.HandleId = 0;
		}

		// Token: 0x06003EC3 RID: 16067 RVA: 0x001BF801 File Offset: 0x001BDA01
		public static void Init()
		{
			ConfigSurvivorsLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsLevelById.HandleId, "db_survivors.db", "select BinData from `SurvivorsLevel` where Id=?");
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x001BF81C File Offset: 0x001BDA1C
		public static SurvivorsLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsLevelById.HandleId, ConfigSurvivorsLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsLevel?(SurvivorsLevel.GetRootAsSurvivorsLevel(configBuffer));
				}
			}
			ConfigSurvivorsLevelById.LogPair.Clear();
			ConfigSurvivorsLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsLevelById.HandleId, 1, p0Id, ConfigSurvivorsLevelById.LogPair) || ConfigCommon.Step(ConfigSurvivorsLevelById.HandleId, true, ConfigSurvivorsLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsLevelById.HandleId, ConfigSurvivorsLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsLevelById.HandleId, 0, ConfigSurvivorsLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsLevelById.HandleId, ConfigSurvivorsLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsLevel rootAsSurvivorsLevel = SurvivorsLevel.GetRootAsSurvivorsLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsLevelById.HandleId, ConfigSurvivorsLevelById.LogPair);
			return new SurvivorsLevel?(rootAsSurvivorsLevel);
		}

		// Token: 0x04004904 RID: 18692
		private const string DB = "db_survivors.db";

		// Token: 0x04004905 RID: 18693
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x04004906 RID: 18694
		private const string TABLE = "SurvivorsLevel";

		// Token: 0x04004907 RID: 18695
		private const string COMMAND = "select BinData from `SurvivorsLevel` where Id=?";

		// Token: 0x04004908 RID: 18696
		private const string KEY_PREFIX = "SurvivorsLevelById";

		// Token: 0x04004909 RID: 18697
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400490A RID: 18698
		private static int HandleId;
	}
}
