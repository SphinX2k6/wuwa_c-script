using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000944 RID: 2372
	public class ConfigRoverRogueTalentTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037AB RID: 14251 RVA: 0x00197283 File Offset: 0x00195483
		static ConfigRoverRogueTalentTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueTalentTreeById.CreateStaticDefaultValue), new Action(ConfigRoverRogueTalentTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x001972A4 File Offset: 0x001954A4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueTalentTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueTalentTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueTalentTree` where Id=?")
			});
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x00197323 File Offset: 0x00195523
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueTalentTreeById.LogPair = null;
			ConfigRoverRogueTalentTreeById.HandleId = 0;
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x00197331 File Offset: 0x00195531
		public static void Init()
		{
			ConfigRoverRogueTalentTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueTalentTreeById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueTalentTree` where Id=?");
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x0019734C File Offset: 0x0019554C
		public static RoverRogueTalentTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueTalentTreeById.HandleId, ConfigRoverRogueTalentTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueTalentTree?(RoverRogueTalentTree.GetRootAsRoverRogueTalentTree(configBuffer));
				}
			}
			ConfigRoverRogueTalentTreeById.LogPair.Clear();
			ConfigRoverRogueTalentTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueTalentTreeById.HandleId, 1, p0Id, ConfigRoverRogueTalentTreeById.LogPair) || ConfigCommon.Step(ConfigRoverRogueTalentTreeById.HandleId, true, ConfigRoverRogueTalentTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueTalentTreeById.HandleId, ConfigRoverRogueTalentTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueTalentTreeById.HandleId, 0, ConfigRoverRogueTalentTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueTalentTreeById.HandleId, ConfigRoverRogueTalentTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueTalentTree rootAsRoverRogueTalentTree = RoverRogueTalentTree.GetRootAsRoverRogueTalentTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueTalentTreeById.HandleId, ConfigRoverRogueTalentTreeById.LogPair);
			return new RoverRogueTalentTree?(rootAsRoverRogueTalentTree);
		}

		// Token: 0x040040C2 RID: 16578
		private const string DB = "db_roverlike.db";

		// Token: 0x040040C3 RID: 16579
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x040040C4 RID: 16580
		private const string TABLE = "RoverRogueTalentTree";

		// Token: 0x040040C5 RID: 16581
		private const string COMMAND = "select BinData from `RoverRogueTalentTree` where Id=?";

		// Token: 0x040040C6 RID: 16582
		private const string KEY_PREFIX = "RoverRogueTalentTreeById";

		// Token: 0x040040C7 RID: 16583
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040C8 RID: 16584
		private static int HandleId;
	}
}
