using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000373 RID: 883
	public class ConfigGachaSequenceConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014B8 RID: 5304 RVA: 0x000CEAFF File Offset: 0x000CCCFF
		static ConfigGachaSequenceConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaSequenceConfigById.CreateStaticDefaultValue), new Action(ConfigGachaSequenceConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000CEB20 File Offset: 0x000CCD20
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaSequenceConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaSequenceConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaSequenceConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaSequenceConfig` where Id=?")
			});
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000CEB9F File Offset: 0x000CCD9F
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaSequenceConfigById.LogPair = null;
			ConfigGachaSequenceConfigById.HandleId = 0;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x000CEBAD File Offset: 0x000CCDAD
		public static void Init()
		{
			ConfigGachaSequenceConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaSequenceConfigById.HandleId, "db_gacha.db", "select BinData from `GachaSequenceConfig` where Id=?");
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x000CEBC8 File Offset: 0x000CCDC8
		public static GachaSequenceConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaSequenceConfigById.HandleId, ConfigGachaSequenceConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaSequenceConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaSequenceConfig?(GachaSequenceConfig.GetRootAsGachaSequenceConfig(configBuffer));
				}
			}
			ConfigGachaSequenceConfigById.LogPair.Clear();
			ConfigGachaSequenceConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaSequenceConfigById.HandleId, 1, p0Id, ConfigGachaSequenceConfigById.LogPair) || ConfigCommon.Step(ConfigGachaSequenceConfigById.HandleId, true, ConfigGachaSequenceConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaSequenceConfigById.HandleId, ConfigGachaSequenceConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaSequenceConfigById.HandleId, 0, ConfigGachaSequenceConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaSequenceConfigById.HandleId, ConfigGachaSequenceConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaSequenceConfig rootAsGachaSequenceConfig = GachaSequenceConfig.GetRootAsGachaSequenceConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaSequenceConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaSequenceConfigById.HandleId, ConfigGachaSequenceConfigById.LogPair);
			return new GachaSequenceConfig?(rootAsGachaSequenceConfig);
		}

		// Token: 0x04001809 RID: 6153
		private const string DB = "db_gacha.db";

		// Token: 0x0400180A RID: 6154
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x0400180B RID: 6155
		private const string TABLE = "GachaSequenceConfig";

		// Token: 0x0400180C RID: 6156
		private const string COMMAND = "select BinData from `GachaSequenceConfig` where Id=?";

		// Token: 0x0400180D RID: 6157
		private const string KEY_PREFIX = "GachaSequenceConfigById";

		// Token: 0x0400180E RID: 6158
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400180F RID: 6159
		private static int HandleId;
	}
}
