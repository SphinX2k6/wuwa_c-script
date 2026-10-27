using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000654 RID: 1620
	public class ConfigPhantomBattleActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002608 RID: 9736 RVA: 0x00130B40 File Offset: 0x0012ED40
		static ConfigPhantomBattleActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00130B60 File Offset: 0x0012ED60
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleActivityByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleActivityByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleActivity` where ActivityId=?")
			});
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00130BDF File Offset: 0x0012EDDF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleActivityByActivityId.LogPair = null;
			ConfigPhantomBattleActivityByActivityId.HandleId = 0;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00130BED File Offset: 0x0012EDED
		public static void Init()
		{
			ConfigPhantomBattleActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleActivityByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleActivity` where ActivityId=?");
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x00130C08 File Offset: 0x0012EE08
		public static PhantomBattleActivity? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleActivityByActivityId.HandleId, ConfigPhantomBattleActivityByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleActivity?(PhantomBattleActivity.GetRootAsPhantomBattleActivity(configBuffer));
				}
			}
			ConfigPhantomBattleActivityByActivityId.LogPair.Clear();
			ConfigPhantomBattleActivityByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleActivityByActivityId.HandleId, 1, p0ActivityId, ConfigPhantomBattleActivityByActivityId.LogPair) || ConfigCommon.Step(ConfigPhantomBattleActivityByActivityId.HandleId, true, ConfigPhantomBattleActivityByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleActivityByActivityId.HandleId, ConfigPhantomBattleActivityByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleActivityByActivityId.HandleId, 0, ConfigPhantomBattleActivityByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleActivityByActivityId.HandleId, ConfigPhantomBattleActivityByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleActivity rootAsPhantomBattleActivity = PhantomBattleActivity.GetRootAsPhantomBattleActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleActivityByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleActivityByActivityId.HandleId, ConfigPhantomBattleActivityByActivityId.LogPair);
			return new PhantomBattleActivity?(rootAsPhantomBattleActivity);
		}

		// Token: 0x04002C32 RID: 11314
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C33 RID: 11315
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C34 RID: 11316
		private const string TABLE = "PhantomBattleActivity";

		// Token: 0x04002C35 RID: 11317
		private const string COMMAND = "select BinData from `PhantomBattleActivity` where ActivityId=?";

		// Token: 0x04002C36 RID: 11318
		private const string KEY_PREFIX = "PhantomBattleActivityByActivityId";

		// Token: 0x04002C37 RID: 11319
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C38 RID: 11320
		private static int HandleId;
	}
}
