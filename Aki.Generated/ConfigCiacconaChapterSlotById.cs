using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000174 RID: 372
	public class ConfigCiacconaChapterSlotById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x0008E5A8 File Offset: 0x0008C7A8
		static ConfigCiacconaChapterSlotById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaChapterSlotById.CreateStaticDefaultValue), new Action(ConfigCiacconaChapterSlotById.ResetStaticDefaultValue));
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x0008E5C8 File Offset: 0x0008C7C8
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

		// Token: 0x060008BB RID: 2235 RVA: 0x0008E647 File Offset: 0x0008C847
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaChapterSlotById.LogPair = null;
			ConfigCiacconaChapterSlotById.HandleId = 0;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0008E655 File Offset: 0x0008C855
		public static void Init()
		{
			ConfigCiacconaChapterSlotById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaChapterSlotById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaChapterSlot` where Id=?");
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x0008E670 File Offset: 0x0008C870
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

		// Token: 0x04000A10 RID: 2576
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A11 RID: 2577
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A12 RID: 2578
		private const string TABLE = "CiacconaChapterSlot";

		// Token: 0x04000A13 RID: 2579
		private const string COMMAND = "select BinData from `CiacconaChapterSlot` where Id=?";

		// Token: 0x04000A14 RID: 2580
		private const string KEY_PREFIX = "CiacconaChapterSlotById";

		// Token: 0x04000A15 RID: 2581
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A16 RID: 2582
		private static int HandleId;
	}
}
