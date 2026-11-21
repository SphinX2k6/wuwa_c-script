using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000853 RID: 2131
	public class ConfigRogueResCharacterBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003204 RID: 12804 RVA: 0x00177A68 File Offset: 0x00175C68
		static ConfigRogueResCharacterBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCharacterBuffById.CreateStaticDefaultValue), new Action(ConfigRogueResCharacterBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x00177A88 File Offset: 0x00175C88
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCharacterBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCharacterBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCharacterBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCharacterBuff` where Id=?")
			});
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x00177B07 File Offset: 0x00175D07
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCharacterBuffById.LogPair = null;
			ConfigRogueResCharacterBuffById.HandleId = 0;
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x00177B15 File Offset: 0x00175D15
		public static void Init()
		{
			ConfigRogueResCharacterBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCharacterBuffById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCharacterBuff` where Id=?");
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x00177B30 File Offset: 0x00175D30
		public static RogueResCharacterBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCharacterBuffById.HandleId, ConfigRogueResCharacterBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCharacterBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResCharacterBuff?(RogueResCharacterBuff.GetRootAsRogueResCharacterBuff(configBuffer));
				}
			}
			ConfigRogueResCharacterBuffById.LogPair.Clear();
			ConfigRogueResCharacterBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResCharacterBuffById.HandleId, 1, p0Id, ConfigRogueResCharacterBuffById.LogPair) || ConfigCommon.Step(ConfigRogueResCharacterBuffById.HandleId, true, ConfigRogueResCharacterBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResCharacterBuffById.HandleId, ConfigRogueResCharacterBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCharacterBuffById.HandleId, 0, ConfigRogueResCharacterBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResCharacterBuffById.HandleId, ConfigRogueResCharacterBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResCharacterBuff rootAsRogueResCharacterBuff = RogueResCharacterBuff.GetRootAsRogueResCharacterBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCharacterBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResCharacterBuffById.HandleId, ConfigRogueResCharacterBuffById.LogPair);
			return new RogueResCharacterBuff?(rootAsRogueResCharacterBuff);
		}

		// Token: 0x04003A2B RID: 14891
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A2C RID: 14892
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A2D RID: 14893
		private const string TABLE = "RogueResCharacterBuff";

		// Token: 0x04003A2E RID: 14894
		private const string COMMAND = "select BinData from `RogueResCharacterBuff` where Id=?";

		// Token: 0x04003A2F RID: 14895
		private const string KEY_PREFIX = "RogueResCharacterBuffById";

		// Token: 0x04003A30 RID: 14896
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A31 RID: 14897
		private static int HandleId;
	}
}
