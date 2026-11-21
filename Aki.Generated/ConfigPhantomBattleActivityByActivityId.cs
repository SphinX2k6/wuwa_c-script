using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200066C RID: 1644
	public class ConfigPhantomBattleActivityByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002698 RID: 9880 RVA: 0x001375BC File Offset: 0x001357BC
		static ConfigPhantomBattleActivityByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleActivityByActivityId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleActivityByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x001375DC File Offset: 0x001357DC
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

		// Token: 0x0600269A RID: 9882 RVA: 0x0013765B File Offset: 0x0013585B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleActivityByActivityId.LogPair = null;
			ConfigPhantomBattleActivityByActivityId.HandleId = 0;
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00137669 File Offset: 0x00135869
		public static void Init()
		{
			ConfigPhantomBattleActivityByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleActivityByActivityId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleActivity` where ActivityId=?");
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00137684 File Offset: 0x00135884
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

		// Token: 0x04002CDA RID: 11482
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CDB RID: 11483
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CDC RID: 11484
		private const string TABLE = "PhantomBattleActivity";

		// Token: 0x04002CDD RID: 11485
		private const string COMMAND = "select BinData from `PhantomBattleActivity` where ActivityId=?";

		// Token: 0x04002CDE RID: 11486
		private const string KEY_PREFIX = "PhantomBattleActivityByActivityId";

		// Token: 0x04002CDF RID: 11487
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CE0 RID: 11488
		private static int HandleId;
	}
}
