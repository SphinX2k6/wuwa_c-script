using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018B RID: 395
	public class ConfigCommonTouchUiEditGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x0008DE25 File Offset: 0x0008C025
		static ConfigCommonTouchUiEditGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonTouchUiEditGroupById.CreateStaticDefaultValue), new Action(ConfigCommonTouchUiEditGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0008DE44 File Offset: 0x0008C044
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

		// Token: 0x06000946 RID: 2374 RVA: 0x0008DEC3 File Offset: 0x0008C0C3
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonTouchUiEditGroupById.LogPair = null;
			ConfigCommonTouchUiEditGroupById.HandleId = 0;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0008DED1 File Offset: 0x0008C0D1
		public static void Init()
		{
			ConfigCommonTouchUiEditGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonTouchUiEditGroupById.HandleId, "db_commontouchuiedit.db", "select BinData from `CommonTouchUiEditGroup` where Id=?");
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0008DEEC File Offset: 0x0008C0EC
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

		// Token: 0x04000AB1 RID: 2737
		private const string DB = "db_commontouchuiedit.db";

		// Token: 0x04000AB2 RID: 2738
		private const string FILE = "y.移动端活动玩法主界面键位配置.xlsx";

		// Token: 0x04000AB3 RID: 2739
		private const string TABLE = "CommonTouchUiEditGroup";

		// Token: 0x04000AB4 RID: 2740
		private const string COMMAND = "select BinData from `CommonTouchUiEditGroup` where Id=?";

		// Token: 0x04000AB5 RID: 2741
		private const string KEY_PREFIX = "CommonTouchUiEditGroupById";

		// Token: 0x04000AB6 RID: 2742
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AB7 RID: 2743
		private static int HandleId;
	}
}
