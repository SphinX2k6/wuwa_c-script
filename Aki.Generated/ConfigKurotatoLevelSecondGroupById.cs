using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B6 RID: 1206
	public class ConfigKurotatoLevelSecondGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C4F RID: 7247 RVA: 0x000FCF30 File Offset: 0x000FB130
		static ConfigKurotatoLevelSecondGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelSecondGroupById.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelSecondGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x000FCF50 File Offset: 0x000FB150
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelSecondGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelSecondGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevelSecondGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevelSecondGroup` where Id=?")
			});
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x000FCFCF File Offset: 0x000FB1CF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelSecondGroupById.LogPair = null;
			ConfigKurotatoLevelSecondGroupById.HandleId = 0;
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x000FCFDD File Offset: 0x000FB1DD
		public static void Init()
		{
			ConfigKurotatoLevelSecondGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelSecondGroupById.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevelSecondGroup` where Id=?");
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x000FCFF8 File Offset: 0x000FB1F8
		public static KurotatoLevelSecondGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelSecondGroupById.HandleId, ConfigKurotatoLevelSecondGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelSecondGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoLevelSecondGroup?(KurotatoLevelSecondGroup.GetRootAsKurotatoLevelSecondGroup(configBuffer));
				}
			}
			ConfigKurotatoLevelSecondGroupById.LogPair.Clear();
			ConfigKurotatoLevelSecondGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoLevelSecondGroupById.HandleId, 1, p0Id, ConfigKurotatoLevelSecondGroupById.LogPair) || ConfigCommon.Step(ConfigKurotatoLevelSecondGroupById.HandleId, true, ConfigKurotatoLevelSecondGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelSecondGroupById.HandleId, ConfigKurotatoLevelSecondGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelSecondGroupById.HandleId, 0, ConfigKurotatoLevelSecondGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelSecondGroupById.HandleId, ConfigKurotatoLevelSecondGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoLevelSecondGroup rootAsKurotatoLevelSecondGroup = KurotatoLevelSecondGroup.GetRootAsKurotatoLevelSecondGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelSecondGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelSecondGroupById.HandleId, ConfigKurotatoLevelSecondGroupById.LogPair);
			return new KurotatoLevelSecondGroup?(rootAsKurotatoLevelSecondGroup);
		}

		// Token: 0x040020DE RID: 8414
		private const string DB = "db_kurotato.db";

		// Token: 0x040020DF RID: 8415
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040020E0 RID: 8416
		private const string TABLE = "KurotatoLevelSecondGroup";

		// Token: 0x040020E1 RID: 8417
		private const string COMMAND = "select BinData from `KurotatoLevelSecondGroup` where Id=?";

		// Token: 0x040020E2 RID: 8418
		private const string KEY_PREFIX = "KurotatoLevelSecondGroupById";

		// Token: 0x040020E3 RID: 8419
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020E4 RID: 8420
		private static int HandleId;
	}
}
