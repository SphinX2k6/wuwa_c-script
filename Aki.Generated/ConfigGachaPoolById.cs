using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000384 RID: 900
	public class ConfigGachaPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600151E RID: 5406 RVA: 0x000D46FD File Offset: 0x000D28FD
		static ConfigGachaPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaPoolById.CreateStaticDefaultValue), new Action(ConfigGachaPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x000D471C File Offset: 0x000D291C
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaPool"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaPool` where Id=?")
			});
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000D479B File Offset: 0x000D299B
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaPoolById.LogPair = null;
			ConfigGachaPoolById.HandleId = 0;
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000D47A9 File Offset: 0x000D29A9
		public static void Init()
		{
			ConfigGachaPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaPoolById.HandleId, "db_gacha.db", "select BinData from `GachaPool` where Id=?");
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x000D47C4 File Offset: 0x000D29C4
		public static GachaPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaPoolById.HandleId, ConfigGachaPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaPool?(GachaPool.GetRootAsGachaPool(configBuffer));
				}
			}
			ConfigGachaPoolById.LogPair.Clear();
			ConfigGachaPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaPoolById.HandleId, 1, p0Id, ConfigGachaPoolById.LogPair) || ConfigCommon.Step(ConfigGachaPoolById.HandleId, true, ConfigGachaPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaPoolById.HandleId, ConfigGachaPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaPoolById.HandleId, 0, ConfigGachaPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaPoolById.HandleId, ConfigGachaPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaPool rootAsGachaPool = GachaPool.GetRootAsGachaPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaPoolById.HandleId, ConfigGachaPoolById.LogPair);
			return new GachaPool?(rootAsGachaPool);
		}

		// Token: 0x04001880 RID: 6272
		private const string DB = "db_gacha.db";

		// Token: 0x04001881 RID: 6273
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x04001882 RID: 6274
		private const string TABLE = "GachaPool";

		// Token: 0x04001883 RID: 6275
		private const string COMMAND = "select BinData from `GachaPool` where Id=?";

		// Token: 0x04001884 RID: 6276
		private const string KEY_PREFIX = "GachaPoolById";

		// Token: 0x04001885 RID: 6277
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001886 RID: 6278
		private static int HandleId;
	}
}
