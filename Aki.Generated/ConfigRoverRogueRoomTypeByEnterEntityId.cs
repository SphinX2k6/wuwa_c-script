using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000941 RID: 2369
	public class ConfigRoverRogueRoomTypeByEnterEntityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003799 RID: 14233 RVA: 0x00196C60 File Offset: 0x00194E60
		static ConfigRoverRogueRoomTypeByEnterEntityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueRoomTypeByEnterEntityId.CreateStaticDefaultValue), new Action(ConfigRoverRogueRoomTypeByEnterEntityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00196C80 File Offset: 0x00194E80
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueRoomType"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueRoomType` where EnterEntityId=?")
			});
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x00196CFF File Offset: 0x00194EFF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair = null;
			ConfigRoverRogueRoomTypeByEnterEntityId.HandleId = 0;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x00196D0D File Offset: 0x00194F0D
		public static void Init()
		{
			ConfigRoverRogueRoomTypeByEnterEntityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, "db_roverlike.db", "select BinData from `RoverRogueRoomType` where EnterEntityId=?");
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00196D28 File Offset: 0x00194F28
		public static RoverRogueRoomType? GetConfig(int p0EnterEntityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoomTypeByEnterEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EnterEntityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueRoomType?(RoverRogueRoomType.GetRootAsRoverRogueRoomType(configBuffer));
				}
			}
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair.Clear();
			ConfigRoverRogueRoomTypeByEnterEntityId.LogPair.Add(new ValueTuple<string, object>("EnterEntityId", p0EnterEntityId));
			if (!ConfigCommon.BindInt(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, 1, p0EnterEntityId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair) || ConfigCommon.Step(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, true, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, 0, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueRoomType rootAsRoverRogueRoomType = RoverRogueRoomType.GetRootAsRoverRogueRoomType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueRoomTypeByEnterEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0EnterEntityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueRoomTypeByEnterEntityId.HandleId, ConfigRoverRogueRoomTypeByEnterEntityId.LogPair);
			return new RoverRogueRoomType?(rootAsRoverRogueRoomType);
		}

		// Token: 0x040040AD RID: 16557
		private const string DB = "db_roverlike.db";

		// Token: 0x040040AE RID: 16558
		private const string FILE = "f.俯视肉鸽_关卡.xlsx";

		// Token: 0x040040AF RID: 16559
		private const string TABLE = "RoverRogueRoomType";

		// Token: 0x040040B0 RID: 16560
		private const string COMMAND = "select BinData from `RoverRogueRoomType` where EnterEntityId=?";

		// Token: 0x040040B1 RID: 16561
		private const string KEY_PREFIX = "RoverRogueRoomTypeByEnterEntityId";

		// Token: 0x040040B2 RID: 16562
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040B3 RID: 16563
		private static int HandleId;
	}
}
