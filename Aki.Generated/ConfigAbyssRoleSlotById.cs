using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000028 RID: 40
	public class ConfigAbyssRoleSlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x0005F1DF File Offset: 0x0005D3DF
		static ConfigAbyssRoleSlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRoleSlotById.CreateStaticDefaultValue), new Action(ConfigAbyssRoleSlotById.ResetStaticDefaultValue));
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0005F200 File Offset: 0x0005D400
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRoleSlotById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRoleSlotById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoleSlot"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoleSlot` where Id=?")
			});
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0005F27F File Offset: 0x0005D47F
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRoleSlotById.LogPair = null;
			ConfigAbyssRoleSlotById.HandleId = 0;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0005F28D File Offset: 0x0005D48D
		public static void Init()
		{
			ConfigAbyssRoleSlotById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRoleSlotById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRoleSlot` where Id=?");
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0005F2A8 File Offset: 0x0005D4A8
		public static AbyssRoleSlot? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRoleSlotById.HandleId, ConfigAbyssRoleSlotById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoleSlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssRoleSlot?(AbyssRoleSlot.GetRootAsAbyssRoleSlot(configBuffer));
				}
			}
			ConfigAbyssRoleSlotById.LogPair.Clear();
			ConfigAbyssRoleSlotById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssRoleSlotById.HandleId, 1, p0Id, ConfigAbyssRoleSlotById.LogPair) || ConfigCommon.Step(ConfigAbyssRoleSlotById.HandleId, true, ConfigAbyssRoleSlotById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssRoleSlotById.HandleId, ConfigAbyssRoleSlotById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRoleSlotById.HandleId, 0, ConfigAbyssRoleSlotById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssRoleSlotById.HandleId, ConfigAbyssRoleSlotById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssRoleSlot rootAsAbyssRoleSlot = AbyssRoleSlot.GetRootAsAbyssRoleSlot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRoleSlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssRoleSlotById.HandleId, ConfigAbyssRoleSlotById.LogPair);
			return new AbyssRoleSlot?(rootAsAbyssRoleSlot);
		}

		// Token: 0x040000FC RID: 252
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000FD RID: 253
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000FE RID: 254
		private const string TABLE = "AbyssRoleSlot";

		// Token: 0x040000FF RID: 255
		private const string COMMAND = "select BinData from `AbyssRoleSlot` where Id=?";

		// Token: 0x04000100 RID: 256
		private const string KEY_PREFIX = "AbyssRoleSlotById";

		// Token: 0x04000101 RID: 257
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000102 RID: 258
		private static int HandleId;
	}
}
