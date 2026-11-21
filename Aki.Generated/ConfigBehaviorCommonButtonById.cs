using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FD RID: 253
	public class ConfigBehaviorCommonButtonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005EF RID: 1519 RVA: 0x0007ECCB File Offset: 0x0007CECB
		static ConfigBehaviorCommonButtonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBehaviorCommonButtonById.CreateStaticDefaultValue), new Action(ConfigBehaviorCommonButtonById.ResetStaticDefaultValue));
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0007ECEC File Offset: 0x0007CEEC
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

		// Token: 0x060005F1 RID: 1521 RVA: 0x0007ED6B File Offset: 0x0007CF6B
		public static void ResetStaticDefaultValue()
		{
			ConfigBehaviorCommonButtonById.LogPair = null;
			ConfigBehaviorCommonButtonById.HandleId = 0;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0007ED79 File Offset: 0x0007CF79
		public static void Init()
		{
			ConfigBehaviorCommonButtonById.HandleId = ConfigCommon.InitDataStatement(ConfigBehaviorCommonButtonById.HandleId, "db_skillbutton.db", "select BinData from `BehaviorCommonButton` where Id=?");
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0007ED94 File Offset: 0x0007CF94
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

		// Token: 0x040006CF RID: 1743
		private const string DB = "db_skillbutton.db";

		// Token: 0x040006D0 RID: 1744
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040006D1 RID: 1745
		private const string TABLE = "BehaviorCommonButton";

		// Token: 0x040006D2 RID: 1746
		private const string COMMAND = "select BinData from `BehaviorCommonButton` where Id=?";

		// Token: 0x040006D3 RID: 1747
		private const string KEY_PREFIX = "BehaviorCommonButtonById";

		// Token: 0x040006D4 RID: 1748
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006D5 RID: 1749
		private static int HandleId;
	}
}
