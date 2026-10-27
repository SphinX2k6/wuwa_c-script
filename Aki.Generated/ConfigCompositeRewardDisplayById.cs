using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000190 RID: 400
	public class ConfigCompositeRewardDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x0008E8C7 File Offset: 0x0008CAC7
		static ConfigCompositeRewardDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCompositeRewardDisplayById.CreateStaticDefaultValue), new Action(ConfigCompositeRewardDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0008E8E8 File Offset: 0x0008CAE8
		public static void CreateStaticDefaultValue()
		{
			ConfigCompositeRewardDisplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCompositeRewardDisplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rewardui.db"),
				new ValueTuple<string, object>("文件", "j.奖励界面表现.xlsx"),
				new ValueTuple<string, object>("表名", "CompositeRewardDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `CompositeRewardDisplay` where Id=?")
			});
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0008E967 File Offset: 0x0008CB67
		public static void ResetStaticDefaultValue()
		{
			ConfigCompositeRewardDisplayById.LogPair = null;
			ConfigCompositeRewardDisplayById.HandleId = 0;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0008E975 File Offset: 0x0008CB75
		public static void Init()
		{
			ConfigCompositeRewardDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigCompositeRewardDisplayById.HandleId, "db_rewardui.db", "select BinData from `CompositeRewardDisplay` where Id=?");
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x0008E990 File Offset: 0x0008CB90
		public static CompositeRewardDisplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCompositeRewardDisplayById.HandleId, ConfigCompositeRewardDisplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CompositeRewardDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CompositeRewardDisplay?(CompositeRewardDisplay.GetRootAsCompositeRewardDisplay(configBuffer));
				}
			}
			ConfigCompositeRewardDisplayById.LogPair.Clear();
			ConfigCompositeRewardDisplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCompositeRewardDisplayById.HandleId, 1, p0Id, ConfigCompositeRewardDisplayById.LogPair) || ConfigCommon.Step(ConfigCompositeRewardDisplayById.HandleId, true, ConfigCompositeRewardDisplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCompositeRewardDisplayById.HandleId, ConfigCompositeRewardDisplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCompositeRewardDisplayById.HandleId, 0, ConfigCompositeRewardDisplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCompositeRewardDisplayById.HandleId, ConfigCompositeRewardDisplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CompositeRewardDisplay rootAsCompositeRewardDisplay = CompositeRewardDisplay.GetRootAsCompositeRewardDisplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CompositeRewardDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCompositeRewardDisplayById.HandleId, ConfigCompositeRewardDisplayById.LogPair);
			return new CompositeRewardDisplay?(rootAsCompositeRewardDisplay);
		}

		// Token: 0x04000AD4 RID: 2772
		private const string DB = "db_rewardui.db";

		// Token: 0x04000AD5 RID: 2773
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04000AD6 RID: 2774
		private const string TABLE = "CompositeRewardDisplay";

		// Token: 0x04000AD7 RID: 2775
		private const string COMMAND = "select BinData from `CompositeRewardDisplay` where Id=?";

		// Token: 0x04000AD8 RID: 2776
		private const string KEY_PREFIX = "CompositeRewardDisplayById";

		// Token: 0x04000AD9 RID: 2777
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ADA RID: 2778
		private static int HandleId;
	}
}
