using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9A RID: 2714
	public class ConfigWorldLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FB1 RID: 16305 RVA: 0x001C287C File Offset: 0x001C0A7C
		static ConfigWorldLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldLevelById.CreateStaticDefaultValue), new Action(ConfigWorldLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x001C289C File Offset: 0x001C0A9C
		public static void CreateStaticDefaultValue()
		{
			ConfigWorldLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWorldLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_worldlevel.db"),
				new ValueTuple<string, object>("文件", "s.世界等级.xlsx"),
				new ValueTuple<string, object>("表名", "WorldLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `WorldLevel` where Id = ?")
			});
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x001C291B File Offset: 0x001C0B1B
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldLevelById.LogPair = null;
			ConfigWorldLevelById.HandleId = 0;
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x001C2929 File Offset: 0x001C0B29
		public static void Init()
		{
			ConfigWorldLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigWorldLevelById.HandleId, "db_worldlevel.db", "select BinData from `WorldLevel` where Id = ?");
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x001C2944 File Offset: 0x001C0B44
		public static WorldLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWorldLevelById.HandleId, ConfigWorldLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WorldLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WorldLevel?(WorldLevel.GetRootAsWorldLevel(configBuffer));
				}
			}
			ConfigWorldLevelById.LogPair.Clear();
			ConfigWorldLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWorldLevelById.HandleId, 1, p0Id, ConfigWorldLevelById.LogPair) || ConfigCommon.Step(ConfigWorldLevelById.HandleId, true, ConfigWorldLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWorldLevelById.HandleId, ConfigWorldLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWorldLevelById.HandleId, 0, ConfigWorldLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWorldLevelById.HandleId, ConfigWorldLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WorldLevel rootAsWorldLevel = WorldLevel.GetRootAsWorldLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WorldLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWorldLevelById.HandleId, ConfigWorldLevelById.LogPair);
			return new WorldLevel?(rootAsWorldLevel);
		}

		// Token: 0x04004A1C RID: 18972
		private const string DB = "db_worldlevel.db";

		// Token: 0x04004A1D RID: 18973
		private const string FILE = "s.世界等级.xlsx";

		// Token: 0x04004A1E RID: 18974
		private const string TABLE = "WorldLevel";

		// Token: 0x04004A1F RID: 18975
		private const string COMMAND = "select BinData from `WorldLevel` where Id = ?";

		// Token: 0x04004A20 RID: 18976
		private const string KEY_PREFIX = "WorldLevelById";

		// Token: 0x04004A21 RID: 18977
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A22 RID: 18978
		private static int HandleId;
	}
}
