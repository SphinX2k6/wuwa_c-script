using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CC RID: 204
	public class ConfigBabelTowerBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004C9 RID: 1225 RVA: 0x00074BD3 File Offset: 0x00072DD3
		static ConfigBabelTowerBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerBuffById.CreateStaticDefaultValue), new Action(ConfigBabelTowerBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00074BF4 File Offset: 0x00072DF4
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerBuff` where Id=?")
			});
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00074C73 File Offset: 0x00072E73
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerBuffById.LogPair = null;
			ConfigBabelTowerBuffById.HandleId = 0;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00074C81 File Offset: 0x00072E81
		public static void Init()
		{
			ConfigBabelTowerBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerBuffById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerBuff` where Id=?");
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00074C9C File Offset: 0x00072E9C
		public static BabelTowerBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerBuffById.HandleId, ConfigBabelTowerBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerBuff?(BabelTowerBuff.GetRootAsBabelTowerBuff(configBuffer));
				}
			}
			ConfigBabelTowerBuffById.LogPair.Clear();
			ConfigBabelTowerBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBabelTowerBuffById.HandleId, 1, p0Id, ConfigBabelTowerBuffById.LogPair) || ConfigCommon.Step(ConfigBabelTowerBuffById.HandleId, true, ConfigBabelTowerBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerBuffById.HandleId, ConfigBabelTowerBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerBuffById.HandleId, 0, ConfigBabelTowerBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerBuffById.HandleId, ConfigBabelTowerBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerBuff rootAsBabelTowerBuff = BabelTowerBuff.GetRootAsBabelTowerBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerBuffById.HandleId, ConfigBabelTowerBuffById.LogPair);
			return new BabelTowerBuff?(rootAsBabelTowerBuff);
		}

		// Token: 0x04000578 RID: 1400
		private const string DB = "db_babeltower.db";

		// Token: 0x04000579 RID: 1401
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x0400057A RID: 1402
		private const string TABLE = "BabelTowerBuff";

		// Token: 0x0400057B RID: 1403
		private const string COMMAND = "select BinData from `BabelTowerBuff` where Id=?";

		// Token: 0x0400057C RID: 1404
		private const string KEY_PREFIX = "BabelTowerBuffById";

		// Token: 0x0400057D RID: 1405
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400057E RID: 1406
		private static int HandleId;
	}
}
