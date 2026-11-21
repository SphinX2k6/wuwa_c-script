using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092A RID: 2346
	public class ConfigRoverRogueBlessGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600370F RID: 14095 RVA: 0x00193C50 File Offset: 0x00191E50
		static ConfigRoverRogueBlessGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueBlessGroupById.CreateStaticDefaultValue), new Action(ConfigRoverRogueBlessGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00193C70 File Offset: 0x00191E70
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueBlessGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueBlessGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_增益.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueBlessGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueBlessGroup` where Id=?")
			});
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00193CEF File Offset: 0x00191EEF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueBlessGroupById.LogPair = null;
			ConfigRoverRogueBlessGroupById.HandleId = 0;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00193CFD File Offset: 0x00191EFD
		public static void Init()
		{
			ConfigRoverRogueBlessGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueBlessGroupById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueBlessGroup` where Id=?");
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00193D18 File Offset: 0x00191F18
		public static RoverRogueBlessGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueBlessGroupById.HandleId, ConfigRoverRogueBlessGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueBlessGroup?(RoverRogueBlessGroup.GetRootAsRoverRogueBlessGroup(configBuffer));
				}
			}
			ConfigRoverRogueBlessGroupById.LogPair.Clear();
			ConfigRoverRogueBlessGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueBlessGroupById.HandleId, 1, p0Id, ConfigRoverRogueBlessGroupById.LogPair) || ConfigCommon.Step(ConfigRoverRogueBlessGroupById.HandleId, true, ConfigRoverRogueBlessGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessGroupById.HandleId, ConfigRoverRogueBlessGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueBlessGroupById.HandleId, 0, ConfigRoverRogueBlessGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueBlessGroupById.HandleId, ConfigRoverRogueBlessGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueBlessGroup rootAsRoverRogueBlessGroup = RoverRogueBlessGroup.GetRootAsRoverRogueBlessGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueBlessGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueBlessGroupById.HandleId, ConfigRoverRogueBlessGroupById.LogPair);
			return new RoverRogueBlessGroup?(rootAsRoverRogueBlessGroup);
		}

		// Token: 0x0400400C RID: 16396
		private const string DB = "db_roverlike.db";

		// Token: 0x0400400D RID: 16397
		private const string FILE = "f.俯视肉鸽_增益.xlsx";

		// Token: 0x0400400E RID: 16398
		private const string TABLE = "RoverRogueBlessGroup";

		// Token: 0x0400400F RID: 16399
		private const string COMMAND = "select BinData from `RoverRogueBlessGroup` where Id=?";

		// Token: 0x04004010 RID: 16400
		private const string KEY_PREFIX = "RoverRogueBlessGroupById";

		// Token: 0x04004011 RID: 16401
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004012 RID: 16402
		private static int HandleId;
	}
}
