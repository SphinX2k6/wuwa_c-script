using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000286 RID: 646
	public class ConfigEncircleMapItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F29 RID: 3881 RVA: 0x000B2A27 File Offset: 0x000B0C27
		static ConfigEncircleMapItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleMapItemById.CreateStaticDefaultValue), new Action(ConfigEncircleMapItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000B2A48 File Offset: 0x000B0C48
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

		// Token: 0x06000F2B RID: 3883 RVA: 0x000B2AC7 File Offset: 0x000B0CC7
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleMapItemById.LogPair = null;
			ConfigEncircleMapItemById.HandleId = 0;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000B2AD5 File Offset: 0x000B0CD5
		public static void Init()
		{
			ConfigEncircleMapItemById.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleMapItemById.HandleId, "db_encircle.db", "select BinData from `EncircleMapItem` where Id=?");
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000B2AF0 File Offset: 0x000B0CF0
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

		// Token: 0x0400118E RID: 4494
		private const string DB = "db_encircle.db";

		// Token: 0x0400118F RID: 4495
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x04001190 RID: 4496
		private const string TABLE = "EncircleMapItem";

		// Token: 0x04001191 RID: 4497
		private const string COMMAND = "select BinData from `EncircleMapItem` where Id=?";

		// Token: 0x04001192 RID: 4498
		private const string KEY_PREFIX = "EncircleMapItemById";

		// Token: 0x04001193 RID: 4499
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001194 RID: 4500
		private static int HandleId;
	}
}
