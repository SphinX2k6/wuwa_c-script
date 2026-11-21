using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017A RID: 378
	public class ConfigCiacconaGalStepById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x0008F1F0 File Offset: 0x0008D3F0
		static ConfigCiacconaGalStepById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalStepById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalStepById.ResetStaticDefaultValue));
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0008F210 File Offset: 0x0008D410
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

		// Token: 0x060008DF RID: 2271 RVA: 0x0008F28F File Offset: 0x0008D48F
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalStepById.LogPair = null;
			ConfigCiacconaGalStepById.HandleId = 0;
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0008F29D File Offset: 0x0008D49D
		public static void Init()
		{
			ConfigCiacconaGalStepById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalStepById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalStep` where Id=?");
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0008F2B8 File Offset: 0x0008D4B8
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

		// Token: 0x04000A3A RID: 2618
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A3B RID: 2619
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A3C RID: 2620
		private const string TABLE = "CiacconaGalStep";

		// Token: 0x04000A3D RID: 2621
		private const string COMMAND = "select BinData from `CiacconaGalStep` where Id=?";

		// Token: 0x04000A3E RID: 2622
		private const string KEY_PREFIX = "CiacconaGalStepById";

		// Token: 0x04000A3F RID: 2623
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A40 RID: 2624
		private static int HandleId;
	}
}
