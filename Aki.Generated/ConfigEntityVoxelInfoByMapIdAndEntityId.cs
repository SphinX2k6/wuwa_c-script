using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000295 RID: 661
	public class ConfigEntityVoxelInfoByMapIdAndEntityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F83 RID: 3971 RVA: 0x000B4A60 File Offset: 0x000B2C60
		static ConfigEntityVoxelInfoByMapIdAndEntityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityVoxelInfoByMapIdAndEntityId.CreateStaticDefaultValue), new Action(ConfigEntityVoxelInfoByMapIdAndEntityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000B4A80 File Offset: 0x000B2C80
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

		// Token: 0x06000F85 RID: 3973 RVA: 0x000B4AFF File Offset: 0x000B2CFF
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityVoxelInfoByMapIdAndEntityId.LogPair = null;
			ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId = 0;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x000B4B0D File Offset: 0x000B2D0D
		public static void Init()
		{
			ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId = ConfigCommon.InitDataStatement(ConfigEntityVoxelInfoByMapIdAndEntityId.HandleId, "db_entityvoxelinfo.db", "select BinData from `EntityVoxelInfo` where MapId=? and EntityId=?");
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000B4B28 File Offset: 0x000B2D28
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

		// Token: 0x040011F7 RID: 4599
		private const string DB = "db_entityvoxelinfo.db";

		// Token: 0x040011F8 RID: 4600
		private const string FILE = "UniverseEditor/EntityVoxelInfo.csv";

		// Token: 0x040011F9 RID: 4601
		private const string TABLE = "EntityVoxelInfo";

		// Token: 0x040011FA RID: 4602
		private const string COMMAND = "select BinData from `EntityVoxelInfo` where MapId=? and EntityId=?";

		// Token: 0x040011FB RID: 4603
		private const string KEY_PREFIX = "EntityVoxelInfoByMapIdAndEntityId";

		// Token: 0x040011FC RID: 4604
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011FD RID: 4605
		private static int HandleId;
	}
}
