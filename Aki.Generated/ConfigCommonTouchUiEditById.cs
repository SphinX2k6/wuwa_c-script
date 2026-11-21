using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019B RID: 411
	public class ConfigCommonTouchUiEditById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009A3 RID: 2467 RVA: 0x00093803 File Offset: 0x00091A03
		static ConfigCommonTouchUiEditById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonTouchUiEditById.CreateStaticDefaultValue), new Action(ConfigCommonTouchUiEditById.ResetStaticDefaultValue));
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00093824 File Offset: 0x00091A24
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

		// Token: 0x060009A5 RID: 2469 RVA: 0x000938A3 File Offset: 0x00091AA3
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonTouchUiEditById.LogPair = null;
			ConfigCommonTouchUiEditById.HandleId = 0;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x000938B1 File Offset: 0x00091AB1
		public static void Init()
		{
			ConfigCommonTouchUiEditById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonTouchUiEditById.HandleId, "db_commontouchuiedit.db", "select BinData from `CommonTouchUiEdit` where Id=?");
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000938CC File Offset: 0x00091ACC
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

		// Token: 0x04000B21 RID: 2849
		private const string DB = "db_commontouchuiedit.db";

		// Token: 0x04000B22 RID: 2850
		private const string FILE = "y.移动端活动玩法主界面键位配置.xlsx";

		// Token: 0x04000B23 RID: 2851
		private const string TABLE = "CommonTouchUiEdit";

		// Token: 0x04000B24 RID: 2852
		private const string COMMAND = "select BinData from `CommonTouchUiEdit` where Id=?";

		// Token: 0x04000B25 RID: 2853
		private const string KEY_PREFIX = "CommonTouchUiEditById";

		// Token: 0x04000B26 RID: 2854
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B27 RID: 2855
		private static int HandleId;
	}
}
