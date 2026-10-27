using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000830 RID: 2096
	public class ConfigRogueResAffixById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003132 RID: 12594 RVA: 0x0016F8F0 File Offset: 0x0016DAF0
		static ConfigRogueResAffixById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResAffixById.CreateStaticDefaultValue), new Action(ConfigRogueResAffixById.ResetStaticDefaultValue));
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x0016F910 File Offset: 0x0016DB10
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResAffixById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResAffixById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResAffix"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResAffix` where Id=?")
			});
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x0016F98F File Offset: 0x0016DB8F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResAffixById.LogPair = null;
			ConfigRogueResAffixById.HandleId = 0;
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x0016F99D File Offset: 0x0016DB9D
		public static void Init()
		{
			ConfigRogueResAffixById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResAffixById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResAffix` where Id=?");
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x0016F9B8 File Offset: 0x0016DBB8
		public static RogueResAffix? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResAffixById.HandleId, ConfigRogueResAffixById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResAffixById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResAffix?(RogueResAffix.GetRootAsRogueResAffix(configBuffer));
				}
			}
			ConfigRogueResAffixById.LogPair.Clear();
			ConfigRogueResAffixById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResAffixById.HandleId, 1, p0Id, ConfigRogueResAffixById.LogPair) || ConfigCommon.Step(ConfigRogueResAffixById.HandleId, true, ConfigRogueResAffixById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResAffixById.HandleId, ConfigRogueResAffixById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResAffixById.HandleId, 0, ConfigRogueResAffixById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResAffixById.HandleId, ConfigRogueResAffixById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResAffix rootAsRogueResAffix = RogueResAffix.GetRootAsRogueResAffix(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResAffixById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResAffixById.HandleId, ConfigRogueResAffixById.LogPair);
			return new RogueResAffix?(rootAsRogueResAffix);
		}

		// Token: 0x04003936 RID: 14646
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003937 RID: 14647
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003938 RID: 14648
		private const string TABLE = "RogueResAffix";

		// Token: 0x04003939 RID: 14649
		private const string COMMAND = "select BinData from `RogueResAffix` where Id=?";

		// Token: 0x0400393A RID: 14650
		private const string KEY_PREFIX = "RogueResAffixById";

		// Token: 0x0400393B RID: 14651
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400393C RID: 14652
		private static int HandleId;
	}
}
