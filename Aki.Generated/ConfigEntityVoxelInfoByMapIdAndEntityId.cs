using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000281 RID: 641
	public class ConfigEntityVoxelInfoByMapIdAndEntityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F0B RID: 3851 RVA: 0x000AE79C File Offset: 0x000AC99C
		static ConfigEntityVoxelInfoByMapIdAndEntityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityVoxelInfoByMapIdAndEntityId.CreateStaticDefaultValue), new Action(ConfigEntityVoxelInfoByMapIdAndEntityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x000AE7BC File Offset: 0x000AC9BC
		public static void CreateStaticDefaultValue()
		{
			ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entityvoxelinfo.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/EntityVoxelInfo.csv"),
				new ValueTuple<string, object>("表名", "EntityVoxelInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `EntityVoxelInfo` where MapId=? and EntityId=?")
			});
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x000AE83B File Offset: 0x000ACA3B
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair = null;
			ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId = 0;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000AE849 File Offset: 0x000ACA49
		public static void Init()
		{
			ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId = ConfigCommon.InitDataStatement(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, "db_entityvoxelinfo.db", "select BinData from `EntityVoxelInfo` where MapId=? and EntityId=?");
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000AE864 File Offset: 0x000ACA64
		public static EntityVoxelInfo? GetConfig(int p0MapId, int p1EntityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EntityVoxelInfoByMapIdAndEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1EntityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EntityVoxelInfo?(EntityVoxelInfo.GetRootAsEntityVoxelInfo(configBuffer));
				}
			}
			ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair.Clear();
			ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair.Add(new ValueTuple<string, object>("EntityId", p1EntityId));
			if (!ConfigCommon.BindInt(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, 1, p0MapId, ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair) || !ConfigCommon.BindInt(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, 2, p1EntityId, ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair) || ConfigCommon.Step(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, true, ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, 0, ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntityVoxelInfo rootAsEntityVoxelInfo = EntityVoxelInfo.GetRootAsEntityVoxelInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EntityVoxelInfoByMapIdAndEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1EntityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair);
			return new EntityVoxelInfo?(rootAsEntityVoxelInfo);
		}

		// Token: 0x0400116B RID: 4459
		private const string DB = "db_entityvoxelinfo.db";

		// Token: 0x0400116C RID: 4460
		private const string FILE = "UniverseEditor/EntityVoxelInfo.csv";

		// Token: 0x0400116D RID: 4461
		private const string TABLE = "EntityVoxelInfo";

		// Token: 0x0400116E RID: 4462
		private const string COMMAND = "select BinData from `EntityVoxelInfo` where MapId=? and EntityId=?";

		// Token: 0x0400116F RID: 4463
		private const string KEY_PREFIX = "EntityVoxelInfoByMapIdAndEntityId";

		// Token: 0x04001170 RID: 4464
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001171 RID: 4465
		private static int HandleId;
	}
}
