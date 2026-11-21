using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B2 RID: 1714
	public class ConfigPhantomGrowthByGrowthIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600283C RID: 10300 RVA: 0x001409DC File Offset: 0x0013EBDC
		static ConfigPhantomGrowthByGrowthIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomGrowthByGrowthIdAndLevel.CreateStaticDefaultValue), new Action(ConfigPhantomGrowthByGrowthIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x001409FC File Offset: 0x0013EBFC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomGrowthByGrowthIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomGrowthByGrowthIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomGrowth"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomGrowth` where GrowthId=? AND Level=?")
			});
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00140A7B File Offset: 0x0013EC7B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomGrowthByGrowthIdAndLevel.LogPair = null;
			ConfigPhantomGrowthByGrowthIdAndLevel.HandleId = 0;
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00140A89 File Offset: 0x0013EC89
		public static void Init()
		{
			ConfigPhantomGrowthByGrowthIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, "db_phantom.db", "select BinData from `PhantomGrowth` where GrowthId=? AND Level=?");
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00140AA4 File Offset: 0x0013ECA4
		public static PhantomGrowth? GetConfig(int p0GrowthId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, ConfigPhantomGrowthByGrowthIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomGrowthByGrowthIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GrowthId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomGrowth?(PhantomGrowth.GetRootAsPhantomGrowth(configBuffer));
				}
			}
			ConfigPhantomGrowthByGrowthIdAndLevel.LogPair.Clear();
			ConfigPhantomGrowthByGrowthIdAndLevel.LogPair.Add(new ValueTuple<string, object>("GrowthId", p0GrowthId));
			ConfigPhantomGrowthByGrowthIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, 1, p0GrowthId, ConfigPhantomGrowthByGrowthIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, 2, p1Level, ConfigPhantomGrowthByGrowthIdAndLevel.LogPair) || ConfigCommon.Step(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, true, ConfigPhantomGrowthByGrowthIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, ConfigPhantomGrowthByGrowthIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, 0, ConfigPhantomGrowthByGrowthIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, ConfigPhantomGrowthByGrowthIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomGrowth rootAsPhantomGrowth = PhantomGrowth.GetRootAsPhantomGrowth(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomGrowthByGrowthIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GrowthId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, ConfigPhantomGrowthByGrowthIdAndLevel.LogPair);
			return new PhantomGrowth?(rootAsPhantomGrowth);
		}

		// Token: 0x04002EC4 RID: 11972
		private const string DB = "db_phantom.db";

		// Token: 0x04002EC5 RID: 11973
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EC6 RID: 11974
		private const string TABLE = "PhantomGrowth";

		// Token: 0x04002EC7 RID: 11975
		private const string COMMAND = "select BinData from `PhantomGrowth` where GrowthId=? AND Level=?";

		// Token: 0x04002EC8 RID: 11976
		private const string KEY_PREFIX = "PhantomGrowthByGrowthIdAndLevel";

		// Token: 0x04002EC9 RID: 11977
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ECA RID: 11978
		private static int HandleId;
	}
}
