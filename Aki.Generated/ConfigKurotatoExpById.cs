using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000490 RID: 1168
	public class ConfigKurotatoExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B6A RID: 7018 RVA: 0x000F4457 File Offset: 0x000F2657
		static ConfigKurotatoExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoExpById.CreateStaticDefaultValue), new Action(ConfigKurotatoExpById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x000F4478 File Offset: 0x000F2678
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoExpById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoExpById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoExp"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoExp` where Id=?")
			});
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x000F44F7 File Offset: 0x000F26F7
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoExpById.LogPair = null;
			ConfigKurotatoExpById.HandleId = 0;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x000F4505 File Offset: 0x000F2705
		public static void Init()
		{
			ConfigKurotatoExpById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoExpById.HandleId, "db_kurotato.db", "select BinData from `KurotatoExp` where Id=?");
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x000F4520 File Offset: 0x000F2720
		public static KurotatoExp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoExpById.HandleId, ConfigKurotatoExpById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoExp?(KurotatoExp.GetRootAsKurotatoExp(configBuffer));
				}
			}
			ConfigKurotatoExpById.LogPair.Clear();
			ConfigKurotatoExpById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoExpById.HandleId, 1, p0Id, ConfigKurotatoExpById.LogPair) || ConfigCommon.Step(ConfigKurotatoExpById.HandleId, true, ConfigKurotatoExpById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoExpById.HandleId, ConfigKurotatoExpById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoExpById.HandleId, 0, ConfigKurotatoExpById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoExpById.HandleId, ConfigKurotatoExpById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoExp rootAsKurotatoExp = KurotatoExp.GetRootAsKurotatoExp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoExpById.HandleId, ConfigKurotatoExpById.LogPair);
			return new KurotatoExp?(rootAsKurotatoExp);
		}

		// Token: 0x04001FD4 RID: 8148
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FD5 RID: 8149
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04001FD6 RID: 8150
		private const string TABLE = "KurotatoExp";

		// Token: 0x04001FD7 RID: 8151
		private const string COMMAND = "select BinData from `KurotatoExp` where Id=?";

		// Token: 0x04001FD8 RID: 8152
		private const string KEY_PREFIX = "KurotatoExpById";

		// Token: 0x04001FD9 RID: 8153
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FDA RID: 8154
		private static int HandleId;
	}
}
