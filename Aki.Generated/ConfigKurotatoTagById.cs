using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B9 RID: 1209
	public class ConfigKurotatoTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C61 RID: 7265 RVA: 0x000F9AA3 File Offset: 0x000F7CA3
		static ConfigKurotatoTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoTagById.CreateStaticDefaultValue), new Action(ConfigKurotatoTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000F9AC4 File Offset: 0x000F7CC4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_标签.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoTag"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoTag` where Id=?")
			});
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x000F9B43 File Offset: 0x000F7D43
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoTagById.LogPair = null;
			ConfigKurotatoTagById.HandleId = 0;
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000F9B51 File Offset: 0x000F7D51
		public static void Init()
		{
			ConfigKurotatoTagById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoTagById.HandleId, "db_kurotato.db", "select BinData from `KurotatoTag` where Id=?");
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x000F9B6C File Offset: 0x000F7D6C
		public static KurotatoTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoTagById.HandleId, ConfigKurotatoTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoTag?(KurotatoTag.GetRootAsKurotatoTag(configBuffer));
				}
			}
			ConfigKurotatoTagById.LogPair.Clear();
			ConfigKurotatoTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoTagById.HandleId, 1, p0Id, ConfigKurotatoTagById.LogPair) || ConfigCommon.Step(ConfigKurotatoTagById.HandleId, true, ConfigKurotatoTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoTagById.HandleId, ConfigKurotatoTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoTagById.HandleId, 0, ConfigKurotatoTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoTagById.HandleId, ConfigKurotatoTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoTag rootAsKurotatoTag = KurotatoTag.GetRootAsKurotatoTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoTagById.HandleId, ConfigKurotatoTagById.LogPair);
			return new KurotatoTag?(rootAsKurotatoTag);
		}

		// Token: 0x040020F3 RID: 8435
		private const string DB = "db_kurotato.db";

		// Token: 0x040020F4 RID: 8436
		private const string FILE = "t.土豆兄弟_标签.xlsx";

		// Token: 0x040020F5 RID: 8437
		private const string TABLE = "KurotatoTag";

		// Token: 0x040020F6 RID: 8438
		private const string COMMAND = "select BinData from `KurotatoTag` where Id=?";

		// Token: 0x040020F7 RID: 8439
		private const string KEY_PREFIX = "KurotatoTagById";

		// Token: 0x040020F8 RID: 8440
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020F9 RID: 8441
		private static int HandleId;
	}
}
