using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CF RID: 1487
	public class ConfigMotorTechTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022E7 RID: 8935 RVA: 0x0011EE4F File Offset: 0x0011D04F
		static ConfigMotorTechTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechTreeById.CreateStaticDefaultValue), new Action(ConfigMotorTechTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x0011EE70 File Offset: 0x0011D070
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorTechTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorTechTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorTechTree"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorTechTree` where Id=?")
			});
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x0011EEEF File Offset: 0x0011D0EF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechTreeById.LogPair = null;
			ConfigMotorTechTreeById.HandleId = 0;
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x0011EEFD File Offset: 0x0011D0FD
		public static void Init()
		{
			ConfigMotorTechTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechTreeById.HandleId, "db_motor.db", "select BinData from `MotorTechTree` where Id=?");
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x0011EF18 File Offset: 0x0011D118
		public static MotorTechTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorTechTreeById.HandleId, ConfigMotorTechTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorTechTree?(MotorTechTree.GetRootAsMotorTechTree(configBuffer));
				}
			}
			ConfigMotorTechTreeById.LogPair.Clear();
			ConfigMotorTechTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorTechTreeById.HandleId, 1, p0Id, ConfigMotorTechTreeById.LogPair) || ConfigCommon.Step(ConfigMotorTechTreeById.HandleId, true, ConfigMotorTechTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorTechTreeById.HandleId, ConfigMotorTechTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorTechTreeById.HandleId, 0, ConfigMotorTechTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorTechTreeById.HandleId, ConfigMotorTechTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorTechTree rootAsMotorTechTree = MotorTechTree.GetRootAsMotorTechTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorTechTreeById.HandleId, ConfigMotorTechTreeById.LogPair);
			return new MotorTechTree?(rootAsMotorTechTree);
		}

		// Token: 0x0400288D RID: 10381
		private const string DB = "db_motor.db";

		// Token: 0x0400288E RID: 10382
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400288F RID: 10383
		private const string TABLE = "MotorTechTree";

		// Token: 0x04002890 RID: 10384
		private const string COMMAND = "select BinData from `MotorTechTree` where Id=?";

		// Token: 0x04002891 RID: 10385
		private const string KEY_PREFIX = "MotorTechTreeById";

		// Token: 0x04002892 RID: 10386
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002893 RID: 10387
		private static int HandleId;
	}
}
