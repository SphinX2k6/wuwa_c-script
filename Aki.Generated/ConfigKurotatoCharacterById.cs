using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000489 RID: 1161
	public class ConfigKurotatoCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B40 RID: 6976 RVA: 0x000F35C7 File Offset: 0x000F17C7
		static ConfigKurotatoCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterById.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x000F35E8 File Offset: 0x000F17E8
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoCharacterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoCharacterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_角色.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoCharacter` where Id=?")
			});
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000F3667 File Offset: 0x000F1867
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterById.LogPair = null;
			ConfigKurotatoCharacterById.HandleId = 0;
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x000F3675 File Offset: 0x000F1875
		public static void Init()
		{
			ConfigKurotatoCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterById.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacter` where Id=?");
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x000F3690 File Offset: 0x000F1890
		public static KurotatoCharacter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoCharacterById.HandleId, ConfigKurotatoCharacterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoCharacter?(KurotatoCharacter.GetRootAsKurotatoCharacter(configBuffer));
				}
			}
			ConfigKurotatoCharacterById.LogPair.Clear();
			ConfigKurotatoCharacterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoCharacterById.HandleId, 1, p0Id, ConfigKurotatoCharacterById.LogPair) || ConfigCommon.Step(ConfigKurotatoCharacterById.HandleId, true, ConfigKurotatoCharacterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoCharacterById.HandleId, ConfigKurotatoCharacterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoCharacterById.HandleId, 0, ConfigKurotatoCharacterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoCharacterById.HandleId, ConfigKurotatoCharacterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoCharacter rootAsKurotatoCharacter = KurotatoCharacter.GetRootAsKurotatoCharacter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoCharacterById.HandleId, ConfigKurotatoCharacterById.LogPair);
			return new KurotatoCharacter?(rootAsKurotatoCharacter);
		}

		// Token: 0x04001FA3 RID: 8099
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FA4 RID: 8100
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x04001FA5 RID: 8101
		private const string TABLE = "KurotatoCharacter";

		// Token: 0x04001FA6 RID: 8102
		private const string COMMAND = "select BinData from `KurotatoCharacter` where Id=?";

		// Token: 0x04001FA7 RID: 8103
		private const string KEY_PREFIX = "KurotatoCharacterById";

		// Token: 0x04001FA8 RID: 8104
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FA9 RID: 8105
		private static int HandleId;
	}
}
