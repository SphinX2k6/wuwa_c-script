using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057A RID: 1402
	public class ConfigMoraleFlagTypeByType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020E9 RID: 8425 RVA: 0x00116FEC File Offset: 0x001151EC
		static ConfigMoraleFlagTypeByType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleFlagTypeByType.CreateStaticDefaultValue), new Action(ConfigMoraleFlagTypeByType.ResetStaticDefaultValue));
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x0011700C File Offset: 0x0011520C
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleFlagTypeByType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleFlagTypeByType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleFlagType"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleFlagType` where TypeId=?")
			});
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x0011708B File Offset: 0x0011528B
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleFlagTypeByType.LogPair = null;
			ConfigMoraleFlagTypeByType.HandleId = 0;
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00117099 File Offset: 0x00115299
		public static void Init()
		{
			ConfigMoraleFlagTypeByType.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleFlagTypeByType.HandleId, "db_moraleplay.db", "select BinData from `MoraleFlagType` where TypeId=?");
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x001170B4 File Offset: 0x001152B4
		public static MoraleFlagType? GetConfig(int p0TypeId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleFlagTypeByType.HandleId, ConfigMoraleFlagTypeByType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleFlagTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleFlagType?(MoraleFlagType.GetRootAsMoraleFlagType(configBuffer));
				}
			}
			ConfigMoraleFlagTypeByType.LogPair.Clear();
			ConfigMoraleFlagTypeByType.LogPair.Add(new ValueTuple<string, object>("TypeId", p0TypeId));
			if (!ConfigCommon.BindInt(ConfigMoraleFlagTypeByType.HandleId, 1, p0TypeId, ConfigMoraleFlagTypeByType.LogPair) || ConfigCommon.Step(ConfigMoraleFlagTypeByType.HandleId, true, ConfigMoraleFlagTypeByType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleFlagTypeByType.HandleId, ConfigMoraleFlagTypeByType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleFlagTypeByType.HandleId, 0, ConfigMoraleFlagTypeByType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleFlagTypeByType.HandleId, ConfigMoraleFlagTypeByType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleFlagType rootAsMoraleFlagType = MoraleFlagType.GetRootAsMoraleFlagType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleFlagTypeByType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleFlagTypeByType.HandleId, ConfigMoraleFlagTypeByType.LogPair);
			return new MoraleFlagType?(rootAsMoraleFlagType);
		}

		// Token: 0x0400263A RID: 9786
		private const string DB = "db_moraleplay.db";

		// Token: 0x0400263B RID: 9787
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400263C RID: 9788
		private const string TABLE = "MoraleFlagType";

		// Token: 0x0400263D RID: 9789
		private const string COMMAND = "select BinData from `MoraleFlagType` where TypeId=?";

		// Token: 0x0400263E RID: 9790
		private const string KEY_PREFIX = "MoraleFlagTypeByType";

		// Token: 0x0400263F RID: 9791
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002640 RID: 9792
		private static int HandleId;
	}
}
