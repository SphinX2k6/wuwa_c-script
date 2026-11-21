using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FD RID: 1021
	public class ConfigHonamiStoryItemCollectionByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017F5 RID: 6133 RVA: 0x000E499F File Offset: 0x000E2B9F
		static ConfigHonamiStoryItemCollectionByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemCollectionByItemId.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemCollectionByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x000E49C0 File Offset: 0x000E2BC0
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryItemCollectionByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryItemCollectionByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语局外.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryItemCollection"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryItemCollection` where ItemId=?")
			});
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x000E4A3F File Offset: 0x000E2C3F
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemCollectionByItemId.LogPair = null;
			ConfigHonamiStoryItemCollectionByItemId.HandleId = 0;
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000E4A4D File Offset: 0x000E2C4D
		public static void Init()
		{
			ConfigHonamiStoryItemCollectionByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemCollectionByItemId.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItemCollection` where ItemId=?");
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x000E4A68 File Offset: 0x000E2C68
		public static HonamiStoryItemCollection? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryItemCollectionByItemId.HandleId, ConfigHonamiStoryItemCollectionByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemCollectionByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HonamiStoryItemCollection?(HonamiStoryItemCollection.GetRootAsHonamiStoryItemCollection(configBuffer));
				}
			}
			ConfigHonamiStoryItemCollectionByItemId.LogPair.Clear();
			ConfigHonamiStoryItemCollectionByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigHonamiStoryItemCollectionByItemId.HandleId, 1, p0ItemId, ConfigHonamiStoryItemCollectionByItemId.LogPair) || ConfigCommon.Step(ConfigHonamiStoryItemCollectionByItemId.HandleId, true, ConfigHonamiStoryItemCollectionByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemCollectionByItemId.HandleId, ConfigHonamiStoryItemCollectionByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryItemCollectionByItemId.HandleId, 0, ConfigHonamiStoryItemCollectionByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHonamiStoryItemCollectionByItemId.HandleId, ConfigHonamiStoryItemCollectionByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HonamiStoryItemCollection rootAsHonamiStoryItemCollection = HonamiStoryItemCollection.GetRootAsHonamiStoryItemCollection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HonamiStoryItemCollectionByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHonamiStoryItemCollectionByItemId.HandleId, ConfigHonamiStoryItemCollectionByItemId.LogPair);
			return new HonamiStoryItemCollection?(rootAsHonamiStoryItemCollection);
		}

		// Token: 0x04001BCF RID: 7119
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BD0 RID: 7120
		private const string FILE = "s.穗波奇妙物语局外.xlsx";

		// Token: 0x04001BD1 RID: 7121
		private const string TABLE = "HonamiStoryItemCollection";

		// Token: 0x04001BD2 RID: 7122
		private const string COMMAND = "select BinData from `HonamiStoryItemCollection` where ItemId=?";

		// Token: 0x04001BD3 RID: 7123
		private const string KEY_PREFIX = "HonamiStoryItemCollectionByItemId";

		// Token: 0x04001BD4 RID: 7124
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BD5 RID: 7125
		private static int HandleId;
	}
}
