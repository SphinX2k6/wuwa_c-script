using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051F RID: 1311
	public class ConfigMainTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x0010A9DF File Offset: 0x00108BDF
		static ConfigMainTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainTypeById.CreateStaticDefaultValue), new Action(ConfigMainTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x0010AA00 File Offset: 0x00108C00
		public static void CreateStaticDefaultValue()
		{
			ConfigMainTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "MainType"),
				new ValueTuple<string, object>("语句", "select BinData from `MainType` where Id=?")
			});
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0010AA7F File Offset: 0x00108C7F
		public static void ResetStaticDefaultValue()
		{
			ConfigMainTypeById.LogPair = null;
			ConfigMainTypeById.HandleId = 0;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0010AA8D File Offset: 0x00108C8D
		public static void Init()
		{
			ConfigMainTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMainTypeById.HandleId, "db_menu.db", "select BinData from `MainType` where Id=?");
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0010AAA8 File Offset: 0x00108CA8
		public static MainType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainTypeById.HandleId, ConfigMainTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MainType?(MainType.GetRootAsMainType(configBuffer));
				}
			}
			ConfigMainTypeById.LogPair.Clear();
			ConfigMainTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMainTypeById.HandleId, 1, p0Id, ConfigMainTypeById.LogPair) || ConfigCommon.Step(ConfigMainTypeById.HandleId, true, ConfigMainTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMainTypeById.HandleId, ConfigMainTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainTypeById.HandleId, 0, ConfigMainTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMainTypeById.HandleId, ConfigMainTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MainType rootAsMainType = MainType.GetRootAsMainType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MainTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMainTypeById.HandleId, ConfigMainTypeById.LogPair);
			return new MainType?(rootAsMainType);
		}

		// Token: 0x040023BD RID: 9149
		private const string DB = "db_menu.db";

		// Token: 0x040023BE RID: 9150
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x040023BF RID: 9151
		private const string TABLE = "MainType";

		// Token: 0x040023C0 RID: 9152
		private const string COMMAND = "select BinData from `MainType` where Id=?";

		// Token: 0x040023C1 RID: 9153
		private const string KEY_PREFIX = "MainTypeById";

		// Token: 0x040023C2 RID: 9154
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023C3 RID: 9155
		private static int HandleId;
	}
}
