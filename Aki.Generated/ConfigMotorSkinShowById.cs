using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DC RID: 1500
	public class ConfigMotorSkinShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002335 RID: 9013 RVA: 0x0012413C File Offset: 0x0012233C
		static ConfigMotorSkinShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSkinShowById.CreateStaticDefaultValue), new Action(ConfigMotorSkinShowById.ResetStaticDefaultValue));
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0012415C File Offset: 0x0012235C
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

		// Token: 0x06002337 RID: 9015 RVA: 0x001241DB File Offset: 0x001223DB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSkinShowById.LogPair = null;
			ConfigMotorSkinShowById.HandleId = 0;
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x001241E9 File Offset: 0x001223E9
		public static void Init()
		{
			ConfigMotorSkinShowById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSkinShowById.HandleId, "db_motorskin.db", "select BinData from `MotorSkinShow` where Id=?");
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00124204 File Offset: 0x00122404
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

		// Token: 0x040028E8 RID: 10472
		private const string DB = "db_motorskin.db";

		// Token: 0x040028E9 RID: 10473
		private const string FILE = "m.礼包外显表.xlsx";

		// Token: 0x040028EA RID: 10474
		private const string TABLE = "MotorSkinShow";

		// Token: 0x040028EB RID: 10475
		private const string COMMAND = "select BinData from `MotorSkinShow` where Id=?";

		// Token: 0x040028EC RID: 10476
		private const string KEY_PREFIX = "MotorSkinShowById";

		// Token: 0x040028ED RID: 10477
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028EE RID: 10478
		private static int HandleId;
	}
}
