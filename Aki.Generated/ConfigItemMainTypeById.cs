using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000461 RID: 1121
	public class ConfigItemMainTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A50 RID: 6736 RVA: 0x000EE20F File Offset: 0x000EC40F
		static ConfigItemMainTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemMainTypeById.CreateStaticDefaultValue), new Action(ConfigItemMainTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x000EE230 File Offset: 0x000EC430
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

		// Token: 0x06001A52 RID: 6738 RVA: 0x000EE2AF File Offset: 0x000EC4AF
		public static void ResetStaticDefaultValue()
		{
			ConfigItemMainTypeById.LogPair = null;
			ConfigItemMainTypeById.HandleId = 0;
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x000EE2BD File Offset: 0x000EC4BD
		public static void Init()
		{
			ConfigItemMainTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigItemMainTypeById.HandleId, "db_bag.db", "select BinData from `ItemMainType` where Id=?");
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x000EE2D8 File Offset: 0x000EC4D8
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

		// Token: 0x04001E8B RID: 7819
		private const string DB = "db_bag.db";

		// Token: 0x04001E8C RID: 7820
		private const string FILE = "b.背包.xlsx";

		// Token: 0x04001E8D RID: 7821
		private const string TABLE = "ItemMainType";

		// Token: 0x04001E8E RID: 7822
		private const string COMMAND = "select BinData from `ItemMainType` where Id=?";

		// Token: 0x04001E8F RID: 7823
		private const string KEY_PREFIX = "ItemMainTypeById";

		// Token: 0x04001E90 RID: 7824
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E91 RID: 7825
		private static int HandleId;
	}
}
