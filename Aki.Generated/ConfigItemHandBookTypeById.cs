using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200045B RID: 1115
	public class ConfigItemHandBookTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A2C RID: 6700 RVA: 0x000ED627 File Offset: 0x000EB827
		static ConfigItemHandBookTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookTypeById.CreateStaticDefaultValue), new Action(ConfigItemHandBookTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x000ED648 File Offset: 0x000EB848
		public static void CreateStaticDefaultValue()
		{
			ConfigItemHandBookTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemHandBookTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ItemHandBookType"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemHandBookType` where Id=?")
			});
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000ED6C7 File Offset: 0x000EB8C7
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookTypeById.LogPair = null;
			ConfigItemHandBookTypeById.HandleId = 0;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x000ED6D5 File Offset: 0x000EB8D5
		public static void Init()
		{
			ConfigItemHandBookTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookTypeById.HandleId, "db_handbook.db", "select BinData from `ItemHandBookType` where Id=?");
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x000ED6F0 File Offset: 0x000EB8F0
		public static ItemHandBookType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemHandBookTypeById.HandleId, ConfigItemHandBookTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemHandBookTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemHandBookType?(ItemHandBookType.GetRootAsItemHandBookType(configBuffer));
				}
			}
			ConfigItemHandBookTypeById.LogPair.Clear();
			ConfigItemHandBookTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigItemHandBookTypeById.HandleId, 1, p0Id, ConfigItemHandBookTypeById.LogPair) || ConfigCommon.Step(ConfigItemHandBookTypeById.HandleId, true, ConfigItemHandBookTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemHandBookTypeById.HandleId, ConfigItemHandBookTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemHandBookTypeById.HandleId, 0, ConfigItemHandBookTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemHandBookTypeById.HandleId, ConfigItemHandBookTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemHandBookType rootAsItemHandBookType = ItemHandBookType.GetRootAsItemHandBookType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemHandBookTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemHandBookTypeById.HandleId, ConfigItemHandBookTypeById.LogPair);
			return new ItemHandBookType?(rootAsItemHandBookType);
		}

		// Token: 0x04001E61 RID: 7777
		private const string DB = "db_handbook.db";

		// Token: 0x04001E62 RID: 7778
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001E63 RID: 7779
		private const string TABLE = "ItemHandBookType";

		// Token: 0x04001E64 RID: 7780
		private const string COMMAND = "select BinData from `ItemHandBookType` where Id=?";

		// Token: 0x04001E65 RID: 7781
		private const string KEY_PREFIX = "ItemHandBookTypeById";

		// Token: 0x04001E66 RID: 7782
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E67 RID: 7783
		private static int HandleId;
	}
}
