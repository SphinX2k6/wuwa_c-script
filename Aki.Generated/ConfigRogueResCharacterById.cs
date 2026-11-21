using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000854 RID: 2132
	public class ConfigRogueResCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600320A RID: 12810 RVA: 0x00177CB0 File Offset: 0x00175EB0
		static ConfigRogueResCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCharacterById.CreateStaticDefaultValue), new Action(ConfigRogueResCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x00177CD0 File Offset: 0x00175ED0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResCharacterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResCharacterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResCharacter` where Id=?")
			});
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x00177D4F File Offset: 0x00175F4F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCharacterById.LogPair = null;
			ConfigRogueResCharacterById.HandleId = 0;
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x00177D5D File Offset: 0x00175F5D
		public static void Init()
		{
			ConfigRogueResCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCharacterById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCharacter` where Id=?");
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x00177D78 File Offset: 0x00175F78
		public static RogueResCharacter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResCharacterById.HandleId, ConfigRogueResCharacterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResCharacter?(RogueResCharacter.GetRootAsRogueResCharacter(configBuffer));
				}
			}
			ConfigRogueResCharacterById.LogPair.Clear();
			ConfigRogueResCharacterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResCharacterById.HandleId, 1, p0Id, ConfigRogueResCharacterById.LogPair) || ConfigCommon.Step(ConfigRogueResCharacterById.HandleId, true, ConfigRogueResCharacterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResCharacterById.HandleId, ConfigRogueResCharacterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResCharacterById.HandleId, 0, ConfigRogueResCharacterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResCharacterById.HandleId, ConfigRogueResCharacterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResCharacter rootAsRogueResCharacter = RogueResCharacter.GetRootAsRogueResCharacter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResCharacterById.HandleId, ConfigRogueResCharacterById.LogPair);
			return new RogueResCharacter?(rootAsRogueResCharacter);
		}

		// Token: 0x04003A32 RID: 14898
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A33 RID: 14899
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A34 RID: 14900
		private const string TABLE = "RogueResCharacter";

		// Token: 0x04003A35 RID: 14901
		private const string COMMAND = "select BinData from `RogueResCharacter` where Id=?";

		// Token: 0x04003A36 RID: 14902
		private const string KEY_PREFIX = "RogueResCharacterById";

		// Token: 0x04003A37 RID: 14903
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A38 RID: 14904
		private static int HandleId;
	}
}
