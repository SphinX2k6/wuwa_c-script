using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C5 RID: 1477
	public class ConfigMotorSkinShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022AB RID: 8875 RVA: 0x0011D854 File Offset: 0x0011BA54
		static ConfigMotorSkinShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSkinShowById.CreateStaticDefaultValue), new Action(ConfigMotorSkinShowById.ResetStaticDefaultValue));
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x0011D874 File Offset: 0x0011BA74
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorSkinShowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorSkinShowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorskin.db"),
				new ValueTuple<string, object>("文件", "m.礼包外显表.xlsx"),
				new ValueTuple<string, object>("表名", "MotorSkinShow"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorSkinShow` where Id=?")
			});
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x0011D8F3 File Offset: 0x0011BAF3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSkinShowById.LogPair = null;
			ConfigMotorSkinShowById.HandleId = 0;
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0011D901 File Offset: 0x0011BB01
		public static void Init()
		{
			ConfigMotorSkinShowById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSkinShowById.HandleId, "db_motorskin.db", "select BinData from `MotorSkinShow` where Id=?");
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0011D91C File Offset: 0x0011BB1C
		public static MotorSkinShow? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorSkinShowById.HandleId, ConfigMotorSkinShowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorSkinShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorSkinShow?(MotorSkinShow.GetRootAsMotorSkinShow(configBuffer));
				}
			}
			ConfigMotorSkinShowById.LogPair.Clear();
			ConfigMotorSkinShowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorSkinShowById.HandleId, 1, p0Id, ConfigMotorSkinShowById.LogPair) || ConfigCommon.Step(ConfigMotorSkinShowById.HandleId, true, ConfigMotorSkinShowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorSkinShowById.HandleId, ConfigMotorSkinShowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorSkinShowById.HandleId, 0, ConfigMotorSkinShowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorSkinShowById.HandleId, ConfigMotorSkinShowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorSkinShow rootAsMotorSkinShow = MotorSkinShow.GetRootAsMotorSkinShow(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorSkinShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorSkinShowById.HandleId, ConfigMotorSkinShowById.LogPair);
			return new MotorSkinShow?(rootAsMotorSkinShow);
		}

		// Token: 0x04002847 RID: 10311
		private const string DB = "db_motorskin.db";

		// Token: 0x04002848 RID: 10312
		private const string FILE = "m.礼包外显表.xlsx";

		// Token: 0x04002849 RID: 10313
		private const string TABLE = "MotorSkinShow";

		// Token: 0x0400284A RID: 10314
		private const string COMMAND = "select BinData from `MotorSkinShow` where Id=?";

		// Token: 0x0400284B RID: 10315
		private const string KEY_PREFIX = "MotorSkinShowById";

		// Token: 0x0400284C RID: 10316
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400284D RID: 10317
		private static int HandleId;
	}
}
