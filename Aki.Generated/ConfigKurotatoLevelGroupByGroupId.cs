using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B5 RID: 1205
	public class ConfigKurotatoLevelGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C49 RID: 7241 RVA: 0x000FCCE7 File Offset: 0x000FAEE7
		static ConfigKurotatoLevelGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x000FCD08 File Offset: 0x000FAF08
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelGroupByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelGroupByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevelGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevelGroup` where GroupId=?")
			});
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000FCD87 File Offset: 0x000FAF87
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelGroupByGroupId.LogPair = null;
			ConfigKurotatoLevelGroupByGroupId.HandleId = 0;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x000FCD95 File Offset: 0x000FAF95
		public static void Init()
		{
			ConfigKurotatoLevelGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelGroupByGroupId.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevelGroup` where GroupId=?");
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x000FCDB0 File Offset: 0x000FAFB0
		public static KurotatoLevelGroup? GetConfig(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelGroupByGroupId.HandleId, ConfigKurotatoLevelGroupByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoLevelGroup?(KurotatoLevelGroup.GetRootAsKurotatoLevelGroup(configBuffer));
				}
			}
			ConfigKurotatoLevelGroupByGroupId.LogPair.Clear();
			ConfigKurotatoLevelGroupByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigKurotatoLevelGroupByGroupId.HandleId, 1, p0GroupId, ConfigKurotatoLevelGroupByGroupId.LogPair) || ConfigCommon.Step(ConfigKurotatoLevelGroupByGroupId.HandleId, true, ConfigKurotatoLevelGroupByGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelGroupByGroupId.HandleId, ConfigKurotatoLevelGroupByGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelGroupByGroupId.HandleId, 0, ConfigKurotatoLevelGroupByGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoLevelGroupByGroupId.HandleId, ConfigKurotatoLevelGroupByGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoLevelGroup rootAsKurotatoLevelGroup = KurotatoLevelGroup.GetRootAsKurotatoLevelGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoLevelGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelGroupByGroupId.HandleId, ConfigKurotatoLevelGroupByGroupId.LogPair);
			return new KurotatoLevelGroup?(rootAsKurotatoLevelGroup);
		}

		// Token: 0x040020D7 RID: 8407
		private const string DB = "db_kurotato.db";

		// Token: 0x040020D8 RID: 8408
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040020D9 RID: 8409
		private const string TABLE = "KurotatoLevelGroup";

		// Token: 0x040020DA RID: 8410
		private const string COMMAND = "select BinData from `KurotatoLevelGroup` where GroupId=?";

		// Token: 0x040020DB RID: 8411
		private const string KEY_PREFIX = "KurotatoLevelGroupByGroupId";

		// Token: 0x040020DC RID: 8412
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020DD RID: 8413
		private static int HandleId;
	}
}
