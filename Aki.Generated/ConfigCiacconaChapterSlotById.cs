using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000164 RID: 356
	public class ConfigCiacconaChapterSlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x00088A4C File Offset: 0x00086C4C
		static ConfigCiacconaChapterSlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaChapterSlotById.CreateStaticDefaultValue), new Action(ConfigCiacconaChapterSlotById.ResetStaticDefaultValue));
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00088A6C File Offset: 0x00086C6C
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaChapterSlotById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaChapterSlotById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaChapterSlot"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaChapterSlot` where Id=?")
			});
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00088AEB File Offset: 0x00086CEB
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaChapterSlotById.LogPair = null;
			ConfigCiacconaChapterSlotById.HandleId = 0;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00088AF9 File Offset: 0x00086CF9
		public static void Init()
		{
			ConfigCiacconaChapterSlotById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaChapterSlotById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaChapterSlot` where Id=?");
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00088B14 File Offset: 0x00086D14
		public static CiacconaChapterSlot? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaChapterSlotById.HandleId, ConfigCiacconaChapterSlotById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaChapterSlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaChapterSlot?(CiacconaChapterSlot.GetRootAsCiacconaChapterSlot(configBuffer));
				}
			}
			ConfigCiacconaChapterSlotById.LogPair.Clear();
			ConfigCiacconaChapterSlotById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaChapterSlotById.HandleId, 1, p0Id, ConfigCiacconaChapterSlotById.LogPair) || ConfigCommon.Step(ConfigCiacconaChapterSlotById.HandleId, true, ConfigCiacconaChapterSlotById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaChapterSlotById.HandleId, ConfigCiacconaChapterSlotById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaChapterSlotById.HandleId, 0, ConfigCiacconaChapterSlotById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaChapterSlotById.HandleId, ConfigCiacconaChapterSlotById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaChapterSlot rootAsCiacconaChapterSlot = CiacconaChapterSlot.GetRootAsCiacconaChapterSlot(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaChapterSlotById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaChapterSlotById.HandleId, ConfigCiacconaChapterSlotById.LogPair);
			return new CiacconaChapterSlot?(rootAsCiacconaChapterSlot);
		}

		// Token: 0x040009A0 RID: 2464
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009A1 RID: 2465
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009A2 RID: 2466
		private const string TABLE = "CiacconaChapterSlot";

		// Token: 0x040009A3 RID: 2467
		private const string COMMAND = "select BinData from `CiacconaChapterSlot` where Id=?";

		// Token: 0x040009A4 RID: 2468
		private const string KEY_PREFIX = "CiacconaChapterSlotById";

		// Token: 0x040009A5 RID: 2469
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009A6 RID: 2470
		private static int HandleId;
	}
}
