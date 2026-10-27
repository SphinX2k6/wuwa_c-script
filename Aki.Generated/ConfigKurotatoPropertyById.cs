using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AB RID: 1195
	public class ConfigKurotatoPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C0D RID: 7181 RVA: 0x000F7ED7 File Offset: 0x000F60D7
		static ConfigKurotatoPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoPropertyById.CreateStaticDefaultValue), new Action(ConfigKurotatoPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x000F7EF8 File Offset: 0x000F60F8
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

		// Token: 0x06001C0F RID: 7183 RVA: 0x000F7F77 File Offset: 0x000F6177
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoPropertyById.LogPair = null;
			ConfigKurotatoPropertyById.HandleId = 0;
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x000F7F85 File Offset: 0x000F6185
		public static void Init()
		{
			ConfigKurotatoPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoPropertyById.HandleId, "db_kurotato.db", "select BinData from `KurotatoProperty` where Id=?");
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x000F7FA0 File Offset: 0x000F61A0
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

		// Token: 0x04002091 RID: 8337
		private const string DB = "db_kurotato.db";

		// Token: 0x04002092 RID: 8338
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04002093 RID: 8339
		private const string TABLE = "KurotatoProperty";

		// Token: 0x04002094 RID: 8340
		private const string COMMAND = "select BinData from `KurotatoProperty` where Id=?";

		// Token: 0x04002095 RID: 8341
		private const string KEY_PREFIX = "KurotatoPropertyById";

		// Token: 0x04002096 RID: 8342
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002097 RID: 8343
		private static int HandleId;
	}
}
