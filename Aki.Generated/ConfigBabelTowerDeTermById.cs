using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D1 RID: 209
	public class ConfigBabelTowerDeTermById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004E7 RID: 1255 RVA: 0x000755C3 File Offset: 0x000737C3
		static ConfigBabelTowerDeTermById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDeTermById.CreateStaticDefaultValue), new Action(ConfigBabelTowerDeTermById.ResetStaticDefaultValue));
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x000755E4 File Offset: 0x000737E4
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDeTermById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDeTermById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDeTerm"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDeTerm` where Id=?")
			});
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00075663 File Offset: 0x00073863
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDeTermById.LogPair = null;
			ConfigBabelTowerDeTermById.HandleId = 0;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00075671 File Offset: 0x00073871
		public static void Init()
		{
			ConfigBabelTowerDeTermById.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDeTermById.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDeTerm` where Id=?");
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0007568C File Offset: 0x0007388C
		public static BabelTowerDeTerm? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDeTermById.HandleId, ConfigBabelTowerDeTermById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDeTermById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BabelTowerDeTerm?(BabelTowerDeTerm.GetRootAsBabelTowerDeTerm(configBuffer));
				}
			}
			ConfigBabelTowerDeTermById.LogPair.Clear();
			ConfigBabelTowerDeTermById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBabelTowerDeTermById.HandleId, 1, p0Id, ConfigBabelTowerDeTermById.LogPair) || ConfigCommon.Step(ConfigBabelTowerDeTermById.HandleId, true, ConfigBabelTowerDeTermById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBabelTowerDeTermById.HandleId, ConfigBabelTowerDeTermById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDeTermById.HandleId, 0, ConfigBabelTowerDeTermById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBabelTowerDeTermById.HandleId, ConfigBabelTowerDeTermById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BabelTowerDeTerm rootAsBabelTowerDeTerm = BabelTowerDeTerm.GetRootAsBabelTowerDeTerm(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BabelTowerDeTermById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBabelTowerDeTermById.HandleId, ConfigBabelTowerDeTermById.LogPair);
			return new BabelTowerDeTerm?(rootAsBabelTowerDeTerm);
		}

		// Token: 0x0400059B RID: 1435
		private const string DB = "db_babeltower.db";

		// Token: 0x0400059C RID: 1436
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x0400059D RID: 1437
		private const string TABLE = "BabelTowerDeTerm";

		// Token: 0x0400059E RID: 1438
		private const string COMMAND = "select BinData from `BabelTowerDeTerm` where Id=?";

		// Token: 0x0400059F RID: 1439
		private const string KEY_PREFIX = "BabelTowerDeTermById";

		// Token: 0x040005A0 RID: 1440
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005A1 RID: 1441
		private static int HandleId;
	}
}
