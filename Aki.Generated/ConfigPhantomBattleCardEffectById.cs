using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000661 RID: 1633
	public class ConfigPhantomBattleCardEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002656 RID: 9814 RVA: 0x001326E4 File Offset: 0x001308E4
		static ConfigPhantomBattleCardEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleCardEffectById.CreateStaticDefaultValue), new Action(ConfigPhantomBattleCardEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00132704 File Offset: 0x00130904
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

		// Token: 0x06002658 RID: 9816 RVA: 0x00132783 File Offset: 0x00130983
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleCardEffectById.LogPair = null;
			ConfigPhantomBattleCardEffectById.HandleId = 0;
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00132791 File Offset: 0x00130991
		public static void Init()
		{
			ConfigPhantomBattleCardEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleCardEffectById.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleCardEffect` where Id=?");
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x001327AC File Offset: 0x001309AC
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

		// Token: 0x04002C8D RID: 11405
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002C8E RID: 11406
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002C8F RID: 11407
		private const string TABLE = "PhantomBattleCardEffect";

		// Token: 0x04002C90 RID: 11408
		private const string COMMAND = "select BinData from `PhantomBattleCardEffect` where Id=?";

		// Token: 0x04002C91 RID: 11409
		private const string KEY_PREFIX = "PhantomBattleCardEffectById";

		// Token: 0x04002C92 RID: 11410
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C93 RID: 11411
		private static int HandleId;
	}
}
