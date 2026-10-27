using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DE RID: 2270
	public class ConfigRoverRogueBlessById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003547 RID: 13639 RVA: 0x001867E7 File Offset: 0x001849E7
		static ConfigRoverRogueBlessById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessById.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessById.ResetStaticDefaultValue));
		}

		// Token: 0x06003548 RID: 13640 RVA: 0x00186808 File Offset: 0x00184A08
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueBlessById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueBlessById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueBless"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueBless` where Id=?")
			});
		}

		// Token: 0x06003549 RID: 13641 RVA: 0x00186887 File Offset: 0x00184A87
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessById.LogPair = null;
			ConfigRoverRogueBlessById.HandleId = 0;
		}

		// Token: 0x0600354A RID: 13642 RVA: 0x00186895 File Offset: 0x00184A95
		public static void Init()
		{
			ConfigRoverRogueBlessById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBless` where Id=?");
		}

		// Token: 0x0600354B RID: 13643 RVA: 0x001868B0 File Offset: 0x00184AB0
		public static RoverRogueBless? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueBlessById.HandleId, ConfigRoverRogueBlessById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueBless?(RoverRogueBless.GetRootAsRoverRogueBless(configBuffer));
				}
			}
			ConfigRoverRogueBlessById.LogPair.Clear();
			ConfigRoverRogueBlessById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueBlessById.HandleId, 1, p0Id, ConfigRoverRogueBlessById.LogPair) || ConfigCommon.Step(ConfigRoverRogueBlessById.HandleId, true, ConfigRoverRogueBlessById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessById.HandleId, ConfigRoverRogueBlessById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueBlessById.HandleId, 0, ConfigRoverRogueBlessById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessById.HandleId, ConfigRoverRogueBlessById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueBless rootAsRoverRogueBless = RoverRogueBless.GetRootAsRoverRogueBless(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueBlessById.HandleId, ConfigRoverRogueBlessById.LogPair);
			return new RoverRogueBless?(rootAsRoverRogueBless);
		}

		// Token: 0x04003DF8 RID: 15864
		private const string DB = "db_roverlike.db";

		// Token: 0x04003DF9 RID: 15865
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x04003DFA RID: 15866
		private const string TABLE = "RoverRogueBless";

		// Token: 0x04003DFB RID: 15867
		private const string COMMAND = "select BinData from `RoverRogueBless` where Id=?";

		// Token: 0x04003DFC RID: 15868
		private const string KEY_PREFIX = "RoverRogueBlessById";

		// Token: 0x04003DFD RID: 15869
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DFE RID: 15870
		private static int HandleId;
	}
}
