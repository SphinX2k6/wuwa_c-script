using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005CB RID: 1483
	public class ConfigMotorTechByTreeType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022CF RID: 8911 RVA: 0x0011E5F4 File Offset: 0x0011C7F4
		static ConfigMotorTechByTreeType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorTechByTreeType.CreateStaticDefaultValue), new Action(ConfigMotorTechByTreeType.ResetStaticDefaultValue));
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x0011E614 File Offset: 0x0011C814
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

		// Token: 0x060022D1 RID: 8913 RVA: 0x0011E693 File Offset: 0x0011C893
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorTechByTreeType.LogPair = null;
			ConfigMotorTechByTreeType.HandleId = 0;
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0011E6A1 File Offset: 0x0011C8A1
		public static void Init()
		{
			ConfigMotorTechByTreeType.HandleId = ConfigCommon.InitDataStatement(ConfigMotorTechByTreeType.HandleId, "db_motor.db", "select BinData from `MotorTech` where TreeType=?");
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x0011E6BC File Offset: 0x0011C8BC
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

		// Token: 0x04002871 RID: 10353
		private const string DB = "db_motor.db";

		// Token: 0x04002872 RID: 10354
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002873 RID: 10355
		private const string TABLE = "MotorTech";

		// Token: 0x04002874 RID: 10356
		private const string COMMAND = "select BinData from `MotorTech` where TreeType=?";

		// Token: 0x04002875 RID: 10357
		private const string KEY_PREFIX = "MotorTechByTreeType";

		// Token: 0x04002876 RID: 10358
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002877 RID: 10359
		private static int HandleId;
	}
}
