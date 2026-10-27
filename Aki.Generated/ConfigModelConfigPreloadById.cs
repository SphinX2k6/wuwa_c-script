using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000544 RID: 1348
	public class ConfigModelConfigPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FA5 RID: 8101 RVA: 0x0010C387 File Offset: 0x0010A587
		static ConfigModelConfigPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigModelConfigPreloadById.CreateStaticDefaultValue), new Action(ConfigModelConfigPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0010C3A8 File Offset: 0x0010A5A8
		public static void CreateStaticDefaultValue()
		{
			ConfigModelConfigPreloadById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigModelConfigPreloadById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_model_config_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/ModelConfigPreload.csv"),
				new ValueTuple<string, object>("表名", "ModelConfigPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `ModelConfigPreload` where Id=?")
			});
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0010C427 File Offset: 0x0010A627
		public static void ResetStaticDefaultValue()
		{
			ConfigModelConfigPreloadById.LogPair = null;
			ConfigModelConfigPreloadById.HandleId = 0;
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x0010C435 File Offset: 0x0010A635
		public static void Init()
		{
			ConfigModelConfigPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigModelConfigPreloadById.HandleId, "db_model_config_preload.db", "select BinData from `ModelConfigPreload` where Id=?");
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0010C450 File Offset: 0x0010A650
		public static ModelConfigPreload? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigModelConfigPreloadById.HandleId, ConfigModelConfigPreloadById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ModelConfigPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ModelConfigPreload?(ModelConfigPreload.GetRootAsModelConfigPreload(configBuffer));
				}
			}
			ConfigModelConfigPreloadById.LogPair.Clear();
			ConfigModelConfigPreloadById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigModelConfigPreloadById.HandleId, 1, p0Id, ConfigModelConfigPreloadById.LogPair) || ConfigCommon.Step(ConfigModelConfigPreloadById.HandleId, true, ConfigModelConfigPreloadById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigModelConfigPreloadById.HandleId, ConfigModelConfigPreloadById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigModelConfigPreloadById.HandleId, 0, ConfigModelConfigPreloadById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigModelConfigPreloadById.HandleId, ConfigModelConfigPreloadById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ModelConfigPreload rootAsModelConfigPreload = ModelConfigPreload.GetRootAsModelConfigPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ModelConfigPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigModelConfigPreloadById.HandleId, ConfigModelConfigPreloadById.LogPair);
			return new ModelConfigPreload?(rootAsModelConfigPreload);
		}

		// Token: 0x040024C0 RID: 9408
		private const string DB = "db_model_config_preload.db";

		// Token: 0x040024C1 RID: 9409
		private const string FILE = "Preload/ModelConfigPreload.csv";

		// Token: 0x040024C2 RID: 9410
		private const string TABLE = "ModelConfigPreload";

		// Token: 0x040024C3 RID: 9411
		private const string COMMAND = "select BinData from `ModelConfigPreload` where Id=?";

		// Token: 0x040024C4 RID: 9412
		private const string KEY_PREFIX = "ModelConfigPreloadById";

		// Token: 0x040024C5 RID: 9413
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024C6 RID: 9414
		private static int HandleId;
	}
}
