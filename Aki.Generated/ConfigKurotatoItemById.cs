using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AE RID: 1198
	public class ConfigKurotatoItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C1F RID: 7199 RVA: 0x000FBE2F File Offset: 0x000FA02F
		static ConfigKurotatoItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoItemById.CreateStaticDefaultValue), new Action(ConfigKurotatoItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000FBE50 File Offset: 0x000FA050
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_道具.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoItem"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoItem` where Id=?")
			});
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x000FBECF File Offset: 0x000FA0CF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoItemById.LogPair = null;
			ConfigKurotatoItemById.HandleId = 0;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000FBEDD File Offset: 0x000FA0DD
		public static void Init()
		{
			ConfigKurotatoItemById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoItemById.HandleId, "db_kurotato.db", "select BinData from `KurotatoItem` where Id=?");
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000FBEF8 File Offset: 0x000FA0F8
		public static KurotatoItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoItemById.HandleId, ConfigKurotatoItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoItem?(KurotatoItem.GetRootAsKurotatoItem(configBuffer));
				}
			}
			ConfigKurotatoItemById.LogPair.Clear();
			ConfigKurotatoItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoItemById.HandleId, 1, p0Id, ConfigKurotatoItemById.LogPair) || ConfigCommon.Step(ConfigKurotatoItemById.HandleId, true, ConfigKurotatoItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoItemById.HandleId, ConfigKurotatoItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoItemById.HandleId, 0, ConfigKurotatoItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoItemById.HandleId, ConfigKurotatoItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoItem rootAsKurotatoItem = KurotatoItem.GetRootAsKurotatoItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoItemById.HandleId, ConfigKurotatoItemById.LogPair);
			return new KurotatoItem?(rootAsKurotatoItem);
		}

		// Token: 0x040020A6 RID: 8358
		private const string DB = "db_kurotato.db";

		// Token: 0x040020A7 RID: 8359
		private const string FILE = "t.土豆兄弟_道具.xlsx";

		// Token: 0x040020A8 RID: 8360
		private const string TABLE = "KurotatoItem";

		// Token: 0x040020A9 RID: 8361
		private const string COMMAND = "select BinData from `KurotatoItem` where Id=?";

		// Token: 0x040020AA RID: 8362
		private const string KEY_PREFIX = "KurotatoItemById";

		// Token: 0x040020AB RID: 8363
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020AC RID: 8364
		private static int HandleId;
	}
}
