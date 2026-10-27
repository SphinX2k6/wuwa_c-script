using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CC RID: 1484
	public class ConfigMotorTechLvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022D5 RID: 8917 RVA: 0x0011E82B File Offset: 0x0011CA2B
		static ConfigMotorTechLvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechLvById.CreateStaticDefaultValue), new Action(ConfigMotorTechLvById.ResetStaticDefaultValue));
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0011E84C File Offset: 0x0011CA4C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorTechLvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorTechLvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorTechLv"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorTechLv` where Id=?")
			});
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0011E8CB File Offset: 0x0011CACB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechLvById.LogPair = null;
			ConfigMotorTechLvById.HandleId = 0;
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0011E8D9 File Offset: 0x0011CAD9
		public static void Init()
		{
			ConfigMotorTechLvById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechLvById.HandleId, "db_motor.db", "select BinData from `MotorTechLv` where Id=?");
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0011E8F4 File Offset: 0x0011CAF4
		public static MotorTechLv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorTechLvById.HandleId, ConfigMotorTechLvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorTechLv?(MotorTechLv.GetRootAsMotorTechLv(configBuffer));
				}
			}
			ConfigMotorTechLvById.LogPair.Clear();
			ConfigMotorTechLvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorTechLvById.HandleId, 1, p0Id, ConfigMotorTechLvById.LogPair) || ConfigCommon.Step(ConfigMotorTechLvById.HandleId, true, ConfigMotorTechLvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorTechLvById.HandleId, ConfigMotorTechLvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorTechLvById.HandleId, 0, ConfigMotorTechLvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorTechLvById.HandleId, ConfigMotorTechLvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorTechLv rootAsMotorTechLv = MotorTechLv.GetRootAsMotorTechLv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorTechLvById.HandleId, ConfigMotorTechLvById.LogPair);
			return new MotorTechLv?(rootAsMotorTechLv);
		}

		// Token: 0x04002878 RID: 10360
		private const string DB = "db_motor.db";

		// Token: 0x04002879 RID: 10361
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400287A RID: 10362
		private const string TABLE = "MotorTechLv";

		// Token: 0x0400287B RID: 10363
		private const string COMMAND = "select BinData from `MotorTechLv` where Id=?";

		// Token: 0x0400287C RID: 10364
		private const string KEY_PREFIX = "MotorTechLvById";

		// Token: 0x0400287D RID: 10365
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400287E RID: 10366
		private static int HandleId;
	}
}
