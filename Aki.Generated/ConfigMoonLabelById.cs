using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055E RID: 1374
	public class ConfigMoonLabelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002041 RID: 8257 RVA: 0x0010FB9C File Offset: 0x0010DD9C
		static ConfigMoonLabelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoonLabelById.CreateStaticDefaultValue), new Action(ConfigMoonLabelById.ResetStaticDefaultValue));
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0010FBBC File Offset: 0x0010DDBC
		public static void CreateStaticDefaultValue()
		{
			ConfigMoonLabelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoonLabelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonsignin.db"),
				new ValueTuple<string, object>("文件", "y.月相活动.xlsx"),
				new ValueTuple<string, object>("表名", "MoonLabel"),
				new ValueTuple<string, object>("语句", "select BinData from `MoonLabel` where Id=?")
			});
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0010FC3B File Offset: 0x0010DE3B
		public static void ResetStaticDefaultValue()
		{
			ConfigMoonLabelById.LogPair = null;
			ConfigMoonLabelById.HandleId = 0;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0010FC49 File Offset: 0x0010DE49
		public static void Init()
		{
			ConfigMoonLabelById.HandleId = ConfigCommon.InitDataStatement(ConfigMoonLabelById.HandleId, "db_moonsignin.db", "select BinData from `MoonLabel` where Id=?");
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0010FC64 File Offset: 0x0010DE64
		public static MoonLabel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoonLabelById.HandleId, ConfigMoonLabelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonLabelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoonLabel?(MoonLabel.GetRootAsMoonLabel(configBuffer));
				}
			}
			ConfigMoonLabelById.LogPair.Clear();
			ConfigMoonLabelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMoonLabelById.HandleId, 1, p0Id, ConfigMoonLabelById.LogPair) || ConfigCommon.Step(ConfigMoonLabelById.HandleId, true, ConfigMoonLabelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoonLabelById.HandleId, ConfigMoonLabelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoonLabelById.HandleId, 0, ConfigMoonLabelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoonLabelById.HandleId, ConfigMoonLabelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoonLabel rootAsMoonLabel = MoonLabel.GetRootAsMoonLabel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoonLabelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoonLabelById.HandleId, ConfigMoonLabelById.LogPair);
			return new MoonLabel?(rootAsMoonLabel);
		}

		// Token: 0x04002576 RID: 9590
		private const string DB = "db_moonsignin.db";

		// Token: 0x04002577 RID: 9591
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x04002578 RID: 9592
		private const string TABLE = "MoonLabel";

		// Token: 0x04002579 RID: 9593
		private const string COMMAND = "select BinData from `MoonLabel` where Id=?";

		// Token: 0x0400257A RID: 9594
		private const string KEY_PREFIX = "MoonLabelById";

		// Token: 0x0400257B RID: 9595
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400257C RID: 9596
		private static int HandleId;
	}
}
