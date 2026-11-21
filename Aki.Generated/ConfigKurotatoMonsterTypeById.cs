using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BF RID: 1215
	public class ConfigKurotatoMonsterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C85 RID: 7301 RVA: 0x000FE250 File Offset: 0x000FC450
		static ConfigKurotatoMonsterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoMonsterTypeById.CreateStaticDefaultValue), new Action(ConfigKurotatoMonsterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x000FE270 File Offset: 0x000FC470
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoMonsterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoMonsterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoMonsterType"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoMonsterType` where Id=?")
			});
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x000FE2EF File Offset: 0x000FC4EF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoMonsterTypeById.LogPair = null;
			ConfigKurotatoMonsterTypeById.HandleId = 0;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x000FE2FD File Offset: 0x000FC4FD
		public static void Init()
		{
			ConfigKurotatoMonsterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoMonsterTypeById.HandleId, "db_kurotato.db", "select BinData from `KurotatoMonsterType` where Id=?");
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x000FE318 File Offset: 0x000FC518
		public static KurotatoMonsterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoMonsterTypeById.HandleId, ConfigKurotatoMonsterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoMonsterType?(KurotatoMonsterType.GetRootAsKurotatoMonsterType(configBuffer));
				}
			}
			ConfigKurotatoMonsterTypeById.LogPair.Clear();
			ConfigKurotatoMonsterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigKurotatoMonsterTypeById.HandleId, 1, p0Id, ConfigKurotatoMonsterTypeById.LogPair) || ConfigCommon.Step(ConfigKurotatoMonsterTypeById.HandleId, true, ConfigKurotatoMonsterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterTypeById.HandleId, ConfigKurotatoMonsterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoMonsterTypeById.HandleId, 0, ConfigKurotatoMonsterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoMonsterTypeById.HandleId, ConfigKurotatoMonsterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoMonsterType rootAsKurotatoMonsterType = KurotatoMonsterType.GetRootAsKurotatoMonsterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoMonsterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoMonsterTypeById.HandleId, ConfigKurotatoMonsterTypeById.LogPair);
			return new KurotatoMonsterType?(rootAsKurotatoMonsterType);
		}

		// Token: 0x0400211D RID: 8477
		private const string DB = "db_kurotato.db";

		// Token: 0x0400211E RID: 8478
		private const string FILE = "t.土豆兄弟_怪物.xlsx";

		// Token: 0x0400211F RID: 8479
		private const string TABLE = "KurotatoMonsterType";

		// Token: 0x04002120 RID: 8480
		private const string COMMAND = "select BinData from `KurotatoMonsterType` where Id=?";

		// Token: 0x04002121 RID: 8481
		private const string KEY_PREFIX = "KurotatoMonsterTypeById";

		// Token: 0x04002122 RID: 8482
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002123 RID: 8483
		private static int HandleId;
	}
}
