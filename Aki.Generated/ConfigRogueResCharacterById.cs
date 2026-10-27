using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000838 RID: 2104
	public class ConfigRogueResCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003162 RID: 12642 RVA: 0x001709C8 File Offset: 0x0016EBC8
		static ConfigRogueResCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResCharacterById.CreateStaticDefaultValue), new Action(ConfigRogueResCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x001709E8 File Offset: 0x0016EBE8
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

		// Token: 0x06003164 RID: 12644 RVA: 0x00170A67 File Offset: 0x0016EC67
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResCharacterById.LogPair = null;
			ConfigRogueResCharacterById.HandleId = 0;
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x00170A75 File Offset: 0x0016EC75
		public static void Init()
		{
			ConfigRogueResCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResCharacterById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResCharacter` where Id=?");
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x00170A90 File Offset: 0x0016EC90
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

		// Token: 0x0400396E RID: 14702
		private const string DB = "db_permanentrogue.db";

		// Token: 0x0400396F RID: 14703
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003970 RID: 14704
		private const string TABLE = "RogueResCharacter";

		// Token: 0x04003971 RID: 14705
		private const string COMMAND = "select BinData from `RogueResCharacter` where Id=?";

		// Token: 0x04003972 RID: 14706
		private const string KEY_PREFIX = "RogueResCharacterById";

		// Token: 0x04003973 RID: 14707
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003974 RID: 14708
		private static int HandleId;
	}
}
