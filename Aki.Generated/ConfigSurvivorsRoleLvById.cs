using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7A RID: 2682
	public class ConfigSurvivorsRoleLvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EF0 RID: 16112 RVA: 0x001C0984 File Offset: 0x001BEB84
		static ConfigSurvivorsRoleLvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleLvById.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleLvById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x001C09A4 File Offset: 0x001BEBA4
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsRoleLvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsRoleLvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsRoleLv"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsRoleLv` where Id=?")
			});
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x001C0A23 File Offset: 0x001BEC23
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleLvById.LogPair = null;
			ConfigSurvivorsRoleLvById.HandleId = 0;
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x001C0A31 File Offset: 0x001BEC31
		public static void Init()
		{
			ConfigSurvivorsRoleLvById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleLvById.HandleId, "db_survivors.db", "select BinData from `SurvivorsRoleLv` where Id=?");
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x001C0A4C File Offset: 0x001BEC4C
		public static SurvivorsRoleLv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsRoleLvById.HandleId, ConfigSurvivorsRoleLvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsRoleLv?(SurvivorsRoleLv.GetRootAsSurvivorsRoleLv(configBuffer));
				}
			}
			ConfigSurvivorsRoleLvById.LogPair.Clear();
			ConfigSurvivorsRoleLvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsRoleLvById.HandleId, 1, p0Id, ConfigSurvivorsRoleLvById.LogPair) || ConfigCommon.Step(ConfigSurvivorsRoleLvById.HandleId, true, ConfigSurvivorsRoleLvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsRoleLvById.HandleId, ConfigSurvivorsRoleLvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsRoleLvById.HandleId, 0, ConfigSurvivorsRoleLvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsRoleLvById.HandleId, ConfigSurvivorsRoleLvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsRoleLv rootAsSurvivorsRoleLv = SurvivorsRoleLv.GetRootAsSurvivorsRoleLv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsRoleLvById.HandleId, ConfigSurvivorsRoleLvById.LogPair);
			return new SurvivorsRoleLv?(rootAsSurvivorsRoleLv);
		}

		// Token: 0x0400493C RID: 18748
		private const string DB = "db_survivors.db";

		// Token: 0x0400493D RID: 18749
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x0400493E RID: 18750
		private const string TABLE = "SurvivorsRoleLv";

		// Token: 0x0400493F RID: 18751
		private const string COMMAND = "select BinData from `SurvivorsRoleLv` where Id=?";

		// Token: 0x04004940 RID: 18752
		private const string KEY_PREFIX = "SurvivorsRoleLvById";

		// Token: 0x04004941 RID: 18753
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004942 RID: 18754
		private static int HandleId;
	}
}
