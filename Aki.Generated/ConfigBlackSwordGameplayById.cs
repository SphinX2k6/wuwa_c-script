using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FE RID: 254
	public class ConfigBlackSwordGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005F5 RID: 1525 RVA: 0x0007B5EF File Offset: 0x000797EF
		static ConfigBlackSwordGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordGameplayById.CreateStaticDefaultValue), new Action(ConfigBlackSwordGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0007B610 File Offset: 0x00079810
		public static void CreateStaticDefaultValue()
		{
			ConfigBlackSwordGameplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBlackSwordGameplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_blackswordchallenge.db"),
				new ValueTuple<string, object>("文件", "h.黑剑挑战.xlsx"),
				new ValueTuple<string, object>("表名", "BlackSwordGameplay"),
				new ValueTuple<string, object>("语句", "select BinData from `BlackSwordGameplay` where Id=?")
			});
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0007B68F File Offset: 0x0007988F
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordGameplayById.LogPair = null;
			ConfigBlackSwordGameplayById.HandleId = 0;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0007B69D File Offset: 0x0007989D
		public static void Init()
		{
			ConfigBlackSwordGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordGameplayById.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordGameplay` where Id=?");
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0007B6B8 File Offset: 0x000798B8
		public static BlackSwordGameplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBlackSwordGameplayById.HandleId, ConfigBlackSwordGameplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackSwordGameplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BlackSwordGameplay?(BlackSwordGameplay.GetRootAsBlackSwordGameplay(configBuffer));
				}
			}
			ConfigBlackSwordGameplayById.LogPair.Clear();
			ConfigBlackSwordGameplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBlackSwordGameplayById.HandleId, 1, p0Id, ConfigBlackSwordGameplayById.LogPair) || ConfigCommon.Step(ConfigBlackSwordGameplayById.HandleId, true, ConfigBlackSwordGameplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBlackSwordGameplayById.HandleId, ConfigBlackSwordGameplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBlackSwordGameplayById.HandleId, 0, ConfigBlackSwordGameplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBlackSwordGameplayById.HandleId, ConfigBlackSwordGameplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BlackSwordGameplay rootAsBlackSwordGameplay = BlackSwordGameplay.GetRootAsBlackSwordGameplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BlackSwordGameplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBlackSwordGameplayById.HandleId, ConfigBlackSwordGameplayById.LogPair);
			return new BlackSwordGameplay?(rootAsBlackSwordGameplay);
		}

		// Token: 0x040006D6 RID: 1750
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x040006D7 RID: 1751
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x040006D8 RID: 1752
		private const string TABLE = "BlackSwordGameplay";

		// Token: 0x040006D9 RID: 1753
		private const string COMMAND = "select BinData from `BlackSwordGameplay` where Id=?";

		// Token: 0x040006DA RID: 1754
		private const string KEY_PREFIX = "BlackSwordGameplayById";

		// Token: 0x040006DB RID: 1755
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006DC RID: 1756
		private static int HandleId;
	}
}
