using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000870 RID: 2160
	public class ConfigRogueResRoomTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032B2 RID: 12978 RVA: 0x0017BA24 File Offset: 0x00179C24
		static ConfigRogueResRoomTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResRoomTypeById.CreateStaticDefaultValue), new Action(ConfigRogueResRoomTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x0017BA44 File Offset: 0x00179C44
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResRoomTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResRoomTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResRoomType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResRoomType` where Id=?")
			});
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x0017BAC3 File Offset: 0x00179CC3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResRoomTypeById.LogPair = null;
			ConfigRogueResRoomTypeById.HandleId = 0;
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x0017BAD1 File Offset: 0x00179CD1
		public static void Init()
		{
			ConfigRogueResRoomTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResRoomTypeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResRoomType` where Id=?");
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x0017BAEC File Offset: 0x00179CEC
		public static RogueResRoomType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResRoomTypeById.HandleId, ConfigRogueResRoomTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResRoomType?(RogueResRoomType.GetRootAsRogueResRoomType(configBuffer));
				}
			}
			ConfigRogueResRoomTypeById.LogPair.Clear();
			ConfigRogueResRoomTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResRoomTypeById.HandleId, 1, p0Id, ConfigRogueResRoomTypeById.LogPair) || ConfigCommon.Step(ConfigRogueResRoomTypeById.HandleId, true, ConfigRogueResRoomTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResRoomTypeById.HandleId, ConfigRogueResRoomTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResRoomTypeById.HandleId, 0, ConfigRogueResRoomTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResRoomTypeById.HandleId, ConfigRogueResRoomTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResRoomType rootAsRogueResRoomType = RogueResRoomType.GetRootAsRogueResRoomType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResRoomTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResRoomTypeById.HandleId, ConfigRogueResRoomTypeById.LogPair);
			return new RogueResRoomType?(rootAsRogueResRoomType);
		}

		// Token: 0x04003AF6 RID: 15094
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003AF7 RID: 15095
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003AF8 RID: 15096
		private const string TABLE = "RogueResRoomType";

		// Token: 0x04003AF9 RID: 15097
		private const string COMMAND = "select BinData from `RogueResRoomType` where Id=?";

		// Token: 0x04003AFA RID: 15098
		private const string KEY_PREFIX = "RogueResRoomTypeById";

		// Token: 0x04003AFB RID: 15099
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AFC RID: 15100
		private static int HandleId;
	}
}
