using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A0 RID: 1184
	public class ConfigKurotatoLevelSecondGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BCB RID: 7115 RVA: 0x000F67DC File Offset: 0x000F49DC
		static ConfigKurotatoLevelSecondGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelSecondGroupById.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelSecondGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x000F67FC File Offset: 0x000F49FC
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelSecondGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelSecondGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevelSecondGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevelSecondGroup` where Id=?")
			});
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x000F687B File Offset: 0x000F4A7B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelSecondGroupById.LogPair = null;
			ConfigKurotatoLevelSecondGroupById.HandleId = 0;
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000F6889 File Offset: 0x000F4A89
		public static void Init()
		{
			ConfigKurotatoLevelSecondGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelSecondGroupById.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevelSecondGroup` where Id=?");
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x000F68A4 File Offset: 0x000F4AA4
		public static KurotatoLevelSecondGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelSecondGroupById.HandleId, ConfigKurotatoLevelSecondGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelSecondGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoLevelSecondGroup?(KurotatoLevelSecondGroup.GetRootAsKurotatoLevelSecondGroup(configBuffer));
				}
			}
			ConfigKurotatoLevelSecondGroupById.LogPair.Clear();
			ConfigKurotatoLevelSecondGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoLevelSecondGroupById.HandleId, 1, p0Id, ConfigKurotatoLevelSecondGroupById.LogPair) || ConfigCommon.Step(ConfigKurotatoLevelSecondGroupById.HandleId, true, ConfigKurotatoLevelSecondGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelSecondGroupById.HandleId, ConfigKurotatoLevelSecondGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelSecondGroupById.HandleId, 0, ConfigKurotatoLevelSecondGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelSecondGroupById.HandleId, ConfigKurotatoLevelSecondGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoLevelSecondGroup rootAsKurotatoLevelSecondGroup = KurotatoLevelSecondGroup.GetRootAsKurotatoLevelSecondGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelSecondGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelSecondGroupById.HandleId, ConfigKurotatoLevelSecondGroupById.LogPair);
			return new KurotatoLevelSecondGroup?(rootAsKurotatoLevelSecondGroup);
		}

		// Token: 0x04002044 RID: 8260
		private const string DB = "db_kurotato.db";

		// Token: 0x04002045 RID: 8261
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x04002046 RID: 8262
		private const string TABLE = "KurotatoLevelSecondGroup";

		// Token: 0x04002047 RID: 8263
		private const string COMMAND = "select BinData from `KurotatoLevelSecondGroup` where Id=?";

		// Token: 0x04002048 RID: 8264
		private const string KEY_PREFIX = "KurotatoLevelSecondGroupById";

		// Token: 0x04002049 RID: 8265
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400204A RID: 8266
		private static int HandleId;
	}
}
