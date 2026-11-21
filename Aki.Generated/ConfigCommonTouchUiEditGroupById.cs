using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019D RID: 413
	public class ConfigCommonTouchUiEditGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009B0 RID: 2480 RVA: 0x00093D5D File Offset: 0x00091F5D
		static ConfigCommonTouchUiEditGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonTouchUiEditGroupById.CreateStaticDefaultValue), new Action(ConfigCommonTouchUiEditGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00093D7C File Offset: 0x00091F7C
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonTouchUiEditGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonTouchUiEditGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commontouchuiedit.db"),
				new ValueTuple<string, object>("文件", "y.移动端活动玩法主界面键位配置.xlsx"),
				new ValueTuple<string, object>("表名", "CommonTouchUiEditGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `CommonTouchUiEditGroup` where Id=?")
			});
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00093DFB File Offset: 0x00091FFB
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonTouchUiEditGroupById.LogPair = null;
			ConfigCommonTouchUiEditGroupById.HandleId = 0;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00093E09 File Offset: 0x00092009
		public static void Init()
		{
			ConfigCommonTouchUiEditGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonTouchUiEditGroupById.HandleId, "db_commontouchuiedit.db", "select BinData from `CommonTouchUiEditGroup` where Id=?");
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00093E24 File Offset: 0x00092024
		public static CommonTouchUiEditGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonTouchUiEditGroupById.HandleId, ConfigCommonTouchUiEditGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonTouchUiEditGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CommonTouchUiEditGroup?(CommonTouchUiEditGroup.GetRootAsCommonTouchUiEditGroup(configBuffer));
				}
			}
			ConfigCommonTouchUiEditGroupById.LogPair.Clear();
			ConfigCommonTouchUiEditGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCommonTouchUiEditGroupById.HandleId, 1, p0Id, ConfigCommonTouchUiEditGroupById.LogPair) || ConfigCommon.Step(ConfigCommonTouchUiEditGroupById.HandleId, true, ConfigCommonTouchUiEditGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCommonTouchUiEditGroupById.HandleId, ConfigCommonTouchUiEditGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonTouchUiEditGroupById.HandleId, 0, ConfigCommonTouchUiEditGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCommonTouchUiEditGroupById.HandleId, ConfigCommonTouchUiEditGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CommonTouchUiEditGroup rootAsCommonTouchUiEditGroup = CommonTouchUiEditGroup.GetRootAsCommonTouchUiEditGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonTouchUiEditGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCommonTouchUiEditGroupById.HandleId, ConfigCommonTouchUiEditGroupById.LogPair);
			return new CommonTouchUiEditGroup?(rootAsCommonTouchUiEditGroup);
		}

		// Token: 0x04000B2F RID: 2863
		private const string DB = "db_commontouchuiedit.db";

		// Token: 0x04000B30 RID: 2864
		private const string FILE = "y.移动端活动玩法主界面键位配置.xlsx";

		// Token: 0x04000B31 RID: 2865
		private const string TABLE = "CommonTouchUiEditGroup";

		// Token: 0x04000B32 RID: 2866
		private const string COMMAND = "select BinData from `CommonTouchUiEditGroup` where Id=?";

		// Token: 0x04000B33 RID: 2867
		private const string KEY_PREFIX = "CommonTouchUiEditGroupById";

		// Token: 0x04000B34 RID: 2868
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B35 RID: 2869
		private static int HandleId;
	}
}
