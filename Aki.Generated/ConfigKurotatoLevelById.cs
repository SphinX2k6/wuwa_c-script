using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049B RID: 1179
	public class ConfigKurotatoLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BAD RID: 7085 RVA: 0x000F5CEF File Offset: 0x000F3EEF
		static ConfigKurotatoLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelById.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x000F5D10 File Offset: 0x000F3F10
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevel` where Id=?")
			});
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x000F5D8F File Offset: 0x000F3F8F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelById.LogPair = null;
			ConfigKurotatoLevelById.HandleId = 0;
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x000F5D9D File Offset: 0x000F3F9D
		public static void Init()
		{
			ConfigKurotatoLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelById.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevel` where Id=?");
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x000F5DB8 File Offset: 0x000F3FB8
		public static KurotatoLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelById.HandleId, ConfigKurotatoLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoLevel?(KurotatoLevel.GetRootAsKurotatoLevel(configBuffer));
				}
			}
			ConfigKurotatoLevelById.LogPair.Clear();
			ConfigKurotatoLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoLevelById.HandleId, 1, p0Id, ConfigKurotatoLevelById.LogPair) || ConfigCommon.Step(ConfigKurotatoLevelById.HandleId, true, ConfigKurotatoLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelById.HandleId, ConfigKurotatoLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelById.HandleId, 0, ConfigKurotatoLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelById.HandleId, ConfigKurotatoLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoLevel rootAsKurotatoLevel = KurotatoLevel.GetRootAsKurotatoLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelById.HandleId, ConfigKurotatoLevelById.LogPair);
			return new KurotatoLevel?(rootAsKurotatoLevel);
		}

		// Token: 0x04002021 RID: 8225
		private const string DB = "db_kurotato.db";

		// Token: 0x04002022 RID: 8226
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x04002023 RID: 8227
		private const string TABLE = "KurotatoLevel";

		// Token: 0x04002024 RID: 8228
		private const string COMMAND = "select BinData from `KurotatoLevel` where Id=?";

		// Token: 0x04002025 RID: 8229
		private const string KEY_PREFIX = "KurotatoLevelById";

		// Token: 0x04002026 RID: 8230
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002027 RID: 8231
		private static int HandleId;
	}
}
