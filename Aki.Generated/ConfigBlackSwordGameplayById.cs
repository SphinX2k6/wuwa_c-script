using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200010D RID: 269
	public class ConfigBlackSwordGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x00080F53 File Offset: 0x0007F153
		static ConfigBlackSwordGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBlackSwordGameplayById.CreateStaticDefaultValue), new Action(ConfigBlackSwordGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00080F74 File Offset: 0x0007F174
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

		// Token: 0x06000651 RID: 1617 RVA: 0x00080FF3 File Offset: 0x0007F1F3
		public static void ResetStaticDefaultValue()
		{
			ConfigBlackSwordGameplayById.LogPair = null;
			ConfigBlackSwordGameplayById.HandleId = 0;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00081001 File Offset: 0x0007F201
		public static void Init()
		{
			ConfigBlackSwordGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigBlackSwordGameplayById.HandleId, "db_blackswordchallenge.db", "select BinData from `BlackSwordGameplay` where Id=?");
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0008101C File Offset: 0x0007F21C
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

		// Token: 0x0400073F RID: 1855
		private const string DB = "db_blackswordchallenge.db";

		// Token: 0x04000740 RID: 1856
		private const string FILE = "h.黑剑挑战.xlsx";

		// Token: 0x04000741 RID: 1857
		private const string TABLE = "BlackSwordGameplay";

		// Token: 0x04000742 RID: 1858
		private const string COMMAND = "select BinData from `BlackSwordGameplay` where Id=?";

		// Token: 0x04000743 RID: 1859
		private const string KEY_PREFIX = "BlackSwordGameplayById";

		// Token: 0x04000744 RID: 1860
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000745 RID: 1861
		private static int HandleId;
	}
}
