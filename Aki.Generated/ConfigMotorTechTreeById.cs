using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E7 RID: 1511
	public class ConfigMotorTechTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002377 RID: 9079 RVA: 0x001258CB File Offset: 0x00123ACB
		static ConfigMotorTechTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechTreeById.CreateStaticDefaultValue), new Action(ConfigMotorTechTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x001258EC File Offset: 0x00123AEC
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

		// Token: 0x06002379 RID: 9081 RVA: 0x0012596B File Offset: 0x00123B6B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechTreeById.LogPair = null;
			ConfigMotorTechTreeById.HandleId = 0;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00125979 File Offset: 0x00123B79
		public static void Init()
		{
			ConfigMotorTechTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechTreeById.HandleId, "db_motor.db", "select BinData from `MotorTechTree` where Id=?");
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00125994 File Offset: 0x00123B94
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

		// Token: 0x04002935 RID: 10549
		private const string DB = "db_motor.db";

		// Token: 0x04002936 RID: 10550
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002937 RID: 10551
		private const string TABLE = "MotorTechTree";

		// Token: 0x04002938 RID: 10552
		private const string COMMAND = "select BinData from `MotorTechTree` where Id=?";

		// Token: 0x04002939 RID: 10553
		private const string KEY_PREFIX = "MotorTechTreeById";

		// Token: 0x0400293A RID: 10554
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400293B RID: 10555
		private static int HandleId;
	}
}
