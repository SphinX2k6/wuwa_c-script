using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055C RID: 1372
	public class ConfigMontageDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002035 RID: 8245 RVA: 0x0010F70C File Offset: 0x0010D90C
		static ConfigMontageDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMontageDataById.CreateStaticDefaultValue), new Action(ConfigMontageDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x0010F72C File Offset: 0x0010D92C
		public static void CreateStaticDefaultValue()
		{
			ConfigMontageDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMontageDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_montagedata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/MontageConfig/MontageConfig.csv"),
				new ValueTuple<string, object>("表名", "MontageData"),
				new ValueTuple<string, object>("语句", "select BinData from `MontageData` where Id=?")
			});
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x0010F7AB File Offset: 0x0010D9AB
		public static void ResetStaticDefaultValue()
		{
			ConfigMontageDataById.LogPair = null;
			ConfigMontageDataById.HandleId = 0;
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x0010F7B9 File Offset: 0x0010D9B9
		public static void Init()
		{
			ConfigMontageDataById.HandleId = ConfigCommon.InitDataStatement(ConfigMontageDataById.HandleId, "db_montagedata.db", "select BinData from `MontageData` where Id=?");
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0010F7D4 File Offset: 0x0010D9D4
		public static MontageData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMontageDataById.HandleId, ConfigMontageDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MontageDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MontageData?(MontageData.GetRootAsMontageData(configBuffer));
				}
			}
			ConfigMontageDataById.LogPair.Clear();
			ConfigMontageDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMontageDataById.HandleId, 1, p0Id, ConfigMontageDataById.LogPair) || ConfigCommon.Step(ConfigMontageDataById.HandleId, true, ConfigMontageDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMontageDataById.HandleId, ConfigMontageDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMontageDataById.HandleId, 0, ConfigMontageDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMontageDataById.HandleId, ConfigMontageDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MontageData rootAsMontageData = MontageData.GetRootAsMontageData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MontageDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMontageDataById.HandleId, ConfigMontageDataById.LogPair);
			return new MontageData?(rootAsMontageData);
		}

		// Token: 0x04002568 RID: 9576
		private const string DB = "db_montagedata.db";

		// Token: 0x04002569 RID: 9577
		private const string FILE = "UniverseEditor/MontageConfig/MontageConfig.csv";

		// Token: 0x0400256A RID: 9578
		private const string TABLE = "MontageData";

		// Token: 0x0400256B RID: 9579
		private const string COMMAND = "select BinData from `MontageData` where Id=?";

		// Token: 0x0400256C RID: 9580
		private const string KEY_PREFIX = "MontageDataById";

		// Token: 0x0400256D RID: 9581
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400256E RID: 9582
		private static int HandleId;
	}
}
