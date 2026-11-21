using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000670 RID: 1648
	public class ConfigPhantomBattleBadgeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026B0 RID: 9904 RVA: 0x00137E5F File Offset: 0x0013605F
		static ConfigPhantomBattleBadgeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeById.ResetStaticDefaultValue));
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00137E80 File Offset: 0x00136080
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleBadgeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleBadge"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleBadge` where Id=?")
			});
		}

		// Token: 0x060026B2 RID: 9906 RVA: 0x00137EFF File Offset: 0x001360FF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeById.LogPair = null;
			ConfigPhantomBattleBadgeById.HandleId = 0;
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00137F0D File Offset: 0x0013610D
		public static void Init()
		{
			ConfigPhantomBattleBadgeById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadge` where Id=?");
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00137F28 File Offset: 0x00136128
		public static PhantomBattleBadge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleBadgeById.HandleId, ConfigPhantomBattleBadgeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleBadge?(PhantomBattleBadge.GetRootAsPhantomBattleBadge(configBuffer));
				}
			}
			ConfigPhantomBattleBadgeById.LogPair.Clear();
			ConfigPhantomBattleBadgeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleBadgeById.HandleId, 1, p0Id, ConfigPhantomBattleBadgeById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleBadgeById.HandleId, true, ConfigPhantomBattleBadgeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleBadgeById.HandleId, ConfigPhantomBattleBadgeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleBadgeById.HandleId, 0, ConfigPhantomBattleBadgeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleBadgeById.HandleId, ConfigPhantomBattleBadgeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleBadge rootAsPhantomBattleBadge = PhantomBattleBadge.GetRootAsPhantomBattleBadge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleBadgeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleBadgeById.HandleId, ConfigPhantomBattleBadgeById.LogPair);
			return new PhantomBattleBadge?(rootAsPhantomBattleBadge);
		}

		// Token: 0x04002CF6 RID: 11510
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002CF7 RID: 11511
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002CF8 RID: 11512
		private const string TABLE = "PhantomBattleBadge";

		// Token: 0x04002CF9 RID: 11513
		private const string COMMAND = "select BinData from `PhantomBattleBadge` where Id=?";

		// Token: 0x04002CFA RID: 11514
		private const string KEY_PREFIX = "PhantomBattleBadgeById";

		// Token: 0x04002CFB RID: 11515
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CFC RID: 11516
		private static int HandleId;
	}
}
