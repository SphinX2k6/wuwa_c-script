using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200067C RID: 1660
	public class ConfigPhantomBattleMapParamByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060026F8 RID: 9976 RVA: 0x001360D0 File Offset: 0x001342D0
		static ConfigPhantomBattleMapParamByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomBattleMapParamByMapId.CreateStaticDefaultValue), new Action(ConfigPhantomBattleMapParamByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x001360F0 File Offset: 0x001342F0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomBattleMapParamByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantombattle.db"),
				new ValueTuple<string, object>("文件", "s.声骸大作战外围.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomBattleMapParam"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomBattleMapParam` where MapId=?")
			});
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x0013616F File Offset: 0x0013436F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomBattleMapParamByMapId.LogPair = null;
			ConfigPhantomBattleMapParamByMapId.HandleId = 0;
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x0013617D File Offset: 0x0013437D
		public static void Init()
		{
			ConfigPhantomBattleMapParamByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomBattleMapParamByMapId.HandleId, "db_phantombattle.db", "select BinData from `PhantomBattleMapParam` where MapId=?");
		}

		// Token: 0x060026FC RID: 9980 RVA: 0x00136198 File Offset: 0x00134398
		public static PhantomBattleMapParam? GetConfig(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomBattleMapParamByMapId.HandleId, ConfigPhantomBattleMapParamByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMapParamByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomBattleMapParam?(PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(configBuffer));
				}
			}
			ConfigPhantomBattleMapParamByMapId.LogPair.Clear();
			ConfigPhantomBattleMapParamByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigPhantomBattleMapParamByMapId.HandleId, 1, p0MapId, ConfigPhantomBattleMapParamByMapId.LogPair) || ConfigCommon.Step(ConfigPhantomBattleMapParamByMapId.HandleId, true, ConfigPhantomBattleMapParamByMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMapParamByMapId.HandleId, ConfigPhantomBattleMapParamByMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomBattleMapParamByMapId.HandleId, 0, ConfigPhantomBattleMapParamByMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomBattleMapParamByMapId.HandleId, ConfigPhantomBattleMapParamByMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomBattleMapParam rootAsPhantomBattleMapParam = PhantomBattleMapParam.GetRootAsPhantomBattleMapParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomBattleMapParamByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomBattleMapParamByMapId.HandleId, ConfigPhantomBattleMapParamByMapId.LogPair);
			return new PhantomBattleMapParam?(rootAsPhantomBattleMapParam);
		}

		// Token: 0x04002D4A RID: 11594
		private const string DB = "db_phantombattle.db";

		// Token: 0x04002D4B RID: 11595
		private const string FILE = "s.声骸大作战外围.xlsx";

		// Token: 0x04002D4C RID: 11596
		private const string TABLE = "PhantomBattleMapParam";

		// Token: 0x04002D4D RID: 11597
		private const string COMMAND = "select BinData from `PhantomBattleMapParam` where MapId=?";

		// Token: 0x04002D4E RID: 11598
		private const string KEY_PREFIX = "PhantomBattleMapParamByMapId";

		// Token: 0x04002D4F RID: 11599
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002D50 RID: 11600
		private static int HandleId;
	}
}
