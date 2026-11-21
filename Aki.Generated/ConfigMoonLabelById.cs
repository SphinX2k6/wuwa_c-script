using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000574 RID: 1396
	public class ConfigMoonLabelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020C5 RID: 8389 RVA: 0x001162F0 File Offset: 0x001144F0
		static ConfigMoonLabelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoonLabelById.CreateStaticDefaultValue), new Action(ConfigMoonLabelById.ResetStaticDefaultValue));
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00116310 File Offset: 0x00114510
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

		// Token: 0x060020C7 RID: 8391 RVA: 0x0011638F File Offset: 0x0011458F
		public static void ResetStaticDefaultValue()
		{
			ConfigMoonLabelById.LogPair = null;
			ConfigMoonLabelById.HandleId = 0;
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x0011639D File Offset: 0x0011459D
		public static void Init()
		{
			ConfigMoonLabelById.HandleId = ConfigCommon.InitDataStatement(ConfigMoonLabelById.HandleId, "db_moonsignin.db", "select BinData from `MoonLabel` where Id=?");
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x001163B8 File Offset: 0x001145B8
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

		// Token: 0x04002610 RID: 9744
		private const string DB = "db_moonsignin.db";

		// Token: 0x04002611 RID: 9745
		private const string FILE = "y.月相活动.xlsx";

		// Token: 0x04002612 RID: 9746
		private const string TABLE = "MoonLabel";

		// Token: 0x04002613 RID: 9747
		private const string COMMAND = "select BinData from `MoonLabel` where Id=?";

		// Token: 0x04002614 RID: 9748
		private const string KEY_PREFIX = "MoonLabelById";

		// Token: 0x04002615 RID: 9749
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002616 RID: 9750
		private static int HandleId;
	}
}
