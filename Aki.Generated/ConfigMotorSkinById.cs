using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DB RID: 1499
	public class ConfigMotorSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600232F RID: 9007 RVA: 0x00123EF3 File Offset: 0x001220F3
		static ConfigMotorSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSkinById.CreateStaticDefaultValue), new Action(ConfigMotorSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00123F14 File Offset: 0x00122114
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorSkinById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorSkinById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorSkin` where Id=?")
			});
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00123F93 File Offset: 0x00122193
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSkinById.LogPair = null;
			ConfigMotorSkinById.HandleId = 0;
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00123FA1 File Offset: 0x001221A1
		public static void Init()
		{
			ConfigMotorSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSkinById.HandleId, "db_motordiy.db", "select BinData from `MotorSkin` where Id=?");
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00123FBC File Offset: 0x001221BC
		public static MotorSkin? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorSkinById.HandleId, ConfigMotorSkinById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorSkin?(MotorSkin.GetRootAsMotorSkin(configBuffer));
				}
			}
			ConfigMotorSkinById.LogPair.Clear();
			ConfigMotorSkinById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorSkinById.HandleId, 1, p0Id, ConfigMotorSkinById.LogPair) || ConfigCommon.Step(ConfigMotorSkinById.HandleId, true, ConfigMotorSkinById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorSkinById.HandleId, ConfigMotorSkinById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorSkinById.HandleId, 0, ConfigMotorSkinById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorSkinById.HandleId, ConfigMotorSkinById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorSkin rootAsMotorSkin = MotorSkin.GetRootAsMotorSkin(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorSkinById.HandleId, ConfigMotorSkinById.LogPair);
			return new MotorSkin?(rootAsMotorSkin);
		}

		// Token: 0x040028E1 RID: 10465
		private const string DB = "db_motordiy.db";

		// Token: 0x040028E2 RID: 10466
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040028E3 RID: 10467
		private const string TABLE = "MotorSkin";

		// Token: 0x040028E4 RID: 10468
		private const string COMMAND = "select BinData from `MotorSkin` where Id=?";

		// Token: 0x040028E5 RID: 10469
		private const string KEY_PREFIX = "MotorSkinById";

		// Token: 0x040028E6 RID: 10470
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028E7 RID: 10471
		private static int HandleId;
	}
}
