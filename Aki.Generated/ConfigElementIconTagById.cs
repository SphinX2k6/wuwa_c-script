using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025F RID: 607
	public class ConfigElementIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x000A9F6C File Offset: 0x000A816C
		static ConfigElementIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementIconTagById.CreateStaticDefaultValue), new Action(ConfigElementIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000A9F8C File Offset: 0x000A818C
		public static void CreateStaticDefaultValue()
		{
			ConfigElementIconTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigElementIconTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_component_config.db"),
				new ValueTuple<string, object>("文件", "t.通用组件配置.xlsx"),
				new ValueTuple<string, object>("表名", "ElementIconTag"),
				new ValueTuple<string, object>("语句", "select BinData from `ElementIconTag` where Id=?")
			});
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000AA00B File Offset: 0x000A820B
		public static void ResetStaticDefaultValue()
		{
			ConfigElementIconTagById.LogPair = null;
			ConfigElementIconTagById.HandleId = 0;
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000AA019 File Offset: 0x000A8219
		public static void Init()
		{
			ConfigElementIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigElementIconTagById.HandleId, "db_component_config.db", "select BinData from `ElementIconTag` where Id=?");
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x000AA034 File Offset: 0x000A8234
		public static ElementIconTag? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigElementIconTagById.HandleId, ConfigElementIconTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("ElementIconTagById#" + p0Id);
				if (configBuffer != null)
				{
					return new ElementIconTag?(ElementIconTag.GetRootAsElementIconTag(configBuffer));
				}
			}
			ConfigElementIconTagById.LogPair.Clear();
			ConfigElementIconTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigElementIconTagById.HandleId, 1, p0Id, ConfigElementIconTagById.LogPair) || ConfigCommon.Step(ConfigElementIconTagById.HandleId, true, ConfigElementIconTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigElementIconTagById.HandleId, ConfigElementIconTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigElementIconTagById.HandleId, 0, ConfigElementIconTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigElementIconTagById.HandleId, ConfigElementIconTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ElementIconTag rootAsElementIconTag = ElementIconTag.GetRootAsElementIconTag(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("ElementIconTagById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigElementIconTagById.HandleId, ConfigElementIconTagById.LogPair);
			return new ElementIconTag?(rootAsElementIconTag);
		}

		// Token: 0x0400107D RID: 4221
		private const string DB = "db_component_config.db";

		// Token: 0x0400107E RID: 4222
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x0400107F RID: 4223
		private const string TABLE = "ElementIconTag";

		// Token: 0x04001080 RID: 4224
		private const string COMMAND = "select BinData from `ElementIconTag` where Id=?";

		// Token: 0x04001081 RID: 4225
		private const string KEY_PREFIX = "ElementIconTagById";

		// Token: 0x04001082 RID: 4226
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001083 RID: 4227
		private static int HandleId;
	}
}
