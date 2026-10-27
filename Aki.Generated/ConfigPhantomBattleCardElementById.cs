using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000662 RID: 1634
	public class ConfigPhantomBattleCardElementById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600265C RID: 9820 RVA: 0x0013292C File Offset: 0x00130B2C
		static ConfigPhantomBattleCardElementById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardElementById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardElementById.ResetStaticDefaultValue));
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x0013294C File Offset: 0x00130B4C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardElementById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardElementById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardElement"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardElement` where Id=?")
			});
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x001329CB File Offset: 0x00130BCB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardElementById.LogPair = null;
			ConfigPhantomBattleCardElementById.HandleId = 0;
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x001329D9 File Offset: 0x00130BD9
		public static void Init()
		{
			ConfigPhantomBattleCardElementById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardElementById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardElement` where Id=?");
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x001329F4 File Offset: 0x00130BF4
		public static PhantomBattleCardElement? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardElementById.HandleId, ConfigPhantomBattleCardElementById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardElementById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCardElement?(PhantomBattleCardElement.GetRootAsPhantomBattleCardElement(configBuffer));
				}
			}
			ConfigPhantomBattleCardElementById.LogPair.Clear();
			ConfigPhantomBattleCardElementById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardElementById.HandleId, 1, p0Id, ConfigPhantomBattleCardElementById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardElementById.HandleId, true, ConfigPhantomBattleCardElementById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardElementById.HandleId, ConfigPhantomBattleCardElementById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardElementById.HandleId, 0, ConfigPhantomBattleCardElementById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardElementById.HandleId, ConfigPhantomBattleCardElementById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCardElement rootAsPhantomBattleCardElement = PhantomBattleCardElement.GetRootAsPhantomBattleCardElement(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardElementById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardElementById.HandleId, ConfigPhantomBattleCardElementById.LogPair);
			return new PhantomBattleCardElement?(rootAsPhantomBattleCardElement);
		}

		// Token: 0x04002C94 RID: 11412
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C95 RID: 11413
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C96 RID: 11414
		private const string TABLE = "PhantomBattleCardElement";

		// Token: 0x04002C97 RID: 11415
		private const string COMMAND = "select BinData from `PhantomBattleCardElement` where Id=?";

		// Token: 0x04002C98 RID: 11416
		private const string KEY_PREFIX = "PhantomBattleCardElementById";

		// Token: 0x04002C99 RID: 11417
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C9A RID: 11418
		private static int HandleId;
	}
}
