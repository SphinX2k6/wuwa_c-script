using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B1 RID: 1713
	public class ConfigPhantomGainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002836 RID: 10294 RVA: 0x00140793 File Offset: 0x0013E993
		static ConfigPhantomGainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomGainById.CreateStaticDefaultValue), new Action(ConfigPhantomGainById.ResetStaticDefaultValue));
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x001407B4 File Offset: 0x0013E9B4
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

		// Token: 0x06002838 RID: 10296 RVA: 0x00140833 File Offset: 0x0013EA33
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomGainById.LogPair = null;
			ConfigPhantomGainById.HandleId = 0;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00140841 File Offset: 0x0013EA41
		public static void Init()
		{
			ConfigPhantomGainById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomGainById.HandleId, "db_activitymaptravel.db", "select BinData from `PhantomGain` where Id=?");
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0014085C File Offset: 0x0013EA5C
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

		// Token: 0x04002EBD RID: 11965
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04002EBE RID: 11966
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04002EBF RID: 11967
		private const string TABLE = "PhantomGain";

		// Token: 0x04002EC0 RID: 11968
		private const string COMMAND = "select BinData from `PhantomGain` where Id=?";

		// Token: 0x04002EC1 RID: 11969
		private const string KEY_PREFIX = "PhantomGainById";

		// Token: 0x04002EC2 RID: 11970
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EC3 RID: 11971
		private static int HandleId;
	}
}
