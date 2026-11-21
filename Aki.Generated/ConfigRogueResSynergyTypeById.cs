using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000874 RID: 2164
	public class ConfigRogueResSynergyTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032CA RID: 13002 RVA: 0x0017C1DB File Offset: 0x0017A3DB
		static ConfigRogueResSynergyTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResSynergyTypeById.CreateStaticDefaultValue), new Action(ConfigRogueResSynergyTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x0017C1FC File Offset: 0x0017A3FC
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResSynergyTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResSynergyTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResSynergyType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResSynergyType` where Id=?")
			});
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x0017C27B File Offset: 0x0017A47B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResSynergyTypeById.LogPair = null;
			ConfigRogueResSynergyTypeById.HandleId = 0;
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x0017C289 File Offset: 0x0017A489
		public static void Init()
		{
			ConfigRogueResSynergyTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResSynergyTypeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResSynergyType` where Id=?");
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x0017C2A4 File Offset: 0x0017A4A4
		public static RogueResSynergyType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResSynergyTypeById.HandleId, ConfigRogueResSynergyTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResSynergyTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResSynergyType?(RogueResSynergyType.GetRootAsRogueResSynergyType(configBuffer));
				}
			}
			ConfigRogueResSynergyTypeById.LogPair.Clear();
			ConfigRogueResSynergyTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResSynergyTypeById.HandleId, 1, p0Id, ConfigRogueResSynergyTypeById.LogPair) || ConfigCommon.Step(ConfigRogueResSynergyTypeById.HandleId, true, ConfigRogueResSynergyTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResSynergyTypeById.HandleId, ConfigRogueResSynergyTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResSynergyTypeById.HandleId, 0, ConfigRogueResSynergyTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResSynergyTypeById.HandleId, ConfigRogueResSynergyTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResSynergyType rootAsRogueResSynergyType = RogueResSynergyType.GetRootAsRogueResSynergyType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResSynergyTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResSynergyTypeById.HandleId, ConfigRogueResSynergyTypeById.LogPair);
			return new RogueResSynergyType?(rootAsRogueResSynergyType);
		}

		// Token: 0x04003B12 RID: 15122
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B13 RID: 15123
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B14 RID: 15124
		private const string TABLE = "RogueResSynergyType";

		// Token: 0x04003B15 RID: 15125
		private const string COMMAND = "select BinData from `RogueResSynergyType` where Id=?";

		// Token: 0x04003B16 RID: 15126
		private const string KEY_PREFIX = "RogueResSynergyTypeById";

		// Token: 0x04003B17 RID: 15127
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B18 RID: 15128
		private static int HandleId;
	}
}
