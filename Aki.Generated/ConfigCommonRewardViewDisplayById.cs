using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000197 RID: 407
	public class ConfigCommonRewardViewDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600098B RID: 2443 RVA: 0x00092FA8 File Offset: 0x000911A8
		static ConfigCommonRewardViewDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonRewardViewDisplayById.CreateStaticDefaultValue), new Action(ConfigCommonRewardViewDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00092FC8 File Offset: 0x000911C8
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonRewardViewDisplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonRewardViewDisplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rewardui.db"),
				new ValueTuple<string, object>("文件", "j.奖励界面表现.xlsx"),
				new ValueTuple<string, object>("表名", "CommonRewardViewDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `CommonRewardViewDisplay` where Id=?")
			});
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00093047 File Offset: 0x00091247
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonRewardViewDisplayById.LogPair = null;
			ConfigCommonRewardViewDisplayById.HandleId = 0;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00093055 File Offset: 0x00091255
		public static void Init()
		{
			ConfigCommonRewardViewDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonRewardViewDisplayById.HandleId, "db_rewardui.db", "select BinData from `CommonRewardViewDisplay` where Id=?");
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00093070 File Offset: 0x00091270
		public static CommonRewardViewDisplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonRewardViewDisplayById.HandleId, ConfigCommonRewardViewDisplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonRewardViewDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CommonRewardViewDisplay?(CommonRewardViewDisplay.GetRootAsCommonRewardViewDisplay(configBuffer));
				}
			}
			ConfigCommonRewardViewDisplayById.LogPair.Clear();
			ConfigCommonRewardViewDisplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCommonRewardViewDisplayById.HandleId, 1, p0Id, ConfigCommonRewardViewDisplayById.LogPair) || ConfigCommon.Step(ConfigCommonRewardViewDisplayById.HandleId, true, ConfigCommonRewardViewDisplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCommonRewardViewDisplayById.HandleId, ConfigCommonRewardViewDisplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonRewardViewDisplayById.HandleId, 0, ConfigCommonRewardViewDisplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCommonRewardViewDisplayById.HandleId, ConfigCommonRewardViewDisplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CommonRewardViewDisplay rootAsCommonRewardViewDisplay = CommonRewardViewDisplay.GetRootAsCommonRewardViewDisplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonRewardViewDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCommonRewardViewDisplayById.HandleId, ConfigCommonRewardViewDisplayById.LogPair);
			return new CommonRewardViewDisplay?(rootAsCommonRewardViewDisplay);
		}

		// Token: 0x04000B05 RID: 2821
		private const string DB = "db_rewardui.db";

		// Token: 0x04000B06 RID: 2822
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04000B07 RID: 2823
		private const string TABLE = "CommonRewardViewDisplay";

		// Token: 0x04000B08 RID: 2824
		private const string COMMAND = "select BinData from `CommonRewardViewDisplay` where Id=?";

		// Token: 0x04000B09 RID: 2825
		private const string KEY_PREFIX = "CommonRewardViewDisplayById";

		// Token: 0x04000B0A RID: 2826
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B0B RID: 2827
		private static int HandleId;
	}
}
