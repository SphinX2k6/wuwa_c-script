using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000533 RID: 1331
	public class ConfigMapMarkPhantomGroupByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F3D RID: 7997 RVA: 0x0010D55B File Offset: 0x0010B75B
		static ConfigMapMarkPhantomGroupByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkPhantomGroupByMarkId.CreateStaticDefaultValue), new Action(ConfigMapMarkPhantomGroupByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x0010D57C File Offset: 0x0010B77C
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

		// Token: 0x06001F3F RID: 7999 RVA: 0x0010D5FB File Offset: 0x0010B7FB
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkPhantomGroupByMarkId.LogPair = null;
			ConfigMapMarkPhantomGroupByMarkId.HandleId = 0;
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x0010D609 File Offset: 0x0010B809
		public static void Init()
		{
			ConfigMapMarkPhantomGroupByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkPhantomGroupByMarkId.HandleId, "db_map_mark.db", "select BinData from `MapMarkPhantomGroup` where MarkId=?");
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x0010D624 File Offset: 0x0010B824
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

		// Token: 0x04002449 RID: 9289
		private const string DB = "db_map_mark.db";

		// Token: 0x0400244A RID: 9290
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x0400244B RID: 9291
		private const string TABLE = "MapMarkPhantomGroup";

		// Token: 0x0400244C RID: 9292
		private const string COMMAND = "select BinData from `MapMarkPhantomGroup` where MarkId=?";

		// Token: 0x0400244D RID: 9293
		private const string KEY_PREFIX = "MapMarkPhantomGroupByMarkId";

		// Token: 0x0400244E RID: 9294
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400244F RID: 9295
		private static int HandleId;
	}
}
