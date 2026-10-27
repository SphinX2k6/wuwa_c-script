using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000272 RID: 626
	public class ConfigEncircleMapItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EB1 RID: 3761 RVA: 0x000AC763 File Offset: 0x000AA963
		static ConfigEncircleMapItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleMapItemById.CreateStaticDefaultValue), new Action(ConfigEncircleMapItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000AC784 File Offset: 0x000AA984
		public static void CreateStaticDefaultValue()
		{
			ConfigEncircleMapItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEncircleMapItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_encircle.db"),
				new ValueTuple<string, object>("文件", "j.界面围剿.xlsx"),
				new ValueTuple<string, object>("表名", "EncircleMapItem"),
				new ValueTuple<string, object>("语句", "select BinData from `EncircleMapItem` where Id=?")
			});
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000AC803 File Offset: 0x000AAA03
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleMapItemById.LogPair = null;
			ConfigEncircleMapItemById.HandleId = 0;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000AC811 File Offset: 0x000AAA11
		public static void Init()
		{
			ConfigEncircleMapItemById.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleMapItemById.HandleId, "db_encircle.db", "select BinData from `EncircleMapItem` where Id=?");
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000AC82C File Offset: 0x000AAA2C
		public static EncircleMapItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEncircleMapItemById.HandleId, ConfigEncircleMapItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleMapItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EncircleMapItem?(EncircleMapItem.GetRootAsEncircleMapItem(configBuffer));
				}
			}
			ConfigEncircleMapItemById.LogPair.Clear();
			ConfigEncircleMapItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEncircleMapItemById.HandleId, 1, p0Id, ConfigEncircleMapItemById.LogPair) || ConfigCommon.Step(ConfigEncircleMapItemById.HandleId, true, ConfigEncircleMapItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEncircleMapItemById.HandleId, ConfigEncircleMapItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEncircleMapItemById.HandleId, 0, ConfigEncircleMapItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEncircleMapItemById.HandleId, ConfigEncircleMapItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EncircleMapItem rootAsEncircleMapItem = EncircleMapItem.GetRootAsEncircleMapItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleMapItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEncircleMapItemById.HandleId, ConfigEncircleMapItemById.LogPair);
			return new EncircleMapItem?(rootAsEncircleMapItem);
		}

		// Token: 0x04001102 RID: 4354
		private const string DB = "db_encircle.db";

		// Token: 0x04001103 RID: 4355
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x04001104 RID: 4356
		private const string TABLE = "EncircleMapItem";

		// Token: 0x04001105 RID: 4357
		private const string COMMAND = "select BinData from `EncircleMapItem` where Id=?";

		// Token: 0x04001106 RID: 4358
		private const string KEY_PREFIX = "EncircleMapItemById";

		// Token: 0x04001107 RID: 4359
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001108 RID: 4360
		private static int HandleId;
	}
}
