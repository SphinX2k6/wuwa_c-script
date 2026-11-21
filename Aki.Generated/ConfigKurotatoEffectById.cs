using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A4 RID: 1188
	public class ConfigKurotatoEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BE2 RID: 7138 RVA: 0x000FA7D0 File Offset: 0x000F89D0
		static ConfigKurotatoEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoEffectById.CreateStaticDefaultValue), new Action(ConfigKurotatoEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x000FA7F0 File Offset: 0x000F89F0
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

		// Token: 0x06001BE4 RID: 7140 RVA: 0x000FA86F File Offset: 0x000F8A6F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoEffectById.LogPair = null;
			ConfigKurotatoEffectById.HandleId = 0;
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x000FA87D File Offset: 0x000F8A7D
		public static void Init()
		{
			ConfigKurotatoEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoEffectById.HandleId, "db_kurotato.db", "select BinData from `KurotatoEffect` where Id=?");
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x000FA898 File Offset: 0x000F8A98
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

		// Token: 0x04002060 RID: 8288
		private const string DB = "db_kurotato.db";

		// Token: 0x04002061 RID: 8289
		private const string FILE = "t.土豆兄弟_效果.xlsx";

		// Token: 0x04002062 RID: 8290
		private const string TABLE = "KurotatoEffect";

		// Token: 0x04002063 RID: 8291
		private const string COMMAND = "select BinData from `KurotatoEffect` where Id=?";

		// Token: 0x04002064 RID: 8292
		private const string KEY_PREFIX = "KurotatoEffectById";

		// Token: 0x04002065 RID: 8293
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002066 RID: 8294
		private static int HandleId;
	}
}
