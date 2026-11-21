using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055A RID: 1370
	public class ConfigModelConfigPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002029 RID: 8233 RVA: 0x00112ADB File Offset: 0x00110CDB
		static ConfigModelConfigPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigModelConfigPreloadById.CreateStaticDefaultValue), new Action(ConfigModelConfigPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00112AFC File Offset: 0x00110CFC
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

		// Token: 0x0600202B RID: 8235 RVA: 0x00112B7B File Offset: 0x00110D7B
		public static void ResetStaticDefaultValue()
		{
			ConfigModelConfigPreloadById.LogPair = null;
			ConfigModelConfigPreloadById.HandleId = 0;
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00112B89 File Offset: 0x00110D89
		public static void Init()
		{
			ConfigModelConfigPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigModelConfigPreloadById.HandleId, "db_model_config_preload.db", "select BinData from `ModelConfigPreload` where Id=?");
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00112BA4 File Offset: 0x00110DA4
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

		// Token: 0x0400255A RID: 9562
		private const string DB = "db_model_config_preload.db";

		// Token: 0x0400255B RID: 9563
		private const string FILE = "Preload/ModelConfigPreload.csv";

		// Token: 0x0400255C RID: 9564
		private const string TABLE = "ModelConfigPreload";

		// Token: 0x0400255D RID: 9565
		private const string COMMAND = "select BinData from `ModelConfigPreload` where Id=?";

		// Token: 0x0400255E RID: 9566
		private const string KEY_PREFIX = "ModelConfigPreloadById";

		// Token: 0x0400255F RID: 9567
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002560 RID: 9568
		private static int HandleId;
	}
}
