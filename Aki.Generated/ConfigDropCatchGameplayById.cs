using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000239 RID: 569
	public class ConfigDropCatchGameplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D5A RID: 3418 RVA: 0x000A50A3 File Offset: 0x000A32A3
		static ConfigDropCatchGameplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchGameplayById.CreateStaticDefaultValue), new Action(ConfigDropCatchGameplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x000A50C4 File Offset: 0x000A32C4
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchGameplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchGameplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchGameplay"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchGameplay` where Id=?")
			});
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x000A5143 File Offset: 0x000A3343
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchGameplayById.LogPair = null;
			ConfigDropCatchGameplayById.HandleId = 0;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x000A5151 File Offset: 0x000A3351
		public static void Init()
		{
			ConfigDropCatchGameplayById.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchGameplayById.HandleId, "db_dropcatch.db", "select BinData from `DropCatchGameplay` where Id=?");
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x000A516C File Offset: 0x000A336C
		public static DropCatchGameplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchGameplayById.HandleId, ConfigDropCatchGameplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchGameplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DropCatchGameplay?(DropCatchGameplay.GetRootAsDropCatchGameplay(configBuffer));
				}
			}
			ConfigDropCatchGameplayById.LogPair.Clear();
			ConfigDropCatchGameplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDropCatchGameplayById.HandleId, 1, p0Id, ConfigDropCatchGameplayById.LogPair) || ConfigCommon.Step(ConfigDropCatchGameplayById.HandleId, true, ConfigDropCatchGameplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDropCatchGameplayById.HandleId, ConfigDropCatchGameplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchGameplayById.HandleId, 0, ConfigDropCatchGameplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDropCatchGameplayById.HandleId, ConfigDropCatchGameplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DropCatchGameplay rootAsDropCatchGameplay = DropCatchGameplay.GetRootAsDropCatchGameplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DropCatchGameplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDropCatchGameplayById.HandleId, ConfigDropCatchGameplayById.LogPair);
			return new DropCatchGameplay?(rootAsDropCatchGameplay);
		}

		// Token: 0x04000F73 RID: 3955
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F74 RID: 3956
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F75 RID: 3957
		private const string TABLE = "DropCatchGameplay";

		// Token: 0x04000F76 RID: 3958
		private const string COMMAND = "select BinData from `DropCatchGameplay` where Id=?";

		// Token: 0x04000F77 RID: 3959
		private const string KEY_PREFIX = "DropCatchGameplayById";

		// Token: 0x04000F78 RID: 3960
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F79 RID: 3961
		private static int HandleId;
	}
}
