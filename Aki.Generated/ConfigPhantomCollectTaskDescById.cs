using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A4 RID: 1700
	public class ConfigPhantomCollectTaskDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027E8 RID: 10216 RVA: 0x0013ED80 File Offset: 0x0013CF80
		static ConfigPhantomCollectTaskDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomCollectTaskDescById.CreateStaticDefaultValue), new Action(ConfigPhantomCollectTaskDescById.ResetStaticDefaultValue));
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x0013EDA0 File Offset: 0x0013CFA0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomCollectTaskDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomCollectTaskDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantomcollectactivity.db"),
				new ValueTuple<string, object>("文件", "s.声骸收集活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomCollectTaskDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomCollectTaskDesc` where Id=?")
			});
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x0013EE1F File Offset: 0x0013D01F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomCollectTaskDescById.LogPair = null;
			ConfigPhantomCollectTaskDescById.HandleId = 0;
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x0013EE2D File Offset: 0x0013D02D
		public static void Init()
		{
			ConfigPhantomCollectTaskDescById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomCollectTaskDescById.HandleId, "db_phantomcollectactivity.db", "select BinData from `PhantomCollectTaskDesc` where Id=?");
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x0013EE48 File Offset: 0x0013D048
		public static PhantomCollectTaskDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomCollectTaskDescById.HandleId, ConfigPhantomCollectTaskDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCollectTaskDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomCollectTaskDesc?(PhantomCollectTaskDesc.GetRootAsPhantomCollectTaskDesc(configBuffer));
				}
			}
			ConfigPhantomCollectTaskDescById.LogPair.Clear();
			ConfigPhantomCollectTaskDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomCollectTaskDescById.HandleId, 1, p0Id, ConfigPhantomCollectTaskDescById.LogPair) || ConfigCommon.Step(ConfigPhantomCollectTaskDescById.HandleId, true, ConfigPhantomCollectTaskDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomCollectTaskDescById.HandleId, ConfigPhantomCollectTaskDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomCollectTaskDescById.HandleId, 0, ConfigPhantomCollectTaskDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomCollectTaskDescById.HandleId, ConfigPhantomCollectTaskDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomCollectTaskDesc rootAsPhantomCollectTaskDesc = PhantomCollectTaskDesc.GetRootAsPhantomCollectTaskDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomCollectTaskDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomCollectTaskDescById.HandleId, ConfigPhantomCollectTaskDescById.LogPair);
			return new PhantomCollectTaskDesc?(rootAsPhantomCollectTaskDesc);
		}

		// Token: 0x04002E62 RID: 11874
		private const string DB = "db_phantomcollectactivity.db";

		// Token: 0x04002E63 RID: 11875
		private const string FILE = "s.声骸收集活动.xlsx";

		// Token: 0x04002E64 RID: 11876
		private const string TABLE = "PhantomCollectTaskDesc";

		// Token: 0x04002E65 RID: 11877
		private const string COMMAND = "select BinData from `PhantomCollectTaskDesc` where Id=?";

		// Token: 0x04002E66 RID: 11878
		private const string KEY_PREFIX = "PhantomCollectTaskDescById";

		// Token: 0x04002E67 RID: 11879
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E68 RID: 11880
		private static int HandleId;
	}
}
