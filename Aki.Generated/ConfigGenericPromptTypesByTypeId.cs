using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000385 RID: 901
	public class ConfigGenericPromptTypesByTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001524 RID: 5412 RVA: 0x000D126D File Offset: 0x000CF46D
		static ConfigGenericPromptTypesByTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGenericPromptTypesByTypeId.CreateStaticDefaultValue), new Action(ConfigGenericPromptTypesByTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x000D128C File Offset: 0x000CF48C
		public static void CreateStaticDefaultValue()
		{
			ConfigGenericPromptTypesByTypeId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGenericPromptTypesByTypeId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_generic_tips.db"),
				new ValueTuple<string, object>("文件", "t.通用提示.xlsx"),
				new ValueTuple<string, object>("表名", "GenericPromptTypes"),
				new ValueTuple<string, object>("语句", "select BinData from `GenericPromptTypes` where TypeId=?")
			});
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x000D130B File Offset: 0x000CF50B
		public static void ResetStaticDefaultValue()
		{
			ConfigGenericPromptTypesByTypeId.LogPair = null;
			ConfigGenericPromptTypesByTypeId.HandleId = 0;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000D1319 File Offset: 0x000CF519
		public static void Init()
		{
			ConfigGenericPromptTypesByTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigGenericPromptTypesByTypeId.HandleId, "db_generic_tips.db", "select BinData from `GenericPromptTypes` where TypeId=?");
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x000D1334 File Offset: 0x000CF534
		public static GenericPromptTypes? GetConfig(int p0TypeId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGenericPromptTypesByTypeId.HandleId, ConfigGenericPromptTypesByTypeId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GenericPromptTypesByTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GenericPromptTypes?(GenericPromptTypes.GetRootAsGenericPromptTypes(configBuffer));
				}
			}
			ConfigGenericPromptTypesByTypeId.LogPair.Clear();
			ConfigGenericPromptTypesByTypeId.LogPair.Add(new ValueTuple<string, object>("TypeId", p0TypeId));
			if (!ConfigCommon.BindInt(ConfigGenericPromptTypesByTypeId.HandleId, 1, p0TypeId, ConfigGenericPromptTypesByTypeId.LogPair) || ConfigCommon.Step(ConfigGenericPromptTypesByTypeId.HandleId, true, ConfigGenericPromptTypesByTypeId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGenericPromptTypesByTypeId.HandleId, ConfigGenericPromptTypesByTypeId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGenericPromptTypesByTypeId.HandleId, 0, ConfigGenericPromptTypesByTypeId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGenericPromptTypesByTypeId.HandleId, ConfigGenericPromptTypesByTypeId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GenericPromptTypes rootAsGenericPromptTypes = GenericPromptTypes.GetRootAsGenericPromptTypes(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GenericPromptTypesByTypeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TypeId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGenericPromptTypesByTypeId.HandleId, ConfigGenericPromptTypesByTypeId.LogPair);
			return new GenericPromptTypes?(rootAsGenericPromptTypes);
		}

		// Token: 0x04001887 RID: 6279
		private const string DB = "db_generic_tips.db";

		// Token: 0x04001888 RID: 6280
		private const string FILE = "t.通用提示.xlsx";

		// Token: 0x04001889 RID: 6281
		private const string TABLE = "GenericPromptTypes";

		// Token: 0x0400188A RID: 6282
		private const string COMMAND = "select BinData from `GenericPromptTypes` where TypeId=?";

		// Token: 0x0400188B RID: 6283
		private const string KEY_PREFIX = "GenericPromptTypesByTypeId";

		// Token: 0x0400188C RID: 6284
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400188D RID: 6285
		private static int HandleId;
	}
}
