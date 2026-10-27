using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000858 RID: 2136
	public class ConfigRogueResSynergyTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003222 RID: 12834 RVA: 0x00174EF3 File Offset: 0x001730F3
		static ConfigRogueResSynergyTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResSynergyTypeById.CreateStaticDefaultValue), new Action(ConfigRogueResSynergyTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x00174F14 File Offset: 0x00173114
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

		// Token: 0x06003224 RID: 12836 RVA: 0x00174F93 File Offset: 0x00173193
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResSynergyTypeById.LogPair = null;
			ConfigRogueResSynergyTypeById.HandleId = 0;
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00174FA1 File Offset: 0x001731A1
		public static void Init()
		{
			ConfigRogueResSynergyTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResSynergyTypeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResSynergyType` where Id=?");
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x00174FBC File Offset: 0x001731BC
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

		// Token: 0x04003A4E RID: 14926
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A4F RID: 14927
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A50 RID: 14928
		private const string TABLE = "RogueResSynergyType";

		// Token: 0x04003A51 RID: 14929
		private const string COMMAND = "select BinData from `RogueResSynergyType` where Id=?";

		// Token: 0x04003A52 RID: 14930
		private const string KEY_PREFIX = "RogueResSynergyTypeById";

		// Token: 0x04003A53 RID: 14931
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A54 RID: 14932
		private static int HandleId;
	}
}
