using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048E RID: 1166
	public class ConfigKurotatoEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B5E RID: 7006 RVA: 0x000F407C File Offset: 0x000F227C
		static ConfigKurotatoEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoEffectById.CreateStaticDefaultValue), new Action(ConfigKurotatoEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x000F409C File Offset: 0x000F229C
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_效果.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoEffect` where Id=?")
			});
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x000F411B File Offset: 0x000F231B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoEffectById.LogPair = null;
			ConfigKurotatoEffectById.HandleId = 0;
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x000F4129 File Offset: 0x000F2329
		public static void Init()
		{
			ConfigKurotatoEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoEffectById.HandleId, "db_kurotato.db", "select BinData from `KurotatoEffect` where Id=?");
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000F4144 File Offset: 0x000F2344
		public static KurotatoEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoEffectById.HandleId, ConfigKurotatoEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoEffect?(KurotatoEffect.GetRootAsKurotatoEffect(configBuffer));
				}
			}
			ConfigKurotatoEffectById.LogPair.Clear();
			ConfigKurotatoEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoEffectById.HandleId, 1, p0Id, ConfigKurotatoEffectById.LogPair) || ConfigCommon.Step(ConfigKurotatoEffectById.HandleId, true, ConfigKurotatoEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoEffectById.HandleId, ConfigKurotatoEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoEffectById.HandleId, 0, ConfigKurotatoEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoEffectById.HandleId, ConfigKurotatoEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoEffect rootAsKurotatoEffect = KurotatoEffect.GetRootAsKurotatoEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoEffectById.HandleId, ConfigKurotatoEffectById.LogPair);
			return new KurotatoEffect?(rootAsKurotatoEffect);
		}

		// Token: 0x04001FC6 RID: 8134
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FC7 RID: 8135
		private const string FILE = "t.土豆兄弟_效果.xlsx";

		// Token: 0x04001FC8 RID: 8136
		private const string TABLE = "KurotatoEffect";

		// Token: 0x04001FC9 RID: 8137
		private const string COMMAND = "select BinData from `KurotatoEffect` where Id=?";

		// Token: 0x04001FCA RID: 8138
		private const string KEY_PREFIX = "KurotatoEffectById";

		// Token: 0x04001FCB RID: 8139
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FCC RID: 8140
		private static int HandleId;
	}
}
