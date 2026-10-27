using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016A RID: 362
	public class ConfigCiacconaGalStepById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x00089694 File Offset: 0x00087894
		static ConfigCiacconaGalStepById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalStepById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalStepById.ResetStaticDefaultValue));
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x000896B4 File Offset: 0x000878B4
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalStepById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalStepById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalStep"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalStep` where Id=?")
			});
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00089733 File Offset: 0x00087933
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalStepById.LogPair = null;
			ConfigCiacconaGalStepById.HandleId = 0;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00089741 File Offset: 0x00087941
		public static void Init()
		{
			ConfigCiacconaGalStepById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalStepById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalStep` where Id=?");
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0008975C File Offset: 0x0008795C
		public static CiacconaGalStep? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalStepById.HandleId, ConfigCiacconaGalStepById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalStepById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaGalStep?(CiacconaGalStep.GetRootAsCiacconaGalStep(configBuffer));
				}
			}
			ConfigCiacconaGalStepById.LogPair.Clear();
			ConfigCiacconaGalStepById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaGalStepById.HandleId, 1, p0Id, ConfigCiacconaGalStepById.LogPair) || ConfigCommon.Step(ConfigCiacconaGalStepById.HandleId, true, ConfigCiacconaGalStepById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaGalStepById.HandleId, ConfigCiacconaGalStepById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalStepById.HandleId, 0, ConfigCiacconaGalStepById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaGalStepById.HandleId, ConfigCiacconaGalStepById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaGalStep rootAsCiacconaGalStep = CiacconaGalStep.GetRootAsCiacconaGalStep(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalStepById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaGalStepById.HandleId, ConfigCiacconaGalStepById.LogPair);
			return new CiacconaGalStep?(rootAsCiacconaGalStep);
		}

		// Token: 0x040009CA RID: 2506
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009CB RID: 2507
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009CC RID: 2508
		private const string TABLE = "CiacconaGalStep";

		// Token: 0x040009CD RID: 2509
		private const string COMMAND = "select BinData from `CiacconaGalStep` where Id=?";

		// Token: 0x040009CE RID: 2510
		private const string KEY_PREFIX = "CiacconaGalStepById";

		// Token: 0x040009CF RID: 2511
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009D0 RID: 2512
		private static int HandleId;
	}
}
