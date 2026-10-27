using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EE RID: 238
	public class ConfigBehaviorCommonButtonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x00079367 File Offset: 0x00077567
		static ConfigBehaviorCommonButtonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBehaviorCommonButtonById.CreateStaticDefaultValue), new Action(ConfigBehaviorCommonButtonById.ResetStaticDefaultValue));
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00079388 File Offset: 0x00077588
		public static void CreateStaticDefaultValue()
		{
			ConfigBehaviorCommonButtonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBehaviorCommonButtonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "BehaviorCommonButton"),
				new ValueTuple<string, object>("语句", "select BinData from `BehaviorCommonButton` where Id=?")
			});
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00079407 File Offset: 0x00077607
		public static void ResetStaticDefaultValue()
		{
			ConfigBehaviorCommonButtonById.LogPair = null;
			ConfigBehaviorCommonButtonById.HandleId = 0;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00079415 File Offset: 0x00077615
		public static void Init()
		{
			ConfigBehaviorCommonButtonById.HandleId = ConfigCommon.InitDataStatement(ConfigBehaviorCommonButtonById.HandleId, "db_skillbutton.db", "select BinData from `BehaviorCommonButton` where Id=?");
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00079430 File Offset: 0x00077630
		public static BehaviorCommonButton? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBehaviorCommonButtonById.HandleId, ConfigBehaviorCommonButtonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BehaviorCommonButtonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BehaviorCommonButton?(BehaviorCommonButton.GetRootAsBehaviorCommonButton(configBuffer));
				}
			}
			ConfigBehaviorCommonButtonById.LogPair.Clear();
			ConfigBehaviorCommonButtonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBehaviorCommonButtonById.HandleId, 1, p0Id, ConfigBehaviorCommonButtonById.LogPair) || ConfigCommon.Step(ConfigBehaviorCommonButtonById.HandleId, true, ConfigBehaviorCommonButtonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBehaviorCommonButtonById.HandleId, ConfigBehaviorCommonButtonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBehaviorCommonButtonById.HandleId, 0, ConfigBehaviorCommonButtonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBehaviorCommonButtonById.HandleId, ConfigBehaviorCommonButtonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BehaviorCommonButton rootAsBehaviorCommonButton = BehaviorCommonButton.GetRootAsBehaviorCommonButton(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BehaviorCommonButtonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBehaviorCommonButtonById.HandleId, ConfigBehaviorCommonButtonById.LogPair);
			return new BehaviorCommonButton?(rootAsBehaviorCommonButton);
		}

		// Token: 0x04000666 RID: 1638
		private const string DB = "db_skillbutton.db";

		// Token: 0x04000667 RID: 1639
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04000668 RID: 1640
		private const string TABLE = "BehaviorCommonButton";

		// Token: 0x04000669 RID: 1641
		private const string COMMAND = "select BinData from `BehaviorCommonButton` where Id=?";

		// Token: 0x0400066A RID: 1642
		private const string KEY_PREFIX = "BehaviorCommonButtonById";

		// Token: 0x0400066B RID: 1643
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400066C RID: 1644
		private static int HandleId;
	}
}
