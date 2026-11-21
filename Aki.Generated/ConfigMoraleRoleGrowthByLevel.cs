using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000583 RID: 1411
	public class ConfigMoraleRoleGrowthByLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600211F RID: 8479 RVA: 0x00118258 File Offset: 0x00116458
		static ConfigMoraleRoleGrowthByLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleRoleGrowthByLevel.CreateStaticDefaultValue), new Action(ConfigMoraleRoleGrowthByLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00118278 File Offset: 0x00116478
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleRoleGrowthByLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleRoleGrowthByLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleRoleGrowth"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleRoleGrowth` where Level=?")
			});
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x001182F7 File Offset: 0x001164F7
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleRoleGrowthByLevel.LogPair = null;
			ConfigMoraleRoleGrowthByLevel.HandleId = 0;
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00118305 File Offset: 0x00116505
		public static void Init()
		{
			ConfigMoraleRoleGrowthByLevel.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleRoleGrowthByLevel.HandleId, "db_moraleplay.db", "select BinData from `MoraleRoleGrowth` where Level=?");
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00118320 File Offset: 0x00116520
		public static MoraleRoleGrowth? GetConfig(int p0Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleRoleGrowthByLevel.HandleId, ConfigMoraleRoleGrowthByLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleRoleGrowthByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleRoleGrowth?(MoraleRoleGrowth.GetRootAsMoraleRoleGrowth(configBuffer));
				}
			}
			ConfigMoraleRoleGrowthByLevel.LogPair.Clear();
			ConfigMoraleRoleGrowthByLevel.LogPair.Add(new ValueTuple<string, object>("Level", p0Level));
			if (!ConfigCommon.BindInt(ConfigMoraleRoleGrowthByLevel.HandleId, 1, p0Level, ConfigMoraleRoleGrowthByLevel.LogPair) || ConfigCommon.Step(ConfigMoraleRoleGrowthByLevel.HandleId, true, ConfigMoraleRoleGrowthByLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleRoleGrowthByLevel.HandleId, ConfigMoraleRoleGrowthByLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleRoleGrowthByLevel.HandleId, 0, ConfigMoraleRoleGrowthByLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleRoleGrowthByLevel.HandleId, ConfigMoraleRoleGrowthByLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleRoleGrowth rootAsMoraleRoleGrowth = MoraleRoleGrowth.GetRootAsMoraleRoleGrowth(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleRoleGrowthByLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleRoleGrowthByLevel.HandleId, ConfigMoraleRoleGrowthByLevel.LogPair);
			return new MoraleRoleGrowth?(rootAsMoraleRoleGrowth);
		}

		// Token: 0x04002679 RID: 9849
		private const string DB = "db_moraleplay.db";

		// Token: 0x0400267A RID: 9850
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400267B RID: 9851
		private const string TABLE = "MoraleRoleGrowth";

		// Token: 0x0400267C RID: 9852
		private const string COMMAND = "select BinData from `MoraleRoleGrowth` where Level=?";

		// Token: 0x0400267D RID: 9853
		private const string KEY_PREFIX = "MoraleRoleGrowthByLevel";

		// Token: 0x0400267E RID: 9854
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400267F RID: 9855
		private static int HandleId;
	}
}
