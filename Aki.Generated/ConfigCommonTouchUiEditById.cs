using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000189 RID: 393
	public class ConfigCommonTouchUiEditById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000937 RID: 2359 RVA: 0x0008D8CB File Offset: 0x0008BACB
		static ConfigCommonTouchUiEditById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonTouchUiEditById.CreateStaticDefaultValue), new Action(ConfigCommonTouchUiEditById.ResetStaticDefaultValue));
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0008D8EC File Offset: 0x0008BAEC
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonTouchUiEditById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonTouchUiEditById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commontouchuiedit.db"),
				new ValueTuple<string, object>("文件", "y.移动端活动玩法主界面键位配置.xlsx"),
				new ValueTuple<string, object>("表名", "CommonTouchUiEdit"),
				new ValueTuple<string, object>("语句", "select BinData from `CommonTouchUiEdit` where Id=?")
			});
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0008D96B File Offset: 0x0008BB6B
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonTouchUiEditById.LogPair = null;
			ConfigCommonTouchUiEditById.HandleId = 0;
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0008D979 File Offset: 0x0008BB79
		public static void Init()
		{
			ConfigCommonTouchUiEditById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonTouchUiEditById.HandleId, "db_commontouchuiedit.db", "select BinData from `CommonTouchUiEdit` where Id=?");
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0008D994 File Offset: 0x0008BB94
		public static CommonTouchUiEdit? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonTouchUiEditById.HandleId, ConfigCommonTouchUiEditById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonTouchUiEditById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CommonTouchUiEdit?(CommonTouchUiEdit.GetRootAsCommonTouchUiEdit(configBuffer));
				}
			}
			ConfigCommonTouchUiEditById.LogPair.Clear();
			ConfigCommonTouchUiEditById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCommonTouchUiEditById.HandleId, 1, p0Id, ConfigCommonTouchUiEditById.LogPair) || ConfigCommon.Step(ConfigCommonTouchUiEditById.HandleId, true, ConfigCommonTouchUiEditById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCommonTouchUiEditById.HandleId, ConfigCommonTouchUiEditById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonTouchUiEditById.HandleId, 0, ConfigCommonTouchUiEditById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCommonTouchUiEditById.HandleId, ConfigCommonTouchUiEditById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CommonTouchUiEdit rootAsCommonTouchUiEdit = CommonTouchUiEdit.GetRootAsCommonTouchUiEdit(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonTouchUiEditById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCommonTouchUiEditById.HandleId, ConfigCommonTouchUiEditById.LogPair);
			return new CommonTouchUiEdit?(rootAsCommonTouchUiEdit);
		}

		// Token: 0x04000AA3 RID: 2723
		private const string DB = "db_commontouchuiedit.db";

		// Token: 0x04000AA4 RID: 2724
		private const string FILE = "y.移动端活动玩法主界面键位配置.xlsx";

		// Token: 0x04000AA5 RID: 2725
		private const string TABLE = "CommonTouchUiEdit";

		// Token: 0x04000AA6 RID: 2726
		private const string COMMAND = "select BinData from `CommonTouchUiEdit` where Id=?";

		// Token: 0x04000AA7 RID: 2727
		private const string KEY_PREFIX = "CommonTouchUiEditById";

		// Token: 0x04000AA8 RID: 2728
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AA9 RID: 2729
		private static int HandleId;
	}
}
