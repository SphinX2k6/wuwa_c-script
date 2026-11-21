using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028C RID: 652
	public class ConfigEntityGravityConfigByMapIdAndEntityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F4D RID: 3917 RVA: 0x000B374F File Offset: 0x000B194F
		static ConfigEntityGravityConfigByMapIdAndEntityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntityGravityConfigByMapIdAndEntityId.CreateStaticDefaultValue), new Action(ConfigEntityGravityConfigByMapIdAndEntityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x000B3770 File Offset: 0x000B1970
		public static void CreateStaticDefaultValue()
		{
			ConfigEntityGravityConfigByMapIdAndEntityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntityGravityConfigByMapIdAndEntityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entitygravity.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Gravity/重力方向_Json_GravityAbnormalEntityList.csv"),
				new ValueTuple<string, object>("表名", "EntityGravityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EntityGravityConfig` where MapId=? And EntityId=?")
			});
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x000B37EF File Offset: 0x000B19EF
		public static void ResetStaticDefaultValue()
		{
			ConfigEntityGravityConfigByMapIdAndEntityId.LogPair = null;
			ConfigEntityGravityConfigByMapIdAndEntityId.HandleId = 0;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000B37FD File Offset: 0x000B19FD
		public static void Init()
		{
			ConfigEntityGravityConfigByMapIdAndEntityId.HandleId = ConfigCommon.InitDataStatement(ConfigEntityGravityConfigByMapIdAndEntityId.HandleId, "db_entitygravity.db", "select BinData from `EntityGravityConfig` where MapId=? And EntityId=?");
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x000B3818 File Offset: 0x000B1A18
		public static EntityGravityConfig? GetConfig(int p0MapId, int p1EntityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntityGravityConfigByMapIdAndEntityId.HandleId, ConfigEntityGravityConfigByMapIdAndEntityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EntityGravityConfigByMapIdAndEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1EntityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EntityGravityConfig?(EntityGravityConfig.GetRootAsEntityGravityConfig(configBuffer));
				}
			}
			ConfigEntityGravityConfigByMapIdAndEntityId.LogPair.Clear();
			ConfigEntityGravityConfigByMapIdAndEntityId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			ConfigEntityGravityConfigByMapIdAndEntityId.LogPair.Add(new ValueTuple<string, object>("EntityId", p1EntityId));
			if (!ConfigCommon.BindInt(ConfigEntityGravityConfigByMapIdAndEntityId.HandleId, 1, p0MapId, ConfigEntityGravityConfigByMapIdAndEntityId.LogPair) || !ConfigCommon.BindInt(ConfigEntityGravityConfigByMapIdAndEntityId.HandleId, 2, p1EntityId, ConfigEntityGravityConfigByMapIdAndEntityId.LogPair) || ConfigCommon.Step(ConfigEntityGravityConfigByMapIdAndEntityId.HandleId, true, ConfigEntityGravityConfigByMapIdAndEntityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntityGravityConfigByMapIdAndEntityId.HandleId, ConfigEntityGravityConfigByMapIdAndEntityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntityGravityConfigByMapIdAndEntityId.HandleId, 0, ConfigEntityGravityConfigByMapIdAndEntityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntityGravityConfigByMapIdAndEntityId.HandleId, ConfigEntityGravityConfigByMapIdAndEntityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntityGravityConfig rootAsEntityGravityConfig = EntityGravityConfig.GetRootAsEntityGravityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EntityGravityConfigByMapIdAndEntityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1EntityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntityGravityConfigByMapIdAndEntityId.HandleId, ConfigEntityGravityConfigByMapIdAndEntityId.LogPair);
			return new EntityGravityConfig?(rootAsEntityGravityConfig);
		}

		// Token: 0x040011B8 RID: 4536
		private const string DB = "db_entitygravity.db";

		// Token: 0x040011B9 RID: 4537
		private const string FILE = "UniverseEditor/Gravity/重力方向_Json_GravityAbnormalEntityList.csv";

		// Token: 0x040011BA RID: 4538
		private const string TABLE = "EntityGravityConfig";

		// Token: 0x040011BB RID: 4539
		private const string COMMAND = "select BinData from `EntityGravityConfig` where MapId=? And EntityId=?";

		// Token: 0x040011BC RID: 4540
		private const string KEY_PREFIX = "EntityGravityConfigByMapIdAndEntityId";

		// Token: 0x040011BD RID: 4541
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011BE RID: 4542
		private static int HandleId;
	}
}
