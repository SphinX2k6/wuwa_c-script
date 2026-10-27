using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049F RID: 1183
	public class ConfigKurotatoLevelGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BC5 RID: 7109 RVA: 0x000F6593 File Offset: 0x000F4793
		static ConfigKurotatoLevelGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000F65B4 File Offset: 0x000F47B4
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

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000F6633 File Offset: 0x000F4833
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelGroupByGroupId.LogPair = null;
			ConfigKurotatoLevelGroupByGroupId.HandleId = 0;
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000F6641 File Offset: 0x000F4841
		public static void Init()
		{
			ConfigKurotatoLevelGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelGroupByGroupId.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevelGroup` where GroupId=?");
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x000F665C File Offset: 0x000F485C
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

		// Token: 0x0400203D RID: 8253
		private const string DB = "db_kurotato.db";

		// Token: 0x0400203E RID: 8254
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x0400203F RID: 8255
		private const string TABLE = "KurotatoLevelGroup";

		// Token: 0x04002040 RID: 8256
		private const string COMMAND = "select BinData from `KurotatoLevelGroup` where GroupId=?";

		// Token: 0x04002041 RID: 8257
		private const string KEY_PREFIX = "KurotatoLevelGroupByGroupId";

		// Token: 0x04002042 RID: 8258
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002043 RID: 8259
		private static int HandleId;
	}
}
