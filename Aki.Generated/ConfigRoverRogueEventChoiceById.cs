using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E5 RID: 2277
	public class ConfigRoverRogueEventChoiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003571 RID: 13681 RVA: 0x0018771C File Offset: 0x0018591C
		static ConfigRoverRogueEventChoiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueEventChoiceById.CreateStaticDefaultValue), new Action(ConfigRoverRogueEventChoiceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x0018773C File Offset: 0x0018593C
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

		// Token: 0x06003573 RID: 13683 RVA: 0x001877BB File Offset: 0x001859BB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueEventChoiceById.LogPair = null;
			ConfigRoverRogueEventChoiceById.HandleId = 0;
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x001877C9 File Offset: 0x001859C9
		public static void Init()
		{
			ConfigRoverRogueEventChoiceById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueEventChoiceById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueEventChoice` where Id=?");
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x001877E4 File Offset: 0x001859E4
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

		// Token: 0x04003E29 RID: 15913
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E2A RID: 15914
		private const string FILE = "f.俯视肉鸽_事件.xlsx";

		// Token: 0x04003E2B RID: 15915
		private const string TABLE = "RoverRogueEventChoice";

		// Token: 0x04003E2C RID: 15916
		private const string COMMAND = "select BinData from `RoverRogueEventChoice` where Id=?";

		// Token: 0x04003E2D RID: 15917
		private const string KEY_PREFIX = "RoverRogueEventChoiceById";

		// Token: 0x04003E2E RID: 15918
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E2F RID: 15919
		private static int HandleId;
	}
}
