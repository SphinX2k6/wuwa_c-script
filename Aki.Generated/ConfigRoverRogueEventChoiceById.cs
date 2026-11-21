using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000930 RID: 2352
	public class ConfigRoverRogueEventChoiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003733 RID: 14131 RVA: 0x0019493C File Offset: 0x00192B3C
		static ConfigRoverRogueEventChoiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueEventChoiceById.CreateStaticDefaultValue), new Action(ConfigRoverRogueEventChoiceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x0019495C File Offset: 0x00192B5C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueEventChoiceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueEventChoiceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_事件.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueEventChoice"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueEventChoice` where Id=?")
			});
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x001949DB File Offset: 0x00192BDB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueEventChoiceById.LogPair = null;
			ConfigRoverRogueEventChoiceById.HandleId = 0;
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x001949E9 File Offset: 0x00192BE9
		public static void Init()
		{
			ConfigRoverRogueEventChoiceById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueEventChoiceById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueEventChoice` where Id=?");
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00194A04 File Offset: 0x00192C04
		public static RoverRogueEventChoice? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueEventChoiceById.HandleId, ConfigRoverRogueEventChoiceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueEventChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueEventChoice?(RoverRogueEventChoice.GetRootAsRoverRogueEventChoice(configBuffer));
				}
			}
			ConfigRoverRogueEventChoiceById.LogPair.Clear();
			ConfigRoverRogueEventChoiceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueEventChoiceById.HandleId, 1, p0Id, ConfigRoverRogueEventChoiceById.LogPair) || ConfigCommon.Step(ConfigRoverRogueEventChoiceById.HandleId, true, ConfigRoverRogueEventChoiceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueEventChoiceById.HandleId, ConfigRoverRogueEventChoiceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueEventChoiceById.HandleId, 0, ConfigRoverRogueEventChoiceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueEventChoiceById.HandleId, ConfigRoverRogueEventChoiceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueEventChoice rootAsRoverRogueEventChoice = RoverRogueEventChoice.GetRootAsRoverRogueEventChoice(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueEventChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueEventChoiceById.HandleId, ConfigRoverRogueEventChoiceById.LogPair);
			return new RoverRogueEventChoice?(rootAsRoverRogueEventChoice);
		}

		// Token: 0x04004036 RID: 16438
		private const string DB = "db_roverlike.db";

		// Token: 0x04004037 RID: 16439
		private const string FILE = "f.俯视肉鸽_事件.xlsx";

		// Token: 0x04004038 RID: 16440
		private const string TABLE = "RoverRogueEventChoice";

		// Token: 0x04004039 RID: 16441
		private const string COMMAND = "select BinData from `RoverRogueEventChoice` where Id=?";

		// Token: 0x0400403A RID: 16442
		private const string KEY_PREFIX = "RoverRogueEventChoiceById";

		// Token: 0x0400403B RID: 16443
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400403C RID: 16444
		private static int HandleId;
	}
}
