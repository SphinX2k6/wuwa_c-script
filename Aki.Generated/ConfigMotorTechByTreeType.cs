using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E3 RID: 1507
	public class ConfigMotorTechByTreeType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600235F RID: 9055 RVA: 0x00125070 File Offset: 0x00123270
		static ConfigMotorTechByTreeType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechByTreeType.CreateStaticDefaultValue), new Action(ConfigMotorTechByTreeType.ResetStaticDefaultValue));
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00125090 File Offset: 0x00123290
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorTechByTreeType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorTechByTreeType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorTech"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorTech` where TreeType=?")
			});
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x0012510F File Offset: 0x0012330F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechByTreeType.LogPair = null;
			ConfigMotorTechByTreeType.HandleId = 0;
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x0012511D File Offset: 0x0012331D
		public static void Init()
		{
			ConfigMotorTechByTreeType.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechByTreeType.HandleId, "db_motor.db", "select BinData from `MotorTech` where TreeType=?");
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00125138 File Offset: 0x00123338
		[NullableContext(2)]
		public static IReadOnlyList<MotorTech> GetConfigList(int p0TreeType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorTechByTreeType.HandleId, ConfigMotorTechByTreeType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechByTreeType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TreeType);
				IReadOnlyList<MotorTech> readOnlyList = (IReadOnlyList<MotorTech>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigMotorTechByTreeType.LogPair.Clear();
			ConfigMotorTechByTreeType.LogPair.Add(new ValueTuple<string, object>("TreeType", p0TreeType));
			if (!ConfigCommon.BindInt(ConfigMotorTechByTreeType.HandleId, 1, p0TreeType, ConfigMotorTechByTreeType.LogPair))
			{
				ConfigCommon.Reset(ConfigMotorTechByTreeType.HandleId, ConfigMotorTechByTreeType.LogPair);
				return null;
			}
			List<MotorTech> list = new List<MotorTech>();
			while (ConfigCommon.Step(ConfigMotorTechByTreeType.HandleId, false, ConfigMotorTechByTreeType.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorTechByTreeType.HandleId, 0, ConfigMotorTechByTreeType.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMotorTechByTreeType.HandleId, ConfigMotorTechByTreeType.LogPair);
					return null;
				}
				MotorTech rootAsMotorTech = MotorTech.GetRootAsMotorTech(new ByteBuffer(item2));
				list.Add(rootAsMotorTech);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorTechByTreeType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TreeType);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigMotorTechByTreeType.HandleId, ConfigMotorTechByTreeType.LogPair);
			return list;
		}

		// Token: 0x04002919 RID: 10521
		private const string DB = "db_motor.db";

		// Token: 0x0400291A RID: 10522
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x0400291B RID: 10523
		private const string TABLE = "MotorTech";

		// Token: 0x0400291C RID: 10524
		private const string COMMAND = "select BinData from `MotorTech` where TreeType=?";

		// Token: 0x0400291D RID: 10525
		private const string KEY_PREFIX = "MotorTechByTreeType";

		// Token: 0x0400291E RID: 10526
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400291F RID: 10527
		private static int HandleId;
	}
}
