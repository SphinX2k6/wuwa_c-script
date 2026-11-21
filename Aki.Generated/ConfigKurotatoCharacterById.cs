using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049F RID: 1183
	public class ConfigKurotatoCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BC4 RID: 7108 RVA: 0x000F9D1B File Offset: 0x000F7F1B
		static ConfigKurotatoCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterById.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x000F9D3C File Offset: 0x000F7F3C
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

		// Token: 0x06001BC6 RID: 7110 RVA: 0x000F9DBB File Offset: 0x000F7FBB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterById.LogPair = null;
			ConfigKurotatoCharacterById.HandleId = 0;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x000F9DC9 File Offset: 0x000F7FC9
		public static void Init()
		{
			ConfigKurotatoCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterById.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacter` where Id=?");
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x000F9DE4 File Offset: 0x000F7FE4
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

		// Token: 0x0400203D RID: 8253
		private const string DB = "db_kurotato.db";

		// Token: 0x0400203E RID: 8254
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x0400203F RID: 8255
		private const string TABLE = "KurotatoCharacter";

		// Token: 0x04002040 RID: 8256
		private const string COMMAND = "select BinData from `KurotatoCharacter` where Id=?";

		// Token: 0x04002041 RID: 8257
		private const string KEY_PREFIX = "KurotatoCharacterById";

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
