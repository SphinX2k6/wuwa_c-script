using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000185 RID: 389
	public class ConfigCommonRewardViewDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x0008D070 File Offset: 0x0008B270
		static ConfigCommonRewardViewDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonRewardViewDisplayById.CreateStaticDefaultValue), new Action(ConfigCommonRewardViewDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0008D090 File Offset: 0x0008B290
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

		// Token: 0x06000921 RID: 2337 RVA: 0x0008D10F File Offset: 0x0008B30F
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonRewardViewDisplayById.LogPair = null;
			ConfigCommonRewardViewDisplayById.HandleId = 0;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0008D11D File Offset: 0x0008B31D
		public static void Init()
		{
			ConfigCommonRewardViewDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonRewardViewDisplayById.HandleId, "db_rewardui.db", "select BinData from `CommonRewardViewDisplay` where Id=?");
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0008D138 File Offset: 0x0008B338
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

		// Token: 0x04000A87 RID: 2695
		private const string DB = "db_rewardui.db";

		// Token: 0x04000A88 RID: 2696
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04000A89 RID: 2697
		private const string TABLE = "CommonRewardViewDisplay";

		// Token: 0x04000A8A RID: 2698
		private const string COMMAND = "select BinData from `CommonRewardViewDisplay` where Id=?";

		// Token: 0x04000A8B RID: 2699
		private const string KEY_PREFIX = "CommonRewardViewDisplayById";

		// Token: 0x04000A8C RID: 2700
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A8D RID: 2701
		private static int HandleId;
	}
}
