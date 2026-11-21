using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000572 RID: 1394
	public class ConfigMontageDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020B9 RID: 8377 RVA: 0x00115E60 File Offset: 0x00114060
		static ConfigMontageDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMontageDataById.CreateStaticDefaultValue), new Action(ConfigMontageDataById.ResetStaticDefaultValue));
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x00115E80 File Offset: 0x00114080
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

		// Token: 0x060020BB RID: 8379 RVA: 0x00115EFF File Offset: 0x001140FF
		public static void ResetStaticDefaultValue()
		{
			ConfigMontageDataById.LogPair = null;
			ConfigMontageDataById.HandleId = 0;
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00115F0D File Offset: 0x0011410D
		public static void Init()
		{
			ConfigMontageDataById.HandleId = ConfigCommon.InitDataStatement(ConfigMontageDataById.HandleId, "db_montagedata.db", "select BinData from `MontageData` where Id=?");
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00115F28 File Offset: 0x00114128
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

		// Token: 0x04002602 RID: 9730
		private const string DB = "db_montagedata.db";

		// Token: 0x04002603 RID: 9731
		private const string FILE = "UniverseEditor/MontageConfig/MontageConfig.csv";

		// Token: 0x04002604 RID: 9732
		private const string TABLE = "MontageData";

		// Token: 0x04002605 RID: 9733
		private const string COMMAND = "select BinData from `MontageData` where Id=?";

		// Token: 0x04002606 RID: 9734
		private const string KEY_PREFIX = "MontageDataById";

		// Token: 0x04002607 RID: 9735
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002608 RID: 9736
		private static int HandleId;
	}
}
