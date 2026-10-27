using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099D RID: 2461
	public class ConfigSurvivorsLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039C2 RID: 14786 RVA: 0x001A03BF File Offset: 0x0019E5BF
		static ConfigSurvivorsLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsLevelById.CreateStaticDefaultValue), new Action(ConfigSurvivorsLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060039C3 RID: 14787 RVA: 0x001A03E0 File Offset: 0x0019E5E0
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

		// Token: 0x060039C4 RID: 14788 RVA: 0x001A045F File Offset: 0x0019E65F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsLevelById.LogPair = null;
			ConfigSurvivorsLevelById.HandleId = 0;
		}

		// Token: 0x060039C5 RID: 14789 RVA: 0x001A046D File Offset: 0x0019E66D
		public static void Init()
		{
			ConfigSurvivorsLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsLevelById.HandleId, "db_survivors.db", "select BinData from `SurvivorsLevel` where Id=?");
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x001A0488 File Offset: 0x0019E688
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

		// Token: 0x04004331 RID: 17201
		private const string DB = "db_survivors.db";

		// Token: 0x04004332 RID: 17202
		private const string FILE = "x.幸存者_关卡.xlsx";

		// Token: 0x04004333 RID: 17203
		private const string TABLE = "SurvivorsLevel";

		// Token: 0x04004334 RID: 17204
		private const string COMMAND = "select BinData from `SurvivorsLevel` where Id=?";

		// Token: 0x04004335 RID: 17205
		private const string KEY_PREFIX = "SurvivorsLevelById";

		// Token: 0x04004336 RID: 17206
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004337 RID: 17207
		private static int HandleId;
	}
}
