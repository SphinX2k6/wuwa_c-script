using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099E RID: 2462
	public class ConfigSurvivorsMonsterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039C8 RID: 14792 RVA: 0x001A0608 File Offset: 0x0019E808
		static ConfigSurvivorsMonsterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsMonsterTypeById.CreateStaticDefaultValue), new Action(ConfigSurvivorsMonsterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060039C9 RID: 14793 RVA: 0x001A0628 File Offset: 0x0019E828
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsMonsterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsMonsterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsMonsterType"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsMonsterType` where Id=?")
			});
		}

		// Token: 0x060039CA RID: 14794 RVA: 0x001A06A7 File Offset: 0x0019E8A7
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsMonsterTypeById.LogPair = null;
			ConfigSurvivorsMonsterTypeById.HandleId = 0;
		}

		// Token: 0x060039CB RID: 14795 RVA: 0x001A06B5 File Offset: 0x0019E8B5
		public static void Init()
		{
			ConfigSurvivorsMonsterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsMonsterTypeById.HandleId, "db_survivors.db", "select BinData from `SurvivorsMonsterType` where Id=?");
		}

		// Token: 0x060039CC RID: 14796 RVA: 0x001A06D0 File Offset: 0x0019E8D0
		public static SurvivorsMonsterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsMonsterTypeById.HandleId, ConfigSurvivorsMonsterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsMonsterType?(SurvivorsMonsterType.GetRootAsSurvivorsMonsterType(configBuffer));
				}
			}
			ConfigSurvivorsMonsterTypeById.LogPair.Clear();
			ConfigSurvivorsMonsterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsMonsterTypeById.HandleId, 1, p0Id, ConfigSurvivorsMonsterTypeById.LogPair) || ConfigCommon.Step(ConfigSurvivorsMonsterTypeById.HandleId, true, ConfigSurvivorsMonsterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsMonsterTypeById.HandleId, ConfigSurvivorsMonsterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsMonsterTypeById.HandleId, 0, ConfigSurvivorsMonsterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsMonsterTypeById.HandleId, ConfigSurvivorsMonsterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsMonsterType rootAsSurvivorsMonsterType = SurvivorsMonsterType.GetRootAsSurvivorsMonsterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsMonsterTypeById.HandleId, ConfigSurvivorsMonsterTypeById.LogPair);
			return new SurvivorsMonsterType?(rootAsSurvivorsMonsterType);
		}

		// Token: 0x04004338 RID: 17208
		private const string DB = "db_survivors.db";

		// Token: 0x04004339 RID: 17209
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x0400433A RID: 17210
		private const string TABLE = "SurvivorsMonsterType";

		// Token: 0x0400433B RID: 17211
		private const string COMMAND = "select BinData from `SurvivorsMonsterType` where Id=?";

		// Token: 0x0400433C RID: 17212
		private const string KEY_PREFIX = "SurvivorsMonsterTypeById";

		// Token: 0x0400433D RID: 17213
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400433E RID: 17214
		private static int HandleId;
	}
}
