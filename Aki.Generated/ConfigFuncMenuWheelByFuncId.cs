using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000359 RID: 857
	public class ConfigFuncMenuWheelByFuncId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600141B RID: 5147 RVA: 0x000CB213 File Offset: 0x000C9413
		static ConfigFuncMenuWheelByFuncId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFuncMenuWheelByFuncId.CreateStaticDefaultValue), new Action(ConfigFuncMenuWheelByFuncId.ResetStaticDefaultValue));
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x000CB234 File Offset: 0x000C9434
		public static void CreateStaticDefaultValue()
		{
			ConfigFuncMenuWheelByFuncId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFuncMenuWheelByFuncId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roulette.db"),
				new ValueTuple<string, object>("文件", "l.轮盘.xlsx"),
				new ValueTuple<string, object>("表名", "FuncMenuWheel"),
				new ValueTuple<string, object>("语句", "select BinData from `FuncMenuWheel` where FuncId=?")
			});
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x000CB2B3 File Offset: 0x000C94B3
		public static void ResetStaticDefaultValue()
		{
			ConfigFuncMenuWheelByFuncId.LogPair = null;
			ConfigFuncMenuWheelByFuncId.HandleId = 0;
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x000CB2C1 File Offset: 0x000C94C1
		public static void Init()
		{
			ConfigFuncMenuWheelByFuncId.HandleId = ConfigCommon.InitDataStatement(ConfigFuncMenuWheelByFuncId.HandleId, "db_roulette.db", "select BinData from `FuncMenuWheel` where FuncId=?");
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x000CB2DC File Offset: 0x000C94DC
		public static FuncMenuWheel? GetConfig(int p0FuncId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFuncMenuWheelByFuncId.HandleId, ConfigFuncMenuWheelByFuncId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FuncMenuWheelByFuncId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FuncId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FuncMenuWheel?(FuncMenuWheel.GetRootAsFuncMenuWheel(configBuffer));
				}
			}
			ConfigFuncMenuWheelByFuncId.LogPair.Clear();
			ConfigFuncMenuWheelByFuncId.LogPair.Add(new ValueTuple<string, object>("FuncId", p0FuncId));
			if (!ConfigCommon.BindInt(ConfigFuncMenuWheelByFuncId.HandleId, 1, p0FuncId, ConfigFuncMenuWheelByFuncId.LogPair) || ConfigCommon.Step(ConfigFuncMenuWheelByFuncId.HandleId, true, ConfigFuncMenuWheelByFuncId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFuncMenuWheelByFuncId.HandleId, ConfigFuncMenuWheelByFuncId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFuncMenuWheelByFuncId.HandleId, 0, ConfigFuncMenuWheelByFuncId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFuncMenuWheelByFuncId.HandleId, ConfigFuncMenuWheelByFuncId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FuncMenuWheel rootAsFuncMenuWheel = FuncMenuWheel.GetRootAsFuncMenuWheel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FuncMenuWheelByFuncId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FuncId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFuncMenuWheelByFuncId.HandleId, ConfigFuncMenuWheelByFuncId.LogPair);
			return new FuncMenuWheel?(rootAsFuncMenuWheel);
		}

		// Token: 0x04001753 RID: 5971
		private const string DB = "db_roulette.db";

		// Token: 0x04001754 RID: 5972
		private const string FILE = "l.轮盘.xlsx";

		// Token: 0x04001755 RID: 5973
		private const string TABLE = "FuncMenuWheel";

		// Token: 0x04001756 RID: 5974
		private const string COMMAND = "select BinData from `FuncMenuWheel` where FuncId=?";

		// Token: 0x04001757 RID: 5975
		private const string KEY_PREFIX = "FuncMenuWheelByFuncId";

		// Token: 0x04001758 RID: 5976
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001759 RID: 5977
		private static int HandleId;
	}
}
