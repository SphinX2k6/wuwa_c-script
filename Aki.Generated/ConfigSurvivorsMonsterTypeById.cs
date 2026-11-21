using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A73 RID: 2675
	public class ConfigSurvivorsMonsterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EC6 RID: 16070 RVA: 0x001BF99C File Offset: 0x001BDB9C
		static ConfigSurvivorsMonsterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsMonsterTypeById.CreateStaticDefaultValue), new Action(ConfigSurvivorsMonsterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x001BF9BC File Offset: 0x001BDBBC
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

		// Token: 0x06003EC8 RID: 16072 RVA: 0x001BFA3B File Offset: 0x001BDC3B
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsMonsterTypeById.LogPair = null;
			ConfigSurvivorsMonsterTypeById.HandleId = 0;
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x001BFA49 File Offset: 0x001BDC49
		public static void Init()
		{
			ConfigSurvivorsMonsterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsMonsterTypeById.HandleId, "db_survivors.db", "select BinData from `SurvivorsMonsterType` where Id=?");
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x001BFA64 File Offset: 0x001BDC64
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

		// Token: 0x0400490B RID: 18699
		private const string DB = "db_survivors.db";

		// Token: 0x0400490C RID: 18700
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x0400490D RID: 18701
		private const string TABLE = "SurvivorsMonsterType";

		// Token: 0x0400490E RID: 18702
		private const string COMMAND = "select BinData from `SurvivorsMonsterType` where Id=?";

		// Token: 0x0400490F RID: 18703
		private const string KEY_PREFIX = "SurvivorsMonsterTypeById";

		// Token: 0x04004910 RID: 18704
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004911 RID: 18705
		private static int HandleId;
	}
}
