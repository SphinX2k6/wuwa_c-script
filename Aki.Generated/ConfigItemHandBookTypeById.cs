using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000471 RID: 1137
	public class ConfigItemHandBookTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AB0 RID: 6832 RVA: 0x000F3D7B File Offset: 0x000F1F7B
		static ConfigItemHandBookTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemHandBookTypeById.CreateStaticDefaultValue), new Action(ConfigItemHandBookTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x000F3D9C File Offset: 0x000F1F9C
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

		// Token: 0x06001AB2 RID: 6834 RVA: 0x000F3E1B File Offset: 0x000F201B
		public static void ResetStaticDefaultValue()
		{
			ConfigItemHandBookTypeById.LogPair = null;
			ConfigItemHandBookTypeById.HandleId = 0;
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x000F3E29 File Offset: 0x000F2029
		public static void Init()
		{
			ConfigItemHandBookTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigItemHandBookTypeById.HandleId, "db_handbook.db", "select BinData from `ItemHandBookType` where Id=?");
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000F3E44 File Offset: 0x000F2044
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

		// Token: 0x04001EFB RID: 7931
		private const string DB = "db_handbook.db";

		// Token: 0x04001EFC RID: 7932
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04001EFD RID: 7933
		private const string TABLE = "ItemHandBookType";

		// Token: 0x04001EFE RID: 7934
		private const string COMMAND = "select BinData from `ItemHandBookType` where Id=?";

		// Token: 0x04001EFF RID: 7935
		private const string KEY_PREFIX = "ItemHandBookTypeById";

		// Token: 0x04001F00 RID: 7936
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F01 RID: 7937
		private static int HandleId;
	}
}
