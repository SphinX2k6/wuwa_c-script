using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A2 RID: 418
	public class ConfigCompositeRewardDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x000947FF File Offset: 0x000929FF
		static ConfigCompositeRewardDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCompositeRewardDisplayById.CreateStaticDefaultValue), new Action(ConfigCompositeRewardDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00094820 File Offset: 0x00092A20
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

		// Token: 0x060009D0 RID: 2512 RVA: 0x0009489F File Offset: 0x00092A9F
		public static void ResetStaticDefaultValue()
		{
			ConfigCompositeRewardDisplayById.LogPair = null;
			ConfigCompositeRewardDisplayById.HandleId = 0;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000948AD File Offset: 0x00092AAD
		public static void Init()
		{
			ConfigCompositeRewardDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigCompositeRewardDisplayById.HandleId, "db_rewardui.db", "select BinData from `CompositeRewardDisplay` where Id=?");
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000948C8 File Offset: 0x00092AC8
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

		// Token: 0x04000B52 RID: 2898
		private const string DB = "db_rewardui.db";

		// Token: 0x04000B53 RID: 2899
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04000B54 RID: 2900
		private const string TABLE = "CompositeRewardDisplay";

		// Token: 0x04000B55 RID: 2901
		private const string COMMAND = "select BinData from `CompositeRewardDisplay` where Id=?";

		// Token: 0x04000B56 RID: 2902
		private const string KEY_PREFIX = "CompositeRewardDisplayById";

		// Token: 0x04000B57 RID: 2903
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B58 RID: 2904
		private static int HandleId;
	}
}
