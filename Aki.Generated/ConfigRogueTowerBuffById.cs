using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000888 RID: 2184
	public class ConfigRogueTowerBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003342 RID: 13122 RVA: 0x0017EBD7 File Offset: 0x0017CDD7
		static ConfigRogueTowerBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTowerBuffById.CreateStaticDefaultValue), new Action(ConfigRogueTowerBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x0017EBF8 File Offset: 0x0017CDF8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueTowerBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueTowerBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueTowerBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueTowerBuff` where Id=?")
			});
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x0017EC77 File Offset: 0x0017CE77
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTowerBuffById.LogPair = null;
			ConfigRogueTowerBuffById.HandleId = 0;
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x0017EC85 File Offset: 0x0017CE85
		public static void Init()
		{
			ConfigRogueTowerBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTowerBuffById.HandleId, "db_rogue.db", "select BinData from `RogueTowerBuff` where Id=?");
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x0017ECA0 File Offset: 0x0017CEA0
		public static RogueTowerBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueTowerBuffById.HandleId, ConfigRogueTowerBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueTowerBuff?(RogueTowerBuff.GetRootAsRogueTowerBuff(configBuffer));
				}
			}
			ConfigRogueTowerBuffById.LogPair.Clear();
			ConfigRogueTowerBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueTowerBuffById.HandleId, 1, p0Id, ConfigRogueTowerBuffById.LogPair) || ConfigCommon.Step(ConfigRogueTowerBuffById.HandleId, true, ConfigRogueTowerBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueTowerBuffById.HandleId, ConfigRogueTowerBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueTowerBuffById.HandleId, 0, ConfigRogueTowerBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueTowerBuffById.HandleId, ConfigRogueTowerBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueTowerBuff rootAsRogueTowerBuff = RogueTowerBuff.GetRootAsRogueTowerBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueTowerBuffById.HandleId, ConfigRogueTowerBuffById.LogPair);
			return new RogueTowerBuff?(rootAsRogueTowerBuff);
		}

		// Token: 0x04003B9E RID: 15262
		private const string DB = "db_rogue.db";

		// Token: 0x04003B9F RID: 15263
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x04003BA0 RID: 15264
		private const string TABLE = "RogueTowerBuff";

		// Token: 0x04003BA1 RID: 15265
		private const string COMMAND = "select BinData from `RogueTowerBuff` where Id=?";

		// Token: 0x04003BA2 RID: 15266
		private const string KEY_PREFIX = "RogueTowerBuffById";

		// Token: 0x04003BA3 RID: 15267
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BA4 RID: 15268
		private static int HandleId;
	}
}
