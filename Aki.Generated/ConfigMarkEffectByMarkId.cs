using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000540 RID: 1344
	public class ConfigMarkEffectByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F8B RID: 8075 RVA: 0x0010F1A4 File Offset: 0x0010D3A4
		static ConfigMarkEffectByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMarkEffectByMarkId.CreateStaticDefaultValue), new Action(ConfigMarkEffectByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0010F1C4 File Offset: 0x0010D3C4
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

		// Token: 0x06001F8D RID: 8077 RVA: 0x0010F243 File Offset: 0x0010D443
		public static void ResetStaticDefaultValue()
		{
			ConfigMarkEffectByMarkId.LogPair = null;
			ConfigMarkEffectByMarkId.HandleId = 0;
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0010F251 File Offset: 0x0010D451
		public static void Init()
		{
			ConfigMarkEffectByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigMarkEffectByMarkId.HandleId, "db_map_mark.db", "select BinData from `MarkEffect` where MarkId=?");
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0010F26C File Offset: 0x0010D46C
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

		// Token: 0x040024A4 RID: 9380
		private const string DB = "db_map_mark.db";

		// Token: 0x040024A5 RID: 9381
		private const string FILE = "d.地图标记特效.xlsx";

		// Token: 0x040024A6 RID: 9382
		private const string TABLE = "MarkEffect";

		// Token: 0x040024A7 RID: 9383
		private const string COMMAND = "select BinData from `MarkEffect` where MarkId=?";

		// Token: 0x040024A8 RID: 9384
		private const string KEY_PREFIX = "MarkEffectByMarkId";

		// Token: 0x040024A9 RID: 9385
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024AA RID: 9386
		private static int HandleId;
	}
}
