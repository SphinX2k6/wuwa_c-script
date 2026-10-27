using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000699 RID: 1689
	public class ConfigPhantomGainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027A6 RID: 10150 RVA: 0x00139D17 File Offset: 0x00137F17
		static ConfigPhantomGainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomGainById.CreateStaticDefaultValue), new Action(ConfigPhantomGainById.ResetStaticDefaultValue));
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00139D38 File Offset: 0x00137F38
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomGainById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomGainById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomGain"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomGain` where Id=?")
			});
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00139DB7 File Offset: 0x00137FB7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomGainById.LogPair = null;
			ConfigPhantomGainById.HandleId = 0;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00139DC5 File Offset: 0x00137FC5
		public static void Init()
		{
			ConfigPhantomGainById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomGainById.HandleId, "db_activitymaptravel.db", "select BinData from `PhantomGain` where Id=?");
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00139DE0 File Offset: 0x00137FE0
		public static PhantomGain? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomGainById.HandleId, ConfigPhantomGainById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomGainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomGain?(PhantomGain.GetRootAsPhantomGain(configBuffer));
				}
			}
			ConfigPhantomGainById.LogPair.Clear();
			ConfigPhantomGainById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomGainById.HandleId, 1, p0Id, ConfigPhantomGainById.LogPair) || ConfigCommon.Step(ConfigPhantomGainById.HandleId, true, ConfigPhantomGainById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomGainById.HandleId, ConfigPhantomGainById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomGainById.HandleId, 0, ConfigPhantomGainById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomGainById.HandleId, ConfigPhantomGainById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomGain rootAsPhantomGain = PhantomGain.GetRootAsPhantomGain(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomGainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomGainById.HandleId, ConfigPhantomGainById.LogPair);
			return new PhantomGain?(rootAsPhantomGain);
		}

		// Token: 0x04002E15 RID: 11797
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04002E16 RID: 11798
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04002E17 RID: 11799
		private const string TABLE = "PhantomGain";

		// Token: 0x04002E18 RID: 11800
		private const string COMMAND = "select BinData from `PhantomGain` where Id=?";

		// Token: 0x04002E19 RID: 11801
		private const string KEY_PREFIX = "PhantomGainById";

		// Token: 0x04002E1A RID: 11802
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E1B RID: 11803
		private static int HandleId;
	}
}
