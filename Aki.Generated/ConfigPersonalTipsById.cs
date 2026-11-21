using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000669 RID: 1641
	public class ConfigPersonalTipsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002686 RID: 9862 RVA: 0x00136F97 File Offset: 0x00135197
		static ConfigPersonalTipsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPersonalTipsById.CreateStaticDefaultValue), new Action(ConfigPersonalTipsById.ResetStaticDefaultValue));
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00136FB8 File Offset: 0x001351B8
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

		// Token: 0x06002688 RID: 9864 RVA: 0x00137037 File Offset: 0x00135237
		public static void ResetStaticDefaultValue()
		{
			ConfigPersonalTipsById.LogPair = null;
			ConfigPersonalTipsById.HandleId = 0;
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00137045 File Offset: 0x00135245
		public static void Init()
		{
			ConfigPersonalTipsById.HandleId = ConfigCommon.InitDataStatement(ConfigPersonalTipsById.HandleId, "db_personal.db", "select BinData from `PersonalTips` where Id=?");
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00137060 File Offset: 0x00135260
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

		// Token: 0x04002CC5 RID: 11461
		private const string DB = "db_personal.db";

		// Token: 0x04002CC6 RID: 11462
		private const string FILE = "g.个性化弹窗.xlsx";

		// Token: 0x04002CC7 RID: 11463
		private const string TABLE = "PersonalTips";

		// Token: 0x04002CC8 RID: 11464
		private const string COMMAND = "select BinData from `PersonalTips` where Id=?";

		// Token: 0x04002CC9 RID: 11465
		private const string KEY_PREFIX = "PersonalTipsById";

		// Token: 0x04002CCA RID: 11466
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CCB RID: 11467
		private static int HandleId;
	}
}
