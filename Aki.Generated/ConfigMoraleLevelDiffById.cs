using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057D RID: 1405
	public class ConfigMoraleLevelDiffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020FB RID: 8443 RVA: 0x00117610 File Offset: 0x00115810
		static ConfigMoraleLevelDiffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleLevelDiffById.CreateStaticDefaultValue), new Action(ConfigMoraleLevelDiffById.ResetStaticDefaultValue));
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00117630 File Offset: 0x00115830
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleLevelDiffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleLevelDiffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleLevelDiff"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleLevelDiff` where Level=?")
			});
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x001176AF File Offset: 0x001158AF
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleLevelDiffById.LogPair = null;
			ConfigMoraleLevelDiffById.HandleId = 0;
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x001176BD File Offset: 0x001158BD
		public static void Init()
		{
			ConfigMoraleLevelDiffById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleLevelDiffById.HandleId, "db_moraleplay.db", "select BinData from `MoraleLevelDiff` where Level=?");
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x001176D8 File Offset: 0x001158D8
		public static MoraleLevelDiff? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleLevelDiffById.HandleId, ConfigMoraleLevelDiffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleLevelDiffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleLevelDiff?(MoraleLevelDiff.GetRootAsMoraleLevelDiff(configBuffer));
				}
			}
			ConfigMoraleLevelDiffById.LogPair.Clear();
			ConfigMoraleLevelDiffById.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigMoraleLevelDiffById.HandleId, 1, p0Level, ConfigMoraleLevelDiffById.LogPair) || ConfigCommon.Step(ConfigMoraleLevelDiffById.HandleId, true, ConfigMoraleLevelDiffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleLevelDiffById.HandleId, ConfigMoraleLevelDiffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleLevelDiffById.HandleId, 0, ConfigMoraleLevelDiffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleLevelDiffById.HandleId, ConfigMoraleLevelDiffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleLevelDiff rootAsMoraleLevelDiff = MoraleLevelDiff.GetRootAsMoraleLevelDiff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleLevelDiffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleLevelDiffById.HandleId, ConfigMoraleLevelDiffById.LogPair);
			return new MoraleLevelDiff?(rootAsMoraleLevelDiff);
		}

		// Token: 0x0400264F RID: 9807
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002650 RID: 9808
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002651 RID: 9809
		private const string TABLE = "MoraleLevelDiff";

		// Token: 0x04002652 RID: 9810
		private const string COMMAND = "select BinData from `MoraleLevelDiff` where Level=?";

		// Token: 0x04002653 RID: 9811
		private const string KEY_PREFIX = "MoraleLevelDiffById";

		// Token: 0x04002654 RID: 9812
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002655 RID: 9813
		private static int HandleId;
	}
}
