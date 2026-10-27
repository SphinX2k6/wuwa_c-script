using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000651 RID: 1617
	public class ConfigPersonalTipsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025F6 RID: 9718 RVA: 0x0013051B File Offset: 0x0012E71B
		static ConfigPersonalTipsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPersonalTipsById.CreateStaticDefaultValue), new Action(ConfigPersonalTipsById.ResetStaticDefaultValue));
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x0013053C File Offset: 0x0012E73C
		public static void CreateStaticDefaultValue()
		{
			ConfigPersonalTipsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPersonalTipsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_personal.db"),
				new ValueTuple<string, object>("文件", "g.个性化弹窗.xlsx"),
				new ValueTuple<string, object>("表名", "PersonalTips"),
				new ValueTuple<string, object>("语句", "select BinData from `PersonalTips` where Id=?")
			});
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x001305BB File Offset: 0x0012E7BB
		public static void ResetStaticDefaultValue()
		{
			ConfigPersonalTipsById.LogPair = null;
			ConfigPersonalTipsById.HandleId = 0;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x001305C9 File Offset: 0x0012E7C9
		public static void Init()
		{
			ConfigPersonalTipsById.HandleId = ConfigCommon.InitDataStatement(ConfigPersonalTipsById.HandleId, "db_personal.db", "select BinData from `PersonalTips` where Id=?");
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x001305E4 File Offset: 0x0012E7E4
		public static PersonalTips? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPersonalTipsById.HandleId, ConfigPersonalTipsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PersonalTipsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PersonalTips?(PersonalTips.GetRootAsPersonalTips(configBuffer));
				}
			}
			ConfigPersonalTipsById.LogPair.Clear();
			ConfigPersonalTipsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPersonalTipsById.HandleId, 1, p0Id, ConfigPersonalTipsById.LogPair) || ConfigCommon.Step(ConfigPersonalTipsById.HandleId, true, ConfigPersonalTipsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPersonalTipsById.HandleId, ConfigPersonalTipsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPersonalTipsById.HandleId, 0, ConfigPersonalTipsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPersonalTipsById.HandleId, ConfigPersonalTipsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PersonalTips rootAsPersonalTips = PersonalTips.GetRootAsPersonalTips(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PersonalTipsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPersonalTipsById.HandleId, ConfigPersonalTipsById.LogPair);
			return new PersonalTips?(rootAsPersonalTips);
		}

		// Token: 0x04002C1D RID: 11293
		private const string DB = "db_personal.db";

		// Token: 0x04002C1E RID: 11294
		private const string FILE = "g.个性化弹窗.xlsx";

		// Token: 0x04002C1F RID: 11295
		private const string TABLE = "PersonalTips";

		// Token: 0x04002C20 RID: 11296
		private const string COMMAND = "select BinData from `PersonalTips` where Id=?";

		// Token: 0x04002C21 RID: 11297
		private const string KEY_PREFIX = "PersonalTipsById";

		// Token: 0x04002C22 RID: 11298
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C23 RID: 11299
		private static int HandleId;
	}
}
