using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066B RID: 1643
	public class ConfigPersonProgressCurveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002692 RID: 9874 RVA: 0x00137373 File Offset: 0x00135573
		static ConfigPersonProgressCurveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPersonProgressCurveById.CreateStaticDefaultValue), new Action(ConfigPersonProgressCurveById.ResetStaticDefaultValue));
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00137394 File Offset: 0x00135594
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

		// Token: 0x06002694 RID: 9876 RVA: 0x00137413 File Offset: 0x00135613
		public static void ResetStaticDefaultValue()
		{
			ConfigPersonProgressCurveById.LogPair = null;
			ConfigPersonProgressCurveById.HandleId = 0;
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00137421 File Offset: 0x00135621
		public static void Init()
		{
			ConfigPersonProgressCurveById.HandleId = ConfigCommon.InitDataStatement(ConfigPersonProgressCurveById.HandleId, "db_anniversaryt.db", "select BinData from `PersonProgressCurve` where Id=?");
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x0013743C File Offset: 0x0013563C
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

		// Token: 0x04002CD3 RID: 11475
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04002CD4 RID: 11476
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04002CD5 RID: 11477
		private const string TABLE = "PersonProgressCurve";

		// Token: 0x04002CD6 RID: 11478
		private const string COMMAND = "select BinData from `PersonProgressCurve` where Id=?";

		// Token: 0x04002CD7 RID: 11479
		private const string KEY_PREFIX = "PersonProgressCurveById";

		// Token: 0x04002CD8 RID: 11480
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CD9 RID: 11481
		private static int HandleId;
	}
}
