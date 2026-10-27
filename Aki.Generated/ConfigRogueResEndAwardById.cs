using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000843 RID: 2115
	public class ConfigRogueResEndAwardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031A4 RID: 12708 RVA: 0x00172177 File Offset: 0x00170377
		static ConfigRogueResEndAwardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEndAwardById.CreateStaticDefaultValue), new Action(ConfigRogueResEndAwardById.ResetStaticDefaultValue));
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x00172198 File Offset: 0x00170398
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEndAwardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEndAwardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEndAward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEndAward` where Id=?")
			});
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x00172217 File Offset: 0x00170417
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEndAwardById.LogPair = null;
			ConfigRogueResEndAwardById.HandleId = 0;
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x00172225 File Offset: 0x00170425
		public static void Init()
		{
			ConfigRogueResEndAwardById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEndAwardById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEndAward` where Id=?");
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x00172240 File Offset: 0x00170440
		public static RogueResEndAward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEndAwardById.HandleId, ConfigRogueResEndAwardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEndAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEndAward?(RogueResEndAward.GetRootAsRogueResEndAward(configBuffer));
				}
			}
			ConfigRogueResEndAwardById.LogPair.Clear();
			ConfigRogueResEndAwardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEndAwardById.HandleId, 1, p0Id, ConfigRogueResEndAwardById.LogPair) || ConfigCommon.Step(ConfigRogueResEndAwardById.HandleId, true, ConfigRogueResEndAwardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEndAwardById.HandleId, ConfigRogueResEndAwardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEndAwardById.HandleId, 0, ConfigRogueResEndAwardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEndAwardById.HandleId, ConfigRogueResEndAwardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEndAward rootAsRogueResEndAward = RogueResEndAward.GetRootAsRogueResEndAward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEndAwardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEndAwardById.HandleId, ConfigRogueResEndAwardById.LogPair);
			return new RogueResEndAward?(rootAsRogueResEndAward);
		}

		// Token: 0x040039BB RID: 14779
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039BC RID: 14780
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039BD RID: 14781
		private const string TABLE = "RogueResEndAward";

		// Token: 0x040039BE RID: 14782
		private const string COMMAND = "select BinData from `RogueResEndAward` where Id=?";

		// Token: 0x040039BF RID: 14783
		private const string KEY_PREFIX = "RogueResEndAwardById";

		// Token: 0x040039C0 RID: 14784
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039C1 RID: 14785
		private static int HandleId;
	}
}
