using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000463 RID: 1123
	public class ConfigItemShowTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A5C RID: 6748 RVA: 0x000EE6A0 File Offset: 0x000EC8A0
		static ConfigItemShowTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemShowTypeById.CreateStaticDefaultValue), new Action(ConfigItemShowTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000EE6C0 File Offset: 0x000EC8C0
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

		// Token: 0x06001A5E RID: 6750 RVA: 0x000EE73F File Offset: 0x000EC93F
		public static void ResetStaticDefaultValue()
		{
			ConfigItemShowTypeById.LogPair = null;
			ConfigItemShowTypeById.HandleId = 0;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000EE74D File Offset: 0x000EC94D
		public static void Init()
		{
			ConfigItemShowTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigItemShowTypeById.HandleId, "db_item.db", "select BinData from `ItemShowType` where Id=?");
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x000EE768 File Offset: 0x000EC968
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

		// Token: 0x04001E99 RID: 7833
		private const string DB = "db_item.db";

		// Token: 0x04001E9A RID: 7834
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04001E9B RID: 7835
		private const string TABLE = "ItemShowType";

		// Token: 0x04001E9C RID: 7836
		private const string COMMAND = "select BinData from `ItemShowType` where Id=?";

		// Token: 0x04001E9D RID: 7837
		private const string KEY_PREFIX = "ItemShowTypeById";

		// Token: 0x04001E9E RID: 7838
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E9F RID: 7839
		private static int HandleId;
	}
}
