using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A3 RID: 1699
	public class ConfigPhantomCollectActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027E2 RID: 10210 RVA: 0x0013EB38 File Offset: 0x0013CD38
		static ConfigPhantomCollectActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomCollectActivityById.CreateStaticDefaultValue), new Action(ConfigPhantomCollectActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x0013EB58 File Offset: 0x0013CD58
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomCollectActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomCollectActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantomcollectactivity.db"),
				new ValueTuple<string, object>("文件", "s.声骸收集活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomCollectActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomCollectActivity` where Id=?")
			});
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x0013EBD7 File Offset: 0x0013CDD7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomCollectActivityById.LogPair = null;
			ConfigPhantomCollectActivityById.HandleId = 0;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x0013EBE5 File Offset: 0x0013CDE5
		public static void Init()
		{
			ConfigPhantomCollectActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomCollectActivityById.HandleId, "db_phantomcollectactivity.db", "select BinData from `PhantomCollectActivity` where Id=?");
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x0013EC00 File Offset: 0x0013CE00
		public static PhantomCollectActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomCollectActivityById.HandleId, ConfigPhantomCollectActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCollectActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomCollectActivity?(PhantomCollectActivity.GetRootAsPhantomCollectActivity(configBuffer));
				}
			}
			ConfigPhantomCollectActivityById.LogPair.Clear();
			ConfigPhantomCollectActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomCollectActivityById.HandleId, 1, p0Id, ConfigPhantomCollectActivityById.LogPair) || ConfigCommon.Step(ConfigPhantomCollectActivityById.HandleId, true, ConfigPhantomCollectActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomCollectActivityById.HandleId, ConfigPhantomCollectActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomCollectActivityById.HandleId, 0, ConfigPhantomCollectActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomCollectActivityById.HandleId, ConfigPhantomCollectActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomCollectActivity rootAsPhantomCollectActivity = PhantomCollectActivity.GetRootAsPhantomCollectActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCollectActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomCollectActivityById.HandleId, ConfigPhantomCollectActivityById.LogPair);
			return new PhantomCollectActivity?(rootAsPhantomCollectActivity);
		}

		// Token: 0x04002E5B RID: 11867
		private const string DB = "db_phantomcollectactivity.db";

		// Token: 0x04002E5C RID: 11868
		private const string FILE = "s.声骸收集活动.xlsx";

		// Token: 0x04002E5D RID: 11869
		private const string TABLE = "PhantomCollectActivity";

		// Token: 0x04002E5E RID: 11870
		private const string COMMAND = "select BinData from `PhantomCollectActivity` where Id=?";

		// Token: 0x04002E5F RID: 11871
		private const string KEY_PREFIX = "PhantomCollectActivityById";

		// Token: 0x04002E60 RID: 11872
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E61 RID: 11873
		private static int HandleId;
	}
}
