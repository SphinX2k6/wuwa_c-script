using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000261 RID: 609
	public class ConfigElementInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E4A RID: 3658 RVA: 0x000AA2F7 File Offset: 0x000A84F7
		static ConfigElementInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementInfoById.CreateStaticDefaultValue), new Action(ConfigElementInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000AA318 File Offset: 0x000A8518
		public static void CreateStaticDefaultValue()
		{
			ConfigElementInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigElementInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_element_info.db"),
				new ValueTuple<string, object>("文件", "y.元素属性.xlsx"),
				new ValueTuple<string, object>("表名", "ElementInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `ElementInfo` where Id=?")
			});
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000AA397 File Offset: 0x000A8597
		public static void ResetStaticDefaultValue()
		{
			ConfigElementInfoById.LogPair = null;
			ConfigElementInfoById.HandleId = 0;
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000AA3A5 File Offset: 0x000A85A5
		public static void Init()
		{
			ConfigElementInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigElementInfoById.HandleId, "db_element_info.db", "select BinData from `ElementInfo` where Id=?");
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000AA3C0 File Offset: 0x000A85C0
		public static ElementInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigElementInfoById.HandleId, ConfigElementInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ElementInfo?(ElementInfo.GetRootAsElementInfo(configBuffer));
				}
			}
			ConfigElementInfoById.LogPair.Clear();
			ConfigElementInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigElementInfoById.HandleId, 1, p0Id, ConfigElementInfoById.LogPair) || ConfigCommon.Step(ConfigElementInfoById.HandleId, true, ConfigElementInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigElementInfoById.HandleId, ConfigElementInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigElementInfoById.HandleId, 0, ConfigElementInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigElementInfoById.HandleId, ConfigElementInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ElementInfo rootAsElementInfo = ElementInfo.GetRootAsElementInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigElementInfoById.HandleId, ConfigElementInfoById.LogPair);
			return new ElementInfo?(rootAsElementInfo);
		}

		// Token: 0x0400108B RID: 4235
		private const string DB = "db_element_info.db";

		// Token: 0x0400108C RID: 4236
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x0400108D RID: 4237
		private const string TABLE = "ElementInfo";

		// Token: 0x0400108E RID: 4238
		private const string COMMAND = "select BinData from `ElementInfo` where Id=?";

		// Token: 0x0400108F RID: 4239
		private const string KEY_PREFIX = "ElementInfoById";

		// Token: 0x04001090 RID: 4240
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001091 RID: 4241
		private static int HandleId;
	}
}
