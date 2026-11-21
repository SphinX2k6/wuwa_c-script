using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095E RID: 2398
	public class ConfigSheriffClueById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003847 RID: 14407 RVA: 0x0019AA83 File Offset: 0x00198C83
		static ConfigSheriffClueById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffClueById.CreateStaticDefaultValue), new Action(ConfigSheriffClueById.ResetStaticDefaultValue));
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x0019AAA4 File Offset: 0x00198CA4
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffClueById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffClueById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffClue"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffClue` where Id=?")
			});
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x0019AB23 File Offset: 0x00198D23
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffClueById.LogPair = null;
			ConfigSheriffClueById.HandleId = 0;
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x0019AB31 File Offset: 0x00198D31
		public static void Init()
		{
			ConfigSheriffClueById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffClueById.HandleId, "db_sheriff.db", "select BinData from `SheriffClue` where Id=?");
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x0019AB4C File Offset: 0x00198D4C
		public static SheriffClue? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffClueById.HandleId, ConfigSheriffClueById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffClueById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffClue?(SheriffClue.GetRootAsSheriffClue(configBuffer));
				}
			}
			ConfigSheriffClueById.LogPair.Clear();
			ConfigSheriffClueById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffClueById.HandleId, 1, p0Id, ConfigSheriffClueById.LogPair) || ConfigCommon.Step(ConfigSheriffClueById.HandleId, true, ConfigSheriffClueById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffClueById.HandleId, ConfigSheriffClueById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffClueById.HandleId, 0, ConfigSheriffClueById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffClueById.HandleId, ConfigSheriffClueById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffClue rootAsSheriffClue = SheriffClue.GetRootAsSheriffClue(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffClueById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffClueById.HandleId, ConfigSheriffClueById.LogPair);
			return new SheriffClue?(rootAsSheriffClue);
		}

		// Token: 0x04004178 RID: 16760
		private const string DB = "db_sheriff.db";

		// Token: 0x04004179 RID: 16761
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x0400417A RID: 16762
		private const string TABLE = "SheriffClue";

		// Token: 0x0400417B RID: 16763
		private const string COMMAND = "select BinData from `SheriffClue` where Id=?";

		// Token: 0x0400417C RID: 16764
		private const string KEY_PREFIX = "SheriffClueById";

		// Token: 0x0400417D RID: 16765
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400417E RID: 16766
		private static int HandleId;
	}
}
