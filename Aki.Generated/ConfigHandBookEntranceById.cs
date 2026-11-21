using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E2 RID: 994
	public class ConfigHandBookEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001753 RID: 5971 RVA: 0x000E0E73 File Offset: 0x000DF073
		static ConfigHandBookEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHandBookEntranceById.CreateStaticDefaultValue), new Action(ConfigHandBookEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x000E0E94 File Offset: 0x000DF094
		public static void CreateStaticDefaultValue()
		{
			ConfigHandBookEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHandBookEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook_entrance.db"),
				new ValueTuple<string, object>("文件", "t.图鉴入口.xlsx"),
				new ValueTuple<string, object>("表名", "HandBookEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `HandBookEntrance` where Id=?")
			});
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x000E0F13 File Offset: 0x000DF113
		public static void ResetStaticDefaultValue()
		{
			ConfigHandBookEntranceById.LogPair = null;
			ConfigHandBookEntranceById.HandleId = 0;
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x000E0F21 File Offset: 0x000DF121
		public static void Init()
		{
			ConfigHandBookEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigHandBookEntranceById.HandleId, "db_handbook_entrance.db", "select BinData from `HandBookEntrance` where Id=?");
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x000E0F3C File Offset: 0x000DF13C
		public static HandBookEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHandBookEntranceById.HandleId, ConfigHandBookEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HandBookEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HandBookEntrance?(HandBookEntrance.GetRootAsHandBookEntrance(configBuffer));
				}
			}
			ConfigHandBookEntranceById.LogPair.Clear();
			ConfigHandBookEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHandBookEntranceById.HandleId, 1, p0Id, ConfigHandBookEntranceById.LogPair) || ConfigCommon.Step(ConfigHandBookEntranceById.HandleId, true, ConfigHandBookEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHandBookEntranceById.HandleId, ConfigHandBookEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHandBookEntranceById.HandleId, 0, ConfigHandBookEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHandBookEntranceById.HandleId, ConfigHandBookEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HandBookEntrance rootAsHandBookEntrance = HandBookEntrance.GetRootAsHandBookEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HandBookEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHandBookEntranceById.HandleId, ConfigHandBookEntranceById.LogPair);
			return new HandBookEntrance?(rootAsHandBookEntrance);
		}

		// Token: 0x04001B12 RID: 6930
		private const string DB = "db_handbook_entrance.db";

		// Token: 0x04001B13 RID: 6931
		private const string FILE = "t.图鉴入口.xlsx";

		// Token: 0x04001B14 RID: 6932
		private const string TABLE = "HandBookEntrance";

		// Token: 0x04001B15 RID: 6933
		private const string COMMAND = "select BinData from `HandBookEntrance` where Id=?";

		// Token: 0x04001B16 RID: 6934
		private const string KEY_PREFIX = "HandBookEntranceById";

		// Token: 0x04001B17 RID: 6935
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B18 RID: 6936
		private static int HandleId;
	}
}
