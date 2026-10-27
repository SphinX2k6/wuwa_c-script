using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051D RID: 1309
	public class ConfigMapMarkPhantomGroupByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EB9 RID: 7865 RVA: 0x00106E07 File Offset: 0x00105007
		static ConfigMapMarkPhantomGroupByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkPhantomGroupByMarkId.CreateStaticDefaultValue), new Action(ConfigMapMarkPhantomGroupByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00106E28 File Offset: 0x00105028
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkPhantomGroupByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkPhantomGroupByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMarkPhantomGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMarkPhantomGroup` where MarkId=?")
			});
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00106EA7 File Offset: 0x001050A7
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkPhantomGroupByMarkId.LogPair = null;
			ConfigMapMarkPhantomGroupByMarkId.HandleId = 0;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00106EB5 File Offset: 0x001050B5
		public static void Init()
		{
			ConfigMapMarkPhantomGroupByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkPhantomGroupByMarkId.HandleId, "db_map_mark.db", "select BinData from `MapMarkPhantomGroup` where MarkId=?");
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00106ED0 File Offset: 0x001050D0
		public static MapMarkPhantomGroup? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkPhantomGroupByMarkId.HandleId, ConfigMapMarkPhantomGroupByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkPhantomGroupByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapMarkPhantomGroup?(MapMarkPhantomGroup.GetRootAsMapMarkPhantomGroup(configBuffer));
				}
			}
			ConfigMapMarkPhantomGroupByMarkId.LogPair.Clear();
			ConfigMapMarkPhantomGroupByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigMapMarkPhantomGroupByMarkId.HandleId, 1, p0MarkId, ConfigMapMarkPhantomGroupByMarkId.LogPair) || ConfigCommon.Step(ConfigMapMarkPhantomGroupByMarkId.HandleId, true, ConfigMapMarkPhantomGroupByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapMarkPhantomGroupByMarkId.HandleId, ConfigMapMarkPhantomGroupByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkPhantomGroupByMarkId.HandleId, 0, ConfigMapMarkPhantomGroupByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapMarkPhantomGroupByMarkId.HandleId, ConfigMapMarkPhantomGroupByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapMarkPhantomGroup rootAsMapMarkPhantomGroup = MapMarkPhantomGroup.GetRootAsMapMarkPhantomGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkPhantomGroupByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapMarkPhantomGroupByMarkId.HandleId, ConfigMapMarkPhantomGroupByMarkId.LogPair);
			return new MapMarkPhantomGroup?(rootAsMapMarkPhantomGroup);
		}

		// Token: 0x040023AF RID: 9135
		private const string DB = "db_map_mark.db";

		// Token: 0x040023B0 RID: 9136
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x040023B1 RID: 9137
		private const string TABLE = "MapMarkPhantomGroup";

		// Token: 0x040023B2 RID: 9138
		private const string COMMAND = "select BinData from `MapMarkPhantomGroup` where MarkId=?";

		// Token: 0x040023B3 RID: 9139
		private const string KEY_PREFIX = "MapMarkPhantomGroupByMarkId";

		// Token: 0x040023B4 RID: 9140
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023B5 RID: 9141
		private static int HandleId;
	}
}
