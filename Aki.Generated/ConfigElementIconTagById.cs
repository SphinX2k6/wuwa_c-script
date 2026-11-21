using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000273 RID: 627
	public class ConfigElementIconTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EB6 RID: 3766 RVA: 0x000B0230 File Offset: 0x000AE430
		static ConfigElementIconTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementIconTagById.CreateStaticDefaultValue), new Action(ConfigElementIconTagById.ResetStaticDefaultValue));
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x000B0250 File Offset: 0x000AE450
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

		// Token: 0x06000EB8 RID: 3768 RVA: 0x000B02CF File Offset: 0x000AE4CF
		public static void ResetStaticDefaultValue()
		{
			ConfigElementIconTagById.LogPair = null;
			ConfigElementIconTagById.HandleId = 0;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x000B02DD File Offset: 0x000AE4DD
		public static void Init()
		{
			ConfigElementIconTagById.HandleId = ConfigCommon.InitDataStatement(ConfigElementIconTagById.HandleId, "db_component_config.db", "select BinData from `ElementIconTag` where Id=?");
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x000B02F8 File Offset: 0x000AE4F8
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

		// Token: 0x04001109 RID: 4361
		private const string DB = "db_component_config.db";

		// Token: 0x0400110A RID: 4362
		private const string FILE = "t.通用组件配置.xlsx";

		// Token: 0x0400110B RID: 4363
		private const string TABLE = "ElementIconTag";

		// Token: 0x0400110C RID: 4364
		private const string COMMAND = "select BinData from `ElementIconTag` where Id=?";

		// Token: 0x0400110D RID: 4365
		private const string KEY_PREFIX = "ElementIconTagById";

		// Token: 0x0400110E RID: 4366
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400110F RID: 4367
		private static int HandleId;
	}
}
