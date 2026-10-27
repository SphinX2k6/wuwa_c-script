using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A16 RID: 2582
	public class ConfigTransitionPopupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C98 RID: 15512 RVA: 0x001B0699 File Offset: 0x001AE899
		static ConfigTransitionPopupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTransitionPopupById.CreateStaticDefaultValue), new Action(ConfigTransitionPopupById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x001B06B8 File Offset: 0x001AE8B8
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

		// Token: 0x06003C9A RID: 15514 RVA: 0x001B0737 File Offset: 0x001AE937
		public static void ResetStaticDefaultValue()
		{
			ConfigTransitionPopupById.LogPair = null;
			ConfigTransitionPopupById.HandleId = 0;
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x001B0745 File Offset: 0x001AE945
		public static void Init()
		{
			ConfigTransitionPopupById.HandleId = ConfigCommon.InitDataStatement(ConfigTransitionPopupById.HandleId, "db_transitionpopup.db", "select BinData from `TransitionPopup` where Id = ?");
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x001B0760 File Offset: 0x001AE960
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

		// Token: 0x04004680 RID: 18048
		private const string DB = "db_transitionpopup.db";

		// Token: 0x04004681 RID: 18049
		private const string FILE = "j.剧情转场弹窗.xlsx";

		// Token: 0x04004682 RID: 18050
		private const string TABLE = "TransitionPopup";

		// Token: 0x04004683 RID: 18051
		private const string COMMAND = "select BinData from `TransitionPopup` where Id = ?";

		// Token: 0x04004684 RID: 18052
		private const string KEY_PREFIX = "TransitionPopupById";

		// Token: 0x04004685 RID: 18053
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004686 RID: 18054
		private static int HandleId;
	}
}
