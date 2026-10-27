using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200027B RID: 635
	public class ConfigEntitySelfEventConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EE7 RID: 3815 RVA: 0x000ADB05 File Offset: 0x000ABD05
		static ConfigEntitySelfEventConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntitySelfEventConfigById.CreateStaticDefaultValue), new Action(ConfigEntitySelfEventConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000ADB24 File Offset: 0x000ABD24
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

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000ADBA3 File Offset: 0x000ABDA3
		public static void ResetStaticDefaultValue()
		{
			ConfigEntitySelfEventConfigById.LogPair = null;
			ConfigEntitySelfEventConfigById.HandleId = 0;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000ADBB1 File Offset: 0x000ABDB1
		public static void Init()
		{
			ConfigEntitySelfEventConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigEntitySelfEventConfigById.HandleId, "db_entityselfeventconfig.db", "select BinData from `EntitySelfEventConfig` where Id=?");
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000ADBCC File Offset: 0x000ABDCC
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

		// Token: 0x04001141 RID: 4417
		private const string DB = "db_entityselfeventconfig.db";

		// Token: 0x04001142 RID: 4418
		private const string FILE = "k.可视化编辑/c.Csv/s.实体自身事件/*.csv*";

		// Token: 0x04001143 RID: 4419
		private const string TABLE = "EntitySelfEventConfig";

		// Token: 0x04001144 RID: 4420
		private const string COMMAND = "select BinData from `EntitySelfEventConfig` where Id=?";

		// Token: 0x04001145 RID: 4421
		private const string KEY_PREFIX = "EntitySelfEventConfigById";

		// Token: 0x04001146 RID: 4422
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001147 RID: 4423
		private static int HandleId;
	}
}
