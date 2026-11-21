using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C1 RID: 1217
	public class ConfigKurotatoPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C91 RID: 7313 RVA: 0x000FE62B File Offset: 0x000FC82B
		static ConfigKurotatoPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoPropertyById.CreateStaticDefaultValue), new Action(ConfigKurotatoPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x000FE64C File Offset: 0x000FC84C
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoPropertyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoPropertyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoProperty` where Id=?")
			});
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000FE6CB File Offset: 0x000FC8CB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoPropertyById.LogPair = null;
			ConfigKurotatoPropertyById.HandleId = 0;
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x000FE6D9 File Offset: 0x000FC8D9
		public static void Init()
		{
			ConfigKurotatoPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoPropertyById.HandleId, "db_kurotato.db", "select BinData from `KurotatoProperty` where Id=?");
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x000FE6F4 File Offset: 0x000FC8F4
		public static KurotatoProperty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoPropertyById.HandleId, ConfigKurotatoPropertyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoProperty?(KurotatoProperty.GetRootAsKurotatoProperty(configBuffer));
				}
			}
			ConfigKurotatoPropertyById.LogPair.Clear();
			ConfigKurotatoPropertyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoPropertyById.HandleId, 1, p0Id, ConfigKurotatoPropertyById.LogPair) || ConfigCommon.Step(ConfigKurotatoPropertyById.HandleId, true, ConfigKurotatoPropertyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoPropertyById.HandleId, ConfigKurotatoPropertyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoPropertyById.HandleId, 0, ConfigKurotatoPropertyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoPropertyById.HandleId, ConfigKurotatoPropertyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoProperty rootAsKurotatoProperty = KurotatoProperty.GetRootAsKurotatoProperty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoPropertyById.HandleId, ConfigKurotatoPropertyById.LogPair);
			return new KurotatoProperty?(rootAsKurotatoProperty);
		}

		// Token: 0x0400212B RID: 8491
		private const string DB = "db_kurotato.db";

		// Token: 0x0400212C RID: 8492
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x0400212D RID: 8493
		private const string TABLE = "KurotatoProperty";

		// Token: 0x0400212E RID: 8494
		private const string COMMAND = "select BinData from `KurotatoProperty` where Id=?";

		// Token: 0x0400212F RID: 8495
		private const string KEY_PREFIX = "KurotatoPropertyById";

		// Token: 0x04002130 RID: 8496
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002131 RID: 8497
		private static int HandleId;
	}
}
