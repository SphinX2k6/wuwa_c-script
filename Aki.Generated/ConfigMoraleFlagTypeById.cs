using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000563 RID: 1379
	public class ConfigMoraleFlagTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x00110650 File Offset: 0x0010E850
		static ConfigMoraleFlagTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleFlagTypeById.CreateStaticDefaultValue), new Action(ConfigMoraleFlagTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00110670 File Offset: 0x0010E870
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleFlagTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleFlagTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleFlagType"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleFlagType` where Id=?")
			});
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x001106EF File Offset: 0x0010E8EF
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleFlagTypeById.LogPair = null;
			ConfigMoraleFlagTypeById.HandleId = 0;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x001106FD File Offset: 0x0010E8FD
		public static void Init()
		{
			ConfigMoraleFlagTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleFlagTypeById.HandleId, "db_moraleplay.db", "select BinData from `MoraleFlagType` where Id=?");
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00110718 File Offset: 0x0010E918
		public static MoraleFlagType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleFlagTypeById.HandleId, ConfigMoraleFlagTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleFlagTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleFlagType?(MoraleFlagType.GetRootAsMoraleFlagType(configBuffer));
				}
			}
			ConfigMoraleFlagTypeById.LogPair.Clear();
			ConfigMoraleFlagTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMoraleFlagTypeById.HandleId, 1, p0Id, ConfigMoraleFlagTypeById.LogPair) || ConfigCommon.Step(ConfigMoraleFlagTypeById.HandleId, true, ConfigMoraleFlagTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleFlagTypeById.HandleId, ConfigMoraleFlagTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleFlagTypeById.HandleId, 0, ConfigMoraleFlagTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleFlagTypeById.HandleId, ConfigMoraleFlagTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleFlagType rootAsMoraleFlagType = MoraleFlagType.GetRootAsMoraleFlagType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleFlagTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleFlagTypeById.HandleId, ConfigMoraleFlagTypeById.LogPair);
			return new MoraleFlagType?(rootAsMoraleFlagType);
		}

		// Token: 0x04002599 RID: 9625
		private const string DB = "db_moraleplay.db";

		// Token: 0x0400259A RID: 9626
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400259B RID: 9627
		private const string TABLE = "MoraleFlagType";

		// Token: 0x0400259C RID: 9628
		private const string COMMAND = "select BinData from `MoraleFlagType` where Id=?";

		// Token: 0x0400259D RID: 9629
		private const string KEY_PREFIX = "MoraleFlagTypeById";

		// Token: 0x0400259E RID: 9630
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400259F RID: 9631
		private static int HandleId;
	}
}
