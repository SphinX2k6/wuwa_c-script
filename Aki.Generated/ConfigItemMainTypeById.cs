using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000477 RID: 1143
	public class ConfigItemMainTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AD4 RID: 6868 RVA: 0x000F4963 File Offset: 0x000F2B63
		static ConfigItemMainTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemMainTypeById.CreateStaticDefaultValue), new Action(ConfigItemMainTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000F4984 File Offset: 0x000F2B84
		public static void CreateStaticDefaultValue()
		{
			ConfigItemMainTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemMainTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bag.db"),
				new ValueTuple<string, object>("文件", "b.背包.xlsx"),
				new ValueTuple<string, object>("表名", "ItemMainType"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemMainType` where Id=?")
			});
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000F4A03 File Offset: 0x000F2C03
		public static void ResetStaticDefaultValue()
		{
			ConfigItemMainTypeById.LogPair = null;
			ConfigItemMainTypeById.HandleId = 0;
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000F4A11 File Offset: 0x000F2C11
		public static void Init()
		{
			ConfigItemMainTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigItemMainTypeById.HandleId, "db_bag.db", "select BinData from `ItemMainType` where Id=?");
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x000F4A2C File Offset: 0x000F2C2C
		public static ItemMainType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemMainTypeById.HandleId, ConfigItemMainTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemMainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemMainType?(ItemMainType.GetRootAsItemMainType(configBuffer));
				}
			}
			ConfigItemMainTypeById.LogPair.Clear();
			ConfigItemMainTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigItemMainTypeById.HandleId, 1, p0Id, ConfigItemMainTypeById.LogPair) || ConfigCommon.Step(ConfigItemMainTypeById.HandleId, true, ConfigItemMainTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemMainTypeById.HandleId, ConfigItemMainTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemMainTypeById.HandleId, 0, ConfigItemMainTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemMainTypeById.HandleId, ConfigItemMainTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemMainType rootAsItemMainType = ItemMainType.GetRootAsItemMainType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemMainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemMainTypeById.HandleId, ConfigItemMainTypeById.LogPair);
			return new ItemMainType?(rootAsItemMainType);
		}

		// Token: 0x04001F25 RID: 7973
		private const string DB = "db_bag.db";

		// Token: 0x04001F26 RID: 7974
		private const string FILE = "b.背包.xlsx";

		// Token: 0x04001F27 RID: 7975
		private const string TABLE = "ItemMainType";

		// Token: 0x04001F28 RID: 7976
		private const string COMMAND = "select BinData from `ItemMainType` where Id=?";

		// Token: 0x04001F29 RID: 7977
		private const string KEY_PREFIX = "ItemMainTypeById";

		// Token: 0x04001F2A RID: 7978
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F2B RID: 7979
		private static int HandleId;
	}
}
