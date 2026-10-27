using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000653 RID: 1619
	public class ConfigPersonProgressCurveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002602 RID: 9730 RVA: 0x001308F7 File Offset: 0x0012EAF7
		static ConfigPersonProgressCurveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPersonProgressCurveById.CreateStaticDefaultValue), new Action(ConfigPersonProgressCurveById.ResetStaticDefaultValue));
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00130918 File Offset: 0x0012EB18
		public static void CreateStaticDefaultValue()
		{
			ConfigPersonProgressCurveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPersonProgressCurveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_anniversaryt.db"),
				new ValueTuple<string, object>("文件", "z.周年庆主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "PersonProgressCurve"),
				new ValueTuple<string, object>("语句", "select BinData from `PersonProgressCurve` where Id=?")
			});
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00130997 File Offset: 0x0012EB97
		public static void ResetStaticDefaultValue()
		{
			ConfigPersonProgressCurveById.LogPair = null;
			ConfigPersonProgressCurveById.HandleId = 0;
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x001309A5 File Offset: 0x0012EBA5
		public static void Init()
		{
			ConfigPersonProgressCurveById.HandleId = ConfigCommon.InitDataStatement(ConfigPersonProgressCurveById.HandleId, "db_anniversaryt.db", "select BinData from `PersonProgressCurve` where Id=?");
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x001309C0 File Offset: 0x0012EBC0
		public static PersonProgressCurve? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPersonProgressCurveById.HandleId, ConfigPersonProgressCurveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PersonProgressCurveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PersonProgressCurve?(PersonProgressCurve.GetRootAsPersonProgressCurve(configBuffer));
				}
			}
			ConfigPersonProgressCurveById.LogPair.Clear();
			ConfigPersonProgressCurveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPersonProgressCurveById.HandleId, 1, p0Id, ConfigPersonProgressCurveById.LogPair) || ConfigCommon.Step(ConfigPersonProgressCurveById.HandleId, true, ConfigPersonProgressCurveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPersonProgressCurveById.HandleId, ConfigPersonProgressCurveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPersonProgressCurveById.HandleId, 0, ConfigPersonProgressCurveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPersonProgressCurveById.HandleId, ConfigPersonProgressCurveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PersonProgressCurve rootAsPersonProgressCurve = PersonProgressCurve.GetRootAsPersonProgressCurve(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PersonProgressCurveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPersonProgressCurveById.HandleId, ConfigPersonProgressCurveById.LogPair);
			return new PersonProgressCurve?(rootAsPersonProgressCurve);
		}

		// Token: 0x04002C2B RID: 11307
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04002C2C RID: 11308
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04002C2D RID: 11309
		private const string TABLE = "PersonProgressCurve";

		// Token: 0x04002C2E RID: 11310
		private const string COMMAND = "select BinData from `PersonProgressCurve` where Id=?";

		// Token: 0x04002C2F RID: 11311
		private const string KEY_PREFIX = "PersonProgressCurveById";

		// Token: 0x04002C30 RID: 11312
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C31 RID: 11313
		private static int HandleId;
	}
}
