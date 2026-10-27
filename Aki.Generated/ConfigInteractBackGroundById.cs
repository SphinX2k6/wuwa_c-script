using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044F RID: 1103
	public class ConfigInteractBackGroundById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019E4 RID: 6628 RVA: 0x000EBD41 File Offset: 0x000E9F41
		static ConfigInteractBackGroundById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInteractBackGroundById.CreateStaticDefaultValue), new Action(ConfigInteractBackGroundById.ResetStaticDefaultValue));
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x000EBD60 File Offset: 0x000E9F60
		public static void CreateStaticDefaultValue()
		{
			ConfigInteractBackGroundById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInteractBackGroundById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commonbackground.db"),
				new ValueTuple<string, object>("文件", "t.通用背景.xlsx"),
				new ValueTuple<string, object>("表名", "InteractBackGround"),
				new ValueTuple<string, object>("语句", "select BinData from `InteractBackGround` where Id=?")
			});
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x000EBDDF File Offset: 0x000E9FDF
		public static void ResetStaticDefaultValue()
		{
			ConfigInteractBackGroundById.LogPair = null;
			ConfigInteractBackGroundById.HandleId = 0;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000EBDED File Offset: 0x000E9FED
		public static void Init()
		{
			ConfigInteractBackGroundById.HandleId = ConfigCommon.InitDataStatement(ConfigInteractBackGroundById.HandleId, "db_commonbackground.db", "select BinData from `InteractBackGround` where Id=?");
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000EBE08 File Offset: 0x000EA008
		public static InteractBackGround? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInteractBackGroundById.HandleId, ConfigInteractBackGroundById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InteractBackGroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InteractBackGround?(InteractBackGround.GetRootAsInteractBackGround(configBuffer));
				}
			}
			ConfigInteractBackGroundById.LogPair.Clear();
			ConfigInteractBackGroundById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInteractBackGroundById.HandleId, 1, p0Id, ConfigInteractBackGroundById.LogPair) || ConfigCommon.Step(ConfigInteractBackGroundById.HandleId, true, ConfigInteractBackGroundById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInteractBackGroundById.HandleId, ConfigInteractBackGroundById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInteractBackGroundById.HandleId, 0, ConfigInteractBackGroundById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInteractBackGroundById.HandleId, ConfigInteractBackGroundById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InteractBackGround rootAsInteractBackGround = InteractBackGround.GetRootAsInteractBackGround(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InteractBackGroundById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInteractBackGroundById.HandleId, ConfigInteractBackGroundById.LogPair);
			return new InteractBackGround?(rootAsInteractBackGround);
		}

		// Token: 0x04001E0D RID: 7693
		private const string DB = "db_commonbackground.db";

		// Token: 0x04001E0E RID: 7694
		private const string FILE = "t.通用背景.xlsx";

		// Token: 0x04001E0F RID: 7695
		private const string TABLE = "InteractBackGround";

		// Token: 0x04001E10 RID: 7696
		private const string COMMAND = "select BinData from `InteractBackGround` where Id=?";

		// Token: 0x04001E11 RID: 7697
		private const string KEY_PREFIX = "InteractBackGroundById";

		// Token: 0x04001E12 RID: 7698
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E13 RID: 7699
		private static int HandleId;
	}
}
