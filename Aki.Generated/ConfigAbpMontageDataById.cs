using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200000B RID: 11
	public class ConfigAbpMontageDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0005B845 File Offset: 0x00059A45
		static ConfigAbpMontageDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbpMontageDataById.CreateStaticDefaultValue), new Action(ConfigAbpMontageDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0005B864 File Offset: 0x00059A64
		public static void CreateStaticDefaultValue()
		{
			ConfigAbpMontageDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbpMontageDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_abpmontagedata.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.ABP蒙太奇映射表/*.csv*"),
				new ValueTuple<string, object>("表名", "AbpMontageData"),
				new ValueTuple<string, object>("语句", "select BinData from `AbpMontageData` where Id=?")
			});
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0005B8E3 File Offset: 0x00059AE3
		public static void ResetStaticDefaultValue()
		{
			ConfigAbpMontageDataById.LogPair = null;
			ConfigAbpMontageDataById.HandleId = 0;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0005B8F1 File Offset: 0x00059AF1
		public static void Init()
		{
			ConfigAbpMontageDataById.HandleId = ConfigCommon.InitDataStatement(ConfigAbpMontageDataById.HandleId, "db_abpmontagedata.db", "select BinData from `AbpMontageData` where Id=?");
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0005B90C File Offset: 0x00059B0C
		public static AbpMontageData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbpMontageDataById.HandleId, ConfigAbpMontageDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbpMontageDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbpMontageData?(AbpMontageData.GetRootAsAbpMontageData(configBuffer));
				}
			}
			ConfigAbpMontageDataById.LogPair.Clear();
			ConfigAbpMontageDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbpMontageDataById.HandleId, 1, p0Id, ConfigAbpMontageDataById.LogPair) || ConfigCommon.Step(ConfigAbpMontageDataById.HandleId, true, ConfigAbpMontageDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbpMontageDataById.HandleId, ConfigAbpMontageDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbpMontageDataById.HandleId, 0, ConfigAbpMontageDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbpMontageDataById.HandleId, ConfigAbpMontageDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbpMontageData rootAsAbpMontageData = AbpMontageData.GetRootAsAbpMontageData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbpMontageDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbpMontageDataById.HandleId, ConfigAbpMontageDataById.LogPair);
			return new AbpMontageData?(rootAsAbpMontageData);
		}

		// Token: 0x04000031 RID: 49
		private const string DB = "db_abpmontagedata.db";

		// Token: 0x04000032 RID: 50
		private const string FILE = "k.可视化编辑/c.Csv/a.ABP蒙太奇映射表/*.csv*";

		// Token: 0x04000033 RID: 51
		private const string TABLE = "AbpMontageData";

		// Token: 0x04000034 RID: 52
		private const string COMMAND = "select BinData from `AbpMontageData` where Id=?";

		// Token: 0x04000035 RID: 53
		private const string KEY_PREFIX = "AbpMontageDataById";

		// Token: 0x04000036 RID: 54
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000037 RID: 55
		private static int HandleId;
	}
}
