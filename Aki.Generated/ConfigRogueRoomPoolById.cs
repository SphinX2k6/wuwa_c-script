using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087D RID: 2173
	public class ConfigRogueRoomPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003300 RID: 13056 RVA: 0x0017D448 File Offset: 0x0017B648
		static ConfigRogueRoomPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueRoomPoolById.CreateStaticDefaultValue), new Action(ConfigRogueRoomPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x0017D468 File Offset: 0x0017B668
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueRoomPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueRoomPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueRoomPool"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueRoomPool` where Id=?")
			});
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x0017D4E7 File Offset: 0x0017B6E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueRoomPoolById.LogPair = null;
			ConfigRogueRoomPoolById.HandleId = 0;
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x0017D4F5 File Offset: 0x0017B6F5
		public static void Init()
		{
			ConfigRogueRoomPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueRoomPoolById.HandleId, "db_rogue.db", "select BinData from `RogueRoomPool` where Id=?");
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x0017D510 File Offset: 0x0017B710
		public static RogueRoomPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueRoomPoolById.HandleId, ConfigRogueRoomPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueRoomPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueRoomPool?(RogueRoomPool.GetRootAsRogueRoomPool(configBuffer));
				}
			}
			ConfigRogueRoomPoolById.LogPair.Clear();
			ConfigRogueRoomPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueRoomPoolById.HandleId, 1, p0Id, ConfigRogueRoomPoolById.LogPair) || ConfigCommon.Step(ConfigRogueRoomPoolById.HandleId, true, ConfigRogueRoomPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueRoomPoolById.HandleId, ConfigRogueRoomPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueRoomPoolById.HandleId, 0, ConfigRogueRoomPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueRoomPoolById.HandleId, ConfigRogueRoomPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueRoomPool rootAsRogueRoomPool = RogueRoomPool.GetRootAsRogueRoomPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueRoomPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueRoomPoolById.HandleId, ConfigRogueRoomPoolById.LogPair);
			return new RogueRoomPool?(rootAsRogueRoomPool);
		}

		// Token: 0x04003B51 RID: 15185
		private const string DB = "db_rogue.db";

		// Token: 0x04003B52 RID: 15186
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B53 RID: 15187
		private const string TABLE = "RogueRoomPool";

		// Token: 0x04003B54 RID: 15188
		private const string COMMAND = "select BinData from `RogueRoomPool` where Id=?";

		// Token: 0x04003B55 RID: 15189
		private const string KEY_PREFIX = "RogueRoomPoolById";

		// Token: 0x04003B56 RID: 15190
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B57 RID: 15191
		private static int HandleId;
	}
}
