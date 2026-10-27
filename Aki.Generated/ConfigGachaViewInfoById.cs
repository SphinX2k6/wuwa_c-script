using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000376 RID: 886
	public class ConfigGachaViewInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014CA RID: 5322 RVA: 0x000CF1D8 File Offset: 0x000CD3D8
		static ConfigGachaViewInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaViewInfoById.CreateStaticDefaultValue), new Action(ConfigGachaViewInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000CF1F8 File Offset: 0x000CD3F8
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaViewInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaViewInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaViewInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaViewInfo` where Id=?")
			});
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x000CF277 File Offset: 0x000CD477
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaViewInfoById.LogPair = null;
			ConfigGachaViewInfoById.HandleId = 0;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x000CF285 File Offset: 0x000CD485
		public static void Init()
		{
			ConfigGachaViewInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaViewInfoById.HandleId, "db_gacha.db", "select BinData from `GachaViewInfo` where Id=?");
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000CF2A0 File Offset: 0x000CD4A0
		public static GachaViewInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaViewInfoById.HandleId, ConfigGachaViewInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaViewInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaViewInfo?(GachaViewInfo.GetRootAsGachaViewInfo(configBuffer));
				}
			}
			ConfigGachaViewInfoById.LogPair.Clear();
			ConfigGachaViewInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaViewInfoById.HandleId, 1, p0Id, ConfigGachaViewInfoById.LogPair) || ConfigCommon.Step(ConfigGachaViewInfoById.HandleId, true, ConfigGachaViewInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaViewInfoById.HandleId, ConfigGachaViewInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaViewInfoById.HandleId, 0, ConfigGachaViewInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaViewInfoById.HandleId, ConfigGachaViewInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaViewInfo rootAsGachaViewInfo = GachaViewInfo.GetRootAsGachaViewInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaViewInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaViewInfoById.HandleId, ConfigGachaViewInfoById.LogPair);
			return new GachaViewInfo?(rootAsGachaViewInfo);
		}

		// Token: 0x0400181E RID: 6174
		private const string DB = "db_gacha.db";

		// Token: 0x0400181F RID: 6175
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x04001820 RID: 6176
		private const string TABLE = "GachaViewInfo";

		// Token: 0x04001821 RID: 6177
		private const string COMMAND = "select BinData from `GachaViewInfo` where Id=?";

		// Token: 0x04001822 RID: 6178
		private const string KEY_PREFIX = "GachaViewInfoById";

		// Token: 0x04001823 RID: 6179
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001824 RID: 6180
		private static int HandleId;
	}
}
