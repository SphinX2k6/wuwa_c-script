using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000479 RID: 1145
	public class ConfigItemShowTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AE0 RID: 6880 RVA: 0x000F4DF4 File Offset: 0x000F2FF4
		static ConfigItemShowTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemShowTypeById.CreateStaticDefaultValue), new Action(ConfigItemShowTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x000F4E14 File Offset: 0x000F3014
		public static void CreateStaticDefaultValue()
		{
			ConfigItemShowTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemShowTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "ItemShowType"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemShowType` where Id=?")
			});
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000F4E93 File Offset: 0x000F3093
		public static void ResetStaticDefaultValue()
		{
			ConfigItemShowTypeById.LogPair = null;
			ConfigItemShowTypeById.HandleId = 0;
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x000F4EA1 File Offset: 0x000F30A1
		public static void Init()
		{
			ConfigItemShowTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigItemShowTypeById.HandleId, "db_item.db", "select BinData from `ItemShowType` where Id=?");
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x000F4EBC File Offset: 0x000F30BC
		public static ItemShowType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemShowTypeById.HandleId, ConfigItemShowTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemShowTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemShowType?(ItemShowType.GetRootAsItemShowType(configBuffer));
				}
			}
			ConfigItemShowTypeById.LogPair.Clear();
			ConfigItemShowTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigItemShowTypeById.HandleId, 1, p0Id, ConfigItemShowTypeById.LogPair) || ConfigCommon.Step(ConfigItemShowTypeById.HandleId, true, ConfigItemShowTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemShowTypeById.HandleId, ConfigItemShowTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemShowTypeById.HandleId, 0, ConfigItemShowTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemShowTypeById.HandleId, ConfigItemShowTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemShowType rootAsItemShowType = ItemShowType.GetRootAsItemShowType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemShowTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemShowTypeById.HandleId, ConfigItemShowTypeById.LogPair);
			return new ItemShowType?(rootAsItemShowType);
		}

		// Token: 0x04001F33 RID: 7987
		private const string DB = "db_item.db";

		// Token: 0x04001F34 RID: 7988
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04001F35 RID: 7989
		private const string TABLE = "ItemShowType";

		// Token: 0x04001F36 RID: 7990
		private const string COMMAND = "select BinData from `ItemShowType` where Id=?";

		// Token: 0x04001F37 RID: 7991
		private const string KEY_PREFIX = "ItemShowTypeById";

		// Token: 0x04001F38 RID: 7992
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F39 RID: 7993
		private static int HandleId;
	}
}
