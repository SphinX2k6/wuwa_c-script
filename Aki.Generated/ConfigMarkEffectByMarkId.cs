using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052A RID: 1322
	public class ConfigMarkEffectByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F07 RID: 7943 RVA: 0x00108A50 File Offset: 0x00106C50
		static ConfigMarkEffectByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMarkEffectByMarkId.CreateStaticDefaultValue), new Action(ConfigMarkEffectByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x00108A70 File Offset: 0x00106C70
		public static void CreateStaticDefaultValue()
		{
			ConfigMarkEffectByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMarkEffectByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记特效.xlsx"),
				new ValueTuple<string, object>("表名", "MarkEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `MarkEffect` where MarkId=?")
			});
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x00108AEF File Offset: 0x00106CEF
		public static void ResetStaticDefaultValue()
		{
			ConfigMarkEffectByMarkId.LogPair = null;
			ConfigMarkEffectByMarkId.HandleId = 0;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x00108AFD File Offset: 0x00106CFD
		public static void Init()
		{
			ConfigMarkEffectByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigMarkEffectByMarkId.HandleId, "db_map_mark.db", "select BinData from `MarkEffect` where MarkId=?");
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x00108B18 File Offset: 0x00106D18
		public static MarkEffect? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMarkEffectByMarkId.HandleId, ConfigMarkEffectByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MarkEffectByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MarkEffect?(MarkEffect.GetRootAsMarkEffect(configBuffer));
				}
			}
			ConfigMarkEffectByMarkId.LogPair.Clear();
			ConfigMarkEffectByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigMarkEffectByMarkId.HandleId, 1, p0MarkId, ConfigMarkEffectByMarkId.LogPair) || ConfigCommon.Step(ConfigMarkEffectByMarkId.HandleId, true, ConfigMarkEffectByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMarkEffectByMarkId.HandleId, ConfigMarkEffectByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMarkEffectByMarkId.HandleId, 0, ConfigMarkEffectByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMarkEffectByMarkId.HandleId, ConfigMarkEffectByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MarkEffect rootAsMarkEffect = MarkEffect.GetRootAsMarkEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MarkEffectByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMarkEffectByMarkId.HandleId, ConfigMarkEffectByMarkId.LogPair);
			return new MarkEffect?(rootAsMarkEffect);
		}

		// Token: 0x0400240A RID: 9226
		private const string DB = "db_map_mark.db";

		// Token: 0x0400240B RID: 9227
		private const string FILE = "d.地图标记特效.xlsx";

		// Token: 0x0400240C RID: 9228
		private const string TABLE = "MarkEffect";

		// Token: 0x0400240D RID: 9229
		private const string COMMAND = "select BinData from `MarkEffect` where MarkId=?";

		// Token: 0x0400240E RID: 9230
		private const string KEY_PREFIX = "MarkEffectByMarkId";

		// Token: 0x0400240F RID: 9231
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002410 RID: 9232
		private static int HandleId;
	}
}
