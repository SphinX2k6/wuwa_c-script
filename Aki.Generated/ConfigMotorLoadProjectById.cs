using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C6 RID: 1478
	public class ConfigMotorLoadProjectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022B1 RID: 8881 RVA: 0x00121353 File Offset: 0x0011F553
		static ConfigMotorLoadProjectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorLoadProjectById.CreateStaticDefaultValue), new Action(ConfigMotorLoadProjectById.ResetStaticDefaultValue));
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00121374 File Offset: 0x0011F574
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorLoadProjectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorLoadProjectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorLoadProject"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorLoadProject` where Id=?")
			});
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x001213F3 File Offset: 0x0011F5F3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorLoadProjectById.LogPair = null;
			ConfigMotorLoadProjectById.HandleId = 0;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00121401 File Offset: 0x0011F601
		public static void Init()
		{
			ConfigMotorLoadProjectById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorLoadProjectById.HandleId, "db_motordiy.db", "select BinData from `MotorLoadProject` where Id=?");
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x0012141C File Offset: 0x0011F61C
		public static MotorLoadProject? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorLoadProjectById.HandleId, ConfigMotorLoadProjectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLoadProjectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorLoadProject?(MotorLoadProject.GetRootAsMotorLoadProject(configBuffer));
				}
			}
			ConfigMotorLoadProjectById.LogPair.Clear();
			ConfigMotorLoadProjectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorLoadProjectById.HandleId, 1, p0Id, ConfigMotorLoadProjectById.LogPair) || ConfigCommon.Step(ConfigMotorLoadProjectById.HandleId, true, ConfigMotorLoadProjectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorLoadProjectById.HandleId, ConfigMotorLoadProjectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorLoadProjectById.HandleId, 0, ConfigMotorLoadProjectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorLoadProjectById.HandleId, ConfigMotorLoadProjectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorLoadProject rootAsMotorLoadProject = MotorLoadProject.GetRootAsMotorLoadProject(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorLoadProjectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorLoadProjectById.HandleId, ConfigMotorLoadProjectById.LogPair);
			return new MotorLoadProject?(rootAsMotorLoadProject);
		}

		// Token: 0x0400284E RID: 10318
		private const string DB = "db_motordiy.db";

		// Token: 0x0400284F RID: 10319
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002850 RID: 10320
		private const string TABLE = "MotorLoadProject";

		// Token: 0x04002851 RID: 10321
		private const string COMMAND = "select BinData from `MotorLoadProject` where Id=?";

		// Token: 0x04002852 RID: 10322
		private const string KEY_PREFIX = "MotorLoadProjectById";

		// Token: 0x04002853 RID: 10323
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002854 RID: 10324
		private static int HandleId;
	}
}
