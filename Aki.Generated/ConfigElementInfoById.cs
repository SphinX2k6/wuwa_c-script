using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000275 RID: 629
	public class ConfigElementInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EC2 RID: 3778 RVA: 0x000B05BB File Offset: 0x000AE7BB
		static ConfigElementInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementInfoById.CreateStaticDefaultValue), new Action(ConfigElementInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x000B05DC File Offset: 0x000AE7DC
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

		// Token: 0x06000EC4 RID: 3780 RVA: 0x000B065B File Offset: 0x000AE85B
		public static void ResetStaticDefaultValue()
		{
			ConfigElementInfoById.LogPair = null;
			ConfigElementInfoById.HandleId = 0;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x000B0669 File Offset: 0x000AE869
		public static void Init()
		{
			ConfigElementInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigElementInfoById.HandleId, "db_element_info.db", "select BinData from `ElementInfo` where Id=?");
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x000B0684 File Offset: 0x000AE884
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

		// Token: 0x04001117 RID: 4375
		private const string DB = "db_element_info.db";

		// Token: 0x04001118 RID: 4376
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x04001119 RID: 4377
		private const string TABLE = "ElementInfo";

		// Token: 0x0400111A RID: 4378
		private const string COMMAND = "select BinData from `ElementInfo` where Id=?";

		// Token: 0x0400111B RID: 4379
		private const string KEY_PREFIX = "ElementInfoById";

		// Token: 0x0400111C RID: 4380
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400111D RID: 4381
		private static int HandleId;
	}
}
