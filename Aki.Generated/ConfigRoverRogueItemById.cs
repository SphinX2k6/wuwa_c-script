using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E9 RID: 2281
	public class ConfigRoverRogueItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003589 RID: 13705 RVA: 0x00187ED3 File Offset: 0x001860D3
		static ConfigRoverRogueItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueItemById.CreateStaticDefaultValue), new Action(ConfigRoverRogueItemById.ResetStaticDefaultValue));
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00187EF4 File Offset: 0x001860F4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueItem` where Id=?")
			});
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00187F73 File Offset: 0x00186173
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueItemById.LogPair = null;
			ConfigRoverRogueItemById.HandleId = 0;
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00187F81 File Offset: 0x00186181
		public static void Init()
		{
			ConfigRoverRogueItemById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueItemById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueItem` where Id=?");
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00187F9C File Offset: 0x0018619C
		public static RoverRogueItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueItemById.HandleId, ConfigRoverRogueItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueItem?(RoverRogueItem.GetRootAsRoverRogueItem(configBuffer));
				}
			}
			ConfigRoverRogueItemById.LogPair.Clear();
			ConfigRoverRogueItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueItemById.HandleId, 1, p0Id, ConfigRoverRogueItemById.LogPair) || ConfigCommon.Step(ConfigRoverRogueItemById.HandleId, true, ConfigRoverRogueItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueItemById.HandleId, ConfigRoverRogueItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueItemById.HandleId, 0, ConfigRoverRogueItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueItemById.HandleId, ConfigRoverRogueItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueItem rootAsRoverRogueItem = RoverRogueItem.GetRootAsRoverRogueItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueItemById.HandleId, ConfigRoverRogueItemById.LogPair);
			return new RoverRogueItem?(rootAsRoverRogueItem);
		}

		// Token: 0x04003E45 RID: 15941
		private const string DB = "db_roverlike.db";

		// Token: 0x04003E46 RID: 15942
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04003E47 RID: 15943
		private const string TABLE = "RoverRogueItem";

		// Token: 0x04003E48 RID: 15944
		private const string COMMAND = "select BinData from `RoverRogueItem` where Id=?";

		// Token: 0x04003E49 RID: 15945
		private const string KEY_PREFIX = "RoverRogueItemById";

		// Token: 0x04003E4A RID: 15946
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E4B RID: 15947
		private static int HandleId;
	}
}
