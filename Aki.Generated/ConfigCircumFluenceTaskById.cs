using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000180 RID: 384
	public class ConfigCircumFluenceTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x0008FF2F File Offset: 0x0008E12F
		static ConfigCircumFluenceTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCircumFluenceTaskById.CreateStaticDefaultValue), new Action(ConfigCircumFluenceTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0008FF50 File Offset: 0x0008E150
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

		// Token: 0x06000903 RID: 2307 RVA: 0x0008FFCF File Offset: 0x0008E1CF
		public static void ResetStaticDefaultValue()
		{
			ConfigCircumFluenceTaskById.LogPair = null;
			ConfigCircumFluenceTaskById.HandleId = 0;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0008FFDD File Offset: 0x0008E1DD
		public static void Init()
		{
			ConfigCircumFluenceTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigCircumFluenceTaskById.HandleId, "db_circumfluence.db", "select BinData from `CircumFluenceTask` where Id=?");
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0008FFF8 File Offset: 0x0008E1F8
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

		// Token: 0x04000A64 RID: 2660
		private const string DB = "db_circumfluence.db";

		// Token: 0x04000A65 RID: 2661
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x04000A66 RID: 2662
		private const string TABLE = "CircumFluenceTask";

		// Token: 0x04000A67 RID: 2663
		private const string COMMAND = "select BinData from `CircumFluenceTask` where Id=?";

		// Token: 0x04000A68 RID: 2664
		private const string KEY_PREFIX = "CircumFluenceTaskById";

		// Token: 0x04000A69 RID: 2665
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A6A RID: 2666
		private static int HandleId;
	}
}
