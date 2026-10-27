using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000658 RID: 1624
	public class ConfigPhantomBattleBadgeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002620 RID: 9760 RVA: 0x001313E3 File Offset: 0x0012F5E3
		static ConfigPhantomBattleBadgeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleBadgeById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleBadgeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x00131404 File Offset: 0x0012F604
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

		// Token: 0x06002622 RID: 9762 RVA: 0x00131483 File Offset: 0x0012F683
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleBadgeById.LogPair = null;
			ConfigPhantomBattleBadgeById.HandleId = 0;
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x00131491 File Offset: 0x0012F691
		public static void Init()
		{
			ConfigPhantomBattleBadgeById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleBadgeById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleBadge` where Id=?");
		}

		// Token: 0x06002624 RID: 9764 RVA: 0x001314AC File Offset: 0x0012F6AC
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

		// Token: 0x04002C4E RID: 11342
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C4F RID: 11343
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C50 RID: 11344
		private const string TABLE = "PhantomBattleBadge";

		// Token: 0x04002C51 RID: 11345
		private const string COMMAND = "select BinData from `PhantomBattleBadge` where Id=?";

		// Token: 0x04002C52 RID: 11346
		private const string KEY_PREFIX = "PhantomBattleBadgeById";

		// Token: 0x04002C53 RID: 11347
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C54 RID: 11348
		private static int HandleId;
	}
}
