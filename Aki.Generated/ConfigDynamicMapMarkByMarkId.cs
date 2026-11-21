using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025C RID: 604
	public class ConfigDynamicMapMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E2C RID: 3628 RVA: 0x000AD20B File Offset: 0x000AB40B
		static ConfigDynamicMapMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDynamicMapMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigDynamicMapMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x000AD22C File Offset: 0x000AB42C
		public static void CreateStaticDefaultValue()
		{
			ConfigDynamicMapMarkByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDynamicMapMarkByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "DynamicMapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `DynamicMapMark` where MarkId=?")
			});
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x000AD2AB File Offset: 0x000AB4AB
		public static void ResetStaticDefaultValue()
		{
			ConfigDynamicMapMarkByMarkId.LogPair = null;
			ConfigDynamicMapMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x000AD2B9 File Offset: 0x000AB4B9
		public static void Init()
		{
			ConfigDynamicMapMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigDynamicMapMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `DynamicMapMark` where MarkId=?");
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x000AD2D4 File Offset: 0x000AB4D4
		public static DynamicMapMark? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDynamicMapMarkByMarkId.HandleId, ConfigDynamicMapMarkByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DynamicMapMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DynamicMapMark?(DynamicMapMark.GetRootAsDynamicMapMark(configBuffer));
				}
			}
			ConfigDynamicMapMarkByMarkId.LogPair.Clear();
			ConfigDynamicMapMarkByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigDynamicMapMarkByMarkId.HandleId, 1, p0MarkId, ConfigDynamicMapMarkByMarkId.LogPair) || ConfigCommon.Step(ConfigDynamicMapMarkByMarkId.HandleId, true, ConfigDynamicMapMarkByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDynamicMapMarkByMarkId.HandleId, ConfigDynamicMapMarkByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDynamicMapMarkByMarkId.HandleId, 0, ConfigDynamicMapMarkByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDynamicMapMarkByMarkId.HandleId, ConfigDynamicMapMarkByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DynamicMapMark rootAsDynamicMapMark = DynamicMapMark.GetRootAsDynamicMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DynamicMapMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDynamicMapMarkByMarkId.HandleId, ConfigDynamicMapMarkByMarkId.LogPair);
			return new DynamicMapMark?(rootAsDynamicMapMark);
		}

		// Token: 0x04001068 RID: 4200
		private const string DB = "db_map_mark.db";

		// Token: 0x04001069 RID: 4201
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x0400106A RID: 4202
		private const string TABLE = "DynamicMapMark";

		// Token: 0x0400106B RID: 4203
		private const string COMMAND = "select BinData from `DynamicMapMark` where MarkId=?";

		// Token: 0x0400106C RID: 4204
		private const string KEY_PREFIX = "DynamicMapMarkByMarkId";

		// Token: 0x0400106D RID: 4205
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400106E RID: 4206
		private static int HandleId;
	}
}
