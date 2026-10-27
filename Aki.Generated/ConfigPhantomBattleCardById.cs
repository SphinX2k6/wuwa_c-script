using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000660 RID: 1632
	public class ConfigPhantomBattleCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002650 RID: 9808 RVA: 0x0013249B File Offset: 0x0013069B
		static ConfigPhantomBattleCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x001324BC File Offset: 0x001306BC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCard"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCard` where Id=?")
			});
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x0013253B File Offset: 0x0013073B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardById.LogPair = null;
			ConfigPhantomBattleCardById.HandleId = 0;
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00132549 File Offset: 0x00130749
		public static void Init()
		{
			ConfigPhantomBattleCardById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCard` where Id=?");
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00132564 File Offset: 0x00130764
		public static PhantomBattleCard? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardById.HandleId, ConfigPhantomBattleCardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCard?(PhantomBattleCard.GetRootAsPhantomBattleCard(configBuffer));
				}
			}
			ConfigPhantomBattleCardById.LogPair.Clear();
			ConfigPhantomBattleCardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardById.HandleId, 1, p0Id, ConfigPhantomBattleCardById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardById.HandleId, true, ConfigPhantomBattleCardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardById.HandleId, ConfigPhantomBattleCardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardById.HandleId, 0, ConfigPhantomBattleCardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardById.HandleId, ConfigPhantomBattleCardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCard rootAsPhantomBattleCard = PhantomBattleCard.GetRootAsPhantomBattleCard(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardById.HandleId, ConfigPhantomBattleCardById.LogPair);
			return new PhantomBattleCard?(rootAsPhantomBattleCard);
		}

		// Token: 0x04002C86 RID: 11398
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C87 RID: 11399
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C88 RID: 11400
		private const string TABLE = "PhantomBattleCard";

		// Token: 0x04002C89 RID: 11401
		private const string COMMAND = "select BinData from `PhantomBattleCard` where Id=?";

		// Token: 0x04002C8A RID: 11402
		private const string KEY_PREFIX = "PhantomBattleCardById";

		// Token: 0x04002C8B RID: 11403
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C8C RID: 11404
		private static int HandleId;
	}
}
