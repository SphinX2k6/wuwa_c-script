using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A5 RID: 2469
	public class ConfigSurvivorsRoleLvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039F2 RID: 14834 RVA: 0x001A15F0 File Offset: 0x0019F7F0
		static ConfigSurvivorsRoleLvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleLvById.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleLvById.ResetStaticDefaultValue));
		}

		// Token: 0x060039F3 RID: 14835 RVA: 0x001A1610 File Offset: 0x0019F810
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

		// Token: 0x060039F4 RID: 14836 RVA: 0x001A168F File Offset: 0x0019F88F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleLvById.LogPair = null;
			ConfigSurvivorsRoleLvById.HandleId = 0;
		}

		// Token: 0x060039F5 RID: 14837 RVA: 0x001A169D File Offset: 0x0019F89D
		public static void Init()
		{
			ConfigSurvivorsRoleLvById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleLvById.HandleId, "db_survivors.db", "select BinData from `SurvivorsRoleLv` where Id=?");
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x001A16B8 File Offset: 0x0019F8B8
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

		// Token: 0x04004369 RID: 17257
		private const string DB = "db_survivors.db";

		// Token: 0x0400436A RID: 17258
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x0400436B RID: 17259
		private const string TABLE = "SurvivorsRoleLv";

		// Token: 0x0400436C RID: 17260
		private const string COMMAND = "select BinData from `SurvivorsRoleLv` where Id=?";

		// Token: 0x0400436D RID: 17261
		private const string KEY_PREFIX = "SurvivorsRoleLvById";

		// Token: 0x0400436E RID: 17262
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400436F RID: 17263
		private static int HandleId;
	}
}
