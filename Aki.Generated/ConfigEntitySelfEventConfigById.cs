using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200028F RID: 655
	public class ConfigEntitySelfEventConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F5F RID: 3935 RVA: 0x000B3DC9 File Offset: 0x000B1FC9
		static ConfigEntitySelfEventConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySelfEventConfigById.CreateStaticDefaultValue), new Action(ConfigEntitySelfEventConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x000B3DE8 File Offset: 0x000B1FE8
		public static void CreateStaticDefaultValue()
		{
			ConfigEntitySelfEventConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntitySelfEventConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_entityselfeventconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/s.实体自身事件/*.csv*"),
				new ValueTuple<string, object>("表名", "EntitySelfEventConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `EntitySelfEventConfig` where Id=?")
			});
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x000B3E67 File Offset: 0x000B2067
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySelfEventConfigById.LogPair = null;
			ConfigEntitySelfEventConfigById.HandleId = 0;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x000B3E75 File Offset: 0x000B2075
		public static void Init()
		{
			ConfigEntitySelfEventConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySelfEventConfigById.HandleId, "db_entityselfeventconfig.db", "select BinData from `EntitySelfEventConfig` where Id=?");
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000B3E90 File Offset: 0x000B2090
		public static EntitySelfEventConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntitySelfEventConfigById.HandleId, ConfigEntitySelfEventConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EntitySelfEventConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EntitySelfEventConfig?(EntitySelfEventConfig.GetRootAsEntitySelfEventConfig(configBuffer));
				}
			}
			ConfigEntitySelfEventConfigById.LogPair.Clear();
			ConfigEntitySelfEventConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEntitySelfEventConfigById.HandleId, 1, p0Id, ConfigEntitySelfEventConfigById.LogPair) || ConfigCommon.Step(ConfigEntitySelfEventConfigById.HandleId, true, ConfigEntitySelfEventConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntitySelfEventConfigById.HandleId, ConfigEntitySelfEventConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntitySelfEventConfigById.HandleId, 0, ConfigEntitySelfEventConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntitySelfEventConfigById.HandleId, ConfigEntitySelfEventConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntitySelfEventConfig rootAsEntitySelfEventConfig = EntitySelfEventConfig.GetRootAsEntitySelfEventConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EntitySelfEventConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntitySelfEventConfigById.HandleId, ConfigEntitySelfEventConfigById.LogPair);
			return new EntitySelfEventConfig?(rootAsEntitySelfEventConfig);
		}

		// Token: 0x040011CD RID: 4557
		private const string DB = "db_entityselfeventconfig.db";

		// Token: 0x040011CE RID: 4558
		private const string FILE = "k.可视化编辑/c.Csv/s.实体自身事件/*.csv*";

		// Token: 0x040011CF RID: 4559
		private const string TABLE = "EntitySelfEventConfig";

		// Token: 0x040011D0 RID: 4560
		private const string COMMAND = "select BinData from `EntitySelfEventConfig` where Id=?";

		// Token: 0x040011D1 RID: 4561
		private const string KEY_PREFIX = "EntitySelfEventConfigById";

		// Token: 0x040011D2 RID: 4562
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040011D3 RID: 4563
		private static int HandleId;
	}
}
