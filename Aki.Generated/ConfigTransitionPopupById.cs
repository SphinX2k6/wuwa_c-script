using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AEB RID: 2795
	public class ConfigTransitionPopupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004196 RID: 16790 RVA: 0x001CFA2D File Offset: 0x001CDC2D
		static ConfigTransitionPopupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTransitionPopupById.CreateStaticDefaultValue), new Action(ConfigTransitionPopupById.ResetStaticDefaultValue));
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x001CFA4C File Offset: 0x001CDC4C
		public static void CreateStaticDefaultValue()
		{
			ConfigTransitionPopupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTransitionPopupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_transitionpopup.db"),
				new ValueTuple<string, object>("文件", "j.剧情转场弹窗.xlsx"),
				new ValueTuple<string, object>("表名", "TransitionPopup"),
				new ValueTuple<string, object>("语句", "select BinData from `TransitionPopup` where Id = ?")
			});
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x001CFACB File Offset: 0x001CDCCB
		public static void ResetStaticDefaultValue()
		{
			ConfigTransitionPopupById.LogPair = null;
			ConfigTransitionPopupById.HandleId = 0;
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x001CFAD9 File Offset: 0x001CDCD9
		public static void Init()
		{
			ConfigTransitionPopupById.HandleId = ConfigCommon.InitDataStatement(ConfigTransitionPopupById.HandleId, "db_transitionpopup.db", "select BinData from `TransitionPopup` where Id = ?");
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x001CFAF4 File Offset: 0x001CDCF4
		public static TransitionPopup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTransitionPopupById.HandleId, ConfigTransitionPopupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TransitionPopupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TransitionPopup?(TransitionPopup.GetRootAsTransitionPopup(configBuffer));
				}
			}
			ConfigTransitionPopupById.LogPair.Clear();
			ConfigTransitionPopupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTransitionPopupById.HandleId, 1, p0Id, ConfigTransitionPopupById.LogPair) || ConfigCommon.Step(ConfigTransitionPopupById.HandleId, true, ConfigTransitionPopupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTransitionPopupById.HandleId, ConfigTransitionPopupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTransitionPopupById.HandleId, 0, ConfigTransitionPopupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTransitionPopupById.HandleId, ConfigTransitionPopupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TransitionPopup rootAsTransitionPopup = TransitionPopup.GetRootAsTransitionPopup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TransitionPopupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTransitionPopupById.HandleId, ConfigTransitionPopupById.LogPair);
			return new TransitionPopup?(rootAsTransitionPopup);
		}

		// Token: 0x04004C53 RID: 19539
		private const string DB = "db_transitionpopup.db";

		// Token: 0x04004C54 RID: 19540
		private const string FILE = "j.剧情转场弹窗.xlsx";

		// Token: 0x04004C55 RID: 19541
		private const string TABLE = "TransitionPopup";

		// Token: 0x04004C56 RID: 19542
		private const string COMMAND = "select BinData from `TransitionPopup` where Id = ?";

		// Token: 0x04004C57 RID: 19543
		private const string KEY_PREFIX = "TransitionPopupById";

		// Token: 0x04004C58 RID: 19544
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C59 RID: 19545
		private static int HandleId;
	}
}
