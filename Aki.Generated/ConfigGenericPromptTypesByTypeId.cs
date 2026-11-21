using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039B RID: 923
	public class ConfigGenericPromptTypesByTypeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015A8 RID: 5544 RVA: 0x000D79C1 File Offset: 0x000D5BC1
		static ConfigGenericPromptTypesByTypeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGenericPromptTypesByTypeId.CreateStaticDefaultValue), new Action(ConfigGenericPromptTypesByTypeId.ResetStaticDefaultValue));
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000D79E0 File Offset: 0x000D5BE0
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

		// Token: 0x060015AA RID: 5546 RVA: 0x000D7A5F File Offset: 0x000D5C5F
		public static void ResetStaticDefaultValue()
		{
			ConfigGenericPromptTypesByTypeId.LogPair = null;
			ConfigGenericPromptTypesByTypeId.HandleId = 0;
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x000D7A6D File Offset: 0x000D5C6D
		public static void Init()
		{
			ConfigGenericPromptTypesByTypeId.HandleId = ConfigCommon.InitDataStatement(ConfigGenericPromptTypesByTypeId.HandleId, "db_generic_tips.db", "select BinData from `GenericPromptTypes` where TypeId=?");
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x000D7A88 File Offset: 0x000D5C88
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

		// Token: 0x04001921 RID: 6433
		private const string DB = "db_generic_tips.db";

		// Token: 0x04001922 RID: 6434
		private const string FILE = "t.通用提示.xlsx";

		// Token: 0x04001923 RID: 6435
		private const string TABLE = "GenericPromptTypes";

		// Token: 0x04001924 RID: 6436
		private const string COMMAND = "select BinData from `GenericPromptTypes` where TypeId=?";

		// Token: 0x04001925 RID: 6437
		private const string KEY_PREFIX = "GenericPromptTypesByTypeId";

		// Token: 0x04001926 RID: 6438
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001927 RID: 6439
		private static int HandleId;
	}
}
