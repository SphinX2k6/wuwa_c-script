using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000579 RID: 1401
	public class ConfigMoraleFlagTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020E3 RID: 8419 RVA: 0x00116DA4 File Offset: 0x00114FA4
		static ConfigMoraleFlagTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleFlagTypeById.CreateStaticDefaultValue), new Action(ConfigMoraleFlagTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00116DC4 File Offset: 0x00114FC4
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

		// Token: 0x060020E5 RID: 8421 RVA: 0x00116E43 File Offset: 0x00115043
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleFlagTypeById.LogPair = null;
			ConfigMoraleFlagTypeById.HandleId = 0;
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00116E51 File Offset: 0x00115051
		public static void Init()
		{
			ConfigMoraleFlagTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleFlagTypeById.HandleId, "db_moraleplay.db", "select BinData from `MoraleFlagType` where Id=?");
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00116E6C File Offset: 0x0011506C
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

		// Token: 0x04002633 RID: 9779
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002634 RID: 9780
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002635 RID: 9781
		private const string TABLE = "MoraleFlagType";

		// Token: 0x04002636 RID: 9782
		private const string COMMAND = "select BinData from `MoraleFlagType` where Id=?";

		// Token: 0x04002637 RID: 9783
		private const string KEY_PREFIX = "MoraleFlagTypeById";

		// Token: 0x04002638 RID: 9784
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002639 RID: 9785
		private static int HandleId;
	}
}
