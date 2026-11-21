using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A75 RID: 2677
	public class ConfigSurvivorsPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ED2 RID: 16082 RVA: 0x001BFE2C File Offset: 0x001BE02C
		static ConfigSurvivorsPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsPropertyById.CreateStaticDefaultValue), new Action(ConfigSurvivorsPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003ED3 RID: 16083 RVA: 0x001BFE4C File Offset: 0x001BE04C
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsPropertyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsPropertyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsProperty` where Id=?")
			});
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x001BFECB File Offset: 0x001BE0CB
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsPropertyById.LogPair = null;
			ConfigSurvivorsPropertyById.HandleId = 0;
		}

		// Token: 0x06003ED5 RID: 16085 RVA: 0x001BFED9 File Offset: 0x001BE0D9
		public static void Init()
		{
			ConfigSurvivorsPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsPropertyById.HandleId, "db_survivors.db", "select BinData from `SurvivorsProperty` where Id=?");
		}

		// Token: 0x06003ED6 RID: 16086 RVA: 0x001BFEF4 File Offset: 0x001BE0F4
		public static SurvivorsProperty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsPropertyById.HandleId, ConfigSurvivorsPropertyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsProperty?(SurvivorsProperty.GetRootAsSurvivorsProperty(configBuffer));
				}
			}
			ConfigSurvivorsPropertyById.LogPair.Clear();
			ConfigSurvivorsPropertyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsPropertyById.HandleId, 1, p0Id, ConfigSurvivorsPropertyById.LogPair) || ConfigCommon.Step(ConfigSurvivorsPropertyById.HandleId, true, ConfigSurvivorsPropertyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsPropertyById.HandleId, ConfigSurvivorsPropertyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsPropertyById.HandleId, 0, ConfigSurvivorsPropertyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsPropertyById.HandleId, ConfigSurvivorsPropertyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsProperty rootAsSurvivorsProperty = SurvivorsProperty.GetRootAsSurvivorsProperty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsPropertyById.HandleId, ConfigSurvivorsPropertyById.LogPair);
			return new SurvivorsProperty?(rootAsSurvivorsProperty);
		}

		// Token: 0x04004919 RID: 18713
		private const string DB = "db_survivors.db";

		// Token: 0x0400491A RID: 18714
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x0400491B RID: 18715
		private const string TABLE = "SurvivorsProperty";

		// Token: 0x0400491C RID: 18716
		private const string COMMAND = "select BinData from `SurvivorsProperty` where Id=?";

		// Token: 0x0400491D RID: 18717
		private const string KEY_PREFIX = "SurvivorsPropertyById";

		// Token: 0x0400491E RID: 18718
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400491F RID: 18719
		private static int HandleId;
	}
}
