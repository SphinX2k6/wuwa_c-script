using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000170 RID: 368
	public class ConfigCircumFluenceTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008A1 RID: 2209 RVA: 0x0008A3D3 File Offset: 0x000885D3
		static ConfigCircumFluenceTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumFluenceTaskById.CreateStaticDefaultValue), new Action(ConfigCircumFluenceTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0008A3F4 File Offset: 0x000885F4
		public static void CreateStaticDefaultValue()
		{
			ConfigCircumFluenceTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCircumFluenceTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "CircumFluenceTask"),
				new ValueTuple<string, object>("语句", "select BinData from `CircumFluenceTask` where Id=?")
			});
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0008A473 File Offset: 0x00088673
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumFluenceTaskById.LogPair = null;
			ConfigCircumFluenceTaskById.HandleId = 0;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0008A481 File Offset: 0x00088681
		public static void Init()
		{
			ConfigCircumFluenceTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigCircumFluenceTaskById.HandleId, "db_circumfluence.db", "select BinData from `CircumFluenceTask` where Id=?");
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0008A49C File Offset: 0x0008869C
		public static CircumFluenceTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCircumFluenceTaskById.HandleId, ConfigCircumFluenceTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumFluenceTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CircumFluenceTask?(CircumFluenceTask.GetRootAsCircumFluenceTask(configBuffer));
				}
			}
			ConfigCircumFluenceTaskById.LogPair.Clear();
			ConfigCircumFluenceTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCircumFluenceTaskById.HandleId, 1, p0Id, ConfigCircumFluenceTaskById.LogPair) || ConfigCommon.Step(ConfigCircumFluenceTaskById.HandleId, true, ConfigCircumFluenceTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCircumFluenceTaskById.HandleId, ConfigCircumFluenceTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCircumFluenceTaskById.HandleId, 0, ConfigCircumFluenceTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCircumFluenceTaskById.HandleId, ConfigCircumFluenceTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CircumFluenceTask rootAsCircumFluenceTask = CircumFluenceTask.GetRootAsCircumFluenceTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CircumFluenceTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCircumFluenceTaskById.HandleId, ConfigCircumFluenceTaskById.LogPair);
			return new CircumFluenceTask?(rootAsCircumFluenceTask);
		}

		// Token: 0x040009F4 RID: 2548
		private const string DB = "db_circumfluence.db";

		// Token: 0x040009F5 RID: 2549
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x040009F6 RID: 2550
		private const string TABLE = "CircumFluenceTask";

		// Token: 0x040009F7 RID: 2551
		private const string COMMAND = "select BinData from `CircumFluenceTask` where Id=?";

		// Token: 0x040009F8 RID: 2552
		private const string KEY_PREFIX = "CircumFluenceTaskById";

		// Token: 0x040009F9 RID: 2553
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009FA RID: 2554
		private static int HandleId;
	}
}
