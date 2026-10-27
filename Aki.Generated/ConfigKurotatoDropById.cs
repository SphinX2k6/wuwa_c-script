using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048D RID: 1165
	public class ConfigKurotatoDropById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B58 RID: 7000 RVA: 0x000F3E34 File Offset: 0x000F2034
		static ConfigKurotatoDropById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoDropById.CreateStaticDefaultValue), new Action(ConfigKurotatoDropById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x000F3E54 File Offset: 0x000F2054
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

		// Token: 0x06001B5A RID: 7002 RVA: 0x000F3ED3 File Offset: 0x000F20D3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoDropById.LogPair = null;
			ConfigKurotatoDropById.HandleId = 0;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x000F3EE1 File Offset: 0x000F20E1
		public static void Init()
		{
			ConfigKurotatoDropById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoDropById.HandleId, "db_kurotato.db", "select BinData from `KurotatoDrop` where Id=?");
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x000F3EFC File Offset: 0x000F20FC
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

		// Token: 0x04001FBF RID: 8127
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FC0 RID: 8128
		private const string FILE = "t.土豆兄弟_掉落物.xlsx";

		// Token: 0x04001FC1 RID: 8129
		private const string TABLE = "KurotatoDrop";

		// Token: 0x04001FC2 RID: 8130
		private const string COMMAND = "select BinData from `KurotatoDrop` where Id=?";

		// Token: 0x04001FC3 RID: 8131
		private const string KEY_PREFIX = "KurotatoDropById";

		// Token: 0x04001FC4 RID: 8132
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FC5 RID: 8133
		private static int HandleId;
	}
}
