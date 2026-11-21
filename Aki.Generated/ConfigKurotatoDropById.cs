using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A3 RID: 1187
	public class ConfigKurotatoDropById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BDC RID: 7132 RVA: 0x000FA588 File Offset: 0x000F8788
		static ConfigKurotatoDropById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoDropById.CreateStaticDefaultValue), new Action(ConfigKurotatoDropById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x000FA5A8 File Offset: 0x000F87A8
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoDropById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoDropById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_掉落物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoDrop"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoDrop` where Id=?")
			});
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x000FA627 File Offset: 0x000F8827
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoDropById.LogPair = null;
			ConfigKurotatoDropById.HandleId = 0;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x000FA635 File Offset: 0x000F8835
		public static void Init()
		{
			ConfigKurotatoDropById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoDropById.HandleId, "db_kurotato.db", "select BinData from `KurotatoDrop` where Id=?");
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x000FA650 File Offset: 0x000F8850
		public static KurotatoDrop? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoDropById.HandleId, ConfigKurotatoDropById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoDropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoDrop?(KurotatoDrop.GetRootAsKurotatoDrop(configBuffer));
				}
			}
			ConfigKurotatoDropById.LogPair.Clear();
			ConfigKurotatoDropById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoDropById.HandleId, 1, p0Id, ConfigKurotatoDropById.LogPair) || ConfigCommon.Step(ConfigKurotatoDropById.HandleId, true, ConfigKurotatoDropById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoDropById.HandleId, ConfigKurotatoDropById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoDropById.HandleId, 0, ConfigKurotatoDropById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoDropById.HandleId, ConfigKurotatoDropById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoDrop rootAsKurotatoDrop = KurotatoDrop.GetRootAsKurotatoDrop(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoDropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoDropById.HandleId, ConfigKurotatoDropById.LogPair);
			return new KurotatoDrop?(rootAsKurotatoDrop);
		}

		// Token: 0x04002059 RID: 8281
		private const string DB = "db_kurotato.db";

		// Token: 0x0400205A RID: 8282
		private const string FILE = "t.土豆兄弟_掉落物.xlsx";

		// Token: 0x0400205B RID: 8283
		private const string TABLE = "KurotatoDrop";

		// Token: 0x0400205C RID: 8284
		private const string COMMAND = "select BinData from `KurotatoDrop` where Id=?";

		// Token: 0x0400205D RID: 8285
		private const string KEY_PREFIX = "KurotatoDropById";

		// Token: 0x0400205E RID: 8286
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400205F RID: 8287
		private static int HandleId;
	}
}
