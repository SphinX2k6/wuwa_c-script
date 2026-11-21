using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000679 RID: 1657
	public class ConfigPhantomBattleCardEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026E6 RID: 9958 RVA: 0x00139160 File Offset: 0x00137360
		static ConfigPhantomBattleCardEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardEffectById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00139180 File Offset: 0x00137380
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleCardEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleCardEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleCardEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleCardEffect` where Id=?")
			});
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x001391FF File Offset: 0x001373FF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardEffectById.LogPair = null;
			ConfigPhantomBattleCardEffectById.HandleId = 0;
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0013920D File Offset: 0x0013740D
		public static void Init()
		{
			ConfigPhantomBattleCardEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardEffectById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardEffect` where Id=?");
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00139228 File Offset: 0x00137428
		public static PhantomBattleCardEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleCardEffectById.HandleId, ConfigPhantomBattleCardEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleCardEffect?(PhantomBattleCardEffect.GetRootAsPhantomBattleCardEffect(configBuffer));
				}
			}
			ConfigPhantomBattleCardEffectById.LogPair.Clear();
			ConfigPhantomBattleCardEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleCardEffectById.HandleId, 1, p0Id, ConfigPhantomBattleCardEffectById.LogPair) || ConfigCommon.Step(ConfigPhantomBattleCardEffectById.HandleId, true, ConfigPhantomBattleCardEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardEffectById.HandleId, ConfigPhantomBattleCardEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleCardEffectById.HandleId, 0, ConfigPhantomBattleCardEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleCardEffectById.HandleId, ConfigPhantomBattleCardEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleCardEffect rootAsPhantomBattleCardEffect = PhantomBattleCardEffect.GetRootAsPhantomBattleCardEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleCardEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleCardEffectById.HandleId, ConfigPhantomBattleCardEffectById.LogPair);
			return new PhantomBattleCardEffect?(rootAsPhantomBattleCardEffect);
		}

		// Token: 0x04002D35 RID: 11573
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D36 RID: 11574
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D37 RID: 11575
		private const string TABLE = "PhantomBattleCardEffect";

		// Token: 0x04002D38 RID: 11576
		private const string COMMAND = "select BinData from `PhantomBattleCardEffect` where Id=?";

		// Token: 0x04002D39 RID: 11577
		private const string KEY_PREFIX = "PhantomBattleCardEffectById";

		// Token: 0x04002D3A RID: 11578
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D3B RID: 11579
		private static int HandleId;
	}
}
