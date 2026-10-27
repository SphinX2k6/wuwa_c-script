using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200069A RID: 1690
	public class ConfigPhantomGrowthByGrowthIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027AC RID: 10156 RVA: 0x00139F60 File Offset: 0x00138160
		static ConfigPhantomGrowthByGrowthIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomGrowthByGrowthIdAndLevel.CreateStaticDefaultValue), new Action(ConfigPhantomGrowthByGrowthIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x00139F80 File Offset: 0x00138180
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

		// Token: 0x060027AE RID: 10158 RVA: 0x00139FFF File Offset: 0x001381FF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomGrowthByGrowthIdAndLevel.LogPair = null;
			ConfigPhantomGrowthByGrowthIdAndLevel.HandleId = 0;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x0013A00D File Offset: 0x0013820D
		public static void Init()
		{
			ConfigPhantomGrowthByGrowthIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomGrowthByGrowthIdAndLevel.HandleId, "db_phantom.db", "select BinData from `PhantomGrowth` where GrowthId=? AND Level=?");
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x0013A028 File Offset: 0x00138228
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

		// Token: 0x04002E1C RID: 11804
		private const string DB = "db_phantom.db";

		// Token: 0x04002E1D RID: 11805
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E1E RID: 11806
		private const string TABLE = "PhantomGrowth";

		// Token: 0x04002E1F RID: 11807
		private const string COMMAND = "select BinData from `PhantomGrowth` where GrowthId=? AND Level=?";

		// Token: 0x04002E20 RID: 11808
		private const string KEY_PREFIX = "PhantomGrowthByGrowthIdAndLevel";

		// Token: 0x04002E21 RID: 11809
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E22 RID: 11810
		private static int HandleId;
	}
}
